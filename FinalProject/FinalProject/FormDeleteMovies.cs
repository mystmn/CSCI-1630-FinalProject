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
            
            conn.findingTitle(textBoxMovieTitle.Text);
            List<Movie> x = conn.FoundTitle;

            textBoxDirector.Text = string.Join(" ", x[0]);
        }
    }
}
