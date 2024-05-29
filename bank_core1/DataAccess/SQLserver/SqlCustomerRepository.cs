using bank_core1.domain.Entites;
using bank_core1.domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace bank_core1.DataAccess.SQLserver
{

    public class SqlCustomerRepository : ICustomerRepository
    {
        private readonly string _connectionString = @" Data Source=QASID\MSSQLSERVER02;
                                            Initial Catalog=BANK;
                                             Integrated Security=true";



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

                command.Parameters.AddWithValue("@Id", item.Id);
                command.Parameters.AddWithValue("@Name", item.FirstName);
                command.Parameters.AddWithValue("@LastName", item.LastName);
                command.Parameters.AddWithValue("@BirthDate", item.BirthDate);
                command.Parameters.AddWithValue("@JoinTime", item.JoinTime);
                command.Parameters.AddWithValue("@Address", item.Address);
                command.Parameters.AddWithValue("@PhoneNumber", item.PhoneNumber);
                command.Parameters.AddWithValue("@Email", item.Email);

                return (int)command.ExecuteScalar();

            }
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Customer Get(int id)
        {
            throw new NotImplementedException();
        }

        public List<Customer> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Update(Customer item)
        {
            throw new NotImplementedException();
        }

        void ICrudRepository<Customer>.Add(Customer item)
        {
            throw new NotImplementedException();
        }
    }
}
