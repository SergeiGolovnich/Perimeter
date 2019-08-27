namespace Периметр
{
    partial class FormSelectLights
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
            this.lbDiapozon = new System.Windows.Forms.Label();
            this.nFrom = new System.Windows.Forms.NumericUpDown();
            this.nTo = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gbChetverti = new System.Windows.Forms.GroupBox();
            this.cb4 = new System.Windows.Forms.CheckBox();
            this.cb3 = new System.Windows.Forms.CheckBox();
            this.cb2 = new System.Windows.Forms.CheckBox();
            this.cb1 = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nFrom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nTo)).BeginInit();
            this.gbChetverti.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbDiapozon
            // 
            this.lbDiapozon.AutoSize = true;
            this.lbDiapozon.Location = new System.Drawing.Point(16, 16);
            this.lbDiapozon.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbDiapozon.Name = "lbDiapozon";
            this.lbDiapozon.Size = new System.Drawing.Size(136, 20);
            this.lbDiapozon.TabIndex = 0;
            this.lbDiapozon.Text = "Тестовый угол:";
            // 
            // nFrom
            // 
            this.nFrom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nFrom.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nFrom.Location = new System.Drawing.Point(47, 60);
            this.nFrom.Maximum = new decimal(new int[] {
            85,
            0,
            0,
            0});
            this.nFrom.Name = "nFrom";
            this.nFrom.Size = new System.Drawing.Size(64, 27);
            this.nFrom.TabIndex = 1;
            // 
            // nTo
            // 
            this.nTo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nTo.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nTo.Location = new System.Drawing.Point(178, 60);
            this.nTo.Maximum = new decimal(new int[] {
            90,
            0,
            0,
            0});
            this.nTo.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nTo.Name = "nTo";
            this.nTo.Size = new System.Drawing.Size(64, 27);
            this.nTo.TabIndex = 2;
            this.nTo.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "От";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(140, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "До";
            // 
            // gbChetverti
            // 
            this.gbChetverti.Controls.Add(this.cb4);
            this.gbChetverti.Controls.Add(this.cb3);
            this.gbChetverti.Controls.Add(this.cb2);
            this.gbChetverti.Controls.Add(this.cb1);
            this.gbChetverti.Location = new System.Drawing.Point(16, 113);
            this.gbChetverti.Name = "gbChetverti";
            this.gbChetverti.Size = new System.Drawing.Size(246, 187);
            this.gbChetverti.TabIndex = 5;
            this.gbChetverti.TabStop = false;
            this.gbChetverti.Text = "Четверти:";
            // 
            // cb4
            // 
            this.cb4.AutoSize = true;
            this.cb4.Checked = true;
            this.cb4.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cb4.Location = new System.Drawing.Point(151, 121);
            this.cb4.Name = "cb4";
            this.cb4.Size = new System.Drawing.Size(66, 24);
            this.cb4.TabIndex = 3;
            this.cb4.Text = "4-ая";
            this.cb4.UseVisualStyleBackColor = true;
            // 
            // cb3
            // 
            this.cb3.AutoSize = true;
            this.cb3.Checked = true;
            this.cb3.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cb3.Location = new System.Drawing.Point(31, 121);
            this.cb3.Name = "cb3";
            this.cb3.Size = new System.Drawing.Size(66, 24);
            this.cb3.TabIndex = 2;
            this.cb3.Text = "3-ая";
            this.cb3.UseVisualStyleBackColor = true;
            // 
            // cb2
            // 
            this.cb2.AutoSize = true;
            this.cb2.Checked = true;
            this.cb2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cb2.Location = new System.Drawing.Point(31, 48);
            this.cb2.Name = "cb2";
            this.cb2.Size = new System.Drawing.Size(66, 24);
            this.cb2.TabIndex = 1;
            this.cb2.Text = "2-ая";
            this.cb2.UseVisualStyleBackColor = true;
            // 
            // cb1
            // 
            this.cb1.AutoSize = true;
            this.cb1.Checked = true;
            this.cb1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cb1.Location = new System.Drawing.Point(151, 48);
            this.cb1.Name = "cb1";
            this.cb1.Size = new System.Drawing.Size(66, 24);
            this.cb1.TabIndex = 0;
            this.cb1.Text = "1-ая";
            this.cb1.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(178, 323);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 50);
            this.button1.TabIndex = 6;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormSelectLights
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(274, 385);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.gbChetverti);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nTo);
            this.Controls.Add(this.nFrom);
            this.Controls.Add(this.lbDiapozon);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormSelectLights";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Выбор светодиодов";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.nFrom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nTo)).EndInit();
            this.gbChetverti.ResumeLayout(false);
            this.gbChetverti.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbDiapozon;
        private System.Windows.Forms.NumericUpDown nFrom;
        private System.Windows.Forms.NumericUpDown nTo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox gbChetverti;
        private System.Windows.Forms.CheckBox cb4;
        private System.Windows.Forms.CheckBox cb3;
        private System.Windows.Forms.CheckBox cb2;
        private System.Windows.Forms.CheckBox cb1;
        private System.Windows.Forms.Button button1;
    }
}