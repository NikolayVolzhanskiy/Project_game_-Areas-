namespace Areas1
{
    public partial class Form1 : Form
    {
        int cell = 20, pPlayer = 0, d1, d2, np1 = 0, np2 = 0;
        Rectangle rect;
        Point tmppnt;
        bool mouseDown = false, nextPlayer = false;
        Bitmap snapshot;
        Bitmap tempDraw;
        Color color;
        Random rnd;

        public Form1()
        {
            InitializeComponent();
            rnd = new Random();
            snapshot = new Bitmap(pictureBox1.ClientRectangle.Width, this.ClientRectangle.Height);
            tempDraw = new Bitmap(snapshot);
            color = Color.LightGreen;
            rect = new Rectangle(0, 0, cell, cell);
            tmppnt = new Point();
        }

        private void drawrect(MouseEventArgs _e)
        {
            if (_e.X - tmppnt.X >= 0)
            {
                rect.Width = ((_e.X - tmppnt.X) / cell + 1) * cell;
            }
            else
            {
                rect.X = (_e.X / cell) * cell;
                rect.Width = ((tmppnt.X - rect.X) / cell + 1) * cell;
            }
            if (_e.Y - tmppnt.Y >= 0)
            {
                rect.Height = ((_e.Y - tmppnt.Y) / cell + 1) * cell;
            }
            else
            {
                rect.Y = (_e.Y / cell) * cell;
                rect.Height = ((tmppnt.Y - rect.Y) / cell + 1) * cell;
            }
        }

        private void Dice_Click(object sender, EventArgs e)
        {
            d1 = rnd.Next(1, 7);
            d2 = rnd.Next(1, 7);
            D1.Text = d1.ToString();
            D2.Text = d2.ToString();
            nextPlayer = true;
            switch (pPlayer)
            {
                case 0 or 2:
                    {
                        pPlayer = 1;
                        color = NP1.ForeColor;
                        np1 += d1 * d2;
                    }
                    break;
                case 1:
                    {
                        pPlayer = 2;
                        color = NP2.ForeColor;
                        np2 += d1 * d2;
                    }
                    break;
                default:
                    break;
            }
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (nextPlayer)
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
                nextPlayer = false;
                rect.Width = rect.Height = cell;
                snapshot = (Bitmap)tempDraw.Clone();
                switch (pPlayer)
                {
                    case 1:
                        {
                            NP1.Text = np1.ToString();
                        }
                        break;
                    case 2:
                        {
                            NP2.Text = np2.ToString();
                        }
                        break;
                    default:
                        break;
                }
            }
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (snapshot.GetPixel(e.X, e.Y).ToArgb() == 0)
            {
                if (mouseDown)
                {
                    drawrect(e);
                }
                else
                {
                    rect.X = (e.X / cell) * cell;
                    rect.Y = (e.Y / cell) * cell;
                }
            }
            pictureBox1.Refresh();
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            tempDraw = (Bitmap)snapshot.Clone();
            Graphics g = Graphics.FromImage(tempDraw);
            Brush brush = new SolidBrush(color);
            Pen myPen = new Pen(Color.Black, 1);
            g.FillRectangle(brush, rect);
            g.DrawRectangle(myPen, rect);
            brush.Dispose();
            e.Graphics.DrawImageUnscaled(tempDraw, 0, 0);
            g.Dispose();
        }
    }
}