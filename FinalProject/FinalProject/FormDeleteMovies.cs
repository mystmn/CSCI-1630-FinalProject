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

        private void buttonFindMovie_Click(object sender, EventArgs e)
        {
            DB_Conn conn = new DB_Conn();

            if (!string.IsNullOrEmpty(textBoxBoxOffice.Text))
            {
                errors.input(Messages.validation.Title);
            }
            else
            {
                textBoxDirector.Text = "";

                conn.findingTitle(textBoxMovieTitle.Text);

                foreach (Movie x in conn.FoundTitle)
                {
                    textBoxYear.Text = $"{x.Year}";
                    textBoxDirector.Text = $"{x.Director}";
                }
            }

        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Close();
        }
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
