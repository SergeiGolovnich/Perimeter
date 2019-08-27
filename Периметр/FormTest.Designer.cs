namespace Периметр
{
    partial class FormTest
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
            this.components = new System.ComponentModel.Container();
            this.pSettings = new System.Windows.Forms.Panel();
            this.lbIntervalTime = new System.Windows.Forms.Label();
            this.lbDurationTime = new System.Windows.Forms.Label();
            this.hsbInterval = new System.Windows.Forms.HScrollBar();
            this.hsbDuration = new System.Windows.Forms.HScrollBar();
            this.lbInterval = new System.Windows.Forms.Label();
            this.lbDuration = new System.Windows.Forms.Label();
            this.pControls = new System.Windows.Forms.Panel();
            this.gbServo = new System.Windows.Forms.GroupBox();
            this.btnDown = new System.Windows.Forms.Button();
            this.btnLeft = new System.Windows.Forms.Button();
            this.btnUp = new System.Windows.Forms.Button();
            this.btnRight = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnPause = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.pIndicators = new System.Windows.Forms.Panel();
            this.lbProgress = new System.Windows.Forms.Label();
            this.lbResultLabel = new System.Windows.Forms.Label();
            this.lbCurrentTime = new System.Windows.Forms.Label();
            this.lbTime = new System.Windows.Forms.Label();
            this.timerDuration = new System.Windows.Forms.Timer(this.components);
            this.timerInterval = new System.Windows.Forms.Timer(this.components);
            this.timerTime = new System.Windows.Forms.Timer(this.components);
            this.pLights = new System.Windows.Forms.PictureBox();
            this.pSettings.SuspendLayout();
            this.pControls.SuspendLayout();
            this.gbServo.SuspendLayout();
            this.pIndicators.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pLights)).BeginInit();
            this.SuspendLayout();
            // 
            // pSettings
            // 
            this.pSettings.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.pSettings.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pSettings.Controls.Add(this.lbIntervalTime);
            this.pSettings.Controls.Add(this.lbDurationTime);
            this.pSettings.Controls.Add(this.hsbInterval);
            this.pSettings.Controls.Add(this.hsbDuration);
            this.pSettings.Controls.Add(this.lbInterval);
            this.pSettings.Controls.Add(this.lbDuration);
            this.pSettings.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pSettings.Location = new System.Drawing.Point(0, 668);
            this.pSettings.Name = "pSettings";
            this.pSettings.Size = new System.Drawing.Size(1024, 100);
            this.pSettings.TabIndex = 0;
            // 
            // lbIntervalTime
            // 
            this.lbIntervalTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbIntervalTime.AutoSize = true;
            this.lbIntervalTime.Location = new System.Drawing.Point(929, 62);
            this.lbIntervalTime.Name = "lbIntervalTime";
            this.lbIntervalTime.Size = new System.Drawing.Size(73, 20);
            this.lbIntervalTime.TabIndex = 5;
            this.lbIntervalTime.Text = "1200 ms";
            // 
            // lbDurationTime
            // 
            this.lbDurationTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbDurationTime.AutoSize = true;
            this.lbDurationTime.Location = new System.Drawing.Point(929, 20);
            this.lbDurationTime.Name = "lbDurationTime";
            this.lbDurationTime.Size = new System.Drawing.Size(64, 20);
            this.lbDurationTime.TabIndex = 4;
            this.lbDurationTime.Text = "200 ms";
            // 
            // hsbInterval
            // 
            this.hsbInterval.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.hsbInterval.LargeChange = 100;
            this.hsbInterval.Location = new System.Drawing.Point(725, 62);
            this.hsbInterval.Maximum = 2099;
            this.hsbInterval.Minimum = 100;
            this.hsbInterval.Name = "hsbInterval";
            this.hsbInterval.Size = new System.Drawing.Size(200, 21);
            this.hsbInterval.SmallChange = 100;
            this.hsbInterval.TabIndex = 3;
            this.hsbInterval.Value = 1200;
            this.hsbInterval.ValueChanged += new System.EventHandler(this.hsbInterval_ValueChanged);
            // 
            // hsbDuration
            // 
            this.hsbDuration.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.hsbDuration.LargeChange = 100;
            this.hsbDuration.Location = new System.Drawing.Point(725, 20);
            this.hsbDuration.Maximum = 2099;
            this.hsbDuration.Minimum = 100;
            this.hsbDuration.Name = "hsbDuration";
            this.hsbDuration.Size = new System.Drawing.Size(200, 21);
            this.hsbDuration.SmallChange = 100;
            this.hsbDuration.TabIndex = 2;
            this.hsbDuration.Value = 200;
            this.hsbDuration.ValueChanged += new System.EventHandler(this.hsbDuration_ValueChanged);
            // 
            // lbInterval
            // 
            this.lbInterval.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbInterval.AutoSize = true;
            this.lbInterval.Location = new System.Drawing.Point(512, 62);
            this.lbInterval.Name = "lbInterval";
            this.lbInterval.Size = new System.Drawing.Size(210, 20);
            this.lbInterval.TabIndex = 1;
            this.lbInterval.Text = "Интервал воздействия:";
            // 
            // lbDuration
            // 
            this.lbDuration.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbDuration.AutoSize = true;
            this.lbDuration.Location = new System.Drawing.Point(512, 20);
            this.lbDuration.Name = "lbDuration";
            this.lbDuration.Size = new System.Drawing.Size(183, 20);
            this.lbDuration.TabIndex = 0;
            this.lbDuration.Text = "Время воздействия:";
            // 
            // pControls
            // 
            this.pControls.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.pControls.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pControls.Controls.Add(this.gbServo);
            this.pControls.Controls.Add(this.btnStop);
            this.pControls.Controls.Add(this.btnPause);
            this.pControls.Controls.Add(this.btnStart);
            this.pControls.Controls.Add(this.btnExit);
            this.pControls.Dock = System.Windows.Forms.DockStyle.Right;
            this.pControls.Location = new System.Drawing.Point(863, 0);
            this.pControls.Name = "pControls";
            this.pControls.Size = new System.Drawing.Size(161, 668);
            this.pControls.TabIndex = 1;
            // 
            // gbServo
            // 
            this.gbServo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gbServo.Controls.Add(this.btnDown);
            this.gbServo.Controls.Add(this.btnLeft);
            this.gbServo.Controls.Add(this.btnUp);
            this.gbServo.Controls.Add(this.btnRight);
            this.gbServo.Location = new System.Drawing.Point(0, 0);
            this.gbServo.Name = "gbServo";
            this.gbServo.Size = new System.Drawing.Size(159, 183);
            this.gbServo.TabIndex = 8;
            this.gbServo.TabStop = false;
            this.gbServo.Text = "Управление сервоприводом";
            // 
            // btnDown
            // 
            this.btnDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDown.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDown.Location = new System.Drawing.Point(64, 133);
            this.btnDown.Name = "btnDown";
            this.btnDown.Size = new System.Drawing.Size(40, 35);
            this.btnDown.TabIndex = 9;
            this.btnDown.Text = "↓";
            this.btnDown.UseVisualStyleBackColor = true;
            this.btnDown.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnDown_MouseDown);
            this.btnDown.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_StopServo);
            // 
            // btnLeft
            // 
            this.btnLeft.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLeft.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLeft.Location = new System.Drawing.Point(26, 92);
            this.btnLeft.Name = "btnLeft";
            this.btnLeft.Size = new System.Drawing.Size(40, 35);
            this.btnLeft.TabIndex = 11;
            this.btnLeft.Text = "←";
            this.btnLeft.UseVisualStyleBackColor = true;
            this.btnLeft.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnLeft_MouseDown);
            this.btnLeft.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_StopServo);
            // 
            // btnUp
            // 
            this.btnUp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUp.Location = new System.Drawing.Point(64, 51);
            this.btnUp.Name = "btnUp";
            this.btnUp.Size = new System.Drawing.Size(40, 35);
            this.btnUp.TabIndex = 8;
            this.btnUp.Text = "↑";
            this.btnUp.UseVisualStyleBackColor = true;
            this.btnUp.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnUp_MouseDown);
            this.btnUp.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_StopServo);
            // 
            // btnRight
            // 
            this.btnRight.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRight.Location = new System.Drawing.Point(99, 92);
            this.btnRight.Name = "btnRight";
            this.btnRight.Size = new System.Drawing.Size(40, 35);
            this.btnRight.TabIndex = 10;
            this.btnRight.Text = "→";
            this.btnRight.UseVisualStyleBackColor = true;
            this.btnRight.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnRight_MouseDown);
            this.btnRight.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_StopServo);
            // 
            // btnStop
            // 
            this.btnStop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStop.Location = new System.Drawing.Point(27, 416);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(110, 55);
            this.btnStop.TabIndex = 3;
            this.btnStop.Text = "Стоп";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Visible = false;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnPause
            // 
            this.btnPause.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPause.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPause.Location = new System.Drawing.Point(27, 339);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(110, 55);
            this.btnPause.TabIndex = 2;
            this.btnPause.Text = "Пауза";
            this.btnPause.UseVisualStyleBackColor = true;
            this.btnPause.Visible = false;
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
            // 
            // btnStart
            // 
            this.btnStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStart.Location = new System.Drawing.Point(27, 260);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(110, 55);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "Старт";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Location = new System.Drawing.Point(27, 588);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(110, 55);
            this.btnExit.TabIndex = 0;
            this.btnExit.Text = "Выход";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // pIndicators
            // 
            this.pIndicators.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.pIndicators.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pIndicators.Controls.Add(this.lbProgress);
            this.pIndicators.Controls.Add(this.lbResultLabel);
            this.pIndicators.Controls.Add(this.lbCurrentTime);
            this.pIndicators.Controls.Add(this.lbTime);
            this.pIndicators.Dock = System.Windows.Forms.DockStyle.Left;
            this.pIndicators.Location = new System.Drawing.Point(0, 0);
            this.pIndicators.Name = "pIndicators";
            this.pIndicators.Size = new System.Drawing.Size(202, 668);
            this.pIndicators.TabIndex = 3;
            // 
            // lbProgress
            // 
            this.lbProgress.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbProgress.AutoSize = true;
            this.lbProgress.Location = new System.Drawing.Point(66, 567);
            this.lbProgress.Name = "lbProgress";
            this.lbProgress.Size = new System.Drawing.Size(0, 20);
            this.lbProgress.TabIndex = 4;
            // 
            // lbResultLabel
            // 
            this.lbResultLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbResultLabel.AutoSize = true;
            this.lbResultLabel.Location = new System.Drawing.Point(3, 537);
            this.lbResultLabel.Name = "lbResultLabel";
            this.lbResultLabel.Size = new System.Drawing.Size(161, 20);
            this.lbResultLabel.TabIndex = 3;
            this.lbResultLabel.Text = "Проверено точек:";
            // 
            // lbCurrentTime
            // 
            this.lbCurrentTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbCurrentTime.AutoSize = true;
            this.lbCurrentTime.Location = new System.Drawing.Point(66, 634);
            this.lbCurrentTime.Name = "lbCurrentTime";
            this.lbCurrentTime.Size = new System.Drawing.Size(0, 20);
            this.lbCurrentTime.TabIndex = 2;
            // 
            // lbTime
            // 
            this.lbTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbTime.AutoSize = true;
            this.lbTime.Location = new System.Drawing.Point(2, 605);
            this.lbTime.Name = "lbTime";
            this.lbTime.Size = new System.Drawing.Size(192, 20);
            this.lbTime.TabIndex = 1;
            this.lbTime.Text = "Время тестирования:";
            // 
            // timerDuration
            // 
            this.timerDuration.Interval = 200;
            this.timerDuration.Tick += new System.EventHandler(this.timerDuration_Tick);
            // 
            // timerInterval
            // 
            this.timerInterval.Interval = 1200;
            this.timerInterval.Tick += new System.EventHandler(this.timerInterval_Tick);
            // 
            // timerTime
            // 
            this.timerTime.Interval = 1000;
            this.timerTime.Tick += new System.EventHandler(this.timerTime_Tick);
            // 
            // pLights
            // 
            this.pLights.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pLights.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pLights.Location = new System.Drawing.Point(202, 0);
            this.pLights.Name = "pLights";
            this.pLights.Size = new System.Drawing.Size(661, 668);
            this.pLights.TabIndex = 4;
            this.pLights.TabStop = false;
            // 
            // FormTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 768);
            this.Controls.Add(this.pLights);
            this.Controls.Add(this.pIndicators);
            this.Controls.Add(this.pControls);
            this.Controls.Add(this.pSettings);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimizeBox = false;
            this.Name = "FormTest";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormTest";
            this.TopMost = true;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormTest_FormClosing);
            this.Shown += new System.EventHandler(this.FormTest_Shown);
            this.SizeChanged += new System.EventHandler(this.FormTest_SizeChanged);
            this.pSettings.ResumeLayout(false);
            this.pSettings.PerformLayout();
            this.pControls.ResumeLayout(false);
            this.gbServo.ResumeLayout(false);
            this.pIndicators.ResumeLayout(false);
            this.pIndicators.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pLights)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pSettings;
        private System.Windows.Forms.Panel pControls;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Panel pIndicators;
        private System.Windows.Forms.Label lbIntervalTime;
        private System.Windows.Forms.Label lbDurationTime;
        private System.Windows.Forms.HScrollBar hsbInterval;
        private System.Windows.Forms.HScrollBar hsbDuration;
        private System.Windows.Forms.Label lbInterval;
        private System.Windows.Forms.Label lbDuration;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnPause;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.GroupBox gbServo;
        private System.Windows.Forms.Button btnDown;
        private System.Windows.Forms.Button btnLeft;
        private System.Windows.Forms.Button btnUp;
        private System.Windows.Forms.Button btnRight;
        private System.Windows.Forms.Timer timerDuration;
        private System.Windows.Forms.Timer timerInterval;
        private System.Windows.Forms.Label lbTime;
        private System.Windows.Forms.Timer timerTime;
        private System.Windows.Forms.Label lbCurrentTime;
        private System.Windows.Forms.Label lbProgress;
        private System.Windows.Forms.Label lbResultLabel;
        private System.Windows.Forms.PictureBox pLights;
    }
}