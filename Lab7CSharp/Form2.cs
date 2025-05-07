using System;
using System.Drawing;
using System.Windows.Forms;

namespace Lab7CSharp
{
    public partial class Form2 : Form
    {
        private Bitmap originalImage;
        private Bitmap invertedImage;

        public Form2()
        {
            InitializeComponent();
        }

        private void loadButton_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "BMP files (*.bmp)|*.bmp";
                openFileDialog.Title = "Виберіть зображення у форматі BMP";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        originalImage = new Bitmap(openFileDialog.FileName);
                        pictureBox.Image = originalImage;
                        invertButton.Enabled = true;
                        saveButton.Enabled = false;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Помилка при завантаженні зображення: {ex.Message}", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void invertButton_Click(object sender, EventArgs e)
        {
            if (originalImage == null)
            {
                MessageBox.Show("Спочатку завантажте зображення!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            invertedImage = new Bitmap(originalImage.Width, originalImage.Height);

            for (int x = 0; x < originalImage.Width; x++)
            {
                for (int y = 0; y < originalImage.Height; y++)
                {
                    Color pixelColor = originalImage.GetPixel(x, y);
                    Color newColor;

                    if (fullInversionRadio.Checked)
                    {
                        newColor = Color.FromArgb(255 - pixelColor.R, 255 - pixelColor.G, 255 - pixelColor.B);
                    }
                    else if (redInversionRadio.Checked)
                    {
                        newColor = Color.FromArgb(255 - pixelColor.R, pixelColor.G, pixelColor.B);
                    }
                    else if (greenInversionRadio.Checked)
                    {
                        newColor = Color.FromArgb(pixelColor.R, 255 - pixelColor.G, pixelColor.B);
                    }
                    else // blueInversionRadio.Checked
                    {
                        newColor = Color.FromArgb(pixelColor.R, pixelColor.G, 255 - pixelColor.B);
                    }

                    invertedImage.SetPixel(x, y, newColor);
                }
            }

            pictureBox.Image = invertedImage;
            saveButton.Enabled = true;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (invertedImage == null)
            {
                MessageBox.Show("Спочатку інвертуйте зображення!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "BMP files (*.bmp)|*.bmp";
                saveFileDialog.Title = "Збережіть інвертоване зображення";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        invertedImage.Save(saveFileDialog.FileName, System.Drawing.Imaging.ImageFormat.Bmp);
                        MessageBox.Show("Зображення успішно збережено!", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Помилка при збереженні зображення: {ex.Message}", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}