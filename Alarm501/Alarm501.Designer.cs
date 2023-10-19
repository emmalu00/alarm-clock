namespace Alarm501
{
    partial class Alarm501
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
            this.UxEditBtn = new System.Windows.Forms.Button();
            this.UxAddBtn = new System.Windows.Forms.Button();
            this.UxAlarmList = new System.Windows.Forms.ListBox();
            this.UxSnoozeBtn = new System.Windows.Forms.Button();
            this.UxStopBtn = new System.Windows.Forms.Button();
            this.UxWelcomeLabel = new System.Windows.Forms.Label();
            this.uxRingingLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // UxEditBtn
            // 
            this.UxEditBtn.Location = new System.Drawing.Point(48, 33);
            this.UxEditBtn.Margin = new System.Windows.Forms.Padding(4);
            this.UxEditBtn.Name = "UxEditBtn";
            this.UxEditBtn.Size = new System.Drawing.Size(144, 71);
            this.UxEditBtn.TabIndex = 0;
            this.UxEditBtn.Text = "Edit";
            this.UxEditBtn.UseVisualStyleBackColor = true;
            this.UxEditBtn.Click += new System.EventHandler(this.UxEditBtn_Click);
            // 
            // UxAddBtn
            // 
            this.UxAddBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UxAddBtn.Location = new System.Drawing.Point(1030, 33);
            this.UxAddBtn.Margin = new System.Windows.Forms.Padding(4);
            this.UxAddBtn.Name = "UxAddBtn";
            this.UxAddBtn.Size = new System.Drawing.Size(140, 71);
            this.UxAddBtn.TabIndex = 1;
            this.UxAddBtn.Text = "+";
            this.UxAddBtn.UseVisualStyleBackColor = true;
            this.UxAddBtn.Click += new System.EventHandler(this.UxAddBtn_Click);
            // 
            // UxAlarmList
            // 
            this.UxAlarmList.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UxAlarmList.FormattingEnabled = true;
            this.UxAlarmList.ItemHeight = 46;
            this.UxAlarmList.Location = new System.Drawing.Point(48, 167);
            this.UxAlarmList.Margin = new System.Windows.Forms.Padding(4);
            this.UxAlarmList.Name = "UxAlarmList";
            this.UxAlarmList.ScrollAlwaysVisible = true;
            this.UxAlarmList.Size = new System.Drawing.Size(1122, 280);
            this.UxAlarmList.TabIndex = 2;
            // 
            // UxSnoozeBtn
            // 
            this.UxSnoozeBtn.Location = new System.Drawing.Point(48, 573);
            this.UxSnoozeBtn.Margin = new System.Windows.Forms.Padding(4);
            this.UxSnoozeBtn.Name = "UxSnoozeBtn";
            this.UxSnoozeBtn.Size = new System.Drawing.Size(144, 71);
            this.UxSnoozeBtn.TabIndex = 3;
            this.UxSnoozeBtn.Text = "Snooze";
            this.UxSnoozeBtn.UseVisualStyleBackColor = true;
            this.UxSnoozeBtn.Click += new System.EventHandler(this.UxSnoozeBtn_Click);
            // 
            // UxStopBtn
            // 
            this.UxStopBtn.Location = new System.Drawing.Point(1026, 573);
            this.UxStopBtn.Margin = new System.Windows.Forms.Padding(4);
            this.UxStopBtn.Name = "UxStopBtn";
            this.UxStopBtn.Size = new System.Drawing.Size(144, 71);
            this.UxStopBtn.TabIndex = 4;
            this.UxStopBtn.Text = "Stop";
            this.UxStopBtn.UseVisualStyleBackColor = true;
            this.UxStopBtn.Click += new System.EventHandler(this.UxStopBtn_Click);
            // 
            // UxWelcomeLabel
            // 
            this.UxWelcomeLabel.AutoSize = true;
            this.UxWelcomeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.UxWelcomeLabel.Location = new System.Drawing.Point(377, 50);
            this.UxWelcomeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.UxWelcomeLabel.Name = "UxWelcomeLabel";
            this.UxWelcomeLabel.Size = new System.Drawing.Size(474, 31);
            this.UxWelcomeLabel.TabIndex = 6;
            this.UxWelcomeLabel.Text = "Welcome to Your Alarm Manager :) ";
            // 
            // uxRingingLabel
            // 
            this.uxRingingLabel.AutoSize = true;
            this.uxRingingLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxRingingLabel.Location = new System.Drawing.Point(41, 474);
            this.uxRingingLabel.Name = "uxRingingLabel";
            this.uxRingingLabel.Size = new System.Drawing.Size(550, 42);
            this.uxRingingLabel.TabIndex = 7;
            this.uxRingingLabel.Text = "No Alarms Currently Going Off";
            // 
            // Alarm501
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1222, 690);
            this.Controls.Add(this.uxRingingLabel);
            this.Controls.Add(this.UxWelcomeLabel);
            this.Controls.Add(this.UxStopBtn);
            this.Controls.Add(this.UxSnoozeBtn);
            this.Controls.Add(this.UxAlarmList);
            this.Controls.Add(this.UxAddBtn);
            this.Controls.Add(this.UxEditBtn);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Alarm501";
            this.Text = "Alarm501";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Alarm501_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button UxEditBtn;
        private System.Windows.Forms.Button UxAddBtn;
        private System.Windows.Forms.ListBox UxAlarmList;
        private System.Windows.Forms.Button UxSnoozeBtn;
        private System.Windows.Forms.Button UxStopBtn;
        private System.Windows.Forms.Label UxWelcomeLabel;
        private System.Windows.Forms.Label uxRingingLabel;
    }
}

