using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tao.FreeGlut;
using Tao.OpenGl;
using Tao.Platform;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;

namespace fractal_v2._0
{
    public partial class Form1 : Form
    {

        Pair[] ABCD;
        Pair X0;
        int n, ni=0;
        Pair q;
        Pair[] Xi;
        double zoom = 1, a=0, b=0;

        private class Pair
        {
            public double x { set; get; }
            public double y { set; get; }
            public Pair()
            {
            }
            public Pair(double x, double y)
            {
                this.y = y;
                this.x = x;
            }
        }
        public Form1()
        {
            InitializeComponent();
            fractPicture.InitializeContexts();
        }

        private void calc_fract()
        {


            Random rnd = new Random();
            Xi = new Pair[n];
            Xi[0] = X0;

            for (int i = 1; i < n; i++)
            {

                Pair forRandom = ABCD[rnd.Next(0, 4)];
                Xi[i] = new Pair();
                Xi[i].x = Xi[i - 1].x+(forRandom.x - Xi[i - 1].x) / q.x * q.y;
                Xi[i].y = Xi[i - 1].y+(forRandom.y - Xi[i - 1].y) / q.x * q.y;

                //Xi[i].x = (forRandom.x - Xi[i - 1].x) / q.x * q.y;
                //Xi[i].y = (forRandom.y - Xi[i - 1].y) / q.x * q.y;
            }

            
        }

        private void Draw_fract() {
            //calc_fract();
            Gl.glClear(Gl.GL_COLOR_BUFFER_BIT | Gl.GL_DEPTH_BUFFER_BIT);
            Gl.glClearColor(255, 255, 255, 1);
            Gl.glLoadIdentity();
            Gl.glPushMatrix();
            Gl.glScaled(zoom, zoom, 0);
            Gl.glTranslated(a-1, b-1, 0);
            
            Gl.glColor3d(0, 0, 0);
            Gl.glBegin(Gl.GL_POINTS);
            Gl.glVertex2d(ABCD[0].x, ABCD[0].y);
            Gl.glVertex2d(ABCD[1].x, ABCD[1].y);
            Gl.glVertex2d(ABCD[2].x, ABCD[2].y);
            Gl.glVertex2d(ABCD[3].x, ABCD[3].y);
            Gl.glVertex2d(X0.x, X0.y);
            for (int i = 1; i < ni; i++)
            {
                //Gl.glColor3i(rnd.Next(0, 255), rnd.Next(0, 255), rnd.Next(0, 255));
                Gl.glVertex2d(Xi[i].x, Xi[i].y);
            }
            Gl.glEnd();
            Gl.glPopMatrix();
            Gl.glFlush();
            fractPicture.Invalidate();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Glut.glutInit();
            Glut.glutInitDisplayMode(Glut.GLUT_RGB | Glut.GLUT_DOUBLE);
            Gl.glClearColor(255, 255, 255, 1);
            Gl.glViewport(0, 0, fractPicture.Width, fractPicture.Height);
            Gl.glMatrixMode(Gl.GL_PROJECTION);
            Gl.glLoadIdentity();
            Glu.gluOrtho2D(0, (float)(fractPicture.Width), 0, (float)(fractPicture.Height));
            Gl.glLoadIdentity();
            Gl.glClear(Gl.GL_COLOR_BUFFER_BIT);
            fractPicture.Invalidate();
        }

