using System;
using System.Data;

namespace CourseProject
{
    class Client
    {
        public static int ID;
        public static string Login;
        public static string Password;
        public static string Name;
        public static string Email;
        public static string Phone;

        public static int DeliveryID = -1;
        public static int AddressID = -1;

        public static string GetDataByIDQuery = "SELECT Login, Password, Surname, Name, SecondName, Email, PhoneNumber FROM dbo.Client WHERE Client_id = @ClientID";

        public static string GetFullNameQuery = "SELECT Surname, Name, SecondName FROM dbo.Client WHERE Client_id = @ClientID";

        public static DataTable GetClientData(string query)
        {
            return DataAccess.DoComplexQuery(query, "ClientID", ID);
        }

        public static void SaveData(string login, string password, string name, string email, string phone)
        {
            Login = login;
            Password = password;
            Name = name;
            Email = email;
            Phone = phone;
        }
    }
}
