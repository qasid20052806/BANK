using bank_core1.domain.Entites;
using bank_core1.domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Runtime.InteropServices;

namespace bank_core1.DataAccess.SQLserver
{

    public class SqlCustomerRepository : ICustomerRepository
    {
        private readonly string _connectionString = @" Data Source=QASID\MSSQLSERVER02;
                                            Initial Catalog=BANK;
                                             Integrated Security=true";

        public SqlCustomerRepository()
        {
             

        }

        SqlCustomerRepository(string connectionString)
        {
            _connectionString = connectionString;
        }

        public int Add(Customer item)
        {
            if (item == null)
            {
                throw new ArgumentNullException(nameof(item), "Customer cannot be null");
            }

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                string query = @"INSERT INTO Customers (ID, FirstName, LastName, BirthDate, JoinTime, Address, PhoneNumber, Email) 
                         VALUES (@Id, @Name, @LastName, @BirthDate, @JoinTime, @Address, @PhoneNumber, @Email)";
                SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue("@ID", item.ID);
                command.Parameters.AddWithValue("@FirstName", item.FirstName);
                command.Parameters.AddWithValue("@LastName", item.LastName);
                command.Parameters.AddWithValue("@BirthDate", item.BirthDate);
                command.Parameters.AddWithValue("@JoinTime", item.JoinTime);
                command.Parameters.AddWithValue("@Address", item.Address);
                command.Parameters.AddWithValue("@PhoneNumber", item.PhoneNumber);
                command.Parameters.AddWithValue("@Email", item.Email);

                return (int)command.ExecuteScalar();

            }
        }

        public void Delete(int ID)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                string query = "UPDATE Customers SET IsActive = 0 WHERE ID = @ID";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ID", ID);
                    command.ExecuteNonQuery();
                }
            }
        }

        public Customer Get(int ID)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                string query = "SELECT ID, FirstName,LastName,BirthDate,JoinTime,Address,PhoneNumber,Email FROM Customers WHERE ID = @ID and IsActive = 1";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ID",ID );

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read() == false)
                            return null;

                        Customer customer = new Customer(); 

                        customer.ID = reader.GetInt32(reader.GetOrdinal("ID"));
                        customer.FirstName = reader.GetString(reader.GetOrdinal("FirstName"));
                        customer.BirthDate = reader.GetDateTime(reader.GetOrdinal("BirthDate"));
                        customer.JoinTime = reader.GetDateTime(reader.GetOrdinal("JoinTime"));
                        customer.Address = reader.GetString(reader.GetOrdinal("Address"));
                        customer.PhoneNumber = reader.GetString(reader.GetOrdinal("PhoneNumber"));
                        customer.Email = reader.GetString(reader.GetOrdinal("Email"));



                        return customer;
                    }
                }
            }
        }

        public List<Customer> GetAll()
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                string query = "SELECT ID, FirstName,LastName,BirthDate,JoinTime,Address,PhoneNumber,Email FROM Customers WHERE IsActive = 1";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    List<Customer> customers = new List<Customer>();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Customer customer = new Customer();

                            customer.ID = reader.GetInt32(reader.GetOrdinal("ID"));
                            customer.FirstName = reader.GetString(reader.GetOrdinal("FirstName"));
                            customer.BirthDate = reader.GetDateTime(reader.GetOrdinal("BirthDate"));
                            customer.JoinTime = reader.GetDateTime(reader.GetOrdinal("JoinTime"));
                            customer.Address = reader.GetString(reader.GetOrdinal("Address"));
                            customer.PhoneNumber = reader.GetString(reader.GetOrdinal("PhoneNumber"));
                            customer.Email = reader.GetString(reader.GetOrdinal("Email"));

                            customers.Add(customer);
                        }

                        return customers;
                    }
                }
            }
        }

        public void Update(Customer item)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                string query = @"UPDATE Customers SET FirstName = @FirstName, LastName = @LastName, 
                                BirthDate = @BirthDate, JoinTime = @JoinTime,
                                Address = @Address,
                                PhoneNumber=@PhoneNumber,
                                Email=@Email
                                WHERE ID = @ID";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    

                    command.Parameters.AddWithValue("@ID", item.ID);
                    command.Parameters.AddWithValue("@FirstName", item.FirstName);
                    command.Parameters.AddWithValue("@LastName", item.LastName);
                    command.Parameters.AddWithValue("@BirthDate", item.BirthDate);
                    command.Parameters.AddWithValue("@JoinTime", item.JoinTime);
                    command.Parameters.AddWithValue("@Address", item.Address);
                    command.Parameters.AddWithValue("@PhoneNumber", item.PhoneNumber);
                    command.Parameters.AddWithValue("@Email", item.Email);

                    command.ExecuteNonQuery();
                }
            }
        }

        void ICrudRepository<Customer>.Add(Customer item)
        {
            throw new NotImplementedException();
        }
    }
}
