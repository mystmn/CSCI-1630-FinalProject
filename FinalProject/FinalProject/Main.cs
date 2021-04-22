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
        // Pull the default error messages
        Messages errors = new Messages();

        DB_Conn db_conn = new DB_Conn();

        public Main()
        {
            InitializeComponent();
            showResults();
        }

        public void showResults()
        {

            db_conn.selectData();
            List<string> passing = new List<string>();

            foreach(var x in db_conn.Setname)
            {
                passing.Add(x.Title);

            }
            MessageBox.Show($"secret message = {String.Join(" ", passing)}");


            //string p = String.Join(",", db_conn.Pacman);
            //MessageBox.Show($"secret message = {p}");

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
            // Delete Movies EventHandler

            FormDeleteMovies formDeleteMovies = new FormDeleteMovies();
           formDeleteMovies.Show();
        }
    }
}
