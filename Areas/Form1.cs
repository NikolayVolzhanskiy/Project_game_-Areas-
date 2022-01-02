namespace Areas
{
    public partial class Form1 : Form
    {
        int cell = 20, pplayer = 0, d1, d2;
        Rectangle rect;
        List<Rectangle> rects;
        Point tmppnt;
        bool mouseDown, drawchek;
        Bitmap snapshot;
        Bitmap tempDraw;
        Color color;
        Random rnd;

        public Form1()
        {
            InitializeComponent();
            rnd = new Random();
            snapshot = new Bitmap(pictureBox1.ClientRectangle.Width, this.ClientRectangle.Height);
            color = Color.LightGreen;
            rect = new Rectangle(0, 0, cell, cell);
            tmppnt = new Point();
            rects = new List<Rectangle>();
        }

        private void Dice_Click(object sender, EventArgs e)
        {
            d1 = rnd.Next(1, 7);
            d2 = rnd.Next(1, 7);
            D1.Text = d1.ToString();
            D2.Text = d2.ToString();
            switch (pplayer)
            {
                case 0 or 2:
                    {
                        pplayer = 1;
                        color = NP1.ForeColor;
                    }
                    break;
                case 1:
                    {
                        pplayer = 2;
                        color = NP2.ForeColor;
                    }
                    break;
                default:
                    break;
            }
            //drawchek = true;
        }

        private bool outside(Rectangle _rect, List<Rectangle> _rects)
        {
            int chek = 0;
            for (int i = 0; i < _rects.Count; i++)
            {
                if (_rects[i].X <= _rect.X && _rects[i].Y <= _rect.Y && _rect.Width <= _rects[i].Width && _rect.Height <= _rects[i].Height)
                {
                    chek++;
                }
            }
            if (chek >= _rects.Count - 1)
            {
                return true;
            }
            return false;
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {

            if (outside(rect, rects))
            {
                mouseDown = true;
                tmppnt.X = (e.X / cell) * cell;
                tmppnt.Y = (e.Y / cell) * cell;
            }
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                mouseDown = false;
                rects.Add(rect);
                rect.Size = (Size)(new Point(cell));
                snapshot = (Bitmap)tempDraw.Clone();
            }
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                if (e.X - tmppnt.X >= 0)
                {
                    rect.Width = ((e.X - tmppnt.X) / cell + 1) * cell;
                }
                else
                {
                    rect.X = (e.X / cell) * cell;
                    rect.Width = ((tmppnt.X - rect.X) / cell + 1) * cell;
                }
                if (e.Y - tmppnt.Y >= 0)
                {
                    rect.Height = ((e.Y - tmppnt.Y) / cell + 1) * cell;
                }
                else
                {
                    rect.Y = (e.Y / cell) * cell;
                    rect.Height = ((tmppnt.Y - rect.Y) / cell + 1) * cell;
                }
            }
            else
            {
                rect.X = (e.X / cell) * cell;
                rect.Y = (e.Y / cell) * cell;
            }
            pictureBox1.Refresh();
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            tempDraw = (Bitmap)snapshot.Clone();
            Graphics g = Graphics.FromImage(tempDraw);
            Brush brush = new SolidBrush(color);
            g.FillRectangle(brush, rect);
            e.Graphics.DrawImageUnscaled(tempDraw, 0, 0);
            brush.Dispose();
            g.Dispose();
        }
    }
}