using System;
using System.Windows.Forms;

namespace CourseProject
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void button_register_Click(object sender, EventArgs e)
        {
            RegisterForm.Edit = false;
            var register = new RegisterForm();
            register.Show();
            Hide();
        }

        private void button_logIn_Click(object sender, EventArgs e)
        {
            var login = textBox_login.Text;
            var password = textBox_password.Text;

            if (login == "")
            {
                MessageBox.Show("Будь ласка, введіть Ваш логін");
                return;
            }
            if (password == "")
            {
                MessageBox.Show("Будь ласка, введіть Ваш пароль");
                return;
            }
            
            try
            {
                Client.ID = (int)clientTableAdapter.LogInQuery(login, password);
            }
            catch
            {
                MessageBox.Show("Авторизація не пройшла. Перевірте, будь ласка, правильність введених даних");
                return;
            }
            try
            {
                Client.AddressID = (int)addressTableAdapter1.GetID(Client.ID);
                Client.DeliveryID = (int)deliveryTableAdapter1.GetID(Client.AddressID);
            }
            catch
            {
                if (Client.DeliveryID == -1)
                {                   
                    deliveryTableAdapter1.InsertQuery(null, Client.AddressID);
                    Client.DeliveryID = (int)deliveryTableAdapter1.GetMaxID(Client.AddressID);
                }
            }

            Hide();
            var mf = new MainForm();
            mf.Show();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "clothingShopDataSet.Client". При необходимости она может быть перемещена или удалена.
            clientTableAdapter.Fill(clothingShopDataSet.Client);
        }
    }
}