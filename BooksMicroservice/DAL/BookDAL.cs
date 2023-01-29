using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using System.IO;
using System.Data.SqlClient;
using BrowseBook.Models;


namespace BrowseBook.DAL
{
    public class BookDAL
    {
        private IConfiguration Configuration { get; }
        private SqlConnection conn;
        //Constructor
        public BookDAL()
        {
            //Read ConnectionString from appsettings.json file
            var builder = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json");
            Configuration = builder.Build();
            string strConn = Configuration.GetConnectionString(
            "NPBookConnectionString");
            //Instantiate a SqlConnection object with the
            //Connection String read.
            conn = new SqlConnection(strConn);
        }
        public List<Book> GetAllBooks()
        {
            //Create a SqlCommand object from connection object
            SqlCommand cmd = conn.CreateCommand();
            //Specify the SQL statement that select all branches
            cmd.CommandText = @"SELECT * FROM Book";
            //Open a database connection
            conn.Open();
            //Execute SELCT SQL through a DataReader
            SqlDataReader reader = cmd.ExecuteReader();
            //Read all records until the end, save data into a branch list
            List<Book> bookList = new List<Book>();
            while (reader.Read())
            {
                bookList.Add(
                new Book
                {
                    Isbn = reader.GetInt32(0), // 0 - 1st column
                    Name = reader.GetString(1), // 1 - 2nd column
                    Category = reader.GetString(2),
                    Author = reader.GetString(3),
                    Description = reader.GetString(4),
                    IsAvail = reader.GetString(5),// 2 - 3rd column
                }
                );
            }
            //Close DataReader
            reader.Close();
            conn.Close();
            //Close the database connection

            return bookList;
        }
        public Book GetDetails(int isbn)
        {
            Book book = new Book();
            //Create a SqlCommand object from connection object
            SqlCommand cmd = conn.CreateCommand();
            //Specify the SELECT SQL statement that 
            //retrieves all attributes of a staff record.
            cmd.CommandText = @"SELECT * FROM Book WHERE ISBN = @selectedIsbn";
            //Define the parameter used in SQL statement, value for the
            //parameter is retrieved from the method parameter “staffId”.
            cmd.Parameters.AddWithValue("@selectedIsbn", isbn);
            //Open a database connection
            //Open a database connection
            conn.Open();
            //Execute SELCT SQL through a DataReader
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                //Read the record from database
                while (reader.Read())
                {
                    // Fill staff object with values from the data reader 
                    book.Isbn = isbn;
                    book.Name = !reader.IsDBNull(1) ? reader.GetString(1) : null;
                    // (char) 0 - ASCII Code 0 - null value
                    book.Category = !reader.IsDBNull(2) ? reader.GetString(2) : null;
                    book.Author = !reader.IsDBNull(3) ? reader.GetString(3) : null;
                    book.Description = !reader.IsDBNull(4) ? reader.GetString(4) : null;
                    book.IsAvail = !reader.IsDBNull(5) ? reader.GetString(5) : null;
                }
            }
            //Close data reader
            reader.Close();
            conn.Close();
            //Close database connection

            return book;
        }
    }
}
