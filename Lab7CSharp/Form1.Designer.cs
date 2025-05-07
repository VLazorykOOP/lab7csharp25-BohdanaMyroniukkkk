using System.Windows.Forms;

namespace Lab7CSharp
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        private PictureBox pictureBox;
        private TextBox memo;
        private Button startButton;
        private Button stopButton;
        private Timer timer;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pictureBox = new PictureBox();
            this.memo = new TextBox();
            this.startButton = new Button();
            this.stopButton = new Button();
            this.timer = new Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();

            // pictureBox
            this.pictureBox.Location = new System.Drawing.Point(170, 10);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(400, 300);
            this.pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            this.pictureBox.BorderStyle = BorderStyle.FixedSingle;
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;

            // memo
            this.memo.Location = new System.Drawing.Point(10, 10);
            this.memo.Multiline = true;
            this.memo.Name = "memo";
            this.memo.ScrollBars = ScrollBars.Vertical;
            this.memo.Size = new System.Drawing.Size(150, 100);
            this.memo.TabIndex = 1;

            // startButton
            this.startButton.Location = new System.Drawing.Point(10, 120);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(70, 30);
            this.startButton.TabIndex = 2;
            this.startButton.Text = "Старт";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);

            // stopButton
            this.stopButton.Location = new System.Drawing.Point(90, 120);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(70, 30);
            this.stopButton.TabIndex = 3;
            this.stopButton.Text = "Стоп";
            this.stopButton.UseVisualStyleBackColor = true;
            this.stopButton.Enabled = false;
            this.stopButton.Click += new System.EventHandler(this.stopButton_Click);

            // timer
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);

            // Form1
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 400);
            this.Controls.Add(this.stopButton);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.memo);
            this.Controls.Add(this.pictureBox);
            this.Name = "Form1";
            this.Text = "Циклічне виведення метафайлів";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}