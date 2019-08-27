namespace Периметр
{
    partial class FormMain
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.btExit = new System.Windows.Forms.Button();
            this.gbPatient = new System.Windows.Forms.GroupBox();
            this.mcBirth = new System.Windows.Forms.MonthCalendar();
            this.lbOt = new System.Windows.Forms.Label();
            this.tbOt = new System.Windows.Forms.TextBox();
            this.lbFam = new System.Windows.Forms.Label();
            this.tbFam = new System.Windows.Forms.TextBox();
            this.lbName = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.gbTests = new System.Windows.Forms.GroupBox();
            this.panelOfTests = new System.Windows.Forms.Panel();
            this.gbSys = new System.Windows.Forms.GroupBox();
            this.btnSettings = new System.Windows.Forms.Button();
            this.btnHelp = new System.Windows.Forms.Button();
            this.btnEditTests = new System.Windows.Forms.Button();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.gbBirth = new System.Windows.Forms.GroupBox();
            this.gbSex = new System.Windows.Forms.GroupBox();
            this.rbMale = new System.Windows.Forms.RadioButton();
            this.rbFemale = new System.Windows.Forms.RadioButton();
            this.gbPatient.SuspendLayout();
            this.gbTests.SuspendLayout();
            this.gbSys.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.gbBirth.SuspendLayout();
            this.gbSex.SuspendLayout();
            this.SuspendLayout();
            // 
            // btExit
            // 
            this.btExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btExit.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btExit.Location = new System.Drawing.Point(18, 38);
            this.btExit.Margin = new System.Windows.Forms.Padding(4);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(110, 50);
            this.btExit.TabIndex = 0;
            this.btExit.Text = "Выход";
            this.btExit.UseVisualStyleBackColor = false;
            this.btExit.Click += new System.EventHandler(this.btExit_Click);
            // 
            // gbPatient
            // 
            this.gbPatient.BackColor = System.Drawing.SystemColors.ControlLight;
            this.gbPatient.Controls.Add(this.gbSex);
            this.gbPatient.Controls.Add(this.gbBirth);
            this.gbPatient.Controls.Add(this.lbOt);
            this.gbPatient.Controls.Add(this.tbOt);
            this.gbPatient.Controls.Add(this.lbFam);
            this.gbPatient.Controls.Add(this.tbFam);
            this.gbPatient.Controls.Add(this.lbName);
            this.gbPatient.Controls.Add(this.tbName);
            this.gbPatient.Dock = System.Windows.Forms.DockStyle.Right;
            this.gbPatient.Location = new System.Drawing.Point(698, 0);
            this.gbPatient.Name = "gbPatient";
            this.gbPatient.Size = new System.Drawing.Size(326, 768);
            this.gbPatient.TabIndex = 2;
            this.gbPatient.TabStop = false;
            this.gbPatient.Text = "Данные пациента";
            // 
            // mcBirth
            // 
            this.mcBirth.Location = new System.Drawing.Point(74, 23);
            this.mcBirth.Margin = new System.Windows.Forms.Padding(0);
            this.mcBirth.MaxDate = new System.DateTime(2100, 12, 31, 0, 0, 0, 0);
            this.mcBirth.MaxSelectionCount = 1;
            this.mcBirth.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.mcBirth.Name = "mcBirth";
            this.mcBirth.ShowToday = false;
            this.mcBirth.ShowTodayCircle = false;
            this.mcBirth.TabIndex = 8;
            // 
            // lbOt
            // 
            this.lbOt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbOt.AutoSize = true;
            this.lbOt.Location = new System.Drawing.Point(7, 127);
            this.lbOt.Name = "lbOt";
            this.lbOt.Size = new System.Drawing.Size(96, 20);
            this.lbOt.TabIndex = 7;
            this.lbOt.Text = "Отчество:";
            // 
            // tbOt
            // 
            this.tbOt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbOt.Location = new System.Drawing.Point(109, 120);
            this.tbOt.MaxLength = 30;
            this.tbOt.Name = "tbOt";
            this.tbOt.Size = new System.Drawing.Size(176, 27);
            this.tbOt.TabIndex = 6;
            // 
            // lbFam
            // 
            this.lbFam.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbFam.AutoSize = true;
            this.lbFam.Location = new System.Drawing.Point(7, 94);
            this.lbFam.Name = "lbFam";
            this.lbFam.Size = new System.Drawing.Size(92, 20);
            this.lbFam.TabIndex = 5;
            this.lbFam.Text = "Фамилия:";
            // 
            // tbFam
            // 
            this.tbFam.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbFam.Location = new System.Drawing.Point(109, 87);
            this.tbFam.MaxLength = 30;
            this.tbFam.Name = "tbFam";
            this.tbFam.Size = new System.Drawing.Size(176, 27);
            this.tbFam.TabIndex = 4;
            // 
            // lbName
            // 
            this.lbName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbName.AutoSize = true;
            this.lbName.Location = new System.Drawing.Point(7, 61);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(47, 20);
            this.lbName.TabIndex = 3;
            this.lbName.Text = "Имя:";
            // 
            // tbName
            // 
            this.tbName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbName.Location = new System.Drawing.Point(109, 54);
            this.tbName.MaxLength = 30;
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(176, 27);
            this.tbName.TabIndex = 2;
            // 
            // gbTests
            // 
            this.gbTests.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbTests.Controls.Add(this.panelOfTests);
            this.gbTests.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.gbTests.Location = new System.Drawing.Point(12, 262);
            this.gbTests.Name = "gbTests";
            this.gbTests.Size = new System.Drawing.Size(680, 383);
            this.gbTests.TabIndex = 3;
            this.gbTests.TabStop = false;
            this.gbTests.Text = "Список тестов";
            // 
            // panelOfTests
            // 
            this.panelOfTests.AutoScroll = true;
            this.panelOfTests.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelOfTests.Location = new System.Drawing.Point(3, 23);
            this.panelOfTests.Name = "panelOfTests";
            this.panelOfTests.Size = new System.Drawing.Size(674, 357);
            this.panelOfTests.TabIndex = 0;
            // 
            // gbSys
            // 
            this.gbSys.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbSys.Controls.Add(this.btnSettings);
            this.gbSys.Controls.Add(this.btnHelp);
            this.gbSys.Controls.Add(this.btnEditTests);
            this.gbSys.Controls.Add(this.btExit);
            this.gbSys.Location = new System.Drawing.Point(13, 651);
            this.gbSys.Name = "gbSys";
            this.gbSys.Size = new System.Drawing.Size(679, 105);
            this.gbSys.TabIndex = 5;
            this.gbSys.TabStop = false;
            this.gbSys.Text = "Системные функции";
            // 
            // btnSettings
            // 
            this.btnSettings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSettings.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSettings.Location = new System.Drawing.Point(338, 38);
            this.btnSettings.Margin = new System.Windows.Forms.Padding(4);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(154, 50);
            this.btnSettings.TabIndex = 4;
            this.btnSettings.Text = "Системные настройки";
            this.btnSettings.UseVisualStyleBackColor = false;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // btnHelp
            // 
            this.btnHelp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnHelp.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnHelp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHelp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnHelp.Location = new System.Drawing.Point(500, 38);
            this.btnHelp.Margin = new System.Windows.Forms.Padding(4);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(154, 50);
            this.btnHelp.TabIndex = 3;
            this.btnHelp.Text = "Помощь";
            this.btnHelp.UseVisualStyleBackColor = false;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // btnEditTests
            // 
            this.btnEditTests.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnEditTests.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnEditTests.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditTests.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnEditTests.Location = new System.Drawing.Point(176, 38);
            this.btnEditTests.Margin = new System.Windows.Forms.Padding(4);
            this.btnEditTests.Name = "btnEditTests";
            this.btnEditTests.Size = new System.Drawing.Size(154, 50);
            this.btnEditTests.TabIndex = 2;
            this.btnEditTests.Text = "Изменить список тестов";
            this.btnEditTests.UseVisualStyleBackColor = false;
            this.btnEditTests.Click += new System.EventHandler(this.btnEditTests_Click);
            // 
            // pbLogo
            // 
            this.pbLogo.Image = global::Периметр.Properties.Resources.ZOMZ_256;
            this.pbLogo.Location = new System.Drawing.Point(0, 0);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(256, 256);
            this.pbLogo.TabIndex = 4;
            this.pbLogo.TabStop = false;
            // 
            // gbBirth
            // 
            this.gbBirth.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbBirth.Controls.Add(this.mcBirth);
            this.gbBirth.Location = new System.Drawing.Point(0, 262);
            this.gbBirth.Name = "gbBirth";
            this.gbBirth.Size = new System.Drawing.Size(326, 247);
            this.gbBirth.TabIndex = 9;
            this.gbBirth.TabStop = false;
            this.gbBirth.Text = "Дата рождения:";
            // 
            // gbSex
            // 
            this.gbSex.Controls.Add(this.rbFemale);
            this.gbSex.Controls.Add(this.rbMale);
            this.gbSex.Location = new System.Drawing.Point(0, 163);
            this.gbSex.Name = "gbSex";
            this.gbSex.Size = new System.Drawing.Size(326, 66);
            this.gbSex.TabIndex = 10;
            this.gbSex.TabStop = false;
            this.gbSex.Text = "Пол:";
            // 
            // rbMale
            // 
            this.rbMale.AutoSize = true;
            this.rbMale.Checked = true;
            this.rbMale.Location = new System.Drawing.Point(51, 26);
            this.rbMale.Name = "rbMale";
            this.rbMale.Size = new System.Drawing.Size(102, 24);
            this.rbMale.TabIndex = 0;
            this.rbMale.TabStop = true;
            this.rbMale.Text = "Мужской";
            this.rbMale.UseVisualStyleBackColor = true;
            // 
            // rbFemale
            // 
            this.rbFemale.AutoSize = true;
            this.rbFemale.Location = new System.Drawing.Point(183, 26);
            this.rbFemale.Name = "rbFemale";
            this.rbFemale.Size = new System.Drawing.Size(102, 24);
            this.rbFemale.TabIndex = 1;
            this.rbFemale.Text = "Женский";
            this.rbFemale.UseVisualStyleBackColor = true;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1024, 768);
            this.Controls.Add(this.gbSys);
            this.Controls.Add(this.pbLogo);
            this.Controls.Add(this.gbTests);
            this.Controls.Add(this.gbPatient);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1024, 768);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Периметр";
            this.TopMost = true;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Shown += new System.EventHandler(this.FormMain_Shown);
            this.SizeChanged += new System.EventHandler(this.FormMain_SizeChanged);
            this.gbPatient.ResumeLayout(false);
            this.gbPatient.PerformLayout();
            this.gbTests.ResumeLayout(false);
            this.gbSys.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.gbBirth.ResumeLayout(false);
            this.gbSex.ResumeLayout(false);
            this.gbSex.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btExit;
        private System.Windows.Forms.GroupBox gbPatient;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label lbOt;
        private System.Windows.Forms.TextBox tbOt;
        private System.Windows.Forms.Label lbFam;
        private System.Windows.Forms.TextBox tbFam;
        private System.Windows.Forms.MonthCalendar mcBirth;
        private System.Windows.Forms.GroupBox gbTests;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.GroupBox gbSys;
        private System.Windows.Forms.Panel panelOfTests;
        private System.Windows.Forms.Button btnEditTests;
        private System.Windows.Forms.Button btnHelp;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.GroupBox gbBirth;
        private System.Windows.Forms.GroupBox gbSex;
        private System.Windows.Forms.RadioButton rbFemale;
        private System.Windows.Forms.RadioButton rbMale;
    }
}