        private void StarterButton_Click(object sender, EventArgs e)
        {
            zoom = 1;
            a = 0;
            b = 0;
            ni = 0;
            String[] Save;
            ABCD = new Pair[4];
            Save = A_box.Text.Split(' ');
            ABCD[0] = new Pair(Double.Parse(Save[0]), Double.Parse(Save[1]));
            Save = B_box.Text.Split(' ');
            ABCD[1] = new Pair(Double.Parse(Save[0]), Double.Parse(Save[1]));
            Save = C_box.Text.Split(' ');
            ABCD[2] = new Pair(Double.Parse(Save[0]), Double.Parse(Save[1]));
            Save = D_box.Text.Split(' ');
            ABCD[3] = new Pair(Double.Parse(Save[0]), Double.Parse(Save[1]));
            Save = forX0.Text.Split(' ');
            X0 = new Pair(Double.Parse(Save[0]), Double.Parse(Save[1]));
            n = Int32.Parse(count.Text);
            Save = qi.Text.Split('/');
            q = new Pair((Double.Parse(Save[0]) + Double.Parse(Save[1])), Double.Parse(Save[0]));
            rander.Enabled = true;
            calc_fract();
            Draw_fract();
            
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            try
            {
                rander.Enabled = false;
                SaveFileDialog saveFileDialog1 = new SaveFileDialog();
                saveFileDialog1.Filter = "JPeg Image|*.jpg|Bitmap Image|*.bmp|Gif Image|*.gif";
                saveFileDialog1.Title = "Save an Image File";
                saveFileDialog1.ShowDialog();
                Gl.glClear(Gl.GL_COLOR_BUFFER_BIT | Gl.GL_DEPTH_BUFFER_BIT);
                //Gl.glViewport(0, 0, 900, 900);
                Gl.glClearColor(255, 255, 255, 1);
                Gl.glLoadIdentity();
                Gl.glPushMatrix();
                Gl.glScaled(1, 1, 0);
                Gl.glTranslated(-1, -1, 0);

                Gl.glColor3d(0, 0, 0);
                Gl.glBegin(Gl.GL_POINTS);
                Gl.glVertex2d(ABCD[0].x, ABCD[0].y);
                Gl.glVertex2d(ABCD[1].x, ABCD[1].y);
                Gl.glVertex2d(ABCD[2].x, ABCD[2].y);
                Gl.glVertex2d(ABCD[3].x, ABCD[3].y);
                Gl.glVertex2d(X0.x, X0.y);
                for (int i = 1; i < n; i++)
                    Gl.glVertex2d(Xi[i].x, Xi[i].y);
                Gl.glEnd();
                Gl.glPopMatrix();
                Gl.glFlush();
                Bitmap image = new Bitmap(500, 500);
                BitmapData imgData = image.LockBits(new Rectangle(0, 0, image.Width, image.Height), ImageLockMode.WriteOnly, PixelFormat.Format32bppArgb);

                Gl.glPushClientAttrib(Gl.GL_CLIENT_PIXEL_STORE_BIT);
                Gl.glPixelStoref(Gl.GL_PACK_ALIGNMENT, 4);

                Gl.glReadPixels(0, 0, image.Width, image.Height, Gl.GL_BGRA, Gl.GL_UNSIGNED_BYTE, imgData.Scan0);
                Gl.glPopClientAttrib();
                image.RotateFlip(RotateFlipType.Rotate180FlipX);
                image.Save(saveFileDialog1.FileName);
                rander.Enabled = true;
            }
            catch (Exception) {
                rander.Enabled = true;
            }
        }

        private void BigFuckigZoom_Scroll(object sender, EventArgs e)
        {
            zoom = (BigFuckigZoom.Value / 1000.0);
        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            b = trackBar2.Value / 1000.0;
        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void up_Click(object sender, EventArgs e)
        {
            b =b+ 0.01;
        }

        private void down_Click(object sender, EventArgs e)
        {
            b =b- 0.01;
        }

        private void left_Click(object sender, EventArgs e)
        {
            a =a- 0.01;
        }

        private void right_Click(object sender, EventArgs e)
        {
            a =a+ 0.01;
        }

        private void plus_Click(object sender, EventArgs e)
        {
            zoom = zoom+ 0.05;
        }

        private void minus_Click(object sender, EventArgs e)
        {
            zoom =zoom- 0.05;
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            a = trackBar1.Value / 1000.0;
        }

        private void rander_Tick(object sender, EventArgs e)
        {
            /*
            if (GetAsyncKeyState(Keys.Up) == -32767)
                b = b + 0.01;
            if (GetAsyncKeyState(Keys.Down) == -32767)
                b = b - 0.01;
            if (GetAsyncKeyState(Keys.Left) == -32767)
                a = a - 0.01;
            if (GetAsyncKeyState(Keys.Right) == -32767)
                a = a + 0.01;
            if (GetAsyncKeyState(Keys.PageUp) == -32767)
                zoom = zoom + 0.05;
            if (GetAsyncKeyState(Keys.PageDown) == -32767)
                zoom = zoom - 0.05;
               */
            Draw_fract();
            if (ni != n) ++ni;
        }

        private void skip_Click(object sender, EventArgs e)
        {
            ni = n;
        }

    }
}
