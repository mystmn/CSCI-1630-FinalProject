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
    public partial class FormAddMovies : Form 
    {
        
        // Pull the default error messages
        Messages errors = new Messages();

        public FormAddMovies()
        {
            InitializeComponent();
        }
        // Test Button that will need to be removed later
        private void buttonTest_Click(object sender, EventArgs e)
        {

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
            Close();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {

            int year;
            int boxOffice;
            int rotten;

            // Add button to AddMoviesForm
            if (String.IsNullOrEmpty(textBoxMovieTitle.Text))
            {
                MessageBox.Show(errors.input(Messages.validation.Title));
            }else if(!int.TryParse(textBoxYear.Text, out year))
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

            }else if (!int.TryParse(textBoxBoxOffice.Text, out boxOffice))
            {
                MessageBox.Show(errors.input(Messages.validation.BoxOffice));
            }
            else
            {
                List<Movie> movies = new List<Movie>();

                var eachMovie = new Movie();

                eachMovie.Title = textBoxMovieTitle.Text;
                eachMovie.Year = year;
                eachMovie.Director = textBoxDirector.Text;
                eachMovie.Genre = textBoxGenre.Text;
                eachMovie.RottenTomatoesScore = rotten;
                eachMovie.BoxOffice = boxOffice;

                movies.Add(eachMovie);

                establish_DB(movies);
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
                //string status = db_Conn.insertData() ? errors.db_conn_status(Messages.dbVal.DB_Conn_succ) : errors.db_conn_status(Messages.dbVal.DB_Conn_fail);
                string status = "";
                // update the user
                MessageBox.Show(status);
                Close();
            }
            catch (Exception system_error)
                {
                MessageBox.Show(system_error.Message);
            }
        }
    }
}
