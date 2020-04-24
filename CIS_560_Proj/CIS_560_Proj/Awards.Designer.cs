﻿namespace CIS_560_Proj
{
    partial class Awards
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
            this.uxLabelTitle = new System.Windows.Forms.Label();
            this.uxNumericUpDownYear = new System.Windows.Forms.NumericUpDown();
            this.uxLabelReleaseDate = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.uxNumericUpDownYear)).BeginInit();
            this.SuspendLayout();
            // 
            // uxLabelTitle
            // 
            this.uxLabelTitle.BackColor = System.Drawing.Color.Goldenrod;
            this.uxLabelTitle.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.uxLabelTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.uxLabelTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 20F, System.Drawing.FontStyle.Bold);
            this.uxLabelTitle.ForeColor = System.Drawing.Color.White;
            this.uxLabelTitle.Location = new System.Drawing.Point(0, 0);
            this.uxLabelTitle.Name = "uxLabelTitle";
            this.uxLabelTitle.Size = new System.Drawing.Size(573, 50);
            this.uxLabelTitle.TabIndex = 10;
            this.uxLabelTitle.Text = "Awards";
            this.uxLabelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uxNumericUpDownYear
            // 
            this.uxNumericUpDownYear.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.uxNumericUpDownYear.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.uxNumericUpDownYear.Location = new System.Drawing.Point(344, 81);
            this.uxNumericUpDownYear.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.uxNumericUpDownYear.Minimum = new decimal(new int[] {
            1500,
            0,
            0,
            0});
            this.uxNumericUpDownYear.Name = "uxNumericUpDownYear";
            this.uxNumericUpDownYear.Size = new System.Drawing.Size(120, 32);
            this.uxNumericUpDownYear.TabIndex = 11;
            this.uxNumericUpDownYear.Value = new decimal(new int[] {
            2018,
            0,
            0,
            0});
            // 
            // uxLabelReleaseDate
            // 
            this.uxLabelReleaseDate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.uxLabelReleaseDate.AutoSize = true;
            this.uxLabelReleaseDate.BackColor = System.Drawing.Color.White;
            this.uxLabelReleaseDate.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.uxLabelReleaseDate.ForeColor = System.Drawing.Color.Black;
            this.uxLabelReleaseDate.Location = new System.Drawing.Point(67, 79);
            this.uxLabelReleaseDate.Name = "uxLabelReleaseDate";
            this.uxLabelReleaseDate.Size = new System.Drawing.Size(132, 30);
            this.uxLabelReleaseDate.TabIndex = 12;
            this.uxLabelReleaseDate.Text = "AwardYear:";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(72, 153);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 95);
            this.listBox1.TabIndex = 13;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(344, 153);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(120, 95);
            this.listBox2.TabIndex = 14;
            // 
            // Awards
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.uxLabelReleaseDate);
            this.Controls.Add(this.uxNumericUpDownYear);
            this.Controls.Add(this.uxLabelTitle);
            this.Name = "Awards";
            this.Size = new System.Drawing.Size(573, 471);
            ((System.ComponentModel.ISupportInitialize)(this.uxNumericUpDownYear)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label uxLabelTitle;
        private System.Windows.Forms.NumericUpDown uxNumericUpDownYear;
        private System.Windows.Forms.Label uxLabelReleaseDate;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
    }
}
