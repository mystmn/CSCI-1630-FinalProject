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
            clearFields();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {

            int year;
            decimal boxOffice;
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

            }else if (!decimal.TryParse(textBoxBoxOffice.Text, out boxOffice))
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

                int fakegenre = 0;

                try
                {
                    DB_Conn db_conn = new DB_Conn();
                    db_conn.insertData(
                        textBoxMovieTitle.Text, year, textBoxDirector.Text, fakegenre, rotten, boxOffice
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
    }
}
