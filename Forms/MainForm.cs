using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace CourseProject
{
    public partial class MainForm : Form
    {
        public static string ActiveQueryString;

        public static bool PriceASC;
        public static bool PriceDESC;

        public const string priceAsc = " ORDER BY Catalog.Price ASC ";
        public const string priceDesc = " ORDER BY Catalog.Price DESC ";
        public const string halfPriceAsc = ", Catalog.Price ASC ";
        public const string halfPriceDesc = ", Catalog.Price DESC ";

        public const string brandAsc = " ORDER BY Brand.Brand ASC ";
        public const string brandDesc = " ORDER BY Brand.Brand DESC ";
        public const string halfBrandAsc = ", Brand.Brand ASC ";
        public const string halfBrandDesc = ", Brand.Brand DESC ";

        string[] typeFilterArr;
        string[] brandFilterArr;
        string[] producerFilterArr;
        string[] categoryFilterArr;
        string[] genderFilterArr;

        List<CheckBox> types = new List<CheckBox>();
        List<CheckBox> brands = new List<CheckBox>();
        List<CheckBox> producers = new List<CheckBox>();
        List<CheckBox> categories = new List<CheckBox>();
        List<CheckBox> genders = new List<CheckBox>();

        public MainForm()
        {
            InitializeComponent();
            addCheckBoxes();
        }

        void addCheckBoxes()
        {
            types.Add(checkBox_type1);
            types.Add(checkBox_type2);
            types.Add(checkBox_type3);
            types.Add(checkBox_type4);
            types.Add(checkBox_type5);
            types.Add(checkBox_type6);
            types.Add(checkBox_type7);
            types.Add(checkBox_type8);
            types.Add(checkBox_type9);
            types.Add(checkBox_type10);

            brands.Add(checkBox_brand1);
            brands.Add(checkBox_brand2);
            brands.Add(checkBox_brand3);
            brands.Add(checkBox_brand4);
            brands.Add(checkBox_brand5);
            brands.Add(checkBox_brand6);
            brands.Add(checkBox_brand7);
            brands.Add(checkBox_brand8);

            producers.Add(checkBox_prod1);
            producers.Add(checkBox_prod2);
            producers.Add(checkBox_prod3);
            producers.Add(checkBox_prod4);
            producers.Add(checkBox_prod5);
            producers.Add(checkBox_prod6);
            producers.Add(checkBox_prod7);
            producers.Add(checkBox_prod8);
            producers.Add(checkBox_prod9);

            categories.Add(checkBox_category1);
            categories.Add(checkBox_category2);
            categories.Add(checkBox_category3);

            genders.Add(checkBox_gender1);
            genders.Add(checkBox_gender2);
            genders.Add(checkBox_gender3);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            ActiveQueryString = DataAccess.GetProductInfo;
            displayNeedProducts(ActiveQueryString);
            setPrice();
            setComboBox();
        }

        void setPrice()
        {
            numericUpDown_priceFrom.Value = Convert.ToInt32(catalogTableAdapter1.GetMinPrice());
            numericUpDown_priceTo.Value = Convert.ToInt32(catalogTableAdapter1.GetMaxPrice());
        }

        void setComboBox()
        {
            comboBox_brand.SelectedIndex = 2;
            comboBox_price.SelectedIndex = 2;
        }

        void displayNeedProducts(string query)
        {
            BindingSource bs = DataAccess.MakeSimpleQuery(query);
            bindingNavigator1.BindingSource = bs;
            dataGridView_catalog.DataSource = bs;
            showProductMaterial(true);
            showProductAssortiment();
        }

        void showProductMaterial(bool dataChanged)
        {
            var IDparam = "@ProductID";
            if (dataChanged)
            {
                dataGridView_catalog.Rows[0].Selected = true;
            }
            try
            {
                int value = Convert.ToInt32(dataGridView_catalog.SelectedRows[0].Cells[0].Value);
                dataGridView_material.DataSource = DataAccess.MakeComplexQuery(DataAccess.GetProductMaterial, IDparam, value);
            }
            catch
            {
                return;
            }
        }

        void showProductAssortiment()
        {
            if (dataGridView_catalog.SelectedRows.Count == 1)
            {
                BindingSource bs = DataAccess.MakeComplexQuery(DataAccess.GetProductAssortiment, "@ProductID", Convert.ToInt32(dataGridView_catalog.SelectedRows[0].Cells[0].Value));
                dataGridView_assortiment.DataSource = bs;
            }
        }

        private void button_chooseProduct_Click(object sender, EventArgs e)
        {
            ChooseProduct.Edit = false;
            var st = new ClothingShopDataSet.ProductsCatalogDataTable();
            productsCatalogTableAdapter1.Fill(st, Convert.ToInt32(dataGridView_catalog.SelectedRows[0].Cells[0].Value));
            object[] row = st.Rows[0].ItemArray;
            var choosePr = new ChooseProduct(
                Convert.ToInt32(row[0]),
                row[2].ToString(),
                row[1].ToString(),
                row[3].ToString(),
                row[4].ToString(),
                Convert.ToInt32(row[5]),
                dataGridView_assortiment.SelectedRows[0].Cells[0].Value.ToString(),
                Convert.ToInt32(dataGridView_assortiment.SelectedRows[0].Cells[1].Value)
                );
            choosePr.Show();
        }

        private void exclusiveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label_title.Text = "Ексклюзивні товари";
            ActiveQueryString = DataAccess.ExclusiveProd;

            changeActiveQuery();
            displayNeedProducts(ActiveQueryString);
        }

        private void popularToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label_title.Text = "Найбільш популярні товари";
            ActiveQueryString = DataAccess.PopularProd;

            changeActiveQuery();
            displayNeedProducts(ActiveQueryString);
        }

        private void wholesaleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label_title.Text = "Товари, які купують оптово";
            ActiveQueryString = DataAccess.WholesaleProd;

            changeActiveQuery();
            displayNeedProducts(ActiveQueryString);
        }

        private void catalogToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label_title.Text = "Каталог товарів";
            ActiveQueryString = DataAccess.GetProductInfo;

            changeActiveQuery();
            displayNeedProducts(ActiveQueryString);
        }

        void changeActiveQuery()
        {
            if (PriceASC)
            {
                subStrDel(priceDesc);
                subStrDel(priceAsc);
                ActiveQueryString += priceAsc;
            }
            else if (PriceDESC)
            {
                subStrDel(priceDesc);
                subStrDel(priceAsc);
                ActiveQueryString += priceDesc;
            }
        }

        public static void subStrDel(string substr)
        {
            int n = ActiveQueryString.IndexOf(substr);
            if (n != -1)
                ActiveQueryString = ActiveQueryString.Remove(n, substr.Length);
        }

        private void bindingNavigatorMoveFirstItem_Click(object sender, EventArgs e)
        {
            showProductMaterial(false);
            showProductAssortiment();
        }

        private void bindingNavigatorMovePreviousItem_Click(object sender, EventArgs e)
        {
            showProductMaterial(false);
            showProductAssortiment();
        }

        private void bindingNavigatorMoveNextItem_Click(object sender, EventArgs e)
        {
            showProductMaterial(false);
            showProductAssortiment();
        }

        private void bindingNavigatorMoveLastItem_Click(object sender, EventArgs e)
        {
            showProductMaterial(false);
            showProductAssortiment();
        }

        void highligthDataRows(int[] productIDs)
        {
            for (int i = 0; i < dataGridView_catalog.Rows.Count; ++i)
            {
                if (Array.IndexOf(productIDs, Convert.ToInt32(dataGridView_catalog.Rows[i].Cells[0].Value)) == -1)
                {
                        dataGridView_catalog.Rows[i].DefaultCellStyle.BackColor = Color.White;
                }
                else
                {
                        dataGridView_catalog.Rows[i].DefaultCellStyle.BackColor = Color.LimeGreen;
                }
            }
        }

        private void textBox_search_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                searchDataRows();
            }
        }

        void searchDataRows()
        {
            string[] input = textBox_search.Text.Split().ToArray();
            if (input.Length == 0)
            {
                MessageBox.Show("Будь ласка, введіть пошуковий запит у відповідне поле");
                return;
            }
            if (input.Length > 2)
            {
                MessageBox.Show("Будь ласка, приберіть з пошукового запиту зайві слова");
                return;
            }

            int[] productIDs;
            int[] input1;
            int[] input2;
            if (input.Length == 2)
            {
                input1 = DataAccess.SearchQueryBy2Val(input[0], input[1]);
                input2 = DataAccess.SearchQueryBy2Val(input[1], input[0]);
                productIDs = input1.Length > input2.Length ? input1 : input2;

                if (productIDs.Length == 0)
                {
                    MessageBox.Show("За пошуковим запитом товарів не знайдено");
                    return;
                }

                highligthDataRows(productIDs);
                return;
            }
            if (input.Length == 1)
            {
                input1 = DataAccess.SearchQueryByType(input[0]);
                input2 = DataAccess.SearchQueryByBrand(input[0]);
                productIDs = input1.Length > input2.Length ? input1 : input2;

                if (productIDs.Length == 0)
                {
                    MessageBox.Show("За пошуковим запитом товарів не знайдено");
                    return;
                }

                highligthDataRows(productIDs);
            }
        }

        //private void radioButton_asc_CheckedChanged(object sender, EventArgs e)
        //{
        //    if (radioButton_asc.Checked)
        //    {
        //        PriceASC = true;
        //    }
        //    else
        //    {
        //        PriceASC = false;
        //    }

        //    changeActiveQuery();
        //    try
        //    {
        //        displayNeedProducts(ActiveQueryString);
        //    }
        //    catch
        //    {
        //        ActiveQueryString = DataAccess.GetProductInfo;
        //        displayFilterProduct();
        //    }
        //}

        //private void radioButton_desc_CheckedChanged(object sender, EventArgs e)
        //{
        //    if (radioButton_desc.Checked)
        //    {
        //        PriceDESC = true;
        //    }
        //    else
        //    {
        //        PriceDESC = false;
        //    }

        //    changeActiveQuery();
        //    try
        //    {
        //        displayNeedProducts(ActiveQueryString);
        //    }
        //    catch
        //    {
        //        ActiveQueryString = DataAccess.GetProductInfo;
        //        displayFilterProduct();
        //    }
        //}

        void displayFilterProduct(string sortQuery = null)
        {
            BindingSource bs = DataAccess.FilterQuery(
                typeFilterArr,
                brandFilterArr,
                producerFilterArr,
                categoryFilterArr,
                genderFilterArr,
                Convert.ToInt32(numericUpDown_priceFrom.Value),
                Convert.ToInt32(numericUpDown_priceTo.Value),
                sortQuery
                );

            if (bs.Count == 0)
            {
                MessageBox.Show("Товари не знайдено.");
                return;
            }
            bindingNavigator1.BindingSource = bs;
            dataGridView_catalog.DataSource = bs;
            showProductMaterial(true);
            showProductAssortiment();
        }

        void fillFilterArrays()
        {
            typeFilterArr = fillFilterArr(types);
            brandFilterArr = fillFilterArr(brands);
            producerFilterArr = fillFilterArr(producers);
            categoryFilterArr = fillFilterArr(categories);
            genderFilterArr = fillFilterArr(genders);
        }

        string[] fillFilterArr(List<CheckBox> list)
        {
            int length = 0;
            foreach (CheckBox checkbox in list)
            {
                if (checkbox.Checked)
                    ++length;
            }

            var arr = new string[length];
            int i = 0;
            foreach (CheckBox checkbox in list)
            {
                if (checkbox.Checked)
                {
                    arr[i] = checkbox.Text;
                    ++i;
                }
            }

            return arr;
        }

        private void orderReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (DataAccess.MakeValueQuery(DataAccess.CountInOrder, "@AddressID", Client.AddressID) == 0)
            {
                MessageBox.Show("Наразі у вашому замовленні немає товарів");
                return;
            }
            var rep = new ReportViewer("order");
            rep.Show();
        }

        private void receiptReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (DataAccess.MakeValueQuery(DataAccess.CountInOrder, "@AddressID", Client.AddressID) == 0)
            {
                MessageBox.Show("Наразі у вашому замовленні немає товарів, тому цей документ недоступний");
                return;
            }
            var rep = new ReportViewer("receipt");
            rep.Show();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void dataGridView_catalog_SelectionChanged(object sender, EventArgs e)
        {
            showProductMaterial(false);
            showProductAssortiment();
        }

        private void editClientDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegisterForm.Edit = true;
            var rf = new RegisterForm();
            rf.Show();
        }

        private void deleteAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Ви дійсно бажаєте видалити свій обліковий запис?\n(При цьому видаляться всі дані стосовно ваших замовлень)", "Видалення облікового запису", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                clientTableAdapter.DeleteQuery(Client.ID);
                Close();

                if (MessageBox.Show("Чи бажаєте ви зареєструвати новий обліковий запис?", "Подальші дії", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    RegisterForm.Edit = false;
                    var rf = new RegisterForm();
                    rf.Show();
                }
            }
        }

        private void basketToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (DataAccess.MakeValueQuery(DataAccess.CountInOrder, "@AddressID", Client.AddressID) > 0)
            {
                var bs = new ArrangeDelivery();
                bs.Show();
                return;
            }
            MessageBox.Show("Наразі ваш кошик порожній");
        }

        private void orderHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (DataAccess.MakeValueQuery(DataAccess.CountDeliveries, "@ClientID", Client.ID) > 0)
            {
                var f = new OrderHistory();
                f.Show();
                return;
            }
            MessageBox.Show("Наразі ваша історія замовлень порожня");
        }

        private void filter_Click(object sender, EventArgs e)
        {
            setActiveQuery();
            fillFilterArrays();

            //subStrDel(priceDesc);
            //subStrDel(priceAsc);

            displayFilterProduct();
        }

        void setActiveQuery()
        {
            switch (label_title.Text)
            {
                case "Каталог товарів":
                    ActiveQueryString = DataAccess.GetProductInfo;
                    break;
                case "Найбільш популярні товари":
                    ActiveQueryString = DataAccess.PopularProd;
                    break;
                case "Ексклюзивні товари":
                    ActiveQueryString = DataAccess.ExclusiveProd;
                    break;
                case "Товари, які купують оптово":
                    ActiveQueryString = DataAccess.WholesaleProd;
                    break;
            }
            //ActiveQueryString += sortQuery;
        }

        private void search_Click(object sender, EventArgs e)
        {
            searchDataRows();
        }

        private void checkBox_cancelFilter_CheckedChanged(object sender, EventArgs e)
        {
            if (!checkBox_cancelFilter.Checked)
            {
                return;
            }

            setPrice();

            cancelCheckBoxes(types);
            cancelCheckBoxes(brands);
            cancelCheckBoxes(producers);
            cancelCheckBoxes(categories);
            cancelCheckBoxes(genders);

            setActiveQuery();
            displayNeedProducts(ActiveQueryString);
        }

        void cancelCheckBoxes(List<CheckBox> checkBoxes)
        {
            foreach (CheckBox b in checkBoxes)
            {
                if (b.Checked)
                {
                    b.Checked = false;
                }
            }
        }

        private void comboBox_price_SelectedIndexChanged(object sender, EventArgs e)
        {
            setActiveQuery();
            string sortQuery = "";
            switch (comboBox_price.SelectedIndex)
            {
                case 0:
                    switch (comboBox_brand.SelectedIndex)
                    {
                        case 0:
                            sortQuery += brandDesc + halfPriceDesc;
                            break;
                        case 1:
                            sortQuery += brandAsc + halfPriceDesc;
                            break;
                        case 2:
                            sortQuery += priceDesc;
                            break;
                    }
                    break;
                case 1:
                    switch (comboBox_brand.SelectedIndex)
                    {
                        case 0:
                            sortQuery += brandDesc + halfPriceAsc;
                            break;
                        case 1:
                            sortQuery += brandAsc + halfPriceAsc;
                            break;
                        case 2:
                            sortQuery += priceAsc;
                            break;
                    }
                    break;
                case 2:
                    switch (comboBox_brand.SelectedIndex)
                    {
                        case 0:
                            sortQuery += brandDesc;
                            break;
                        case 1:
                            sortQuery += brandAsc;
                            break;
                    }
                    break;
            }
            
            fillFilterArrays();
            displayFilterProduct(sortQuery);
        }

        string sortQuery;

        private void comboBox_brand_SelectedIndexChanged(object sender, EventArgs e)
        {
            setActiveQuery();
            sortQuery = "";
            switch (comboBox_brand.SelectedIndex)
            {
                case 0:
                    switch (comboBox_price.SelectedIndex)
                    {
                        case 0:
                            sortQuery += priceDesc + halfBrandDesc;
                            break;
                        case 1:
                            sortQuery += priceAsc + halfBrandDesc;
                            break;
                        case 2:
                            sortQuery += brandDesc;
                            break;
                    }
                    break;
                case 1:
                    switch (comboBox_price.SelectedIndex)
                    {
                        case 0:
                            sortQuery += priceDesc + halfBrandAsc;
                            break;
                        case 1:
                            sortQuery += priceAsc + halfBrandAsc;
                            break;
                        case 2:
                            sortQuery += brandAsc;
                            break;
                    }
                    break;
                case 2:
                    switch (comboBox_price.SelectedIndex)
                    {
                        case 0:
                            sortQuery += priceDesc;
                            break;
                        case 1:
                            sortQuery += priceAsc;
                            break;
                    }
                    break;
            }

            fillFilterArrays();
            displayFilterProduct(sortQuery);
        }
    }
}