namespace Периметр
{
    partial class FormSettings
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
            this.lbName = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.lbFIO = new System.Windows.Forms.Label();
            this.tbFIO = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lbPass = new System.Windows.Forms.Label();
            this.tbPass = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Location = new System.Drawing.Point(13, 13);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(371, 20);
            this.lbName.TabIndex = 0;
            this.lbName.Text = "Наименование медицинского учреждения:";
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(17, 49);
            this.tbName.MaxLength = 100;
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(377, 27);
            this.tbName.TabIndex = 1;
            // 
            // lbFIO
            // 
            this.lbFIO.AutoSize = true;
            this.lbFIO.Location = new System.Drawing.Point(13, 101);
            this.lbFIO.Name = "lbFIO";
            this.lbFIO.Size = new System.Drawing.Size(277, 20);
            this.lbFIO.TabIndex = 2;
            this.lbFIO.Text = "ФИО пользователя программы:";
            // 
            // tbFIO
            // 
            this.tbFIO.Location = new System.Drawing.Point(17, 135);
            this.tbFIO.MaxLength = 100;
            this.tbFIO.Name = "tbFIO";
            this.tbFIO.Size = new System.Drawing.Size(377, 27);
            this.tbFIO.TabIndex = 3;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(12, 276);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(119, 45);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Сохранить";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(291, 276);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(119, 45);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Отмена";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lbPass
            // 
            this.lbPass.AutoSize = true;
            this.lbPass.Location = new System.Drawing.Point(13, 178);
            this.lbPass.Name = "lbPass";
            this.lbPass.Size = new System.Drawing.Size(225, 20);
            this.lbPass.TabIndex = 6;
            this.lbPass.Text = "Пароль администратора:";
            // 
            // tbPass
            // 
            this.tbPass.Location = new System.Drawing.Point(17, 210);
            this.tbPass.MaxLength = 20;
            this.tbPass.Name = "tbPass";
            this.tbPass.PasswordChar = '*';
            this.tbPass.Size = new System.Drawing.Size(377, 27);
            this.tbPass.TabIndex = 7;
            this.tbPass.UseSystemPasswordChar = true;
            // 
            // FormSettings
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 333);
            this.Controls.Add(this.tbPass);
            this.Controls.Add(this.lbPass);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.tbFIO);
            this.Controls.Add(this.lbFIO);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.lbName);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormSettings";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Системные настройки";
            this.TopMost = true;
            this.Shown += new System.EventHandler(this.FormSettings_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label lbFIO;
        private System.Windows.Forms.TextBox tbFIO;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lbPass;
        private System.Windows.Forms.TextBox tbPass;
    }
}