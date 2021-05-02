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
    public partial class FormDeleteMovies : Form
    {
        // Messages successful and failers
        Messages errors = new Messages();

        // Make DB connection
        DB_Conn conn = new DB_Conn();

        public FormDeleteMovies()
        {
            InitializeComponent();
        }

        /*
         * Find a movie from the DB
         */
        private void buttonFindMovie_Click(object sender, EventArgs e)
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
                    Movie topic = new Movie();

                    foreach (Movie x in conn.FoundTitle)
                    {
                        textBoxMovieTitle.Text = $"{x.Title}";
                        textBoxYear.Text = $"{x.Year}";
                        string validatedGenre = topic.genreList(x.Genre);
                        comboBoxGenre.Text = $"{validatedGenre}";

                        textBoxDirector.Text = $"{x.Director}";
                        textBoxRotten.Text = $"{x.RottenTomatoesScore}";
                        textBoxBoxOffice.Text = String.Format("{0:C}", x.BoxOffice);
                    }
                }
            }
        }
        /*
         * Closing formn
         */
        private void buttonClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        /*
         * Button clears the input forms, to not confuse the next input fields with the submitted fields.
         */
        private void clearFields()
        {
            //Clear the textboxes
            textBoxMovieTitle.Text = "";
            textBoxYear.Text = "";
            textBoxDirector.Text = "";
            textBoxBoxOffice.Text = "";
            textBoxRotten.Text = "";
            textBoxBoxOffice.Text = "";
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            clearFields();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            string title = textBoxMovieTitle.Text;

            // Validate there's something to delete in title
            if (string.IsNullOrEmpty(title))
            {
                MessageBox.Show(errors.input(Messages.validation.Title));
            }
            else
            {
                var itemTitle = conn.FoundTitle.Select(x => x.Title);
                var itemID = conn.FoundTitle.Select(x => x.ID);

                if (MessageBox.Show($"Would you like to delete {itemTitle.First()} from row {itemID.First()}?", "Delete Movie", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    string varID = conn.DeleteData(itemID.First());
                    string returnMessage = "";

                    if (varID == "successful")
                    {
                        returnMessage = $"Movie deletion was {varID}";
                    }
                    else
                    {
                        returnMessage = $"Movie deletion gave error: {varID}";
                    }
                    MessageBox.Show($"{returnMessage}");
                }
            }
        }
    }
}
