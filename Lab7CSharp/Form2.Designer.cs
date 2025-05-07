using System.Windows.Forms;

namespace Lab7CSharp
{
    partial class Form2
    {
        private System.ComponentModel.IContainer components = null;

        private PictureBox pictureBox;
        private Button loadButton;
        private Button invertButton;
        private Button saveButton;
        private GroupBox inversionModeGroup;
        private RadioButton fullInversionRadio;
        private RadioButton redInversionRadio;
        private RadioButton greenInversionRadio;
        private RadioButton blueInversionRadio;

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
            this.loadButton = new Button();
            this.invertButton = new Button();
            this.saveButton = new Button();
            this.inversionModeGroup = new GroupBox();
            this.fullInversionRadio = new RadioButton();
            this.redInversionRadio = new RadioButton();
            this.greenInversionRadio = new RadioButton();
            this.blueInversionRadio = new RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.inversionModeGroup.SuspendLayout();
            this.SuspendLayout();

            // pictureBox
            this.pictureBox.Location = new System.Drawing.Point(170, 10);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(400, 300);
            this.pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            this.pictureBox.BorderStyle = BorderStyle.FixedSingle;
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;

            // loadButton
            this.loadButton.Location = new System.Drawing.Point(10, 10);
            this.loadButton.Name = "loadButton";
            this.loadButton.Size = new System.Drawing.Size(150, 30);
            this.loadButton.TabIndex = 1;
            this.loadButton.Text = "Завантажити зображення";
            this.loadButton.UseVisualStyleBackColor = true;
            this.loadButton.Click += new System.EventHandler(this.loadButton_Click);

            // invertButton
            this.invertButton.Location = new System.Drawing.Point(10, 50);
            this.invertButton.Name = "invertButton";
            this.invertButton.Size = new System.Drawing.Size(150, 30);
            this.invertButton.TabIndex = 2;
            this.invertButton.Text = "Інвертувати";
            this.invertButton.UseVisualStyleBackColor = true;
            this.invertButton.Enabled = false;
            this.invertButton.Click += new System.EventHandler(this.invertButton_Click);

            // saveButton
            this.saveButton.Location = new System.Drawing.Point(10, 90);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(150, 30);
            this.saveButton.TabIndex = 3;
            this.saveButton.Text = "Зберегти зображення";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Enabled = false;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);

            // inversionModeGroup
            this.inversionModeGroup.Controls.Add(this.fullInversionRadio);
            this.inversionModeGroup.Controls.Add(this.redInversionRadio);
            this.inversionModeGroup.Controls.Add(this.greenInversionRadio);
            this.inversionModeGroup.Controls.Add(this.blueInversionRadio);
            this.inversionModeGroup.Location = new System.Drawing.Point(10, 130);
            this.inversionModeGroup.Name = "inversionModeGroup";
            this.inversionModeGroup.Size = new System.Drawing.Size(150, 130);
            this.inversionModeGroup.TabIndex = 4;
            this.inversionModeGroup.TabStop = false;
            this.inversionModeGroup.Text = "Режим інверсії";

            // fullInversionRadio
            this.fullInversionRadio.AutoSize = true;
            this.fullInversionRadio.Location = new System.Drawing.Point(10, 20);
            this.fullInversionRadio.Name = "fullInversionRadio";
            this.fullInversionRadio.Size = new System.Drawing.Size(100, 17);
            this.fullInversionRadio.TabIndex = 0;
            this.fullInversionRadio.Text = "Повна інверсія";
            this.fullInversionRadio.UseVisualStyleBackColor = true;
            this.fullInversionRadio.Checked = true;

            // redInversionRadio
            this.redInversionRadio.AutoSize = true;
            this.redInversionRadio.Location = new System.Drawing.Point(10, 40);
            this.redInversionRadio.Name = "redInversionRadio";
            this.redInversionRadio.Size = new System.Drawing.Size(120, 17);
            this.redInversionRadio.TabIndex = 1;
            this.redInversionRadio.Text = "Інверсія червоного";
            this.redInversionRadio.UseVisualStyleBackColor = true;

            // greenInversionRadio
            this.greenInversionRadio.AutoSize = true;
            this.greenInversionRadio.Location = new System.Drawing.Point(10, 60);
            this.greenInversionRadio.Name = "greenInversionRadio";
            this.greenInversionRadio.Size = new System.Drawing.Size(120, 17);
            this.greenInversionRadio.TabIndex = 2;
            this.greenInversionRadio.Text = "Інверсія зеленого";
            this.greenInversionRadio.UseVisualStyleBackColor = true;

            // blueInversionRadio
            this.blueInversionRadio.AutoSize = true;
            this.blueInversionRadio.Location = new System.Drawing.Point(10, 80);
            this.blueInversionRadio.Name = "blueInversionRadio";
            this.blueInversionRadio.Size = new System.Drawing.Size(120, 17);
            this.blueInversionRadio.TabIndex = 3;
            this.blueInversionRadio.Text = "Інверсія синього";
            this.blueInversionRadio.UseVisualStyleBackColor = true;

            // Form2
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 400);
            this.Controls.Add(this.inversionModeGroup);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.invertButton);
            this.Controls.Add(this.loadButton);
            this.Controls.Add(this.pictureBox);
            this.Name = "Form2";
            this.Text = "Інверсія кольорів зображення";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.inversionModeGroup.ResumeLayout(false);
            this.inversionModeGroup.PerformLayout();
            this.ResumeLayout(false);
        }
    }
}