namespace Areas
{
    public partial class Form1 : Form
    {
        int cell = 20, pplayer = 0, d1, d2;
        Rectangle rect;
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

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            /*
            mouseDown = true;
            rect.X = (int)(e.X / cell);
            rect.Y = (int)(e.Y / cell);
            */
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            //if (!mouseDown)
            //{
                rect.X = (int)(e.X / cell) * cell;
                rect.Y = (int)(e.Y / cell) * cell;
            //}
            //rect.Width = (int)(e.X / cell + 1);
            //rect.Height = (int)(e.Y / cell + 1);
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