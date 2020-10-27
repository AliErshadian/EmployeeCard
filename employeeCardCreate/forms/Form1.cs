using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using Neodynamic.SDK;

namespace employeeCardCreate
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void GenerateCard()
        {
            //Get the info to create the business card
            string fullname = "";
            string jobtitle = "";
            string addressline1 = "";
            string addressline2 = "";
            string phone = "";
            string email = "";
            string logoFile = "";
            string layout = "Left";
            Color cardColor = lblCardColor.BackColor;

            if (!String.IsNullOrEmpty(txtFullName.Text))
            {
                fullname = txtFullName.Text;
            }
            if (!String.IsNullOrEmpty(txtJobTitle.Text))
            {
                jobtitle = txtJobTitle.Text;
            }
            if (!String.IsNullOrEmpty(txtAddressLine1.Text))
            {
                addressline1 = txtAddressLine1.Text;
            }
            if (!String.IsNullOrEmpty(txtAddressLine2.Text))
            {
                addressline2 = txtAddressLine2.Text;
            }
            if (!String.IsNullOrEmpty(txtPhone.Text))
            {
                phone = txtPhone.Text;
            }
            if (!String.IsNullOrEmpty(txtEmail.Text))
            {
                email = txtEmail.Text;
            }
            if (this.btnLogo.Tag != null && !String.IsNullOrEmpty(this.btnLogo.Tag.ToString()))
            {
                logoFile = this.btnLogo.Tag.ToString();
            }
            if (rbRight.Checked)
            {
                layout = "Right";
            }


            //Create an instance of ImageDraw
            ImageDraw imgDraw = new ImageDraw();
            //Basic settings for Business Card
            imgDraw.Canvas.AutoSize = false;
            imgDraw.ImageFormat = ImageDrawFormat.Png;
            //Set business card size
            imgDraw.Canvas.Width = 400;
            imgDraw.Canvas.Height = 250;

            //Create main decorative shape element
            RectangleShapeElement rect1 = new RectangleShapeElement();
            rect1.X = 10;
            rect1.Y = 10;
            rect1.Width = 380;
            rect1.Height = 230;

            rect1.Roundness = 20;
            rect1.StrokeWidth = 0;
            //Set background
            rect1.Fill.BackgroundColor = cardColor;
            //Add element to output image
            imgDraw.Elements.Add(rect1);



            //Create top decorative shape element
            RectangleShapeElement rect2 = new RectangleShapeElement();
            rect2.X = 20;
            rect2.Y = 20;
            rect2.Width = 360;
            rect2.Height = 170;
            rect2.Roundness = 10;
            rect2.StrokeWidth = 0;
            rect2.Fill.BackgroundColor = Color.White;
            //Add element to output image
            imgDraw.Elements.Add(rect2);

            //Create bottom decorative shape element
            RectangleShapeElement rect3 = new RectangleShapeElement();
            rect3.X = 30;
            rect3.Y = 130;
            rect3.Width = 340;
            rect3.Height = 100;
            rect3.Roundness = 10;
            rect3.StrokeWidth = 1;
            rect3.StrokeFill.BackgroundColor = cardColor;
            rect3.Fill.BackgroundColor = Color.White;
            //Add element to output image
            imgDraw.Elements.Add(rect3);





            //Create an ImageElement to wrap the user logo
            if (logoFile.Length > 0 && System.IO.File.Exists(logoFile))
            {
                ImageElement imgElemLogo = new ImageElement();
                //Get user logo from disk
                imgElemLogo.Source = ImageSource.File;
                imgElemLogo.SourceFile = logoFile;
                //Logo Layout
                if (layout == "Right")
                {
                    imgElemLogo.X = 40;
                    imgElemLogo.Y = 40;
                }
                else
                {
                    imgElemLogo.X = 400 - (50 + 40); //Canvas Width - (Logo Width + X Margin)
                    imgElemLogo.Y = 40;
                }
                //Apply Resize logo
                Resize resizeLogo = new Resize();
                resizeLogo.Width = 50;
                resizeLogo.LockAspectRatio = LockAspectRatio.WidthBased;
                imgElemLogo.Actions.Clear();
                imgElemLogo.Actions.Add(resizeLogo);
                //Add element to output image
                imgDraw.Elements.Add(imgElemLogo);
            }


            //Create TextElement objects for each fields

            //Full Name TextElement
            if (fullname.Length > 0)
            {
                TextElement txtElemName = new TextElement();
                txtElemName.AutoSize = false;
                txtElemName.Font.Name = "Arial";
                txtElemName.Font.Size = 14f;
                txtElemName.Font.Unit = FontUnit.Point;
                txtElemName.Font.Bold = true;
                txtElemName.ForeColor = System.Drawing.Color.Black;
                txtElemName.Text = fullname;
                txtElemName.TextQuality = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;
                txtElemName.X = 40;
                txtElemName.Y = 40;
                txtElemName.Width = 320;
                txtElemName.Height = 20;
                if (layout == "Left")
                {
                    txtElemName.TextAlignment = ContentAlignment.MiddleLeft;
                }
                else
                {
                    txtElemName.TextAlignment = ContentAlignment.MiddleRight;
                }
                //Add element to output image
                imgDraw.Elements.Add(txtElemName);
            }

            //Job Title TextElement
            if (jobtitle.Length > 0)
            {
                TextElement txtElemJob = new TextElement();
                txtElemJob.AutoSize = false;
                txtElemJob.Font.Name = "Arial";
                txtElemJob.Font.Size = 10f;
                txtElemJob.Font.Unit = FontUnit.Point;
                txtElemJob.ForeColor = System.Drawing.Color.Black;
                txtElemJob.Text = jobtitle;
                txtElemJob.TextQuality = System.Drawing.Text.TextRenderingHint.AntiAlias;
                txtElemJob.X = 40;
                txtElemJob.Y = 64;
                txtElemJob.Width = 320;
                txtElemJob.Height = 14;
                if (layout == "Left")
                {
                    txtElemJob.TextAlignment = ContentAlignment.MiddleLeft;
                }
                else
                {
                    txtElemJob.TextAlignment = ContentAlignment.MiddleRight;
                }
                //Add element to output image
                imgDraw.Elements.Add(txtElemJob);
            }

            //Address Lines TextElement
            if (addressline1.Length > 0)
            {
                TextElement txtElemAddress = new TextElement();
                txtElemAddress.AutoSize = false;
                txtElemAddress.Font.Name = "Times New Roman";
                txtElemAddress.Font.Italic = true;
                txtElemAddress.Font.Size = 11f;
                txtElemAddress.Font.Unit = FontUnit.Point;
                txtElemAddress.ForeColor = System.Drawing.Color.Black;
                txtElemAddress.Text = addressline1 + "\n" + addressline2;
                txtElemAddress.TextQuality = System.Drawing.Text.TextRenderingHint.AntiAlias;
                txtElemAddress.X = 40;
                txtElemAddress.Y = 130;
                txtElemAddress.Width = 160;
                txtElemAddress.Height = 50;
                if (layout == "Left")
                {
                    txtElemAddress.TextAlignment = ContentAlignment.MiddleLeft;
                }
                else
                {
                    txtElemAddress.TextAlignment = ContentAlignment.MiddleRight;
                }
                //Add element to output image
                imgDraw.Elements.Add(txtElemAddress);
            }

            //Phone and Email TextElement
            if (phone.Length > 0 || email.Length > 0)
            {
                TextElement txtElemPhone = new TextElement();
                txtElemPhone.AutoSize = false;
                txtElemPhone.Font.Name = "Georgia";
                txtElemPhone.Font.Size = 10f;
                txtElemPhone.Font.Unit = FontUnit.Point;
                txtElemPhone.ForeColor = System.Drawing.Color.Black;
                txtElemPhone.Text = "Phone: " + phone + "\n" + email;
                txtElemPhone.TextQuality = System.Drawing.Text.TextRenderingHint.AntiAlias;
                txtElemPhone.X = 200;
                txtElemPhone.Y = 180;
                txtElemPhone.Width = 160;
                txtElemPhone.Height = 50;
                if (layout == "Right")
                {
                    txtElemPhone.TextAlignment = ContentAlignment.MiddleLeft;
                }
                else
                {
                    txtElemPhone.TextAlignment = ContentAlignment.MiddleRight;
                }
                //Add element to output image
                imgDraw.Elements.Add(txtElemPhone);
            }

            //generate image card and preview it
            picCardPreview.Image = imgDraw.GetOutputImage();
        }

        private void btnLogo_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image Files(*.BMP;*.JPG;*.GIF;*.PNG)|*.BMP;*.JPG;*.GIF;*.PNG|All files (*.*)|*.*";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                btnLogo.Tag = ofd.FileName;

                //Update card preview
                GenerateCard();
            }
        }

        private void DataFields_KeyUp(object sender, KeyEventArgs e)
        {
            //Update card preview
            GenerateCard();
        }

        private void Layout_CheckedChanged(object sender, EventArgs e)
        {
            //Update card preview
            GenerateCard();
        }

        private void btnCardColor_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            cd.Color = lblCardColor.BackColor;

            if (cd.ShowDialog() == DialogResult.OK)
            {
                lblCardColor.BackColor = cd.Color;

                //Update card preview
                GenerateCard();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Set card color
            this.lblCardColor.BackColor = Color.RoyalBlue;
        }

     
    }
}