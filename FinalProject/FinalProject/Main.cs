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
            DB_Conn db_conn = new DB_Conn();


            //Test connect = new Test();
            //connect.test_db();
            //MessageBox.Show("testing...{0}", string.Join(" ", connect.Pacman));

            //db_conn.selectData();
            //MessageBox.Show("vars - {0}", string.Join(" ", db_conn.Setname));

            List<string> eachMovie = new List<string>();

            // Testing the Main.CS grid
            DataTable table = new DataTable();


            /*
            foreach (DataRow row in dataGridViewMaster.Rows;
            {*/
                foreach(var x in db_conn.Setname)
                {
                    dataGridViewMaster.Rows.Add(x);
                }
            //eachMovie.Add(Convert.ToString(x));
            /*
            }
            MessageBox.Show("vars - {0}", string.Join(" ", eachMovie));
            */

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
