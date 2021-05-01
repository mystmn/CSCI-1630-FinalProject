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

        private void clearFields()
        {
            //Clear the textboxes
            textBoxTitle.Text = "";
            textBoxYear.Text = "";
            textBoxDirector.Text = "";
            textBoxGenre.Text = "";
            textBoxRotten.Text = "";
            textBoxBoxOffice.Text = "";
        }

        private void buttonFindMovie_Click(object sender, EventArgs e)
        {
            string title = textBoxTitle.Text;

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
                        textBoxTitle.Text = $"{x.Title}";
                        textBoxYear.Text = $"{x.Year}";
                        textBoxDirector.Text = $"{x.Director}";
                        textBoxRotten.Text = $"{x.RottenTomatoesScore}";
                        textBoxBoxOffice.Text = String.Format("{0:C}", x.BoxOffice);
                        // Need to include Genre
                    }
                }
            }
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            string title = textBoxTitle.Text;

            // Validate there's something to delete in title
            if (string.IsNullOrEmpty(title))
            {
                MessageBox.Show(errors.input(Messages.validation.Title));
            }
            else
            {
                int itemID = conn.FoundTitle.Select(x => x.ID).First();
                var itemTitle = textBoxTitle.Text;
                int itemYear = Convert.ToInt32(textBoxYear.Text);
                string itemDirector = textBoxDirector.Text;
                int itemGenre = Convert.ToInt32(textBoxGenre.Text);
                int itemScore = Convert.ToInt32(textBoxRotten.Text);
                decimal itemBoxoffice = Convert.ToDecimal(textBoxBoxOffice.Text.Replace("$", string.Empty ));


                string varID = conn.updateData(itemID, itemTitle, itemYear, itemDirector, itemGenre, itemScore, itemBoxoffice);
                string returnMessage = "";

                if (varID == "successful")
                {
                    returnMessage = $"Movie update was {varID}";
                }
                else
                {
                    returnMessage = $"Movie update gave error: {varID}";
                }
                MessageBox.Show($"{returnMessage}");
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

        private void buttonFindMovie_Click_1(object sender, EventArgs e)
        {
                        string title = textBoxTitle.Text;

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
                        textBoxTitle.Text = $"{x.Title}";
                        textBoxYear.Text = $"{x.Year}";
                        textBoxDirector.Text = $"{x.Director}";
                        textBoxRotten.Text = $"{x.RottenTomatoesScore}";
                        textBoxBoxOffice.Text = String.Format("{0:C}", x.BoxOffice);
                        // Need to include Genre
                    }
                }
            }
        }
    }
}
