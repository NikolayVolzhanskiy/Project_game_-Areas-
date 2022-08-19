namespace Areas1
{
    public partial class Form1 : Form
    {
        int cell = 40, pPlayer = 0, d1, d2, np1 = 0, np2 = 0, max_d, min_d;
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

        private void clear_Click(object sender, EventArgs e)
        {
            np1 = np2 = 0;
            NP1.Text = np1.ToString();
            NP2.Text = np2.ToString();
            //pictureBox1.;
        }

        private void drawrect(MouseEventArgs _e)
        {
            double xx = _e.X - tmppnt.X;   //Растояние от курсора до точки клика по х
            double yy = _e.Y - tmppnt.Y;   //Растояние от курсора до точки клика по у
            int abs_xc = (int)Math.Abs(xx / cell);  //Модуль растояния по х в ячейках
            int abs_yc = (int)Math.Abs(yy / cell);  //Модуль растояния по у в ячейках
            // Если курсор в пределах значения минимальной стороны прямоугольника
            if (abs_xc < min_d && abs_yc < min_d)
            {
                if (xx >= 0)
                {
                    rect.Width = ((int)xx / cell + 1) * cell;
                }
                else
                {
                    rect.X = (_e.X / cell) * cell;
                    rect.Width = ((tmppnt.X - rect.X) / cell + 1) * cell;
                }
                if (yy >= 0)
                {
                    rect.Height = ((int)yy / cell + 1) * cell;
                }
                else
                {
                    rect.Y = (_e.Y / cell) * cell;
                    rect.Height = ((tmppnt.Y - rect.Y) / cell + 1) * cell;
                }
            }
            // Если курсор в пределах допустимого значения большей стороны прямоугольника относительно х
            if (abs_xc >= min_d && abs_xc < max_d)
            {
                if (abs_yc < min_d) // Если у меньше минимальной стороны
                {
                    if (xx >= 0)
                    {
                        rect.Width = ((int)xx / cell + 1) * cell;
                    }
                    else
                    {
                        rect.X = (_e.X / cell) * cell;
                        rect.Width = ((tmppnt.X - rect.X) / cell + 1) * cell;
                    }
                    if (yy >= 0)
                    {
                        rect.Height = ((int)yy / cell + 1) * cell;
                    }
                    else
                    {
                        rect.Y = (_e.Y / cell) * cell;
                        rect.Height = ((tmppnt.Y - rect.Y) / cell + 1) * cell;
                    }
                } else if (abs_yc < max_d)  // Если у меньше максимальной стороны
                {
                    if (xx / yy <= 1)
                    {
                        if (xx >= 0)
                        {
                            rect.Width = ((int)xx / cell + 1) * cell;
                        }
                        else
                        {
                            rect.X = (_e.X / cell) * cell;
                            rect.Width = ((tmppnt.X - rect.X) / cell + 1) * cell;
                        }
                        if (yy >= 0)
                        {
                            rect.Height = min_d * cell;
                        }
                        else
                        {
                            rect.Y = (tmppnt.Y / cell + 1 - min_d) * cell;
                            rect.Height = min_d * cell;
                        }
                    }
                    else
                    {
                        if (xx >= 0)
                        {
                            rect.Width = min_d * cell;
                        }
                        else
                        {
                            rect.X = (tmppnt.X / cell + 1 - min_d) * cell;
                            rect.Width = min_d * cell;
                        }
                        if (yy >= 0)
                        {
                            rect.Height = ((int)yy / cell + 1) * cell;
                        }
                        else
                        {
                            rect.Y = (_e.Y / cell) * cell;
                            rect.Height = ((tmppnt.Y - rect.Y) / cell + 1) * cell;
                        }
                    }
                }
            }
            // Если курсор выходит за пределы допустимых значений сторон прямоугольника. х и у
            if(abs_xc >= max_d)
            {
                if (xx >= 0)
                {
                    rect.Width = max_d * cell;
                }
                else
                {
                    rect.X = (tmppnt.X / cell + 1 - max_d) * cell;
                    rect.Width = max_d * cell;
                }
                if (yy >= 0)
                {
                    rect.Height = min_d * cell;
                }
                else
                {
                    rect.Y = (tmppnt.Y / cell + 1 - min_d) * cell;
                    rect.Height = min_d * cell;
                }
            }
            if (abs_yc >= max_d)
            {
                if (xx >= 0)
                {
                    rect.Width = min_d * cell;
                }
                else
                {
                    rect.X = (tmppnt.X / cell + 1 - min_d) * cell;
                    rect.Width = min_d * cell;
                }
                if (yy >= 0)
                {
                    rect.Height = max_d * cell;
                }
                else
                {
                    rect.Y = (tmppnt.Y / cell + 1 - max_d) * cell;
                    rect.Height = max_d * cell;
                }
            }
        }

        private void Dice_Click(object sender, EventArgs e)
        {
            d1 = rnd.Next(1, 7);
            d2 = rnd.Next(1, 7);
            max_d = Math.Max(d1, d2);
            min_d = Math.Min(d1, d2);
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
                tmppnt.X = e.X;
                tmppnt.Y = e.Y;
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
