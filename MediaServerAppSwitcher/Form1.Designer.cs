namespace MediaServerAppSwitcher
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.stopTimerButton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.startTimerButton = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.status = new System.Windows.Forms.Label();
            this.timerStatus = new System.Windows.Forms.Label();
            this.secondsOneLabel = new System.Windows.Forms.Label();
            this.secondsTwoLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // stopTimerButton
            // 
            this.stopTimerButton.Enabled = false;
            this.stopTimerButton.Location = new System.Drawing.Point(264, 130);
            this.stopTimerButton.Name = "stopTimerButton";
            this.stopTimerButton.Size = new System.Drawing.Size(75, 23);
            this.stopTimerButton.TabIndex = 7;
            this.stopTimerButton.Text = "Stop timer";
            this.stopTimerButton.UseVisualStyleBackColor = true;
            this.stopTimerButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(264, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 3;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 407);
            this.listBox1.TabIndex = 1;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(138, 12);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(120, 407);
            this.listBox2.TabIndex = 2;
            this.listBox2.SelectedIndexChanged += new System.EventHandler(this.listBox2_SelectedIndexChanged);
            // 
            // startTimerButton
            // 
            this.startTimerButton.Enabled = false;
            this.startTimerButton.Location = new System.Drawing.Point(264, 101);
            this.startTimerButton.Name = "startTimerButton";
            this.startTimerButton.Size = new System.Drawing.Size(75, 23);
            this.startTimerButton.TabIndex = 6;
            this.startTimerButton.Text = "Start timer";
            this.startTimerButton.UseVisualStyleBackColor = true;
            this.startTimerButton.Click += new System.EventHandler(this.startTimerButton_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(264, 39);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 4;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(264, 66);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 5;
            this.saveButton.Text = "Save all";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // status
            // 
            this.status.AutoSize = true;
            this.status.Location = new System.Drawing.Point(346, 71);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(56, 13);
            this.status.TabIndex = 7;
            this.status.Text = "Not saved";
            this.status.Click += new System.EventHandler(this.status_Click);
            // 
            // timerStatus
            // 
            this.timerStatus.AutoSize = true;
            this.timerStatus.Location = new System.Drawing.Point(12, 428);
            this.timerStatus.Name = "timerStatus";
            this.timerStatus.Size = new System.Drawing.Size(84, 13);
            this.timerStatus.TabIndex = 8;
            this.timerStatus.Text = "Timer is stopped";
            // 
            // secondsOneLabel
            // 
            this.secondsOneLabel.AutoSize = true;
            this.secondsOneLabel.Location = new System.Drawing.Point(371, 15);
            this.secondsOneLabel.Name = "secondsOneLabel";
            this.secondsOneLabel.Size = new System.Drawing.Size(166, 13);
            this.secondsOneLabel.TabIndex = 9;
            this.secondsOneLabel.Text = "Duration of first window (seconds)";
            this.secondsOneLabel.Click += new System.EventHandler(this.secondsOneLabel_Click);
            // 
            // secondsTwoLabel
            // 
            this.secondsTwoLabel.AutoSize = true;
            this.secondsTwoLabel.Location = new System.Drawing.Point(371, 42);
            this.secondsTwoLabel.Name = "secondsTwoLabel";
            this.secondsTwoLabel.Size = new System.Drawing.Size(185, 13);
            this.secondsTwoLabel.TabIndex = 10;
            this.secondsTwoLabel.Text = "Duration of second window (seconds)";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.secondsTwoLabel);
            this.Controls.Add(this.secondsOneLabel);
            this.Controls.Add(this.timerStatus);
            this.Controls.Add(this.status);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.startTimerButton);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.stopTimerButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.Button stopTimerButton;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Button startTimerButton;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Label status;
        private System.Windows.Forms.Label timerStatus;
        private System.Windows.Forms.Label secondsOneLabel;
        private System.Windows.Forms.Label secondsTwoLabel;
    }
}

