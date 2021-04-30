using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject
{
    public partial class FormUpdateMovie : Form
    {
        Messages errors = new Messages(); // Messages successful and failers
       
        DB_Conn conn = new DB_Conn(); // Make DB connection
        public FormUpdateMovie()
        {
            InitializeComponent();
        }

        private void button(object sender, EventArgs e)
        {
            string title = textBoxMovieTitle.Text;

            // Validate input
            if (string.IsNullOrEmpty(title))
            {
                MessageBox.Show(errors.input(Messages.validation.Title));
            }
            else
            {
                conn.findingTitle(title);

                if (conn.FoundTitle == null)
                {
                    MessageBox.Show(String.Format("No movie found with that title. Try again...{0}", title));
                }
                else
                {
                    foreach (Movie x in conn.FoundTitle)
                    {
                        textBoxMovieTitle.Text = $"{x.Title}";
                        textBoxYear.Text = $"{x.Year}";
                        textBoxDirector.Text = $"{x.Director}";
                        textBoxRotten.Text = $"{x.RottenTomatoesScore}";
                        textBoxBoxOffice.Text = String.Format("{0:C}", x.BoxOffice);
                        // Need to include Genre
                    }
                }
            }
        }
        private void establish_DB(List<Movie> movie)
        {
            /*
            * This is there the db code goes. Make sure that the connection methods are located under DB_Conn.cs
            */
            try
            {
                // Add movie to DB - This is filler code for now. 
                DB_Conn db_Conn = new DB_Conn(); // making connection to database

                //Did the database successfully INSERT the data; return a bool
                bool status = db_Conn.updateData(Movie);

                // Let the user know that the update worked or didn't work
                if (status)
                {
                   
                    errors.db_conn_status(Messages.dbVal.DB_Conn_succ);
                    MessageBox.Show($"{status}");
                    Close();
                }
                else
                {
                    MessageBox.Show(errors.db_conn_status(Messages.dbVal.DB_Conn_fail));
                    // Give the user a chance to make changes without loosing their current data
                }
                
            }
            catch (Exception system_error)
            {
                MessageBox.Show(system_error.Message);
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            clearFields();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            // Close button
            Close();
        }
        private void clearFields()
        {
            //Clear the textboxes
            textBoxMovieTitle.Text = "";
            textBoxYear.Text = "";
            textBoxDirector.Text = "";
            textBoxGenre.Text = "";
            textBoxRotten.Text = "";
            textBoxBoxOffice.Text = "";
        }
    }
}
