
namespace FinalProject
{
    partial class FormDeleteMovies
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxMovieTitle = new System.Windows.Forms.TextBox();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.textBoxYear = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxDirector = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxRotten = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxBoxOffice = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonFindMovie = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBoxGenre = new System.Windows.Forms.ComboBox();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(72, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Movie Title:";
            // 
            // textBoxMovieTitle
            // 
            this.textBoxMovieTitle.Location = new System.Drawing.Point(140, 36);
            this.textBoxMovieTitle.Name = "textBoxMovieTitle";
            this.textBoxMovieTitle.Size = new System.Drawing.Size(403, 20);
            this.textBoxMovieTitle.TabIndex = 1;
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(59, 392);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(75, 23);
            this.buttonDelete.TabIndex = 2;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            // 
            // textBoxYear
            // 
            this.textBoxYear.Location = new System.Drawing.Point(140, 98);
            this.textBoxYear.Name = "textBoxYear";
            this.textBoxYear.Size = new System.Drawing.Size(100, 20);
            this.textBoxYear.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(102, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Year:";
            // 
            // textBoxDirector
            // 
            this.textBoxDirector.Location = new System.Drawing.Point(140, 169);
            this.textBoxDirector.Name = "textBoxDirector";
            this.textBoxDirector.Size = new System.Drawing.Size(214, 20);
            this.textBoxDirector.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(87, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Director:";
            // 
            // textBoxRotten
            // 
            this.textBoxRotten.Location = new System.Drawing.Point(248, 286);
            this.textBoxRotten.Name = "textBoxRotten";
            this.textBoxRotten.Size = new System.Drawing.Size(134, 20);
            this.textBoxRotten.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(130, 289);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Rotten Tomato Score:";
            // 
            // textBoxBoxOffice
            // 
            this.textBoxBoxOffice.Location = new System.Drawing.Point(514, 286);
            this.textBoxBoxOffice.Name = "textBoxBoxOffice";
            this.textBoxBoxOffice.Size = new System.Drawing.Size(144, 20);
            this.textBoxBoxOffice.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(398, 289);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Box Office Exchange:";
            // 
            // buttonFindMovie
            // 
            this.buttonFindMovie.Location = new System.Drawing.Point(570, 34);
            this.buttonFindMovie.Name = "buttonFindMovie";
            this.buttonFindMovie.Size = new System.Drawing.Size(75, 23);
            this.buttonFindMovie.TabIndex = 11;
            this.buttonFindMovie.Text = "Find";
            this.buttonFindMovie.UseVisualStyleBackColor = true;
            this.buttonFindMovie.Click += new System.EventHandler(this.buttonFindMovie_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(95, 230);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Genre:";
            // 
            // comboBoxGenre
            // 
            this.comboBoxGenre.FormattingEnabled = true;
            this.comboBoxGenre.Items.AddRange(new object[] {
            "example 1",
            "example 2",
            "example 3",
            "example 4",
            "example 5",
            "example 6",
            "example 7",
            "example 8",
            "example 9"});
            this.comboBoxGenre.Location = new System.Drawing.Point(140, 227);
            this.comboBoxGenre.Name = "comboBoxGenre";
            this.comboBoxGenre.Size = new System.Drawing.Size(121, 21);
            this.comboBoxGenre.TabIndex = 13;
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(307, 392);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(75, 23);
            this.buttonClear.TabIndex = 14;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            // 
            // buttonClose
            // 
            this.buttonClose.Location = new System.Drawing.Point(573, 392);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(75, 23);
            this.buttonClose.TabIndex = 15;
            this.buttonClose.Text = "Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Location = new System.Drawing.Point(12, 340);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(776, 98);
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // FormDeleteMovies
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.comboBoxGenre);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.buttonFindMovie);
            this.Controls.Add(this.textBoxBoxOffice);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxRotten);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxDirector);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxYear);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.textBoxMovieTitle);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FormDeleteMovies";
            this.Text = "Delete Movie";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxMovieTitle;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.TextBox textBoxYear;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxDirector;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxRotten;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxBoxOffice;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonFindMovie;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBoxGenre;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}