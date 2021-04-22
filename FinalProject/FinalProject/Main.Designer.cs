
namespace FinalProject
{
    partial class Main
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.maintanceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addMovieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateMovieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteMovieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridViewMaster = new System.Windows.Forms.DataGridView();
            this.colMovieTitles = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMovieYear = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMovieGenre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMovieRotten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMovieBoxOffice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelMasterList = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMaster)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.maintanceToolStripMenuItem,
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(845, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // maintanceToolStripMenuItem
            // 
            this.maintanceToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addMovieToolStripMenuItem,
            this.updateMovieToolStripMenuItem,
            this.deleteMovieToolStripMenuItem});
            this.maintanceToolStripMenuItem.Name = "maintanceToolStripMenuItem";
            this.maintanceToolStripMenuItem.Size = new System.Drawing.Size(88, 20);
            this.maintanceToolStripMenuItem.Text = "Maintenance";
            // 
            // addMovieToolStripMenuItem
            // 
            this.addMovieToolStripMenuItem.Name = "addMovieToolStripMenuItem";
            this.addMovieToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.addMovieToolStripMenuItem.Text = "Add Movie";
            this.addMovieToolStripMenuItem.Click += new System.EventHandler(this.addMovieToolStripMenuItem_Click);
            // 
            // updateMovieToolStripMenuItem
            // 
            this.updateMovieToolStripMenuItem.Name = "updateMovieToolStripMenuItem";
            this.updateMovieToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.updateMovieToolStripMenuItem.Text = "Update Movie";
            this.updateMovieToolStripMenuItem.Click += new System.EventHandler(this.updateMovieToolStripMenuItem_Click);
            // 
            // deleteMovieToolStripMenuItem
            // 
            this.deleteMovieToolStripMenuItem.Name = "deleteMovieToolStripMenuItem";
            this.deleteMovieToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.deleteMovieToolStripMenuItem.Text = "Delete Movie";
            this.deleteMovieToolStripMenuItem.Click += new System.EventHandler(this.deleteMovieToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(52, 20);
            this.toolStripMenuItem1.Text = "About";
            // 
            // dataGridViewMaster
            // 
            this.dataGridViewMaster.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridViewMaster.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMaster.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMovieTitles,
            this.colMovieYear,
            this.colMovieGenre,
            this.colMovieRotten,
            this.colMovieBoxOffice});
            this.dataGridViewMaster.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridViewMaster.Location = new System.Drawing.Point(0, 64);
            this.dataGridViewMaster.Name = "dataGridViewMaster";
            this.dataGridViewMaster.Size = new System.Drawing.Size(845, 297);
            this.dataGridViewMaster.TabIndex = 1;
            // 
            // colMovieTitles
            // 
            this.colMovieTitles.HeaderText = "Movie Title";
            this.colMovieTitles.MinimumWidth = 25;
            this.colMovieTitles.Name = "colMovieTitles";
            this.colMovieTitles.ReadOnly = true;
            this.colMovieTitles.Width = 250;
            // 
            // colMovieYear
            // 
            this.colMovieYear.HeaderText = "Year";
            this.colMovieYear.Name = "colMovieYear";
            this.colMovieYear.ReadOnly = true;
            // 
            // colMovieGenre
            // 
            this.colMovieGenre.HeaderText = "Genre";
            this.colMovieGenre.Name = "colMovieGenre";
            this.colMovieGenre.ReadOnly = true;
            // 
            // colMovieRotten
            // 
            this.colMovieRotten.HeaderText = "Rotten Tomatoes Score";
            this.colMovieRotten.Name = "colMovieRotten";
            this.colMovieRotten.ReadOnly = true;
            // 
            // colMovieBoxOffice
            // 
            this.colMovieBoxOffice.HeaderText = "Total Box Office";
            this.colMovieBoxOffice.Name = "colMovieBoxOffice";
            this.colMovieBoxOffice.ReadOnly = true;
            this.colMovieBoxOffice.Width = 150;
            // 
            // labelMasterList
            // 
            this.labelMasterList.AutoSize = true;
            this.labelMasterList.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.75F, System.Drawing.FontStyle.Bold);
            this.labelMasterList.Location = new System.Drawing.Point(12, 37);
            this.labelMasterList.Name = "labelMasterList";
            this.labelMasterList.Size = new System.Drawing.Size(181, 24);
            this.labelMasterList.TabIndex = 2;
            this.labelMasterList.Text = "Movies Master List";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(845, 450);
            this.Controls.Add(this.labelMasterList);
            this.Controls.Add(this.dataGridViewMaster);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main";
            this.Text = "MovieManager";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMaster)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem maintanceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem addMovieToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateMovieToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteMovieToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridViewMaster;
        private System.Windows.Forms.Label labelMasterList;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMovieTitles;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMovieYear;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMovieGenre;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMovieRotten;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMovieBoxOffice;
    }
}

