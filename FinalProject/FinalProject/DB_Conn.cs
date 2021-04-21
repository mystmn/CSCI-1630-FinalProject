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
        private void Main_Load()
        { 
            //set up connection string
            string connectionString = MakeDBConnection();
            
            //get a list of movies set up from the Movie Class
            List<Movie> movies = new List<Movie>();

            /*
            //SQL statement and Genre ID array
            string sqlCommand = "SELECT Id, Title, Year, Director, Genre, RottenTomatoesScore, TotalEarned FROM Movies ORDER BY Title";
            string[] genres = { "Animation", "Action", "Comedy", "Drama", "Horror", "Mystery", "Romance", "Science Fiction", "Western" };

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand command = new SqlCommand(sqlCommand, connection))
                    {
                        Console.WriteLine("Database is a go!");

                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {

                            while (reader.Read())
                            {
                                var movie = new Movie();
                                movie.Title = reader.GetString(0);
                                movie.Year = reader.GetInt32(1);
                                movie.Director = reader.GetString(2);
                                movie.RottenTomatoesScore = reader.GetInt32(4);
                                movie.BoxOffice = reader.GetInt32(5);

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
                Console.WriteLine($"Database connection failed. Error {ex.Message}");
            }
                        */

        }
        private static string MakeDBConnection()
        {
            string server = "coursemaster1.csbchotp6tva.us-east-2.rds.amazonaws.com";
            string database = "CSCI1630";
            string username = "rw1630";
            string password = "Project!";
            string port = "1433";

            return $"Data Source ={server},{port};Initial Catalog={database};User ID={username};Password={password};";
        }

        public List<Movie> pacman;
        private List<Movie> GetName; //field
        public List<Movie> Setname { get { return GetName; } set{ GetName = this.pacman; } } //property

        public void selectData()
        {
            string sqlCommand = "SELECT * FROM Movies";
            string[] genres = { "Animation", "Action", "Comedy", "Drama", "Horror", "Mystery", "Romance", "Science Fiction", "Western" };

            //get a list of movies set up from the Movie Class
            List<Movie> movies = new List<Movie>();
            var movie = new Movie();

            using (SqlConnection connection = new SqlConnection(MakeDBConnection()))
            {
                SqlCommand command = new SqlCommand(sqlCommand, connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                try
                {
                    while (reader.Read())
                    {
                        movie.Title = reader.GetFieldValue<string>(0);
                        movie.Year = reader.GetFieldValue<int>(1);
                        movie.Director = reader.GetFieldValue<string>(2);
                        movie.RottenTomatoesScore = reader.GetFieldValue<int>(4);
                        movie.BoxOffice = reader.GetFieldValue<int>(5);

                        int genreNumber = reader.GetFieldValue<int>(3);
                        movie.Genre = genres[genreNumber];

                        movies.Add(movie);

                        this.pacman = movies;
                    }

                }
                finally
                {
                    connection.Close();
                }
            } 
        }

        public void insertData()
        {
            string conn = MakeDBConnection();

            // was the data successful?
        }
        public bool updateData(List<Movie> item)
        { 

            string conn = MakeDBConnection();

            // was the data successful?
            return true;
        }
        public bool deleteData(List<Movie> item)
        { 

            string conn = MakeDBConnection();

            // was the data successful?
            return true;
        }
    }
        
}
