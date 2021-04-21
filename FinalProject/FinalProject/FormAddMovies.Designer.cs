
namespace FinalProject
{
    partial class FormAddMovies
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelMovieTitle = new System.Windows.Forms.Label();
            this.textBoxMovieTitle = new System.Windows.Forms.TextBox();
            this.textBoxYear = new System.Windows.Forms.TextBox();
            this.labelYear = new System.Windows.Forms.Label();
            this.textBoxDirector = new System.Windows.Forms.TextBox();
            this.labelDirector = new System.Windows.Forms.Label();
            this.textBoxGenre = new System.Windows.Forms.TextBox();
            this.labelGenre = new System.Windows.Forms.Label();
            this.textBoxRotten = new System.Windows.Forms.TextBox();
            this.labelRottenTomato = new System.Windows.Forms.Label();
            this.textBoxBoxOffice = new System.Windows.Forms.TextBox();
            this.labelBoxOffice = new System.Windows.Forms.Label();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelMovieTitle
            // 
            this.labelMovieTitle.AutoSize = true;
            this.labelMovieTitle.Location = new System.Drawing.Point(106, 44);
            this.labelMovieTitle.Name = "labelMovieTitle";
            this.labelMovieTitle.Size = new System.Drawing.Size(62, 13);
            this.labelMovieTitle.TabIndex = 0;
            this.labelMovieTitle.Text = "Movie Title:";
            // 
            // textBoxMovieTitle
            // 
            this.textBoxMovieTitle.Location = new System.Drawing.Point(168, 41);
            this.textBoxMovieTitle.Name = "textBoxMovieTitle";
            this.textBoxMovieTitle.Size = new System.Drawing.Size(461, 20);
            this.textBoxMovieTitle.TabIndex = 1;
            // 
            // textBoxYear
            // 
            this.textBoxYear.Location = new System.Drawing.Point(168, 106);
            this.textBoxYear.Name = "textBoxYear";
            this.textBoxYear.Size = new System.Drawing.Size(100, 20);
            this.textBoxYear.TabIndex = 3;
            // 
            // labelYear
            // 
            this.labelYear.AutoSize = true;
            this.labelYear.Location = new System.Drawing.Point(130, 109);
            this.labelYear.Name = "labelYear";
            this.labelYear.Size = new System.Drawing.Size(32, 13);
            this.labelYear.TabIndex = 2;
            this.labelYear.Text = "Year:";
            // 
            // textBoxDirector
            // 
            this.textBoxDirector.Location = new System.Drawing.Point(168, 182);
            this.textBoxDirector.Name = "textBoxDirector";
            this.textBoxDirector.Size = new System.Drawing.Size(172, 20);
            this.textBoxDirector.TabIndex = 5;
            // 
            // labelDirector
            // 
            this.labelDirector.AutoSize = true;
            this.labelDirector.Location = new System.Drawing.Point(115, 182);
            this.labelDirector.Name = "labelDirector";
            this.labelDirector.Size = new System.Drawing.Size(47, 13);
            this.labelDirector.TabIndex = 4;
            this.labelDirector.Text = "Director:";
            // 
            // textBoxGenre
            // 
            this.textBoxGenre.Location = new System.Drawing.Point(168, 257);
            this.textBoxGenre.Name = "textBoxGenre";
            this.textBoxGenre.Size = new System.Drawing.Size(172, 20);
            this.textBoxGenre.TabIndex = 7;
            // 
            // labelGenre
            // 
            this.labelGenre.AutoSize = true;
            this.labelGenre.Location = new System.Drawing.Point(123, 260);
            this.labelGenre.Name = "labelGenre";
            this.labelGenre.Size = new System.Drawing.Size(39, 13);
            this.labelGenre.TabIndex = 6;
            this.labelGenre.Text = "Genre:";
            // 
            // textBoxRotten
            // 
            this.textBoxRotten.Location = new System.Drawing.Point(486, 106);
            this.textBoxRotten.Name = "textBoxRotten";
            this.textBoxRotten.Size = new System.Drawing.Size(143, 20);
            this.textBoxRotten.TabIndex = 9;
            // 
            // labelRottenTomato
            // 
            this.labelRottenTomato.AutoSize = true;
            this.labelRottenTomato.Location = new System.Drawing.Point(357, 109);
            this.labelRottenTomato.Name = "labelRottenTomato";
            this.labelRottenTomato.Size = new System.Drawing.Size(123, 13);
            this.labelRottenTomato.TabIndex = 8;
            this.labelRottenTomato.Text = "Rotten Tomatoes Score:";
            // 
            // textBoxBoxOffice
            // 
            this.textBoxBoxOffice.Location = new System.Drawing.Point(486, 182);
            this.textBoxBoxOffice.Name = "textBoxBoxOffice";
            this.textBoxBoxOffice.Size = new System.Drawing.Size(143, 20);
            this.textBoxBoxOffice.TabIndex = 11;
            // 
            // labelBoxOffice
            // 
            this.labelBoxOffice.AutoSize = true;
            this.labelBoxOffice.Location = new System.Drawing.Point(370, 182);
            this.labelBoxOffice.Name = "labelBoxOffice";
            this.labelBoxOffice.Size = new System.Drawing.Size(110, 13);
            this.labelBoxOffice.TabIndex = 10;
            this.labelBoxOffice.Text = "Box Office Exchange:";
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(93, 376);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd.TabIndex = 12;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(360, 376);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(75, 23);
            this.buttonClear.TabIndex = 13;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // buttonClose
            // 
            this.buttonClose.Location = new System.Drawing.Point(554, 376);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(75, 23);
            this.buttonClose.TabIndex = 14;
            this.buttonClose.Text = "Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Location = new System.Drawing.Point(12, 340);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(776, 98);
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // FormAddMovies
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.textBoxBoxOffice);
            this.Controls.Add(this.labelBoxOffice);
            this.Controls.Add(this.textBoxRotten);
            this.Controls.Add(this.labelRottenTomato);
            this.Controls.Add(this.textBoxGenre);
            this.Controls.Add(this.labelGenre);
            this.Controls.Add(this.textBoxDirector);
            this.Controls.Add(this.labelDirector);
            this.Controls.Add(this.textBoxYear);
            this.Controls.Add(this.labelYear);
            this.Controls.Add(this.textBoxMovieTitle);
            this.Controls.Add(this.labelMovieTitle);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FormAddMovies";
            this.Text = "Add Movies";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelMovieTitle;
        private System.Windows.Forms.TextBox textBoxMovieTitle;
        private System.Windows.Forms.TextBox textBoxYear;
        private System.Windows.Forms.Label labelYear;
        private System.Windows.Forms.TextBox textBoxDirector;
        private System.Windows.Forms.Label labelDirector;
        private System.Windows.Forms.TextBox textBoxGenre;
        private System.Windows.Forms.Label labelGenre;
        private System.Windows.Forms.TextBox textBoxRotten;
        private System.Windows.Forms.Label labelRottenTomato;
        private System.Windows.Forms.TextBox textBoxBoxOffice;
        private System.Windows.Forms.Label labelBoxOffice;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}