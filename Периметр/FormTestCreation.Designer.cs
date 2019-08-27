namespace Периметр
{
    partial class FormTestCreation
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
            this.pOptions = new System.Windows.Forms.Panel();
            this.tbTestName = new System.Windows.Forms.TextBox();
            this.lbTestName = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnSelect = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.pLights = new System.Windows.Forms.PictureBox();
            this.pOptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pLights)).BeginInit();
            this.SuspendLayout();
            // 
            // pOptions
            // 
            this.pOptions.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.pOptions.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pOptions.Controls.Add(this.tbTestName);
            this.pOptions.Controls.Add(this.lbTestName);
            this.pOptions.Controls.Add(this.btnSave);
            this.pOptions.Controls.Add(this.btnSelect);
            this.pOptions.Controls.Add(this.btnExit);
            this.pOptions.Dock = System.Windows.Forms.DockStyle.Right;
            this.pOptions.Location = new System.Drawing.Point(800, 0);
            this.pOptions.Name = "pOptions";
            this.pOptions.Size = new System.Drawing.Size(224, 768);
            this.pOptions.TabIndex = 1;
            // 
            // tbTestName
            // 
            this.tbTestName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbTestName.Location = new System.Drawing.Point(8, 315);
            this.tbTestName.MaxLength = 30;
            this.tbTestName.Name = "tbTestName";
            this.tbTestName.Size = new System.Drawing.Size(202, 27);
            this.tbTestName.TabIndex = 4;
            // 
            // lbTestName
            // 
            this.lbTestName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbTestName.AutoSize = true;
            this.lbTestName.Location = new System.Drawing.Point(4, 282);
            this.lbTestName.Name = "lbTestName";
            this.lbTestName.Size = new System.Drawing.Size(150, 20);
            this.lbTestName.TabIndex = 3;
            this.lbTestName.Text = "Название теста:";
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Enabled = false;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Location = new System.Drawing.Point(54, 145);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(120, 50);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Сохранить";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnSelect
            // 
            this.btnSelect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSelect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelect.Location = new System.Drawing.Point(54, 48);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(120, 50);
            this.btnSelect.TabIndex = 1;
            this.btnSelect.Text = "Задать точки";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Location = new System.Drawing.Point(54, 668);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(120, 50);
            this.btnExit.TabIndex = 0;
            this.btnExit.Text = "Выход";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // pLights
            // 
            this.pLights.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pLights.Location = new System.Drawing.Point(0, 0);
            this.pLights.Name = "pLights";
            this.pLights.Size = new System.Drawing.Size(800, 768);
            this.pLights.TabIndex = 2;
            this.pLights.TabStop = false;
            // 
            // FormTestCreation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1024, 768);
            this.Controls.Add(this.pLights);
            this.Controls.Add(this.pOptions);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimizeBox = false;
            this.Name = "FormTestCreation";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Создание теста";
            this.TopMost = true;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormTestCreation_FormClosing);
            this.Shown += new System.EventHandler(this.FormTestCreation_Shown);
            this.pOptions.ResumeLayout(false);
            this.pOptions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pLights)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pOptions;
        private System.Windows.Forms.TextBox tbTestName;
        private System.Windows.Forms.Label lbTestName;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.PictureBox pLights;
    }
}