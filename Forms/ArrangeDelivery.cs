using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace CourseProject
{
    public partial class ArrangeDelivery : Form
    {
        bool[] readyProd;
        int[] notReadyProdID;
        string[] notReadyProdSize;

        public ArrangeDelivery()
        {
            InitializeComponent();
        }

        private void ArrangeDelivery_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "clothingShopDataSet.Client". При необходимости она может быть перемещена или удалена.
            this.clientTableAdapter.Fill(this.clothingShopDataSet.Client);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "clothingShopDataSet.Delivery". При необходимости она может быть перемещена или удалена.
            this.deliveryTableAdapter.Fill(this.clothingShopDataSet.Delivery);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "clothingShopDataSet.Storage". При необходимости она может быть перемещена или удалена.
            this.storageTableAdapter.Fill(this.clothingShopDataSet.Storage);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "clothingShopDataSet.Order". При необходимости она может быть перемещена или удалена.
            this.orderTableAdapter.Fill(this.clothingShopDataSet.Order);

            updateData();
        }

        private void button_Delete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Ви дійсно бажаєте видалити товар №" + dataGridView1.SelectedRows[0].Cells[0].Value + "?", "Видалення товару", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                DataAccess.DeleteProductFromOrder(
                Client.DeliveryID,
                Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value),
                dataGridView1.SelectedRows[0].Cells[5].Value.ToString()
                );

                orderTableAdapter.Update(clothingShopDataSet);
                orderTableAdapter.Fill(clothingShopDataSet.Order);
            }
            updateData();
        }

        private void button_UPD_Click(object sender, EventArgs e)
        {
            ChooseProduct.Edit = true;
            ChooseProduct.CurrProductCode = (int)storageTableAdapter.GetProductCode(
                Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value),
                dataGridView1.SelectedRows[0].Cells[5].Value.ToString());

            var upd = new ChooseProduct(
                Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value),
                dataGridView1.SelectedRows[0].Cells[2].Value.ToString(),
                dataGridView1.SelectedRows[0].Cells[1].Value.ToString(),
                dataGridView1.SelectedRows[0].Cells[3].Value.ToString(),
                dataGridView1.SelectedRows[0].Cells[4].Value.ToString(),
                Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[6].Value),
                dataGridView1.SelectedRows[0].Cells[5].Value.ToString(),
                Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[7].Value)
                );
            upd.ShowDialog();
            updateData();
        }

        void updateData()
        {
            BindingSource bs = DataAccess.MakeComplexQuery(DataAccess.GetOrderData, "@DeliveryID", Client.DeliveryID);
            bindingNavigator1.BindingSource = bs;
            dataGridView1.DataSource = bs;

            var sum = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; ++i)
            {
                sum += Convert.ToInt32(dataGridView1.Rows[i].Cells[8].Value);
            }
            label_sum.Text = sum.ToString();
        }

        private void button_cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button_DeleteAll_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Ви дійсно бажаєте видалити всі товари?", "Видалення товарів", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                orderTableAdapter.DeleteQuery(Client.DeliveryID);
                orderTableAdapter.Update(clothingShopDataSet);
                orderTableAdapter.Fill(clothingShopDataSet.Order);
                Close();
            }
        }

        private void button_makeDel_Click(object sender, EventArgs e)
        {
            checkEveryProduct();
            if (allProductReady())
            {
                getAddedProds();                
                var checkDel = new CheckDelivery(amounts, prodsID, sizes);
                checkDel.Show();
                Close();
                return;
            }

            highlightNotReadyProd();

            if (MessageBox.Show("На жаль, деякі товари з числа обраних вами відсутні у необхідній кількості. " +
                "Чи бажаєте ви відредагувати своє замовлення?\n" +
                "Будь ласка, зробіть свій вибір стосовно подальших дій:\n" +
                "   1. Так => я хочу відредагувати замовлення. (Важливо: вам буде доступний звіт стосовно наявного асортименту цих товарів)\n" +
                "   2. Ні => я хочу ВИДАЛИТИ ВСІ товари, які виявились в обмеженій кількості", "Подальші дії", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                var rep = new ReportViewer(notReadyProdID);
                rep.Show();
                return;
            }

            for (int i = 0; i < notReadyProdID.Length; ++i)
            {
                DataAccess.DeleteProductFromOrder(
                    Client.DeliveryID,
                    notReadyProdID[i],
                    notReadyProdSize[i]
                    );
            }

            if (DataAccess.MakeValueQuery(DataAccess.CountInOrder, "@AddressID", Client.AddressID) > 0)
            {
                getAddedProds();
                var checkDel = new CheckDelivery(amounts, prodsID, sizes);
                checkDel.Show();
                Close();
                return;
            }
            MessageBox.Show("Наразі ваш кошик порожній");
        }

        void confirmSuccesfullOrder()
        {
            if (MessageBox.Show("Не забудьте перевірити свою почтову скриньку, на яку буде відіслано лист із підтвердженням замовлення\n" +
                "Чи не бажаєте ви переглянути звітну документацію щодо свого замовлення?", "Підтвердження замовлення", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                var rep = new ReportViewer("order");
                rep.Show();
                rep = new ReportViewer("receipt");
                rep.Show();
            }
        }

        List<int> amounts;
        List<int> prodsID;
        List<string> sizes;

        void getAddedProds()
        {
            amounts = new List<int>();
            prodsID = new List<int>();
            sizes = new List<string>();
            for (int i = 0; i < dataGridView1.Rows.Count; ++i)
            {
                amounts.Add(Convert.ToInt32(dataGridView1.Rows[i].Cells[7].Value));
                prodsID.Add(Convert.ToInt32(dataGridView1.Rows[i].Cells[0].Value));
                sizes.Add(dataGridView1.Rows[i].Cells[5].Value.ToString());
            }
        }

        void highlightNotReadyProd()
        {
            for (int i = 0; i < dataGridView1.Rows.Count; ++i)
            {
                if (Array.IndexOf(notReadyProdID, Convert.ToInt32(dataGridView1.Rows[i].Cells[0].Value)) == -1 
                    && Array.IndexOf(notReadyProdSize, dataGridView1.Rows[i].Cells[5].Value.ToString()) == -1)
                {
                    dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.White;
                }
                else
                {
                    dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.Red;
                }
            }
        }

        bool allProductReady()
        {
            int count = 0;
            foreach (bool b in readyProd)
            {
                if (!b)
                    ++count;
            }

            notReadyProdID = new int[count];
            notReadyProdSize = new string[count];
            for (int i = 0, j = 0; i < readyProd.Length; ++i)
            {
                if (!readyProd[i])
                {
                    notReadyProdID[j] = Convert.ToInt32(dataGridView1.Rows[i].Cells[0].Value);
                    notReadyProdSize[j] = dataGridView1.Rows[i].Cells[5].Value.ToString();
                    ++j;
                }
            }

            if (notReadyProdID.Length > 0) 
                return false;
            return true;
        }

        void checkEveryProduct()
        {
            readyProd = new bool[dataGridView1.Rows.Count];

            int availableAmount;
            for (int i = 0; i < dataGridView1.Rows.Count; ++i)
            {
                availableAmount = (int)storageTableAdapter.GetAmount(
                    Convert.ToInt32(dataGridView1.Rows[i].Cells[0].Value),
                    dataGridView1.Rows[i].Cells[5].Value.ToString()
                    );
                if (availableAmount >= Convert.ToInt32(dataGridView1.Rows[i].Cells[7].Value))
                {
                    readyProd[i] = true;
                }
                else
                {
                    readyProd[i] = false;
                }
            }
        }
    }
}