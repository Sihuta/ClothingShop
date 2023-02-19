using System;
using System.Windows.Forms;

namespace CourseProject
{
    public partial class AddNewAddress : Form
    {
        string city;
        string street;
        string houseNum;
        string frontDoorNum;
        string flatNum;

        public AddNewAddress()
        {
            InitializeComponent();
        }

        private void button_cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button_ok_Click(object sender, EventArgs e)
        {
            if (checkInput())
            {
                addNewAddress();
                MessageBox.Show("Ця адреса була успішно збережена!");
                Close();
                CheckDelivery.fillComboBox();
            }
        }

        bool checkInput()
        {
            city = textBox_city.Text;
            street = textBox_street.Text;
            houseNum = textBox_houseNum.Text;
            frontDoorNum = textBox_frontDoorNum.Text;
            flatNum = textBox_flatNum.Text;

            if (city == "" || street == "" || houseNum == "")
            {
                MessageBox.Show("Будь ласка, переконайтесь у тому, що всі необхідні поля заповнені");
                return false;
            }
            return true;
        }

        void addNewAddress()
        {
            addressTableAdapter1.InsertQuery(
                    Client.ID,
                    city,
                    street,
                    houseNum,
                    frontDoorNum,
                    flatNum
                    );

            Client.AddressID = (int)addressTableAdapter1.GetID(Client.ID);
            deliveryTableAdapter1.UpdateQuery(Client.AddressID, Client.DeliveryID);

            addressTableAdapter1.Update(clothingShopDataSet1);
            addressTableAdapter1.Fill(clothingShopDataSet1.Address);
        }
    }
}
