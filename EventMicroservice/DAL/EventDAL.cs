using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using System.IO;
using System.Data.SqlClient;
using EventMicroservice.Models;


namespace EventMicroservice.DAL
{
    public class EventDAL
    {
        //    private IConfiguration Configuration { get; }
        //    private SqlConnection conn;
        //    //Constructor
        //    public EventDAL()
        //    {
        //        //Read ConnectionString from appsettings.json file
        //        var builder = new ConfigurationBuilder()
        //        .SetBasePath(Directory.GetCurrentDirectory())
        //        .AddJsonFile("appsettings.json");
        //        Configuration = builder.Build();
        //        string strConn = Configuration.GetConnectionString(
        //        "NPBookConnectionString");
        //        //Instantiate a SqlConnection object with the
        //        //Connection String read.
        //        conn = new SqlConnection(strConn);
        //    }
        //    public List<BookEvent> GetAllEvents()
        //    {
        //        //Create a SqlCommand object from connection object
        //        SqlCommand cmd = conn.CreateCommand();
        //        //Specify the SQL statement that select all branches
        //        cmd.CommandText = @"SELECT * FROM BookEvent";
        //        //Open a database connection
        //        conn.Open();
        //        //Execute SELCT SQL through a DataReader
        //        SqlDataReader reader = cmd.ExecuteReader();
        //        //Read all records until the end, save data into a branch list
        //        List<BookEvent> eventList = new List<BookEvent>();
        //        while (reader.Read())
        //        {
        //            eventList.Add(
        //            new BookEvent
        //            {
        //                EventID = reader.GetInt32(0), // 0 - 1st column
        //                EventName = reader.GetString(1), // 1 - 2nd column
        //                EventStartDate = reader.GetString(2),
        //                EventEndDate = reader.GetString(3),
        //                EventDescription = reader.GetString(4)

        //            }
        //            );
        //        }
        //        //Close DataReader
        //        reader.Close();
        //        conn.Close();
        //        //Close the database connection

        //        return eventList;
        //    }
        //    public BookEvent GetDetails(int id)
        //    {
        //            BookEvent e = new BookEvent();
        //        //Create a SqlCommand object from connection object
        //        SqlCommand cmd = conn.CreateCommand();
        //        //Specify the SELECT SQL statement that 
        //        //retrieves all attributes of a staff record.
        //        cmd.CommandText = @"SELECT * FROM BookEvent WHERE EventID = @selectedID";
        //            //Define the parameter used in SQL statement, value for the
        //            //parameter is retrieved from the method parameter “staffId”.
        //            cmd.Parameters.AddWithValue("@selectedID", id);
        //            //Open a database connection
        //            //Open a database connection
        //            conn.Open();
        //            //Execute SELCT SQL through a DataReader
        //            SqlDataReader reader = cmd.ExecuteReader();
        //            if (reader.HasRows)
        //            {
        //                //Read the record from database
        //                while (reader.Read())
        //                {
        //                    // Fill staff object with values from the data reader 
        //                    e.EventID = id;
        //                    e.EventName = !reader.IsDBNull(1) ? reader.GetString(1) : null;
        //                    // (char) 0 - ASCII Code 0 - null value
        //                    e.EventStartDate = !reader.IsDBNull(2) ? reader.GetString(2) : null;
        //                    e.EventEndDate = !reader.IsDBNull(3) ? reader.GetString(3) : null;
        //                    e.EventDescription = !reader.IsDBNull(4) ? reader.GetString(4) : null;

        //                }
        //}
        ////Close data reader
        //reader.Close();
        //conn.Close();
        ////Close database connection

        //return e;
        //}
        private IConfiguration Configuration { get; }
        private SqlConnection conn;
        //Constructor
        public EventDAL()
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
        public List<BookEvent> GetAllEvents()
        {
            //Create a SqlCommand object from connection object
            SqlCommand cmd = conn.CreateCommand();
            //Specify the SQL statement that select all branches
            cmd.CommandText = @"SELECT * FROM myEvents";
            //Open a database connection
            conn.Open();
            //Execute SELCT SQL through a DataReader
            SqlDataReader reader = cmd.ExecuteReader();
            //Read all records until the end, save data into a branch list
            List<BookEvent> eList = new List<BookEvent>();
            while (reader.Read())
            {
                eList.Add(
                new BookEvent
                {
                   EventID = reader.GetInt32(0), // 0 - 1st column
                       EventName = reader.GetString(1), // 1 - 2nd column
                      StartDate = reader.GetDateTime(4),
                        EndDate = reader.GetDateTime(5),
                       EventDescription = reader.GetString(2)
                }
                );
            }
            //Close DataReader
            reader.Close();
            conn.Close();
            //Close the database connection

            return eList;
        }
        public BookEvent GetDetails(int id)
        {
            BookEvent e = new BookEvent();
            //Create a SqlCommand object from connection object
            SqlCommand cmd = conn.CreateCommand();
            //Specify the SELECT SQL statement that 
            //retrieves all attributes of a staff record.
            cmd.CommandText = @"SELECT * FROM myEvents WHERE EventID = @selectedId";
            //Define the parameter used in SQL statement, value for the
            //parameter is retrieved from the method parameter “staffId”.
            cmd.Parameters.AddWithValue("@selectedId", id);
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
                    e.EventID = id;
                    e.EventName = !reader.IsDBNull(1) ? reader.GetString(1) : null;
                    // (char) 0 - ASCII Code 0 - null value
                    e.StartDate =  reader.GetDateTime(4);
                    e.EndDate = reader.GetDateTime(5);
                    e.EventDescription = !reader.IsDBNull(2) ? reader.GetString(2) : null;
                }
            }
            //Close data reader
            reader.Close();
            conn.Close();
            //Close database connection

            return e;
        }
    }
    
}
