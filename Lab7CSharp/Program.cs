using System;
using System.Windows.Forms;

namespace Lab7CSharp
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            DialogResult result = MessageBox.Show("Запустити Form3 (малюнок з фігур)?\nНатисніть 'Так' для Form3, 'Ні' для Form2, 'Скасувати' для Form1.",
                "Вибір форми",
                MessageBoxButtons.YesNoCancel,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Run(new Form3());
            }
            else if (result == DialogResult.No)
            {
                Application.Run(new Form2());
            }
            else
            {
                Application.Run(new Form1());
            }
        }
    }
}