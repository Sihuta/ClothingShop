using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseProject
{
    class Address
    {
        public static string GetDataByAddressIdQuery = "SELECT City, Street, HouseNum, FrontDoorNum, FlatNum " +
            "FROM dbo.Address " +
            "WHERE Address_id = @AddressID";
        public static string GetDataByClientIdQuery = "SELECT City, Street, HouseNum, FrontDoorNum, FlatNum, Address_id " +
            "FROM dbo.Address " +
            "WHERE Client_id = @ClientID";

        public static DataTable GetAddressData(string query, string param, int value)
        {
            return DataAccess.DoComplexQuery(query, param, value);
        }

        
    }
}
