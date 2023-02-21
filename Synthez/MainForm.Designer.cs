namespace Synthez
{
    partial class MainForm
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
            this.btnPauseResume = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.cmbBoxDictor = new System.Windows.Forms.ComboBox();
            this.rTxtBox = new System.Windows.Forms.RichTextBox();
            this.trackRate = new System.Windows.Forms.TrackBar();
            this.trackVolume = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.trackRate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackVolume)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPauseResume
            // 
            this.btnPauseResume.BackColor = System.Drawing.Color.White;
            this.btnPauseResume.FlatAppearance.BorderSize = 0;
            this.btnPauseResume.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPauseResume.Location = new System.Drawing.Point(636, 41);
            this.btnPauseResume.Name = "btnPauseResume";
            this.btnPauseResume.Size = new System.Drawing.Size(156, 23);
            this.btnPauseResume.TabIndex = 0;
            this.btnPauseResume.Text = "Pause";
            this.btnPauseResume.UseVisualStyleBackColor = false;
            this.btnPauseResume.Click += new System.EventHandler(this.btnPauseResume_Click);
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.Green;
            this.btnStart.FlatAppearance.BorderSize = 0;
            this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnStart.ForeColor = System.Drawing.Color.White;
            this.btnStart.Location = new System.Drawing.Point(636, 12);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(156, 23);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // cmbBoxDictor
            // 
            this.cmbBoxDictor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbBoxDictor.FormattingEnabled = true;
            this.cmbBoxDictor.Location = new System.Drawing.Point(636, 193);
            this.cmbBoxDictor.Name = "cmbBoxDictor";
            this.cmbBoxDictor.Size = new System.Drawing.Size(156, 21);
            this.cmbBoxDictor.TabIndex = 1;
            // 
            // rTxtBox
            // 
            this.rTxtBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rTxtBox.Location = new System.Drawing.Point(12, 12);
            this.rTxtBox.Name = "rTxtBox";
            this.rTxtBox.Size = new System.Drawing.Size(618, 366);
            this.rTxtBox.TabIndex = 2;
            this.rTxtBox.Text = "";
            // 
            // trackRate
            // 
            this.trackRate.Location = new System.Drawing.Point(688, 135);
            this.trackRate.Name = "trackRate";
            this.trackRate.Size = new System.Drawing.Size(104, 45);
            this.trackRate.TabIndex = 3;
            this.trackRate.Value = 1;
            // 
            // trackVolume
            // 
            this.trackVolume.Location = new System.Drawing.Point(688, 84);
            this.trackVolume.Maximum = 100;
            this.trackVolume.Name = "trackVolume";
            this.trackVolume.Size = new System.Drawing.Size(104, 45);
            this.trackVolume.TabIndex = 3;
            this.trackVolume.Value = 100;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(636, 177);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Dictor";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(648, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Volume";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(652, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Rate";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 389);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.trackVolume);
            this.Controls.Add(this.trackRate);
            this.Controls.Add(this.rTxtBox);
            this.Controls.Add(this.cmbBoxDictor);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.btnPauseResume);
            this.Name = "MainForm";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trackRate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackVolume)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnPauseResume;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.ComboBox cmbBoxDictor;
        private System.Windows.Forms.RichTextBox rTxtBox;
        private System.Windows.Forms.TrackBar trackRate;
        private System.Windows.Forms.TrackBar trackVolume;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

