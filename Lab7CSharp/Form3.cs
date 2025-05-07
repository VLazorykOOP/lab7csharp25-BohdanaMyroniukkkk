using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace Lab7CSharp
{
    public partial class Form3 : Form
    {
        private List<Figure> figures = new List<Figure>();
        private Random random = new Random();

        public Form3()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(sizeTextBox.Text, out int size) || size <= 0)
            {
                MessageBox.Show("Введіть коректний розмір!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Color color = colorComboBox.SelectedIndex >= 0 ? GetColorFromIndex(colorComboBox.SelectedIndex) : Color.Black;
            string text = triangleTextTextBox.Text.Trim();

            Figure figure = null;
            int x = random.Next(0, pictureBox.Width - size);
            int y = random.Next(0, pictureBox.Height - size);

            switch (figureTypeComboBox.SelectedIndex)
            {
                case 0: // П’ятикутник
                    figure = new Pentagon(x, y, size, color);
                    break;
                case 1: // Ромб
                    figure = new Rhombus(x, y, size, color);
                    break;
                case 2: // Правильний трикутник з текстом
                    figure = new TriangleWithText(x, y, size, color, text);
                    break;
            }

            if (figure != null)
            {
                figures.Add(figure);
                RefreshPictureBox();
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            figures.Clear();
            pictureBox.Image = null;
        }

        private void moveButton_Click(object sender, EventArgs e)
        {
            foreach (var figure in figures)
            {
                int x = random.Next(0, pictureBox.Width - figure.Size);
                int y = random.Next(0, pictureBox.Height - figure.Size);
                figure.Move(x, y);
            }
            RefreshPictureBox();
        }

        private void RefreshPictureBox()
        {
            if (pictureBox.Image != null)
                pictureBox.Image.Dispose();

            Bitmap bitmap = new Bitmap(pictureBox.Width, pictureBox.Height);
            using (Graphics g = Graphics.FromImage(bitmap))
            {
                g.Clear(Color.White);
                foreach (var figure in figures)
                {
                    figure.Draw(g);
                }
            }
            pictureBox.Image = bitmap;
        }

        private Color GetColorFromIndex(int index)
        {
            switch (index)
            {
                case 0:
                    return Color.Red;
                case 1:
                    return Color.Green;
                case 2:
                    return Color.Blue;
                case 3:
                    return Color.Yellow;
                default:
                    return Color.Black;
            }
        }

        // Абстрактний базовий клас
        abstract class Figure
        {
            public int X { get; protected set; }
            public int Y { get; protected set; }
            public int Size { get; protected set; }
            public Color Color { get; protected set; }

            public Figure(int x, int y, int size, Color color)
            {
                X = x;
                Y = y;
                Size = size;
                Color = color;
            }

            public abstract void Draw(Graphics g);
            public virtual void Move(int newX, int newY)
            {
                X = newX;
                Y = newY;
            }
        }

        // П’ятикутник
        class Pentagon : Figure
        {
            public Pentagon(int x, int y, int size, Color color) : base(x, y, size, color) { }

            public override void Draw(Graphics g)
            {
                PointF[] points = new PointF[5];
                float radius = Size / 2f;
                for (int i = 0; i < 5; i++)
                {
                    float angle = (float)(2 * Math.PI * i / 5 - Math.PI / 2);
                    points[i] = new PointF(
                        X + radius + (float)(radius * Math.Cos(angle)),
                        Y + radius + (float)(radius * Math.Sin(angle))
                    );
                }
                using (SolidBrush brush = new SolidBrush(Color))
                {
                    g.FillPolygon(brush, points);
                }
            }
        }

        // Ромб
        class Rhombus : Figure
        {
            public Rhombus(int x, int y, int size, Color color) : base(x, y, size, color) { }

            public override void Draw(Graphics g)
            {
                Point[] points = new Point[4]
                {
                    new Point(X + Size / 2, Y),
                    new Point(X + Size, Y + Size / 2),
                    new Point(X + Size / 2, Y + Size),
                    new Point(X, Y + Size / 2)
                };
                using (SolidBrush brush = new SolidBrush(Color))
                {
                    g.FillPolygon(brush, points);
                }
            }
        }

        // Правильний трикутник з текстом
        class TriangleWithText : Figure
        {
            public string Text { get; set; }

            public TriangleWithText(int x, int y, int size, Color color, string text) : base(x, y, size, color)
            {
                Text = text;
            }

            public override void Draw(Graphics g)
            {
                Point[] points = new Point[3]
                {
                    new Point(X + Size / 2, Y),
                    new Point(X + Size, Y + Size),
                    new Point(X, Y + Size)
                };
                using (SolidBrush brush = new SolidBrush(Color))
                {
                    g.FillPolygon(brush, points);
                }
                using (SolidBrush textBrush = new SolidBrush(Color.White))
                using (StringFormat format = new StringFormat { Alignment = StringAlignment.Center, LineAlignment = StringAlignment.Center })
                {
                    g.DrawString(Text, new Font("Arial", 10), textBrush, new RectangleF(X, Y, Size, Size), format);
                }
            }
        }
    }
}