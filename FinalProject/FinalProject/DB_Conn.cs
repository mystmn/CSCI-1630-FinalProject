using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

// Added MYSQL
//using MySql.Data.MySqlClient;
using System.Data.SqlClient;


namespace FinalProject
{
    class DB_Conn
    {
 
        /*
         * Make a connection to DB
         */ 
        private static string MakeDBConnection()
        {
            string server = "coursemaster1.csbchotp6tva.us-east-2.rds.amazonaws.com";
            string database = "CSCI1630";
            string username = "rw1630";
            string password = "Project!";
            string port = "1433";

            return $"Data Source ={server},{port};Initial Catalog={database};User ID={username};Password={password};";
        }


        /*
         * Select ALL from Movies for the Main.cs grid
         */
        private DataTable _getName; //field
        public DataTable Setname { get => this._getName; set { this._getName = value; } } //property

        public void selectData()
        {
            string sqlCommand = "SELECT * FROM Movies";
            string[] genres = { "Animation", "Action", "Comedy", "Drama", "Horror", "Mystery", "Romance", "Science Fiction", "Western" };

            // Make the connection with the Server
            using (SqlConnection connection = new SqlConnection(MakeDBConnection()))
            {                                        
                connection.Open();
                using (SqlCommand command = new SqlCommand(sqlCommand, connection))
                {                   
                    // Create a DataSet.
                    DataTable dt = new DataTable();
                    dt.Columns.Add(new DataColumn("ID"));
                    dt.Columns.Add(new DataColumn("Movie Title"));
                    dt.Columns.Add(new DataColumn("Year"));
                    dt.Columns.Add(new DataColumn("Director"));
                    dt.Columns.Add(new DataColumn("Genres"));
                    dt.Columns.Add(new DataColumn("RottenTomatoesScore"));
                    dt.Columns.Add(new DataColumn("BoxOffice"));

                    SqlDataReader reader = command.ExecuteReader();
                    try
                    {

                        while (reader.Read())
                        {
                            dt.Rows.Add(
                                reader.GetValue(0), 
                                reader.GetValue(1),
                                reader.GetValue(2),
                                reader.GetValue(3),
                                reader.GetValue(4),
                                reader.GetValue(5),
                                reader.GetValue(6)
                            );
                            this.Setname = dt;
                        }
                    }
                    finally
                    {
                        connection.Close();
                    } 
                }
            } 
        }

