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
            // Delete Movies EventHandler

            FormDeleteMovies formDeleteMovies = new FormDeleteMovies();
           formDeleteMovies.Show();
        }
    }
}
