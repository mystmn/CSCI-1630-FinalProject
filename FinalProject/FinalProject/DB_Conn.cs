using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Added MYSQL
//using MySql.Data.MySqlClient;
using System.Data.SqlClient;


namespace FinalProject
{
    class DB_Conn
    {
        /*
        private void Main_Load(object sender, EventArgs e)
        { 
            //set up connection string
            string connectionString = MakeDBConnection();
            
            //get a list of movies set up from the Movie Class
            List<Movie> movies = new List<Movie>();
            
            //SQL statement and Genre ID array
            string sqlCommand = "SELECT Id, Title, Year, Director, Genre, RottenTomatoesScore, TotalEarned FROM Movies ORDER BY Title";
            string[] genres = { "Animation", "Action", "Comedy", "Drama", "Horror", "Mystery", "Romance", "Science Fiction", "Western" };


            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand command = new SqlCommand(sqlCommand, connection))
                    {

                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {

                            while (reader.read())
                            {
                                var movie = new Movie();
                                movie.Title = reader.GetString(0);
                                movie.Year = reader.GetString(1);
                                movie.Director = reader.GetString(2);
                                movie.RottenTomatoesScore = reader.GetString(4);
                                movie.TotalEarned = reader.GetString(5);

                                int genreNumber = reader.GetInt32(3);
                                movie.Genre = genres[genreNumber];

                                movies.Add(movie);
                            }
                        }
                        connection.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Database connection failed. Error {ex.Message}");
            }
        }*/
        private static string MakeDBConnection()
        {
            string server = "Data Source=coursemaster1.csbchotp6tva.us-east-2.rds.amazonaws.com";
            string database = "CSCI1630";
            string username = "rw1630";
            string password = "Project!";
            string port = "1433";

            return $"Data Source ={server},{port};Initial Catalog:{database};User ID={username};Password={password};";
        }

        public bool insert(List<Movie> item)
        { 

            string conn = MakeDBConnection();

            // was the data successful?
            return true;
        }
        public bool insertData(List<Movie> item)
        { 

            string conn = MakeDBConnection();

            // was the data successful?
            return true;
        }
        public bool updateData(List<Movie> item)
        { 

            string conn = MakeDBConnection();

            // was the data successful?
            return true;
        }
    }
        
}