        /*
         * Insert input into Database using the constructor
         */
        public void insertData(string title, int year, string director, int genre, int scrore, decimal boxOffice)
        {
            string conn = MakeDBConnection();
            string sqlCommand = "INSERT INTO Movies (Title, Year, Director, Genre, RottenTomatoesScore, TotalEarned )" +
                "VALUES (@param1,@param2,@param3,@param4,@param5,@param6)";

            // Make the connection with the Server
            using (SqlConnection connection = new SqlConnection(MakeDBConnection()))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(sqlCommand, connection))
                {
                        command.Parameters.Add("@param1", SqlDbType.VarChar, 50).Value = title;
                        command.Parameters.Add("@param2", SqlDbType.Int).Value = year;
                        command.Parameters.Add("@param3", SqlDbType.VarChar, 50).Value = director;
                        command.Parameters.Add("@param4", SqlDbType.Int).Value = genre;
                        command.Parameters.Add("@param5", SqlDbType.Int).Value = scrore;
                        command.Parameters.Add("@param6", SqlDbType.Decimal).Value = boxOffice;
                        command.CommandType = CommandType.Text;
                    try
                    {
                        command.ExecuteNonQuery();

                    }
                    finally
                    {
                        connection.Close();
                    }
                }
            }
        }
        public string updateData(int id, string title, int year, string director, int genre, int score, decimal boxOffice)
        {
            string conn = MakeDBConnection();
            string sqlCommand =
                "Update Movies " +
                "SET Title=@param2, Year=@param3, Director=@param4, Genre=@param5, RottenTomatoesScore=@param6, TotalEarned=@param7 " +
                "Where Id=@param8";

            // Make the connection with the Server
            using (SqlConnection connection = new SqlConnection(MakeDBConnection()))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(sqlCommand, connection))
                {
                    command.Parameters.Add("@param2", SqlDbType.VarChar, 50).Value = title;
                    command.Parameters.Add("@param3", SqlDbType.Int).Value = year;
                    command.Parameters.Add("@param4", SqlDbType.VarChar, 50).Value = director;
                    command.Parameters.Add("@param5", SqlDbType.Int).Value = genre;
                    command.Parameters.Add("@param6", SqlDbType.Int).Value = score;
                    command.Parameters.Add("@param7", SqlDbType.Decimal).Value = boxOffice;
                    command.Parameters.Add("@param8", SqlDbType.Int).Value = id;
                    command.CommandType = CommandType.Text;

                    try
                    {
                        command.ExecuteNonQuery();
                    }
                    catch (SystemException ex)
                    {
                        return ex.Message;
                    }
                    finally
                    {
                        connection.Close();
                    }
                    return "successful";
                }
            }
        }
        public string DeleteData(int itemID)
        {
            string conn = MakeDBConnection();

            string sqlCommand = string.Format("DELETE FROM Movies WHERE Id='{0}'",itemID);

            // Make the connection with the Server
            using (SqlConnection connection = new SqlConnection(MakeDBConnection()))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(sqlCommand, connection))
                {
                    try
                    {
                        command.ExecuteNonQuery();
                    }
                    catch(SystemException ex)
                    {
                        return ex.Message;
                    }
                    finally
                    {
                        connection.Close();
                    }
                    return "successful";
                }
            }
        }


        /*
         * Using the find botton => all the values 
         */
        private List<Movie> _FoundTitle;
        public List<Movie> FoundTitle { get => this._FoundTitle; set { this._FoundTitle = value; } }
        
        public void findingTitle(string searchTitle)
        {
            //string sqlCommand = String.Format("SELECT Title, Year, Director, Genre, RottenTomatoesScore, TotalEarned FROM Movies WHERE Title LIKE '%{0}%' ", searchTitle);
            string sqlCommand = String.Format("SELECT * FROM Movies WHERE Title LIKE '%{0}%' ", searchTitle);

            // Make the connection with the Server
            using (SqlConnection connection = new SqlConnection(MakeDBConnection()))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(sqlCommand, connection))
                {
                    // Create a DataSet.
                    Movie movies = new Movie();
                    List<Movie> storeMovies = new List<Movie>();

                    SqlDataReader reader = command.ExecuteReader();
                    try
                    {
                        while (reader.Read())
                        {
                           // Pulling data from the DB. If null return values zero or " ";

                            movies.ID = reader.GetValue(0) != DBNull.Value ? reader.GetInt32(0) : -1;
                            movies.Title = reader.GetValue(1) != DBNull.Value ? reader.GetString(1) : null;
                            movies.Year = reader.GetValue(2) != DBNull.Value ? reader.GetInt32(2) : 0;
                            movies.Director = reader.GetValue(3) != DBNull.Value ? reader.GetString(3) : " ";
                            movies.Genre = reader.GetValue(4) != DBNull.Value ? reader.GetInt32(4) : -1;
                            movies.RottenTomatoesScore = reader.GetValue(5) != DBNull.Value  ? reader.GetInt32(5) : 0;
                            movies.BoxOffice = reader.GetValue(6) != DBNull.Value ? reader.GetDecimal(6) : 0.0m;

                            /*
                            movies.Genre = reader.GetString(3) != null ? reader.GetString(3) : "Null";
                            */
                            storeMovies.Add(movies);
                            this.FoundTitle = storeMovies;
                        }
                    }
                    finally
                    {
                        connection.Close();
                    }
                }
            }
        }

        public void old_code()
        {

            /*
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
                                movie.TotalEarned = reader.GetDecimal(5);

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
    }
        
}
