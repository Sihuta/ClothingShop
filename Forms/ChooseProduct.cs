using System;
using System.Windows.Forms;

namespace CourseProject
{
    public partial class ChooseProduct : Form
    {
        public static bool Edit;
        public static int CurrProductCode;

        static int Price;
        static int ID;
        bool productWasAdded;

        public ChooseProduct()
        {
            InitializeComponent();

            if (Edit)
            {
                button_delivery.Visible = false;
                button_OK.Visible = false;
                button_UPD.Visible = true;
            }
            productWasAdded = false;
        }

        public ChooseProduct(int id, string brand, string type, string producer, string gender, int price)
            : this()
        {
            ID = id;
            label_id.Text = id.ToString();
            label_brand.Text = brand;
            label_type.Text = type;
            label_producer.Text = producer;
            label_gender.Text = gender;
            label_price.Text = price.ToString();
            Price = price;

            comboBox1.DataSource = DataAccess.DoComplexQuery(DataAccess.GetSizeList, "@ProductID", id);
            getSum();
        }

        public ChooseProduct(int id, string brand, string type, string producer, string gender, int price, string size, int amount)
            : this(id, brand, type, producer, gender, price)
        {
            if (Edit)
            {
                numericUpDown1.Value = amount;
                numericUpDown1.Maximum = (int)storageTableAdapter.GetAmount(id, size);
            }
            else
            {
                numericUpDown1.Maximum = amount;
            }
            comboBox1.Text = size;
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            getSum();
        }

        void getSum()
        {
            var sum = Price * Convert.ToInt32(numericUpDown1.Value);
            label_sum.Text = sum.ToString();
        }

        private void numericUpDown1_Leave(object sender, EventArgs e)
        {
            getSum();
        }

        private void ChooseProduct_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "clothingShopDataSet.Order". При необходимости она может быть перемещена или удалена.
            this.orderTableAdapter.Fill(this.clothingShopDataSet.Order);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "clothingShopDataSet.Storage". При необходимости она может быть перемещена или удалена.
            this.storageTableAdapter.Fill(this.clothingShopDataSet.Storage);
        }

        private void button_cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button_OK_Click(object sender, EventArgs e)
        {
            if (addProduct())
            {
                productWasAdded = true;
                MessageBox.Show("Товар було успішно додано!");
                //Close();
            }
        }

        bool addProduct()
        {
            if (numericUpDown1.Value < 1)
            {
                MessageBox.Show("Будь ласка, вкажіть необхідну кількість товарів");
                return false;
            }
            int productCode = (int)storageTableAdapter.GetProductCode(ID, comboBox1.Text);
            orderTableAdapter.InsertQuery(Client.DeliveryID, productCode, Convert.ToInt32(numericUpDown1.Value));
            orderTableAdapter.Update(clothingShopDataSet);

            return true;
        }

        private void button_delivery_Click(object sender, EventArgs e)
        {
            var del = new ArrangeDelivery();
            if (!productWasAdded)
            {
                if (addProduct())
                {
                    del.Show();
                    Close();
                    productWasAdded = false;
                    return;
                }
            }     
            del.Show();
            Close();
        }

        private void button_UPD_Click(object sender, EventArgs e)
        {
            if (numericUpDown1.Value < 1)
            {
                MessageBox.Show("Будь ласка, вкажіть необхідну кількість товарів");
                return;
            }

            int newProductCode = (int)storageTableAdapter.GetProductCode(ID, comboBox1.Text);
            orderTableAdapter.UpdateQuery(newProductCode, Convert.ToInt32(numericUpDown1.Value), Client.DeliveryID, CurrProductCode);
            orderTableAdapter.Update(clothingShopDataSet);
            orderTableAdapter.Fill(clothingShopDataSet.Order);
            clothingShopDataSet.AcceptChanges();
            Close();
        }

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            productWasAdded = false;
            if (ID != 0 && comboBox1.Text != "")
                numericUpDown1.Maximum = (int)storageTableAdapter.GetAmount(ID, comboBox1.Text);
        }

        private void numericUpDown1_KeyPress(object sender, KeyPressEventArgs e)
        {
            getSum();
        }
    }
}