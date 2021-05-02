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

            showMainGrid();
        }

        private void showMainGrid()
        {
            // Pull Objects
            db_conn.selectData();

            // Grab the Grid from DB_conn.cs
            dataGridViewMaster.DataSource = db_conn.Setname;

            // Resize the master DataGridView columns to fit the newly loaded data.
            dataGridViewMaster.AutoResizeColumns();

            // Configure the details DataGridView so that its columns automatically
            // adjust their widths when the data changes.
            dataGridViewMaster.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.AllCells;
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

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            db_conn.selectData();
            dataGridViewMaster.DataSource = db_conn.Setname;
            dataGridViewMaster.Refresh();

        }

        /*
         * Information about our app and team goes here.
         */
        private void toolStripMenuAbout(object sender, EventArgs e)
        {
            MessageBox.Show("We still need content here.");
        }
    }
}
