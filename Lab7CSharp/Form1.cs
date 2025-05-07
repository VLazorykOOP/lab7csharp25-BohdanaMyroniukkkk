using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;

namespace Lab7CSharp
{
    public partial class Form1 : Form
    {
        private string[] imagePaths;
        private int currentImageIndex = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(memo.Text))
            {
                MessageBox.Show("Введіть шляхи до метафайлів у текстове поле!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            imagePaths = memo.Lines;
            currentImageIndex = 0;

            // Перевірка, чи є хоча б один дійсний файл
            bool hasValidFile = false;
            foreach (string path in imagePaths)
            {
                if (!string.IsNullOrWhiteSpace(path) && File.Exists(path))
                {
                    hasValidFile = true;
                    break;
                }
            }

            if (!hasValidFile)
            {
                MessageBox.Show("Жоден із вказаних файлів не існує! Перевірте шляхи.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                DisplayImage();
                timer.Start();
                startButton.Enabled = false;
                stopButton.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Помилка при запуску: {ex.Message}", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                timer.Stop();
                startButton.Enabled = true;
                stopButton.Enabled = false;
            }
        }

        private void stopButton_Click(object sender, EventArgs e)
        {
            timer.Stop();
            startButton.Enabled = true;
            stopButton.Enabled = false;
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            currentImageIndex = (currentImageIndex + 1) % imagePaths.Length;
            DisplayImage();
        }

        private void DisplayImage()
        {
            // Перевіряємо, чи є що відображати
            if (imagePaths.Length == 0 || string.IsNullOrWhiteSpace(imagePaths[currentImageIndex]))
            {
                currentImageIndex = (currentImageIndex + 1) % imagePaths.Length; // Пропускаємо порожні записи
                return;
            }

            try
            {
                // Перевіряємо, чи файл існує
                if (!File.Exists(imagePaths[currentImageIndex]))
                {
                    // Пропускаємо файл, який не існує
                    currentImageIndex = (currentImageIndex + 1) % imagePaths.Length;
                    return;
                }

                pictureBox.Image = Image.FromFile(imagePaths[currentImageIndex]);
            }
            catch (Exception ex)
            {
                // Показуємо помилку лише один раз, потім пропускаємо файл
                MessageBox.Show($"Помилка при завантаженні зображення {imagePaths[currentImageIndex]}: {ex.Message}", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                currentImageIndex = (currentImageIndex + 1) % imagePaths.Length; // Переходимо до наступного файлу
            }
        }
    }
}