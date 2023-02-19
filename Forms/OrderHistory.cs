using System;
using System.Windows.Forms;

namespace CourseProject
{
    public partial class OrderHistory : Form
    {
        string dateAsc = "ORDER BY Delivery.BookingDate ASC ";
        string dateDesc = "ORDER BY Delivery.BookingDate DESC ";
        string halfDateAsc = ", Delivery.BookingDate ASC ";
        string halfDateDesc = ", Delivery.BookingDate DESC ";

        string sumAsc = "ORDER BY SUM([Order].Amount * Catalog.Price) ASC ";
        string sumDesc = "ORDER BY SUM([Order].Amount * Catalog.Price) DESC ";
        string halfSumDesc = ", SUM([Order].Amount * Catalog.Price) DESC ";
        string halfSumAsc = ", SUM([Order].Amount * Catalog.Price) ASC ";

        public OrderHistory()
        {
            InitializeComponent();
        }

        private void OrderHistory_Load(object sender, EventArgs e)
        {
            activeQuery = DataAccess.OrderHistory;
            displayData();

            comboBox_date.SelectedIndex = 2;
            comboBox_sum.SelectedIndex = 2;
        }

        void displayData()
        {
            showClientDel();
            showProdInOrder();
        }

        void showClientDel()
        {
            BindingSource bs = DataAccess.MakeComplexQuery(activeQuery, "@ClientID", Client.ID);
            bindingNavigator1.BindingSource = bs;
            dataGridView_del.DataSource = bs;
        }

        void showProdInOrder()
        {
            if (dataGridView_del.SelectedRows.Count == 1)
            {
                BindingSource bs = DataAccess.MakeComplexQuery(DataAccess.GetOrderData, "@DeliveryID", Convert.ToInt32(dataGridView_del.SelectedRows[0].Cells[0].Value));
                dataGridView_prod.DataSource = bs;
            }
        }

        private void bindingNavigatorMoveFirstItem_Click(object sender, EventArgs e)
        {
            showProdInOrder();
        }

        private void bindingNavigatorMovePreviousItem_Click(object sender, EventArgs e)
        {
            showProdInOrder();
        }

        private void bindingNavigatorMoveNextItem_Click(object sender, EventArgs e)
        {
            showProdInOrder();
        }

        private void bindingNavigatorMoveLastItem_Click(object sender, EventArgs e)
        {
            showProdInOrder();
        }

        private void dataGridView_del_SelectionChanged(object sender, EventArgs e)
        {
            showProdInOrder();
        }

        private void comboBox_date_SelectedIndexChanged(object sender, EventArgs e)
        {
            activeQuery = DataAccess.OrderHistory;
            switch (comboBox_date.SelectedIndex)
            {
                case 0:
                    switch (comboBox_sum.SelectedIndex)
                    {
                        case 0:
                            activeQuery += sumDesc + halfDateDesc;
                            break;
                        case 1:
                            activeQuery += sumAsc + halfDateDesc;
                            break;
                        case 2:
                            activeQuery += dateDesc;
                            break;
                    }
                    break;
                case 1:
                    switch (comboBox_sum.SelectedIndex)
                    {
                        case 0:
                            activeQuery += sumDesc + halfDateAsc;
                            break;
                        case 1:
                            activeQuery += sumAsc + halfDateAsc;
                            break;
                        case 2:
                            activeQuery += dateAsc;
                            break;
                    }
                    break;
                case 2:
                    switch (comboBox_sum.SelectedIndex)
                    {
                        case 0:
                            activeQuery += sumDesc;
                            break;
                        case 1:
                            activeQuery += sumAsc;
                            break;
                    }
                    break;
            }
            displayData();
        }

        string activeQuery;

        private void comboBox_sum_SelectedIndexChanged(object sender, EventArgs e)
        {
            activeQuery = DataAccess.OrderHistory;
            switch (comboBox_sum.SelectedIndex)
            {
                case 0:
                    switch (comboBox_date.SelectedIndex)
                    {
                        case 0:
                            activeQuery += dateDesc + halfSumDesc;
                            break;
                        case 1:
                            activeQuery += dateAsc + halfSumDesc;
                            break;
                        case 2:
                            activeQuery += sumDesc;
                            break;
                    }
                    break;
                case 1:
                    switch (comboBox_date.SelectedIndex)
                    {
                        case 0:
                            activeQuery += dateDesc + halfSumAsc;
                            break;
                        case 1:
                            activeQuery += dateAsc + halfSumAsc;
                            break;
                        case 2:
                            activeQuery += sumAsc;
                            break;
                    }
                    break;
                case 2:
                    switch (comboBox_date.SelectedIndex)
                    {
                        case 0:
                            activeQuery += dateDesc;
                            break;
                        case 1:
                            activeQuery += dateAsc;
                            break;
                    }
                    break;
            }
            displayData();
        }
    }
}
