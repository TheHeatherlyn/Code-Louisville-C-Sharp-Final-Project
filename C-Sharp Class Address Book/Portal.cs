using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace C_Sharp_Class_Address_Book
{
    public class Portal
    {
        public bool Save(Contacts contact)
        {
            string connectionString = @"Data Source=LAPTOP-P0TS8S9C\SQLEXPRESS;Initial Catalog=msdb;Integrated Security=True";
            var connection = new SqlConnection(connectionString);
            connection.Open();

            string query = "INSERT INTO [Dbo].[Table] VALUES ('" + contact.Name + "','" + contact.Phone + "','" + contact.Street + "','" + contact.City + "','" + contact.State + "'," + contact.Zip + ");";
            SqlCommand command = new SqlCommand(query, connection);
            command.ExecuteNonQuery();
            connection.Close();
            return true;

        }

        public Contacts Get(string Name)
        {
            Contacts contacts = new Contacts();
            string connectionString = @"Data Source=LAPTOP-P0TS8S9C\SQLEXPRESS;Initial Catalog=msdb;Integrated Security=True";
            var connection = new SqlConnection(connectionString);
            connection.Open();

            string newQuery = @"SELECT * FROM [Dbo].[Table] WHERE Name = " + Name.Trim();
            SqlCommand cmd = new SqlCommand(query, connection);

            SqlDataReader reader = new cmd.ExecuteReader();
            while (reader.Read)
            {
                contacts.Id = Convert.ToInt32(reader["Id"].ToString());
                contacts.Name = reader["Name"].ToString();
                contacts.Phone = reader["Phone"].ToString();
                contacts.Street = reader["Street"].ToString();
                contacts.City = reader["City"].ToString();
                contacts.State = reader["State"].ToString();
                contacts.Zip = reader["Zip"].ToString();
            }
            return contacts;
        }
        

        private void Get(string v, object name)
        {
            throw new NotImplementedException();
        }
    }
}
