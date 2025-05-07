using System.Windows.Forms;

namespace Lab7CSharp
{
    partial class Form3
    {
        private System.ComponentModel.IContainer components = null;

        private PictureBox pictureBox;
        private Button addButton;
        private Button clearButton;
        private Button moveButton;
        private ComboBox figureTypeComboBox;
        private TextBox sizeTextBox;
        private ComboBox colorComboBox;
        private TextBox triangleTextTextBox;
        private Label figureTypeLabel;
        private Label sizeLabel;
        private Label colorLabel;
        private Label triangleTextLabel;

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
            this.pictureBox = new PictureBox();
            this.addButton = new Button();
            this.clearButton = new Button();
            this.moveButton = new Button();
            this.figureTypeComboBox = new ComboBox();
            this.sizeTextBox = new TextBox();
            this.colorComboBox = new ComboBox();
            this.triangleTextTextBox = new TextBox();
            this.figureTypeLabel = new Label();
            this.sizeLabel = new Label();
            this.colorLabel = new Label();
            this.triangleTextLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();

            // pictureBox
            this.pictureBox.Location = new System.Drawing.Point(200, 10);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(400, 400);
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;

            // addButton
            this.addButton.Location = new System.Drawing.Point(10, 350);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(180, 30);
            this.addButton.TabIndex = 1;
            this.addButton.Text = "Додати фігуру";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);

            // clearButton
            this.clearButton.Location = new System.Drawing.Point(10, 390);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(180, 30);
            this.clearButton.TabIndex = 2;
            this.clearButton.Text = "Очистити";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);

            // moveButton
            this.moveButton.Location = new System.Drawing.Point(10, 430);
            this.moveButton.Name = "moveButton";
            this.moveButton.Size = new System.Drawing.Size(180, 30);
            this.moveButton.TabIndex = 3;
            this.moveButton.Text = "Перемістити";
            this.moveButton.UseVisualStyleBackColor = true;
            this.moveButton.Click += new System.EventHandler(this.moveButton_Click);

            // figureTypeComboBox
            this.figureTypeComboBox.FormattingEnabled = true;
            this.figureTypeComboBox.Items.AddRange(new object[] { "П’ятикутник", "Ромб", "Трикутник з текстом" });
            this.figureTypeComboBox.Location = new System.Drawing.Point(100, 10);
            this.figureTypeComboBox.Name = "figureTypeComboBox";
            this.figureTypeComboBox.Size = new System.Drawing.Size(90, 21);
            this.figureTypeComboBox.TabIndex = 4;

            // sizeTextBox
            this.sizeTextBox.Location = new System.Drawing.Point(100, 40);
            this.sizeTextBox.Name = "sizeTextBox";
            this.sizeTextBox.Size = new System.Drawing.Size(90, 20);
            this.sizeTextBox.TabIndex = 5;

            // colorComboBox
            this.colorComboBox.FormattingEnabled = true;
            this.colorComboBox.Items.AddRange(new object[] { "Червоний", "Зелений", "Синій", "Жовтий" });
            this.colorComboBox.Location = new System.Drawing.Point(100, 70);
            this.colorComboBox.Name = "colorComboBox";
            this.colorComboBox.Size = new System.Drawing.Size(90, 21);
            this.colorComboBox.TabIndex = 6;

            // triangleTextTextBox
            this.triangleTextTextBox.Location = new System.Drawing.Point(100, 100);
            this.triangleTextTextBox.Name = "triangleTextTextBox";
            this.triangleTextTextBox.Size = new System.Drawing.Size(90, 20);
            this.triangleTextTextBox.TabIndex = 7;

            // figureTypeLabel
            this.figureTypeLabel.AutoSize = true;
            this.figureTypeLabel.Location = new System.Drawing.Point(10, 13);
            this.figureTypeLabel.Name = "figureTypeLabel";
            this.figureTypeLabel.Size = new System.Drawing.Size(84, 13);
            this.figureTypeLabel.TabIndex = 8;
            this.figureTypeLabel.Text = "Тип фігури:";

            // sizeLabel
            this.sizeLabel.AutoSize = true;
            this.sizeLabel.Location = new System.Drawing.Point(10, 43);
            this.sizeLabel.Name = "sizeLabel";
            this.sizeLabel.Size = new System.Drawing.Size(45, 13);
            this.sizeLabel.TabIndex = 9;
            this.sizeLabel.Text = "Розмір:";

            // colorLabel
            this.colorLabel.AutoSize = true;
            this.colorLabel.Location = new System.Drawing.Point(10, 73);
            this.colorLabel.Name = "colorLabel";
            this.colorLabel.Size = new System.Drawing.Size(39, 13);
            this.colorLabel.TabIndex = 10;
            this.colorLabel.Text = "Колір:";

            // triangleTextLabel
            this.triangleTextLabel.AutoSize = true;
            this.triangleTextLabel.Location = new System.Drawing.Point(10, 103);
            this.triangleTextLabel.Name = "triangleTextLabel";
            this.triangleTextLabel.Size = new System.Drawing.Size(36, 13);
            this.triangleTextLabel.TabIndex = 11;
            this.triangleTextLabel.Text = "Текст:";

            // Form3
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 470);
            this.Controls.Add(this.triangleTextLabel);
            this.Controls.Add(this.colorLabel);
            this.Controls.Add(this.sizeLabel);
            this.Controls.Add(this.figureTypeLabel);
            this.Controls.Add(this.triangleTextTextBox);
            this.Controls.Add(this.colorComboBox);
            this.Controls.Add(this.sizeTextBox);
            this.Controls.Add(this.figureTypeComboBox);
            this.Controls.Add(this.moveButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.pictureBox);
            this.Name = "Form3";
            this.Text = "Малюнок з фігур";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}