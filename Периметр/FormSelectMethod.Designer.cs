namespace Периметр
{
    partial class FormSelectMethod
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
            this.gbEye = new System.Windows.Forms.GroupBox();
            this.rbRight = new System.Windows.Forms.RadioButton();
            this.rbLeft = new System.Windows.Forms.RadioButton();
            this.gbMethod = new System.Windows.Forms.GroupBox();
            this.rbScreening = new System.Windows.Forms.RadioButton();
            this.rbThreshold = new System.Windows.Forms.RadioButton();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.gbEye.SuspendLayout();
            this.gbMethod.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbEye
            // 
            this.gbEye.Controls.Add(this.rbRight);
            this.gbEye.Controls.Add(this.rbLeft);
            this.gbEye.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gbEye.Location = new System.Drawing.Point(16, 16);
            this.gbEye.Margin = new System.Windows.Forms.Padding(4);
            this.gbEye.Name = "gbEye";
            this.gbEye.Padding = new System.Windows.Forms.Padding(4);
            this.gbEye.Size = new System.Drawing.Size(270, 70);
            this.gbEye.TabIndex = 0;
            this.gbEye.TabStop = false;
            this.gbEye.Text = "Выберите глаз";
            // 
            // rbRight
            // 
            this.rbRight.AutoSize = true;
            this.rbRight.Location = new System.Drawing.Point(146, 28);
            this.rbRight.Margin = new System.Windows.Forms.Padding(4);
            this.rbRight.Name = "rbRight";
            this.rbRight.Size = new System.Drawing.Size(95, 24);
            this.rbRight.TabIndex = 1;
            this.rbRight.Text = "Правый";
            this.rbRight.UseVisualStyleBackColor = true;
            // 
            // rbLeft
            // 
            this.rbLeft.AutoSize = true;
            this.rbLeft.Checked = true;
            this.rbLeft.Location = new System.Drawing.Point(9, 28);
            this.rbLeft.Margin = new System.Windows.Forms.Padding(4);
            this.rbLeft.Name = "rbLeft";
            this.rbLeft.Size = new System.Drawing.Size(84, 24);
            this.rbLeft.TabIndex = 0;
            this.rbLeft.TabStop = true;
            this.rbLeft.Text = "Левый";
            this.rbLeft.UseVisualStyleBackColor = true;
            // 
            // gbMethod
            // 
            this.gbMethod.Controls.Add(this.rbScreening);
            this.gbMethod.Controls.Add(this.rbThreshold);
            this.gbMethod.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gbMethod.Location = new System.Drawing.Point(16, 94);
            this.gbMethod.Margin = new System.Windows.Forms.Padding(4);
            this.gbMethod.Name = "gbMethod";
            this.gbMethod.Padding = new System.Windows.Forms.Padding(4);
            this.gbMethod.Size = new System.Drawing.Size(270, 108);
            this.gbMethod.TabIndex = 1;
            this.gbMethod.TabStop = false;
            this.gbMethod.Text = "Метод тестирования";
            // 
            // rbScreening
            // 
            this.rbScreening.AutoSize = true;
            this.rbScreening.Checked = true;
            this.rbScreening.Location = new System.Drawing.Point(8, 28);
            this.rbScreening.Margin = new System.Windows.Forms.Padding(4);
            this.rbScreening.Name = "rbScreening";
            this.rbScreening.Size = new System.Drawing.Size(154, 24);
            this.rbScreening.TabIndex = 1;
            this.rbScreening.TabStop = true;
            this.rbScreening.Text = "Скрининг-тест";
            this.rbScreening.UseVisualStyleBackColor = true;
            // 
            // rbThreshold
            // 
            this.rbThreshold.AutoSize = true;
            this.rbThreshold.Location = new System.Drawing.Point(8, 71);
            this.rbThreshold.Margin = new System.Windows.Forms.Padding(4);
            this.rbThreshold.Name = "rbThreshold";
            this.rbThreshold.Size = new System.Drawing.Size(196, 24);
            this.rbThreshold.TabIndex = 0;
            this.rbThreshold.Text = "Пороговый уровень";
            this.rbThreshold.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCancel.Location = new System.Drawing.Point(417, 152);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(131, 50);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Отмена";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnStart
            // 
            this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnStart.Location = new System.Drawing.Point(373, 31);
            this.btnStart.Margin = new System.Windows.Forms.Padding(4);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(175, 50);
            this.btnStart.TabIndex = 3;
            this.btnStart.Text = "Начать тест";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // FormSelectMethod
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(561, 219);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.gbMethod);
            this.Controls.Add(this.gbEye);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormSelectMethod";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Выбор глаза и метода тестирования";
            this.TopMost = true;
            this.gbEye.ResumeLayout(false);
            this.gbEye.PerformLayout();
            this.gbMethod.ResumeLayout(false);
            this.gbMethod.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbEye;
        private System.Windows.Forms.RadioButton rbRight;
        private System.Windows.Forms.RadioButton rbLeft;
        private System.Windows.Forms.GroupBox gbMethod;
        private System.Windows.Forms.RadioButton rbScreening;
        private System.Windows.Forms.RadioButton rbThreshold;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnStart;
    }
}