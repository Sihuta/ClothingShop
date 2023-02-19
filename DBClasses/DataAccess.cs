using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CourseProject
{
    class DataAccess
    {
        const string ConnectionString = @"Data Source=localhost;Initial Catalog=ClothingShop;Integrated Security=True";

        public static string GetProductInfo = "SELECT Catalog.Product_id 'Код товару', ClothingType.Type 'Тип одягу', Brand.Brand 'Бренд', Brand.BrandClass 'Категорія одягу', Catalog.Producer 'Виготовник', Catalog.Gender 'Гендер', Catalog.Price 'Ціна' " +
            "FROM Catalog, ClothingType, Brand, Storage " +
            "WHERE Catalog.Type_id = ClothingType.Type_id AND Catalog.Brand_id = Brand.Brand_id AND Catalog.Product_id = Storage.Product_id " +
            "GROUP BY Catalog.Product_id, ClothingType.Type, Brand.Brand, Brand.BrandClass, Catalog.Producer, Catalog.Gender, Catalog.Price " +
            "HAVING SUM(Storage.Amount) > 0 ";

        public static string ExclusiveProd = "SELECT DISTINCT Catalog.Product_id 'Код товару', ClothingType.Type 'Тип одягу', Brand.Brand 'Бренд', Brand.BrandClass 'Категорія', Catalog.Producer 'Виготовник', Catalog.Gender 'Гендер', Catalog.Price 'Ціна' " +
            "FROM Catalog, ClothingType, Brand, Storage " +
            "WHERE Catalog.Type_id = ClothingType.Type_id " +
            "AND Catalog.Brand_id = Brand.Brand_id " +
            "AND Catalog.Product_id = Storage.Product_id " +
            "AND Catalog.Price >= (SELECT AVG(Price) FROM Catalog) " +
            "AND Storage.Amount <= 5 ";

        public static string PopularProd = "SELECT Catalog.Product_id 'Код товару', ClothingType.Type 'Тип одягу', Brand.Brand 'Бренд', Brand.BrandClass 'Категорія', Catalog.Producer 'Виготовник', Catalog.Gender 'Гендер', Catalog.Price 'Ціна' " +
            "FROM Catalog, ClothingType, Brand " +
            "WHERE Catalog.Type_id = ClothingType.Type_id AND Catalog.Brand_id = Brand.Brand_id " +
            "AND Catalog.Product_id IN " +
            "(SELECT Product_id " +
            "FROM (SELECT Storage.Product_id, COUNT(DISTINCT[Order].Delivery_id) COUNT_ " +
            "FROM Storage, [Order] " +
            "WHERE Storage.ProductCode = [Order].ProductCode " +
            "GROUP BY Storage.Product_id " +
            ") X JOIN " +
            "(SELECT MAX(COUNT_) MAX_COUNT " +
            "FROM (SELECT Storage.Product_id, COUNT(DISTINCT[Order].Delivery_id) COUNT_ " +
            "FROM Storage, [Order] " +
            "WHERE Storage.ProductCode = [Order].ProductCode " +
            "GROUP BY Storage.Product_id " +
            ") X " +
            ") Y ON COUNT_ = MAX_COUNT) ";

        public static string WholesaleProd = "SELECT Catalog.Product_id 'Код товару', ClothingType.Type 'Тип одягу', Brand.Brand 'Бренд', Brand.BrandClass 'Категорія', Catalog.Producer 'Виготовник', Catalog.Gender 'Гендер', Catalog.Price 'Ціна' " +
            "FROM Catalog, ClothingType, Brand " +
            "WHERE Catalog.Type_id = ClothingType.Type_id AND Catalog.Brand_id = Brand.Brand_id " +
            "AND Catalog.Product_id IN " +
            "(SELECT Storage.Product_id " +
            "FROM Storage, [Order] " +
            "WHERE Storage.ProductCode = [Order].ProductCode " +
            "GROUP BY Storage.Product_id, [ORDER].Delivery_id " +
            "HAVING SUM([Order].Amount) >= 10) ";

        public static string SearchQueryString = "SELECT Product_id FROM Catalog, ClothingType, Brand " +
            "WHERE Catalog.Type_id = ClothingType.Type_id AND Brand.Brand_id = Catalog.Brand_id " +
            "AND ClothingType.Type LIKE @Type AND Brand.Brand LIKE @Brand";

        public static string SearchQueryByTypeString = "SELECT Product_id FROM Catalog, ClothingType " +
            "WHERE Catalog.Type_id = ClothingType.Type_id " +
            "AND ClothingType.Type LIKE @Type";

        public static string SearchQueryByBrandString = "SELECT Product_id FROM Catalog, Brand " +
            "WHERE Brand.Brand_id = Catalog.Brand_id " +
            "AND Brand.Brand LIKE @Brand";

        public static string GetProductMaterial = "SELECT [Product&Material].MaterialType 'Частина одягу', Material.Material 'Матеріал' " +
            "FROM [Product&Material], Material " +
            "WHERE [Product&Material].Material_id = Material.Material_id " +
            "AND [Product&Material].Product_id = @ProductID";

        public static string GetProductAssortiment = "SELECT Size AS 'Розмір', Amount AS 'Кількість' " +
            "FROM Storage " +
            "WHERE (Product_id = @ProductID) AND Amount > 0";

        public static string GetSizeList = "SELECT Size FROM Storage WHERE Product_id = @ProductID";

        public static string GetOrderData = "SELECT Catalog.Product_id 'Код товару', ClothingType.Type 'Тип одягу', Brand.Brand 'Бренд', " +
            "Catalog.Producer 'Виготовник', Catalog.Gender 'Гендер', Storage.Size 'Розмір', Catalog.Price 'Ціна', " +
            "[Order].Amount 'Кількість', Catalog.Price*[Order].Amount 'Вартість' " +
            "from Catalog, ClothingType, Brand, Storage, [Order] " +
            "WHERE Catalog.Type_id = ClothingType.Type_id AND Catalog.Brand_id = Brand.Brand_id " +
            "AND Catalog.Product_id = Storage.Product_id AND Storage.ProductCode = [Order].ProductCode " +
            "AND [Order].Delivery_id = @DeliveryID";

        public static string CountProductsInOrder = "SELECT COUNT([Order].Order_id) " +
            "FROM[Order], Delivery " +
            "WHERE Delivery.Delivery_id = [Order].Delivery_id " +
            "AND[Order].Delivery_id IN(SELECT Delivery_id " +
            "FROM Delivery " +
            "WHERE BookingDate IS NULL AND Client_id = 3)";

        public static string DeleteProduct = "DELETE FROM [Order] " +
            "WHERE Delivery_id = @DeliveryID AND ProductCode = " +
            "(SELECT ProductCode FROM Storage WHERE Product_id = @ProductID AND Size = @Size)";

        public static string CountInOrder = "SELECT COUNT([Order].Order_id) FROM[Order], Delivery " +
            "WHERE Delivery.Delivery_id = [Order].Delivery_id AND[Order].Delivery_id IN " +
            "(SELECT Delivery_id FROM Delivery WHERE BookingDate IS NULL AND Address_id = @AddressID)";

        public static string OrderHistory = "SELECT Delivery.Delivery_id '№ доставки', Delivery.BookingDate 'Дата і час замовлення', SUM([Order].Amount * Catalog.Price) 'Сума до сплати' " +
            "FROM Delivery, [Order], Catalog, Storage, Address, Client " +
            "WHERE Delivery.Delivery_id = [Order].Delivery_id AND [Order].ProductCode = Storage.ProductCode AND Storage.Product_id = Catalog.Product_id " +
            "AND Delivery.Address_id = Address.Address_id AND Address.Client_id = Client.Client_id AND Client.Client_id = @ClientID AND Delivery.BookingDate IS NOT NULL " +
            "GROUP BY Delivery.Delivery_id, Delivery.BookingDate ";

        public static string CountDeliveries = "SELECT COUNT(Delivery.Delivery_id) " +
            "FROM Delivery, Address, Client " +
            "WHERE Delivery.Address_id = Address.Address_id AND Address.Client_id = Client.Client_id " +
            "AND Client.Client_id = @ClientID";

        public static BindingSource MakeSimpleQuery(string query)
        {
            SqlConnection sqlconn = new SqlConnection(ConnectionString);
            sqlconn.Open();
            SqlDataAdapter oda = new SqlDataAdapter(query, sqlconn);
            DataTable dt = new DataTable();
            BindingSource bs = new BindingSource();
            oda.Fill(dt);
            bs.DataSource = dt;
            sqlconn.Close();
            return bs;
        }

        public static int MakeValueQuery(string query, string parameter, int intValue)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                SqlParameter param = new SqlParameter(parameter, intValue);
                command.Parameters.Add(param);
                command.ExecuteNonQuery();

                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = command;
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                return Convert.ToInt32(dt.Rows[0].ItemArray[0]);
            }
        }

        public static BindingSource MakeComplexQuery(string query, string parameter, int intValue)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                SqlParameter param = new SqlParameter(parameter, intValue);
                command.Parameters.Add(param);
                command.ExecuteNonQuery();

                SqlDataAdapter adapter = new SqlDataAdapter
                {
                    SelectCommand = command
                };
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                BindingSource bs = new BindingSource
                {
                    DataSource = dt
                };

                return bs;
            }
        }

        public static void DeleteProductFromOrder(int deliveryID, int productID, string size)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(DeleteProduct, connection);
                command.Parameters.Add(new SqlParameter("@DeliveryID", deliveryID));
                command.Parameters.Add(new SqlParameter("@ProductID", productID));
                command.Parameters.Add(new SqlParameter("@Size", size));
                command.ExecuteNonQuery();
            }
        }

        public static DataTable DoComplexQuery(string query, string parameter, int intValue)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                SqlParameter param = new SqlParameter(parameter, intValue);
                command.Parameters.Add(param);
                command.ExecuteNonQuery();

                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = command;
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                return dt;
            }
        }

        public static int[] SearchQueryBy2Val(string type, string brand)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(SearchQueryString, connection);
                command.Parameters.Add(new SqlParameter("@Type", "%" + type + "%"));
                command.Parameters.Add(new SqlParameter("@Brand", "%" + brand + "%"));
                command.ExecuteNonQuery();

                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = command;
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                var arr = new int[dt.Rows.Count];
                for (int i = 0; i < dt.Rows.Count; ++i)
                {
                    arr[i] = (int)dt.Rows[i].ItemArray[0];
                }
                return arr;
            }
        }

        public static int[] SearchQueryByType(string type)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(SearchQueryByTypeString, connection);
                command.Parameters.Add(new SqlParameter("@Type", "%" + type + "%"));
                command.ExecuteNonQuery();

                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = command;
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                var arr = new int[dt.Rows.Count];
                for (int i = 0; i < dt.Rows.Count; ++i)
                {
                    arr[i] = (int)dt.Rows[i].ItemArray[0];
                }
                return arr;
            }
        }

        public static int[] SearchQueryByBrand(string brand)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(SearchQueryByBrandString, connection);
                command.Parameters.Add(new SqlParameter("@Brand", "%" + brand + "%"));
                command.ExecuteNonQuery();

                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = command;
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                var arr = new int[dt.Rows.Count];
                for (int i = 0; i < dt.Rows.Count; ++i)
                {
                    arr[i] = (int)dt.Rows[i].ItemArray[0];
                }
                return arr;
            }
        }

        public static BindingSource DisplayNotReadyProdAmount(int[] prodID)
        {
            string query = "SELECT * FROM ProductAmount WHERE";
            if (prodID.Length > 1)
            {
                for (int i = 1; i <= prodID.Length; ++i)
                {
                    if (i == 1)
                        query += " Product_id = " + "@ProductID" + i;
                    else
                        query += " OR" + " Product_id = " + "@ProductID" + i;
                }
            }
            else if (prodID.Length == 1)
            {
                query += " Product_id = " + "@ProductID" + "1";
            }

            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);

                for (int i = 1; i <= prodID.Length; ++i)
                {
                    command.Parameters.Add(new SqlParameter("@ProductID" + i, prodID[i - 1]));
                }

                command.ExecuteNonQuery();

                SqlDataAdapter adapter = new SqlDataAdapter
                {
                    SelectCommand = command
                };
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                BindingSource bs = new BindingSource
                {
                    DataSource = dt
                };

                return bs;
            }
        }

        public static BindingSource FilterQuery(string[] types, string[] brands, string[] producers, string[] categories, string[] genders, int priceFrom, int priceTo, string sortQuery = null)
        {
            string query = MainForm.ActiveQueryString;
            query = createQuery(query, types.Length, "ClothingType.Type", "@Type");
            query = createQuery(query, brands.Length, "Brand.Brand", "@Brand");
            query = createQuery(query, producers.Length, "Catalog.Producer", "@Producer");
            query = createQuery(query, categories.Length, "Brand.BrandClass", "@Category");
            query = createQuery(query, genders.Length, "Catalog.Gender", "@Gender");
            query += " AND Catalog.Price BETWEEN @PriceFrom AND @PriceTo";

            query += sortQuery;
            //MainForm.ActiveQueryString = query;

            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);

                int i = 1;
                while (i <= types.Length)
                {
                    command.Parameters.Add(new SqlParameter("@Type" + i, types[i - 1]));
                    ++i;
                }
                i = 1;
                while (i <= brands.Length)
                {
                    command.Parameters.Add(new SqlParameter("@Brand" + i, brands[i - 1]));
                    ++i;
                }
                i = 1;
                while (i <= producers.Length)
                {
                    command.Parameters.Add(new SqlParameter("@Producer" + i, producers[i - 1]));
                    ++i;
                }
                i = 1;
                while (i <= categories.Length)
                {
                    command.Parameters.Add(new SqlParameter("@Category" + i, categories[i - 1]));
                    ++i;
                }
                i = 1;
                while (i <= genders.Length)
                {
                    command.Parameters.Add(new SqlParameter("@Gender" + i, genders[i - 1]));
                    ++i;
                }

                command.Parameters.Add(new SqlParameter("@PriceFrom", priceFrom));
                command.Parameters.Add(new SqlParameter("@PriceTo", priceTo));
                command.ExecuteNonQuery();

                SqlDataAdapter adapter = new SqlDataAdapter
                {
                    SelectCommand = command
                };
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                BindingSource bs = new BindingSource
                {
                    DataSource = dt
                };

                return bs;
            }
        }

        static string createQuery(string query, int arrLength, string attribute, string param)
        {
            if (arrLength > 1)
            {
                for (int i = 1; i <= arrLength; ++i)
                {
                    if (i == 1)
                        query += " AND (" + attribute + " = " + param + i;
                    else if (i < arrLength)
                        query += " OR " + attribute + " = " + param + i;
                    else
                        query += " OR " + attribute + " = " + param + i + ")";
                }
            }
            else if (arrLength == 1)
            {
                query += " AND " + attribute + " = " + param + "1";
            }

            return query;
        }
    }
}
