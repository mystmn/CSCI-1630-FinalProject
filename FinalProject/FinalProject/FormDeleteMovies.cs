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
        Messages errors = new Messages();

        public FormDeleteMovies()
        {
            InitializeComponent();
        }

        /*
         * Find a movie from the DB
         */
        private void buttonFindMovie_Click(object sender, EventArgs e)
        {
            // Validate input
            if (!string.IsNullOrEmpty(textBoxBoxOffice.Text))
            {
                errors.input(Messages.validation.Title);
            }
            else
            {            
                // Make DB connection
                DB_Conn conn = new DB_Conn();
                
                // Erase previous searches
                textBoxDirector.Text = "";

                // DB established, now SELECT title and year from DB
                conn.findingTitle(textBoxMovieTitle.Text);

                /*
                 * NEEDS DONE - All values needs to be placed in their inputs
                 */
                foreach (Movie x in conn.FoundTitle)
                {
                    textBoxYear.Text = $"{x.Year}";
                    textBoxDirector.Text = $"{x.Director}";
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
    }
}
