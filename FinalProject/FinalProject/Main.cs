using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace FinalProject
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void addMovieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Add Movies EventHandler
            FormAddMovies formAddMovies = new FormAddMovies();
            formAddMovies.Show();
        }

        private void updateMovieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Update Movies EventHandler

            FormUpdateMovie formUpdateMovies = new FormUpdateMovie();
            formUpdateMovies.Show();
        }

        private void deleteMovieToolStripMenuItem_Click(object sender, EventArgs e)
        {
           FormDeleteMovies formDeleteMovies = new FormDeleteMovies();
           formDeleteMovies.Show();
        }

        private void Main_Load(object sender, EventArgs e)
        { //set up connection string
            string connectionString = GetConnectionString1();
            //get a list of movies set up from the Movie Class
            List<Movie> movies = new List<Movie>();
            //SQL statement and Genre ID array
            string sqlCommand = "SELECT Id, Title, Year, Director, Genre, RottenTomatoesScore, TotalEarned FROM Movies ORDER BY Title";
            string[] genres = {"Animation", "Action", "Comedy", "Drama", "Horror","Mystery","Romance","Science Fiction","Western"};


            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand command = new SqlCommand(sqlCommand, connection)){   
                        
                        connection.Open();
                        using(SqlDataReader reader = command.ExecuteReader()){

                            while(reader.read()){
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
            }catch (Exception ex)
            {
                MessageBox.Show($"Database connection failed. Error {ex.Message}");
            }
        }

        private static string GetConnectionString1()
        {
            string server = "Data Source=coursemaster1.csbchotp6tva.us-east-2.rds.amazonaws.com";
            string database = "CSCI1630";
            string username = "rw1630";
            string password = "Project!";
            string port = "1433";

            return $"Data Source ={server},{port};Initial Catalog:{database};User ID={username};Password={password};";
        }
    }
}
