﻿namespace CIS_560_Proj
{
    partial class Add
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.uxTextBoxMovieTitle = new System.Windows.Forms.TextBox();
            this.uxLabelMovieTitle = new System.Windows.Forms.Label();
            this.uxLabelReleaseDate = new System.Windows.Forms.Label();
            this.uxButtonInsertMovie = new System.Windows.Forms.Button();
            this.uxLabelTitle = new System.Windows.Forms.Label();
            this.Persontext = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.listBoxOptoins = new System.Windows.Forms.ListBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.uxUpdateMovie = new System.Windows.Forms.Button();
            this.uxDeleteMovie = new System.Windows.Forms.Button();
            this.uxViewMovies = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.uxProductionName = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // uxTextBoxMovieTitle
            // 
            this.uxTextBoxMovieTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.uxTextBoxMovieTitle.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.uxTextBoxMovieTitle.Location = new System.Drawing.Point(241, 132);
            this.uxTextBoxMovieTitle.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uxTextBoxMovieTitle.Multiline = true;
            this.uxTextBoxMovieTitle.Name = "uxTextBoxMovieTitle";
            this.uxTextBoxMovieTitle.Size = new System.Drawing.Size(402, 52);
            this.uxTextBoxMovieTitle.TabIndex = 2;
            // 
            // uxLabelMovieTitle
            // 
            this.uxLabelMovieTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.uxLabelMovieTitle.AutoSize = true;
            this.uxLabelMovieTitle.BackColor = System.Drawing.Color.White;
            this.uxLabelMovieTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.uxLabelMovieTitle.ForeColor = System.Drawing.Color.Black;
            this.uxLabelMovieTitle.Location = new System.Drawing.Point(35, 139);
            this.uxLabelMovieTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.uxLabelMovieTitle.Name = "uxLabelMovieTitle";
            this.uxLabelMovieTitle.Size = new System.Drawing.Size(198, 45);
            this.uxLabelMovieTitle.TabIndex = 3;
            this.uxLabelMovieTitle.Text = "Movie Title:";
            // 
            // uxLabelReleaseDate
            // 
            this.uxLabelReleaseDate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.uxLabelReleaseDate.AutoSize = true;
            this.uxLabelReleaseDate.BackColor = System.Drawing.Color.White;
            this.uxLabelReleaseDate.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.uxLabelReleaseDate.ForeColor = System.Drawing.Color.Black;
            this.uxLabelReleaseDate.Location = new System.Drawing.Point(35, 217);
            this.uxLabelReleaseDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.uxLabelReleaseDate.Name = "uxLabelReleaseDate";
            this.uxLabelReleaseDate.Size = new System.Drawing.Size(322, 45);
            this.uxLabelReleaseDate.TabIndex = 5;
            this.uxLabelReleaseDate.Text = "Movie Release Date:";
            // 
            // uxButtonInsertMovie
            // 
            this.uxButtonInsertMovie.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.uxButtonInsertMovie.Enabled = false;
            this.uxButtonInsertMovie.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxButtonInsertMovie.Location = new System.Drawing.Point(45, 453);
            this.uxButtonInsertMovie.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uxButtonInsertMovie.Name = "uxButtonInsertMovie";
            this.uxButtonInsertMovie.Size = new System.Drawing.Size(154, 60);
            this.uxButtonInsertMovie.TabIndex = 8;
            this.uxButtonInsertMovie.Text = "Insert";
            this.uxButtonInsertMovie.UseVisualStyleBackColor = true;
            this.uxButtonInsertMovie.Click += new System.EventHandler(this.uxButtonInsertMovie_Click);
            // 
            // uxLabelTitle
            // 
            this.uxLabelTitle.BackColor = System.Drawing.Color.OrangeRed;
            this.uxLabelTitle.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.uxLabelTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.uxLabelTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 20F, System.Drawing.FontStyle.Bold);
            this.uxLabelTitle.ForeColor = System.Drawing.Color.White;
            this.uxLabelTitle.Location = new System.Drawing.Point(0, 0);
            this.uxLabelTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.uxLabelTitle.Name = "uxLabelTitle";
            this.uxLabelTitle.Size = new System.Drawing.Size(1351, 77);
            this.uxLabelTitle.TabIndex = 9;
            this.uxLabelTitle.Text = "Movie";
            this.uxLabelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Persontext
            // 
            this.Persontext.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Persontext.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.Persontext.Location = new System.Drawing.Point(286, 358);
            this.Persontext.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Persontext.Multiline = true;
            this.Persontext.Name = "Persontext";
            this.Persontext.Size = new System.Drawing.Size(202, 52);
            this.Persontext.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(35, 358);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(250, 45);
            this.label1.TabIndex = 11;
            this.label1.Text = "Actor/Director:";
            // 
            // listBoxOptoins
            // 
            this.listBoxOptoins.FormattingEnabled = true;
            this.listBoxOptoins.ItemHeight = 20;
            this.listBoxOptoins.Location = new System.Drawing.Point(515, 360);
            this.listBoxOptoins.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listBoxOptoins.Name = "listBoxOptoins";
            this.listBoxOptoins.Size = new System.Drawing.Size(128, 64);
            this.listBoxOptoins.TabIndex = 12;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(354, 232);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(298, 26);
            this.dateTimePicker1.TabIndex = 22;
            // 
            // uxUpdateMovie
            // 
            this.uxUpdateMovie.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.uxUpdateMovie.Enabled = false;
            this.uxUpdateMovie.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxUpdateMovie.Location = new System.Drawing.Point(286, 453);
            this.uxUpdateMovie.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uxUpdateMovie.Name = "uxUpdateMovie";
            this.uxUpdateMovie.Size = new System.Drawing.Size(147, 60);
            this.uxUpdateMovie.TabIndex = 23;
            this.uxUpdateMovie.Text = "Update";
            this.uxUpdateMovie.UseVisualStyleBackColor = true;
            // 
            // uxDeleteMovie
            // 
            this.uxDeleteMovie.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.uxDeleteMovie.Enabled = false;
            this.uxDeleteMovie.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxDeleteMovie.Location = new System.Drawing.Point(229, 584);
            this.uxDeleteMovie.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uxDeleteMovie.Name = "uxDeleteMovie";
            this.uxDeleteMovie.Size = new System.Drawing.Size(224, 60);
            this.uxDeleteMovie.TabIndex = 24;
            this.uxDeleteMovie.Text = "Delete";
            this.uxDeleteMovie.UseVisualStyleBackColor = true;
            // 
            // uxViewMovies
            // 
            this.uxViewMovies.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.uxViewMovies.Enabled = false;
            this.uxViewMovies.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxViewMovies.Location = new System.Drawing.Point(504, 453);
            this.uxViewMovies.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uxViewMovies.Name = "uxViewMovies";
            this.uxViewMovies.Size = new System.Drawing.Size(148, 60);
            this.uxViewMovies.TabIndex = 25;
            this.uxViewMovies.Text = "View";
            this.uxViewMovies.UseVisualStyleBackColor = true;
            this.uxViewMovies.Click += new System.EventHandler(this.uxViewMovies_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(696, 101);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(626, 589);
            this.dataGridView1.TabIndex = 26;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(37, 286);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(293, 45);
            this.label2.TabIndex = 27;
            this.label2.Text = "Production Name:";
            // 
            // uxProductionName
            // 
            this.uxProductionName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.uxProductionName.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.uxProductionName.Location = new System.Drawing.Point(325, 288);
            this.uxProductionName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uxProductionName.Multiline = true;
            this.uxProductionName.Name = "uxProductionName";
            this.uxProductionName.Size = new System.Drawing.Size(348, 47);
            this.uxProductionName.TabIndex = 28;
            // 
            // Add
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.Controls.Add(this.uxProductionName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.uxViewMovies);
            this.Controls.Add(this.uxDeleteMovie);
            this.Controls.Add(this.uxUpdateMovie);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.listBoxOptoins);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Persontext);
            this.Controls.Add(this.uxLabelTitle);
            this.Controls.Add(this.uxButtonInsertMovie);
            this.Controls.Add(this.uxLabelReleaseDate);
            this.Controls.Add(this.uxTextBoxMovieTitle);
            this.Controls.Add(this.uxLabelMovieTitle);
            this.Name = "Add";
            this.Size = new System.Drawing.Size(1351, 722);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox uxTextBoxMovieTitle;
        private System.Windows.Forms.Label uxLabelMovieTitle;
        private System.Windows.Forms.Label uxLabelReleaseDate;
        private System.Windows.Forms.Button uxButtonInsertMovie;
        private System.Windows.Forms.Label uxLabelTitle;
        private System.Windows.Forms.TextBox Persontext;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBoxOptoins;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button uxUpdateMovie;
        private System.Windows.Forms.Button uxDeleteMovie;
        private System.Windows.Forms.Button uxViewMovies;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox uxProductionName;
    }
}
