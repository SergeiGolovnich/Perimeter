namespace Периметр
{
    partial class FormResult
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
            this.pResultWraper = new System.Windows.Forms.Panel();
            this.pbResult = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.печатьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьВФайлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pResultWraper.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbResult)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pResultWraper
            // 
            this.pResultWraper.AutoScroll = true;
            this.pResultWraper.AutoSize = true;
            this.pResultWraper.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pResultWraper.Controls.Add(this.pbResult);
            this.pResultWraper.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pResultWraper.Location = new System.Drawing.Point(0, 31);
            this.pResultWraper.Name = "pResultWraper";
            this.pResultWraper.Size = new System.Drawing.Size(1006, 690);
            this.pResultWraper.TabIndex = 0;
            // 
            // pbResult
            // 
            this.pbResult.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbResult.Location = new System.Drawing.Point(100, 0);
            this.pbResult.Name = "pbResult";
            this.pbResult.Size = new System.Drawing.Size(820, 1188);
            this.pbResult.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbResult.TabIndex = 0;
            this.pbResult.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.печатьToolStripMenuItem,
            this.сохранитьВФайлToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1006, 31);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // печатьToolStripMenuItem
            // 
            this.печатьToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.печатьToolStripMenuItem.Name = "печатьToolStripMenuItem";
            this.печатьToolStripMenuItem.Size = new System.Drawing.Size(78, 27);
            this.печатьToolStripMenuItem.Text = "Печать";
            this.печатьToolStripMenuItem.Click += new System.EventHandler(this.печатьToolStripMenuItem_Click);
            // 
            // сохранитьВФайлToolStripMenuItem
            // 
            this.сохранитьВФайлToolStripMenuItem.Name = "сохранитьВФайлToolStripMenuItem";
            this.сохранитьВФайлToolStripMenuItem.Size = new System.Drawing.Size(146, 27);
            this.сохранитьВФайлToolStripMenuItem.Text = "Сохранить в файл";
            this.сохранитьВФайлToolStripMenuItem.Click += new System.EventHandler(this.сохранитьВФайлToolStripMenuItem_Click);
            // 
            // FormResult
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1006, 721);
            this.Controls.Add(this.pResultWraper);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormResult";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Результат";
            this.TopMost = true;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Shown += new System.EventHandler(this.FormResult_Shown);
            this.SizeChanged += new System.EventHandler(this.FormResult_SizeChanged);
            this.pResultWraper.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbResult)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pResultWraper;
        private System.Windows.Forms.PictureBox pbResult;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem печатьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьВФайлToolStripMenuItem;
    }
}