using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace CourseProject
{
    public partial class CheckDelivery : Form
    {
        static DataTable addressWithID = new DataTable();
        static DataTable address = new DataTable();

        List<int> amounts = new List<int>();
        List<int> prodsID = new List<int>();
        List<string> sizes = new List<string>();

        string email;

        public CheckDelivery()
        {
            InitializeComponent();            
        }

        public CheckDelivery(List<int> amount, List<int> prodID, List<string> size)
            : this()
        {
            amounts = amount;
            prodsID = prodID;
            sizes = size;
        }

        public static void fillComboBox()
        {
            comboBox_address.Items.Clear();

            addressWithID = Address.GetAddressData(Address.GetDataByClientIdQuery, "@ClientID", Client.ID);
            for (int i = 0; i < addressWithID.Rows.Count; ++i)
            {
                comboBox_address.Items.Add(comboBoxItem(addressWithID, i));
            }
            address = Address.GetAddressData(Address.GetDataByAddressIdQuery, "@AddressID", Client.AddressID);
            comboBox_address.SelectedItem = comboBoxItem(address, 0);
        }

        static string comboBoxItem(DataTable dt, int index)
        {
            string city = dt.Rows[index].ItemArray[0].ToString();
            string street = dt.Rows[index].ItemArray[1].ToString();
            string houseNum = dt.Rows[index].ItemArray[2].ToString();
            string frontDoorNum = dt.Rows[index].ItemArray[3].ToString();
            string flatNum = dt.Rows[index].ItemArray[4].ToString();

            if (frontDoorNum == "" && flatNum == "")
            {
                return "Місто " + city +
                    ", вул. " + street +
                    ", буд. " + houseNum;
            }
            if (frontDoorNum == "")
            {
                return "Місто " + city +
                    ", вул. " + street +
                    ", буд. " + houseNum +
                    ", кв. " + flatNum;
            }

            return "Місто " + city +
                    ", вул. " + street +
                    ", буд. " + houseNum +
                    ", під'їзд " + frontDoorNum +
                    ", кв. " + flatNum;
        }

        private void button_cancel_Click(object sender, EventArgs e)
        {
            var del = new ArrangeDelivery();
            del.Show();
            Close();
        }

        private void button_newAddress_Click(object sender, EventArgs e)
        {
            var newAd = new AddNewAddress();
            newAd.Show();

            fillComboBox();
        }

        void getEmail()
        {
            textBox_email.Text = clientTableAdapter1.GetEmail(Client.ID).ToString();
        }

        private void CheckDelivery_Load(object sender, EventArgs e)
        {
            fillComboBox();
            getEmail();
        }

        private void button_order_Click(object sender, EventArgs e)
        {
            var orderReport = new ReportViewer("order");
            orderReport.Show();
        }

        private void button_receipt_Click(object sender, EventArgs e)
        {
            var receiptReport = new ReportViewer("receipt");
            receiptReport.Show();
        }

        private void button_makeDel_Click(object sender, EventArgs e)
        {
            if (checkInput())
            {
                sendEmailMessage(updateStorageAndDeliveryData());
                MessageBox.Show("Чекайте на лист-підтвердження у вказаній почтовій скриньці!");
                Close();
            }
        }

        bool checkInput()
        {
            email = textBox_email.Text;
            bool mailValidate = EmailValidator.IsValidEmailAddress(email);
            if (!mailValidate)
            {
                MessageBox.Show("Адреса поштової скриньки введена неправильно. Спробуйте ще раз");
                return false;
            }
            return true;
        }

        int updateStorageAndDeliveryData()
        {
            int count = amounts.Count;
            for (int i = 0; i < count; ++i)
            {
                storageTableAdapter.UpdateQuery(
                    amounts[i],
                    prodsID[i],
                    sizes[i]
                    );
            }
            Client.AddressID = getAddressID();
            deliveryTableAdapter.UpdateAllQuery(DateTime.Now, Client.AddressID, Client.DeliveryID);

            int deliveryId = Client.DeliveryID;
            deliveryTableAdapter.InsertQuery(null, Client.AddressID);
            Client.DeliveryID = (int)deliveryTableAdapter.GetID(Client.AddressID);
            return deliveryId;
        }

        int getAddressID()
        {
            int id = Convert.ToInt32(comboBox_address.SelectedIndex);
            id = Convert.ToInt32(addressWithID.Rows[id].ItemArray[5]);
            return id;
        }

        void sendEmailMessage(int deliveryId)
        {
            DataTable dt = Client.GetClientData(Client.GetFullNameQuery);
            string surname = dt.Rows[0].ItemArray[0].ToString();
            string name = dt.Rows[0].ItemArray[1].ToString();
            string secondName = dt.Rows[0].ItemArray[2].ToString();

            string message = "Цей лист-підтвердження адресовано клієнту магазину одягу на ім'я " + surname + " " + name + " " + secondName + "!\n";
            message += "Оформлення доставки пройшло успішно." +
                        "Отже, протягом робочого тижня очікуйте на своє замовлення за наступною адресою: \n" +
                        comboBox_address.Text;
            message += "\nНомер вашої доставки - " + deliveryId + ".\n";
            message += "Сплачуйте замовлення заздалегідь за збереженою квитанцією або після перевірки доставленого вам товару.\n";
            message += "Бажаємо вам гарних Новорічних свят!";

            SendEmail.ConfirmDelivery(email, message);
        }
    }
}
