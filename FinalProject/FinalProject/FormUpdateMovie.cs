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
        // Pull the default error messages
        Messages errors = new Messages();

        public FormUpdateMovie()
        {
            InitializeComponent();
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            int year;
            int boxOffice;
            int rotten;

            // Add button to AddMoviesForm
            if (String.IsNullOrEmpty(textBoxMovieTitle.Text))
            {
                MessageBox.Show(errors.input(Messages.validation.Title));
            }
            else if (!int.TryParse(textBoxYear.Text, out year))
            {
                MessageBox.Show(errors.input(Messages.validation.Year));
            }
            else if (String.IsNullOrEmpty(textBoxDirector.Text))
            {
                MessageBox.Show(errors.input(Messages.validation.Director));
            }
            else if (String.IsNullOrEmpty(textBoxGenre.Text))
            {
                MessageBox.Show(errors.input(Messages.validation.Genre));
            }
            else if (!int.TryParse(textBoxRotten.Text, out rotten))
            {
                MessageBox.Show(errors.input(Messages.validation.Rotten));

            }
            else if (!int.TryParse(textBoxBoxOffice.Text, out boxOffice))
            {
                MessageBox.Show(errors.input(Messages.validation.BoxOffice));
            }
            else
            {
                // Need to search for a movie title
                bool wasMovieFound = true;
                if(wasMovieFound)
                {
                    // establish_DB(movie.add())
                }
                else
                {
                    //Look for the movie again
                }

                // Add the query finds to their fields

                // Make connection to database and update changes

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
                bool status = db_Conn.updateData(movie);

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
            //Clear the textboxes
            textBoxMovieTitle.Text = "";
            textBoxYear.Text = "";
            textBoxDirector.Text = "";
            textBoxGenre.Text = "";
            textBoxRotten.Text = "";
            textBoxBoxOffice.Text = "";
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            // Close button
            Close();
        }
    }
}
