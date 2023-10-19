namespace Alarm501
{
    partial class AddEditAlarm
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
            this.UxAlarmTime = new System.Windows.Forms.DateTimePicker();
            this.UXSetAlarmBtn = new System.Windows.Forms.Button();
            this.UxCancelEditAlarmBtn = new System.Windows.Forms.Button();
            this.UxAlarmOn = new System.Windows.Forms.CheckBox();
            this.UxAlarmSounds = new System.Windows.Forms.ComboBox();
            this.UxSnoozeInterval = new System.Windows.Forms.NumericUpDown();
            this.UxSnoozeLabel1 = new System.Windows.Forms.Label();
            this.UxSnoozeLabel2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.UxSnoozeInterval)).BeginInit();
            this.SuspendLayout();
            // 
            // UxAlarmTime
            // 
            this.UxAlarmTime.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 22.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UxAlarmTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.UxAlarmTime.Location = new System.Drawing.Point(56, 65);
            this.UxAlarmTime.Margin = new System.Windows.Forms.Padding(4);
            this.UxAlarmTime.Name = "UxAlarmTime";
            this.UxAlarmTime.Size = new System.Drawing.Size(300, 31);
            this.UxAlarmTime.TabIndex = 0;
            this.UxAlarmTime.Value = new System.DateTime(2021, 1, 29, 22, 30, 0, 0);
            // 
            // UXSetAlarmBtn
            // 
            this.UXSetAlarmBtn.Location = new System.Drawing.Point(351, 179);
            this.UXSetAlarmBtn.Margin = new System.Windows.Forms.Padding(4);
            this.UXSetAlarmBtn.Name = "UXSetAlarmBtn";
            this.UXSetAlarmBtn.Size = new System.Drawing.Size(114, 58);
            this.UXSetAlarmBtn.TabIndex = 1;
            this.UXSetAlarmBtn.Text = "Set";
            this.UXSetAlarmBtn.UseVisualStyleBackColor = true;
            this.UXSetAlarmBtn.Click += new System.EventHandler(this.UXSetAlarmBtn_Click);
            // 
            // UxCancelEditAlarmBtn
            // 
            this.UxCancelEditAlarmBtn.Location = new System.Drawing.Point(56, 179);
            this.UxCancelEditAlarmBtn.Margin = new System.Windows.Forms.Padding(4);
            this.UxCancelEditAlarmBtn.Name = "UxCancelEditAlarmBtn";
            this.UxCancelEditAlarmBtn.Size = new System.Drawing.Size(114, 58);
            this.UxCancelEditAlarmBtn.TabIndex = 2;
            this.UxCancelEditAlarmBtn.Text = "Cancel";
            this.UxCancelEditAlarmBtn.UseVisualStyleBackColor = true;
            this.UxCancelEditAlarmBtn.Click += new System.EventHandler(this.UxCancelEditAlarmBtn_Click);
            // 
            // UxAlarmOn
            // 
            this.UxAlarmOn.AutoSize = true;
            this.UxAlarmOn.Location = new System.Drawing.Point(393, 65);
            this.UxAlarmOn.Margin = new System.Windows.Forms.Padding(4);
            this.UxAlarmOn.Name = "UxAlarmOn";
            this.UxAlarmOn.Size = new System.Drawing.Size(72, 29);
            this.UxAlarmOn.TabIndex = 3;
            this.UxAlarmOn.Text = "On";
            this.UxAlarmOn.UseVisualStyleBackColor = true;
            // 
            // UxAlarmSounds
            // 
            this.UxAlarmSounds.FormattingEnabled = true;
            this.UxAlarmSounds.Location = new System.Drawing.Point(56, 120);
            this.UxAlarmSounds.Name = "UxAlarmSounds";
            this.UxAlarmSounds.Size = new System.Drawing.Size(139, 33);
            this.UxAlarmSounds.TabIndex = 4;
            // 
            // UxSnoozeInterval
            // 
            this.UxSnoozeInterval.Location = new System.Drawing.Point(393, 120);
            this.UxSnoozeInterval.Name = "UxSnoozeInterval";
            this.UxSnoozeInterval.Size = new System.Drawing.Size(72, 31);
            this.UxSnoozeInterval.TabIndex = 5;
            // 
            // UxSnoozeLabel1
            // 
            this.UxSnoozeLabel1.AutoSize = true;
            this.UxSnoozeLabel1.Location = new System.Drawing.Point(226, 122);
            this.UxSnoozeLabel1.Name = "UxSnoozeLabel1";
            this.UxSnoozeLabel1.Size = new System.Drawing.Size(161, 25);
            this.UxSnoozeLabel1.TabIndex = 6;
            this.UxSnoozeLabel1.Text = "Snooze Interval";
            // 
            // UxSnoozeLabel2
            // 
            this.UxSnoozeLabel2.AutoSize = true;
            this.UxSnoozeLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UxSnoozeLabel2.Location = new System.Drawing.Point(312, 147);
            this.UxSnoozeLabel2.Name = "UxSnoozeLabel2";
            this.UxSnoozeLabel2.Size = new System.Drawing.Size(75, 20);
            this.UxSnoozeLabel2.TabIndex = 7;
            this.UxSnoozeLabel2.Text = "(minutes)";
            // 
            // AddEditAlarm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 270);
            this.Controls.Add(this.UxSnoozeLabel2);
            this.Controls.Add(this.UxSnoozeLabel1);
            this.Controls.Add(this.UxSnoozeInterval);
            this.Controls.Add(this.UxAlarmSounds);
            this.Controls.Add(this.UxAlarmOn);
            this.Controls.Add(this.UxCancelEditAlarmBtn);
            this.Controls.Add(this.UXSetAlarmBtn);
            this.Controls.Add(this.UxAlarmTime);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AddEditAlarm";
            this.Text = "Add/Edit Alarm";
            ((System.ComponentModel.ISupportInitialize)(this.UxSnoozeInterval)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker UxAlarmTime;
        private System.Windows.Forms.Button UXSetAlarmBtn;
        private System.Windows.Forms.Button UxCancelEditAlarmBtn;
        private System.Windows.Forms.CheckBox UxAlarmOn;
        private System.Windows.Forms.ComboBox UxAlarmSounds;
        private System.Windows.Forms.NumericUpDown UxSnoozeInterval;
        private System.Windows.Forms.Label UxSnoozeLabel1;
        private System.Windows.Forms.Label UxSnoozeLabel2;
    }
}