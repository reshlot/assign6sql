//step-4 
using System;
using System.Data.SqlClient;

namespace ProductInventorySystem
{
    internal class Program
    {
        static string connectionString = "server=RESHULOTUS;database=ProductInventoryDB; trusted_connection = true;";
        static SqlConnection connection;
        static SqlCommand cmd;

        static void Main(string[] args)
        {
            try
            {
                connection = new SqlConnection(connectionString);
                connection.Open();

                // Retrieve all product records from the database
                string selectQuery = "SELECT * FROM Products";
                cmd = new SqlCommand(selectQuery, connection);
                SqlDataReader reader = cmd.ExecuteReader();

                Console.WriteLine("Product Inventory:");

                // Display the retrieved product details
                while (reader.Read())
                {
                    int productId = (int)reader["ProductId"];
                    string productName = (string)reader["ProductName"];
                    decimal price = (decimal)reader["Price"];
                    int quantity = (int)reader["Quantity"];
                    DateTime mfDate = (DateTime)reader["MfDate"];
                    DateTime expDate = (DateTime)reader["ExpDate"];

                    Console.WriteLine($"Product ID: {productId}");
                    Console.WriteLine($"Product Name: {productName}");
                    Console.WriteLine($"Price: {price:C}");
                    Console.WriteLine($"Quantity: {quantity}");
                    Console.WriteLine($"Manufacture Date: {mfDate.ToShortDateString()}");
                    Console.WriteLine($"Expiration Date: {expDate.ToShortDateString()}");
                    Console.WriteLine("");
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                connection.Close();
                Console.ReadKey();
            }
        }
    }
}







//Step-5 (Add new product ionventory)



/*using System;
using System.Data.SqlClient;

namespace ProductInventorySystem
{
    internal class Program
    {
        static string connectionString = "server=RESHULOTUS;database=ProductInventoryDB; trusted_connection = true;";
        static SqlConnection connection;
        static SqlCommand cmd;

        static void Main(string[] args)
        {
            try
            {
                connection = new SqlConnection(connectionString);
                connection.Open();

                Console.WriteLine("Enter the details of the new product:");
                Console.Write("Product Name: ");
                string productName = Console.ReadLine();

                Console.Write("Price: ");
                decimal price = decimal.Parse(Console.ReadLine());

                Console.Write("Quantity: ");
                int quantity = int.Parse(Console.ReadLine());

                Console.Write("Manufacture Date (MM/DD/YYYY): ");
                DateTime mfDate = DateTime.Parse(Console.ReadLine());

                Console.Write("Expiration Date (MM/DD/YYYY): ");
                DateTime expDate = DateTime.Parse(Console.ReadLine());

                // Insert the new product into the database
                string insertQuery = "INSERT INTO Products (ProductName, Price, Quantity, MfDate, ExpDate) " +
                    "VALUES (@ProductName, @Price, @Quantity, @MfDate, @ExpDate)";
                cmd = new SqlCommand(insertQuery, connection);
                cmd.Parameters.AddWithValue("@ProductName", productName);
                cmd.Parameters.AddWithValue("@Price", price);
                cmd.Parameters.AddWithValue("@Quantity", quantity);
                cmd.Parameters.AddWithValue("@MfDate", mfDate);
                cmd.Parameters.AddWithValue("@ExpDate", expDate);
                cmd.Parameters.AddWithValue("@ProductId", 1);

                int rowsAffected = cmd.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    Console.WriteLine("New product added successfully!");
                }
                else
                {
                    Console.WriteLine("Failed to add the new product.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                connection.Close();
                Console.ReadKey();
            }
        }
    }
}
*/

//Step-6 update product quamtity

/*using System;
using System.Data.SqlClient;

namespace ProductInventorySystem
{
    internal class Program
    {
        static string connectionString = "server=RESHULOTUS;database=ProductInventoryDB; trusted_connection = true;";
        static SqlConnection connection;
        static SqlCommand cmd;

        static void Main(string[] args)
        {
            try
            {
                connection = new SqlConnection(connectionString);
                connection.Open();

                Console.WriteLine("Enter the Product ID of the product to update:");
                int productId = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter the new quantity:");
                int newQuantity = int.Parse(Console.ReadLine());

                // Update the product quantity in the database
                string updateQuery = "UPDATE Products SET Quantity = @NewQuantity WHERE ProductId = @ProductId";
                cmd = new SqlCommand(updateQuery, connection);
                cmd.Parameters.AddWithValue("@NewQuantity", newQuantity);
                cmd.Parameters.AddWithValue("@ProductId", productId);

                int rowsAffected = cmd.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    Console.WriteLine("Product quantity updated successfully!");
                }
                else
                {
                    Console.WriteLine("Failed to update the product quantity.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                connection.Close();
                Console.ReadKey();
            }
        }
    }
}


*/

//Step-7 Remove

/*using System;
using System.Data.SqlClient;

namespace ProductInventorySystem
{
    internal class Program
    {
        static string connectionString = "server=RESHULOTUS;database=ProductInventoryDB; trusted_connection = true;";
        static SqlConnection connection;
        static SqlCommand cmd;

        static void Main(string[] args)
        {
            try
            {
                connection = new SqlConnection(connectionString);
                connection.Open();

                Console.WriteLine("Enter the Product ID of the product to remove:");
                int productId = int.Parse(Console.ReadLine());

                // Remove the product from the database
                string deleteQuery = "DELETE FROM Products WHERE ProductId = @ProductId";
                cmd = new SqlCommand(deleteQuery, connection);
                cmd.Parameters.AddWithValue("@ProductId", productId);

                int rowsAffected = cmd.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    Console.WriteLine("Product removed successfully!");
                }
                else
                {
                    Console.WriteLine("Failed to remove the product.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                connection.Close();
                Console.ReadKey();
            }
        }
    }
}
*/