﻿namespace Периметр
{
    partial class FormHelpInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHelpInfo));
            this.rtbHelpInfo = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // rtbHelpInfo
            // 
            this.rtbHelpInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbHelpInfo.Location = new System.Drawing.Point(0, 0);
            this.rtbHelpInfo.Name = "rtbHelpInfo";
            this.rtbHelpInfo.ReadOnly = true;
            this.rtbHelpInfo.Size = new System.Drawing.Size(638, 503);
            this.rtbHelpInfo.TabIndex = 0;
            this.rtbHelpInfo.Text = resources.GetString("rtbHelpInfo.Text");
            // 
            // FormHelpInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 503);
            this.Controls.Add(this.rtbHelpInfo);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormHelpInfo";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Справка";
            this.TopMost = true;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbHelpInfo;
    }
}