using System;
using System.Data;
using System.Data.SqlClient;

namespace library
{
    internal class DataAccess
    {
        private readonly string connectionString;

        public DataAccess()
        {
            connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["LibraryDBConnectionString"].ConnectionString;
        }

        public bool RegisterUser(string userName, string password)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO Users (UserName, Password) VALUES (@UserName, @Password)";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@UserName", userName);
                    cmd.Parameters.AddWithValue("@Password", password);

                    try
                    {
                        con.Open();
                        int result = cmd.ExecuteNonQuery();
                        return result > 0;
                    }
                    catch (Exception ex)
                    {
                        throw new Exception("Error registering user", ex);
                    }
                }
            }
        }

        public DataTable SearchBooks(string searchTerm)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Books WHERE Title LIKE @Search OR Author LIKE @Search";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@Search", "%" + searchTerm + "%");

                    try
                    {
                        con.Open();
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            DataTable dt = new DataTable();
                            dt.Load(reader);
                            return dt;
                        }
                    }
                    catch (Exception ex)
                    {
                        throw new Exception("Error searching for books", ex);
                    }
                }
            }
        }

        public DataTable GetAvailableBooks()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Books WHERE Available = 1";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    try
                    {
                        con.Open();
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            DataTable dt = new DataTable();
                            dt.Load(reader);
                            return dt;
                        }
                    }
                    catch (Exception ex)
                    {
                        throw new Exception("Error fetching available books", ex);
                    }
                }
            }
        }

        public bool AddBook(string title, string author)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO Books (Title, Author, Available) VALUES (@Title, @Author, 1)";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@Title", title);
                    cmd.Parameters.AddWithValue("@Author", author);

                    try
                    {
                        con.Open();
                        int result = cmd.ExecuteNonQuery();
                        return result > 0;
                    }
                    catch (Exception ex)
                    {
                        throw new Exception("Error adding book", ex);
                    }
                }
            }
        }
    }
}
