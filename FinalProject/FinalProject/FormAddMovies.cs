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

        /*
         * Add Form takes the input, sends the information to an SQL database
         */
        private void buttonAdd_Click(object sender, EventArgs e)
        {

            int year;
            decimal boxOffice;
            int rotten;

            // Verify the fields match their data type
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

            }else if (!decimal.TryParse(textBoxBoxOffice.Text, out boxOffice))
            {
                MessageBox.Show(errors.input(Messages.validation.BoxOffice));
            }
            else
            {
                /*
                 * Starting section that takes the input, adds it to a class, and submits to DB
                 */
                List<Movie> movies = new List<Movie>();

                var eachMovie = new Movie();

                    eachMovie.Title = textBoxMovieTitle.Text;
                    eachMovie.Year = year;
                    eachMovie.Director = textBoxDirector.Text;
                    eachMovie.Genre = textBoxGenre.Text;
                    eachMovie.RottenTomatoesScore = rotten;
                    eachMovie.BoxOffice = boxOffice;

                movies.Add(eachMovie);

                // Replace with the List<Movie> Genre function
                int genreInt = -1;
                if (String.Equals(eachMovie.Genre,"Animation"))
                {
                    genreInt = 0;
                }
                else if (String.Equals(eachMovie.Genre, "Action"))
                {
                    genreInt = 1;

                }
                else if (String.Equals(eachMovie.Genre, "Comedy"))
                {

                    genreInt = 2;
                }
                else if (String.Equals(eachMovie.Genre, "Drama"))
                {
                    genreInt = 3;

                }
                else if (String.Equals(eachMovie.Genre, "Horror"))
                {
                    genreInt = 4;

                }
                else if (String.Equals(eachMovie.Genre, "Mystery"))
                {
                    genreInt = 5;

                }
                else if (String.Equals(eachMovie.Genre, "Romance"))
                {
                    genreInt = 6;

                }
                else if (String.Equals(eachMovie.Genre, "Science Fiction"))
                {
                    genreInt = 7;

                }
                else if (String.Equals(eachMovie.Genre, "Western"))
                {
                    genreInt = 8;

                }
                else
                {
                    MessageBox.Show("Please Select a Genre");
                }

                /*
                 * Establish a connection with the DB and insert code.
                 */

                try
                {
                    DB_Conn db_conn = new DB_Conn();
                    db_conn.insertData(
                        textBoxMovieTitle.Text, year, textBoxDirector.Text, genreInt, rotten, boxOffice
                   );
                    MessageBox.Show($"{textBoxMovieTitle.Text} has been submitted.");
                    clearFields();
                }
                catch
                {
                    MessageBox.Show($"There was an issue submitting {textBoxMovieTitle.Text}");
                }
                finally
                {
                    Close();
                }
                
            }
            
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
        // Test Button that will need to be removed later
        private void buttonTest_Click(object sender, EventArgs e)
        {

        }

        /*
         * Button clears the input forms, to not confuse the next input fields with the submitted fields.
         */


        private void buttonClear_Click(object sender, EventArgs e)
        {
            clearFields();
        }


        /*
         * Closing the Add Form
         */
        private void buttonClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBoxGenre_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void FormAddMovies_Load(object sender, EventArgs e)
        {

        }
    }
}
