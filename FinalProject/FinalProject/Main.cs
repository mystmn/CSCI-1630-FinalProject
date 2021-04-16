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

            //FormUpdateMovies formUpdateMovies = new FormUpdateMovies();
            //formUpdateMovies.Show();
        }

        private void deleteMovieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //FormDeleteMovies formDeleteMovies = new FormDeleteMovies();
           // formDeleteMovies.Show();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            string connectionString = GetConnectionString1();
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    MessageBox.Show("Connected To Database");
                    connection.Close();
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
