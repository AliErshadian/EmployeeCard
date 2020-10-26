using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MessagingToolkit.UI;

namespace employeeCardCreate
{
    public partial class ImageEditing : Form
    {
        public int a;
        public Bitmap Bmpp;
        public Bitmap BmppFinall;
        Rectangle rect;
        private Point RectStartPoint;
        private Brush selectionBrush = new SolidBrush(Color.FromArgb(128, 72, 145, 220));

        public ImageEditing()
        {
            InitializeComponent();
        }
        public Bitmap CropImage(Bitmap source, Rectangle section)
        {
            Bitmap bmp = new Bitmap(section.Width, section.Height);

            Graphics g = Graphics.FromImage(bmp);

            g.DrawImage(source, 0, 0, section, GraphicsUnit.Pixel);

            return bmp;
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            RectStartPoint  = e.Location;
            Invalidate();
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
                return;
            Point tempEndPoint = e.Location;
            rect.Location =
                new Point(
                    Math.Min(RectStartPoint.X, tempEndPoint.X),
                    Math.Min(RectStartPoint.Y, tempEndPoint.Y)
                    );
            rect.Size=
                new Size(
                    Math.Abs(RectStartPoint.X - tempEndPoint.X),
                    Math.Abs(RectStartPoint.Y - tempEndPoint.Y)
                    );
                    

            pictureBox1.Invalidate();
        }

        private void ImageEditing_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (a == 1)
            {
                newCard.newbmp2 = BmppFinall == null ? new Bitmap(Bmpp, 90, 120) : new Bitmap(BmppFinall, 90, 120);
            }
            if (a == 2)
            {
                newCard2.newbmp2 = BmppFinall == null ? new Bitmap(Bmpp, 90, 120) : new Bitmap(BmppFinall, 90, 120);
            }
        }

        private void ImageEditing_Load(object sender, EventArgs e)
        {
            pictureBox1.Image = new Bitmap(Bmpp, 401, 478);
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            if (pictureBox1.Image != null)
            {
                if (rect != null && rect.Width > 0 && rect.Height > 0)
                {
                    e.Graphics.FillRectangle(selectionBrush, rect);
                }
            }
        }

        private void ImageEditing_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {

                    Bitmap img = new Bitmap(pictureBox1.Image);


                    // Crop the image and save it
                    img = CropImage(img, rect);
                    pictureBox1.Image = new Bitmap(img, 401, 478);
                    rect = Rectangle.Empty;
                    pictureBox1.Invalidate();
                    BmppFinall = img;
                }
                catch
                {
                    MessageBox.Show("ناحیه ای از تصویر انتخاب نشده است");
                }
                    

            }

        }

        

    }
}
