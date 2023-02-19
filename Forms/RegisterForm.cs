using System;
using System.Data;
using System.Windows.Forms;

namespace CourseProject
{
    public partial class RegisterForm : Form
    {
        public static bool Edit = false;

        string login;
        string password;
        string surname;
        string name;
        string secondName;
        string email;
        string phone;

        string city;
        string street;
        string houseNum;
        string frontDoorNum;
        string flatNum;

        public RegisterForm()
        {
            InitializeComponent();

            if (Edit)
            {
                button_register.Visible = false;
                button_UPD.Visible = true;
                fillInputFields();
            }
        }

        private void button_register_Click(object sender, EventArgs e)
        {
            if (checkInput())
            {
                insertClient();
                insertAddress();

                Close();
                var mf = new MainForm();
                mf.Show();
            }            
        }

        void insertClient()
        {
            try
            {
                clientTableAdapter.InsertQuery(
                    login,
                    password,
                    surname,
                    name,
                    secondName,
                    email,
                    phone,
                    DateTime.Now
                    );
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

            clientTableAdapter.Update(clothingShopDataSet);
            Client.ID = (int)clientTableAdapter.LogInQuery(login, password);
            MessageBox.Show("Реєстрація пройшла успішно!");
        }

        void insertAddress()
        {
            try
            {
                addressTableAdapter1.InsertQuery(
                    Client.ID,
                    city,
                    street,
                    houseNum,
                    frontDoorNum,
                    flatNum
                    );
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

            Client.AddressID = (int)addressTableAdapter1.GetID(Client.ID);
            deliveryTableAdapter.InsertQuery(null, Client.AddressID);
            Client.DeliveryID = (int)deliveryTableAdapter.GetMaxID(Client.AddressID);
        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "clothingShopDataSet.Delivery". При необходимости она может быть перемещена или удалена.
            this.deliveryTableAdapter.Fill(this.clothingShopDataSet.Delivery);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "clothingShopDataSet.Client". При необходимости она может быть перемещена или удалена.
            clientTableAdapter.Fill(clothingShopDataSet.Client);
        }

        private void button_UPD_Click(object sender, EventArgs e)
        {
            if (checkInput())
            {
                updateClient();
                updateAddress();

                MessageBox.Show("Ваші дані успішно відредаговано!");
                Close();
            }
        }

        void updateClient()
        {
            clientTableAdapter.UpdateQuery(
                    login,
                    password,
                    surname,
                    name,
                    secondName,
                    email,
                    phone,
                    Client.ID
                    );
            clientTableAdapter.Update(clothingShopDataSet);
        }

        void updateAddress()
        {
            addressTableAdapter1.UpdateQuery(
                    city,
                    street,
                    houseNum,
                    frontDoorNum,
                    flatNum,
                    Client.AddressID
                    );
            //Client.AddressID = (int)addressTableAdapter1.GetID(Client.ID);
            //deliveryTableAdapter.UpdateQuery(Client.AddressID, Client.DeliveryID);
        }

        void fillInputFields()
        {
            DataTable dt = Client.GetClientData(Client.GetDataByIDQuery);

            textBox_login.Text = dt.Rows[0].ItemArray[0].ToString();
            textBox_password.Text = dt.Rows[0].ItemArray[1].ToString();
            textBox_surname.Text = dt.Rows[0].ItemArray[2].ToString();
            textBox_name.Text = dt.Rows[0].ItemArray[3].ToString();
            textBox_secondName.Text = dt.Rows[0].ItemArray[4].ToString();
            textBox_email.Text = dt.Rows[0].ItemArray[5].ToString();
            maskedTextBox_phone.Text = dt.Rows[0].ItemArray[6].ToString();

            dt = Address.GetAddressData(Address.GetDataByAddressIdQuery, "@AddressID", Client.AddressID);

            textBox_city.Text = dt.Rows[0].ItemArray[0].ToString();
            textBox_street.Text = dt.Rows[0].ItemArray[1].ToString();
            textBox_houseNum.Text = dt.Rows[0].ItemArray[2].ToString();
            textBox_frontDoorNum.Text = dt.Rows[0].ItemArray[3].ToString();
            textBox_flatNum.Text = dt.Rows[0].ItemArray[4].ToString();
        }

        bool checkInput()
        {
            setValues();

            if (login == "" || password == "" || name == "" || email == "" || phone == "" || city == "" || street == "" || houseNum == "")
            {
                MessageBox.Show("Будь ласка, переконайтесь у тому, що всі необхідні поля заповнені");
                return false;
            }

            bool mailValidate = EmailValidator.IsValidEmailAddress(email);
            if (!mailValidate)
            {
                MessageBox.Show("Адреса поштової скриньки введена неправильно. Спробуйте ще раз");
                return false;
            }
            return true;
        }

        private void button_cancel_Click(object sender, EventArgs e)
        {
            if (!Edit)
            {
                var lgf = new LoginForm();
                lgf.Show();
            }
            Close();
        }

        void setValues()
        {
            login = textBox_login.Text;
            password = textBox_password.Text;
            surname = textBox_surname.Text;
            name = textBox_name.Text;
            secondName = textBox_secondName.Text;
            email = textBox_email.Text;
            phone = maskedTextBox_phone.Text;

            city = textBox_city.Text;
            street = textBox_street.Text;
            houseNum = textBox_houseNum.Text;
            frontDoorNum = textBox_frontDoorNum.Text;
            flatNum = textBox_flatNum.Text;
        }
    }
}