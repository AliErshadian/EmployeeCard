using System.Data.Entity.Migrations;
using MessagingToolkit.Core.Log;
using MessagingToolkit.QRCode.Codec;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Windows.Forms;
using System.Globalization;
using System;

namespace employeeCardCreate
{
    public static class print
    {
        public static Bitmap card;
        public static int intial;
        
        public static long idd;
        public static Bitmap CardEmp(long ids)
        {
            string FplL = StartForm.EmpDb.Employees.Where(i => i.ID.Equals(ids))
                                .Select(j => j.FirstName + " " + j.LastName).SingleOrDefault();
            string nationalCode = StartForm.EmpDb.Employees.Where(i => i.ID.Equals(ids))
                                .Select(j => j.NationalCode).SingleOrDefault();
            string id = StartForm.EmpDb.Employees.Where(i => i.ID.Equals(ids))
                                .Select(j => j.ID).SingleOrDefault().ToString();
            string fatherName = StartForm.EmpDb.Employees.Where(i => i.ID.Equals(ids))
                                .Select(j => j.FatherName).SingleOrDefault();
            string companyName = StartForm.EmpDb.Employees.Where(i => i.ID.Equals(ids))
                                .Select(j => j.CompanyName).SingleOrDefault();
            string createDate = StartForm.EmpDb.Employees.Where(i => i.ID.Equals(ids))
                                .Select(j => j.CreateDate).SingleOrDefault().ToShortDateString();
            string expireDate = StartForm.EmpDb.Employees.Where(i => i.ID.Equals(ids))
                                .Select(j => j.ExpireDate).SingleOrDefault().ToShortDateString();
            string nationalId = StartForm.EmpDb.Employees.Where(i => i.ID.Equals(ids))
                                .Select(j => j.NationalId).SingleOrDefault();
            string path = @"resources\card1Final.jpg";
            string path2 = @"photos\photo(" + id + ").jpg";
            Bitmap phot = (Bitmap)Image.FromFile(path2);
            Bitmap photo = new Bitmap(phot, 77, 98);
            Bitmap bitmap = (Bitmap)Image.FromFile(path);


            var encoder = new QRCodeEncoder();
            var qrImg = encoder.Encode(id);
            var finalimg = (Image)(new Bitmap(qrImg, 65, 65));


            using (Graphics cardGraphic = Graphics.FromImage(bitmap))
            {
                cardGraphic.DrawImage(finalimg, new Point(455, 4));
                
                cardGraphic.DrawString(id, new Font("IRTitr", 10, FontStyle.Regular), Brushes.SlateBlue,
                    new Point(242, 122));
                cardGraphic.DrawString(FplL, new Font("IRTitr", 10), Brushes.SlateBlue, new Point(208, 153));
                cardGraphic.DrawString(nationalId, new Font("IRTitr", 10), Brushes.SlateBlue,
                    new Point(208, 181));
                cardGraphic.DrawString(fatherName, new Font("IRTitr", 10), Brushes.SlateBlue,
                    new Point(208, 213));
                cardGraphic.DrawString(companyName, new Font("IRTitr", 10), Brushes.SlateBlue,
                    new Point(208, 241));
                cardGraphic.DrawString(createDate, new Font("IRTitr", 10), Brushes.SlateBlue,
                    new Point(208, 268));
                cardGraphic.DrawString(expireDate, new Font("IRTitr", 10), Brushes.SlateBlue,
                    new Point(208, 295));
                cardGraphic.DrawString(nationalCode, new Font("IRTitr", 11, FontStyle.Bold), Brushes.SlateBlue,
                    new Point(575, 4));
                cardGraphic.DrawImage(photo, new Point(4, 4));
            }
            return bitmap;
        }
        public static void printTest()
        {
            PrintDialog printDialog1 = new PrintDialog();
            PrintDocument printDocument1 = new PrintDocument();

            printDialog1.Document = printDocument1;
            printDocument1.PrintPage +=
                new PrintPageEventHandler(printDocument1_PrintPage);
            printDocument1.EndPrint += new System.Drawing.Printing.PrintEventHandler(printDocument1_EndPrint);
            DialogResult result = printDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                printDocument1.Print();
            }
            

        }
        static void printDocument1_EndPrint(object sender, PrintEventArgs e)
        {
            PersianCalendar pc = new PersianCalendar();
            var n = DateTime.Now;
            var tm = pc.GetYear(n).ToString() + "/" + pc.GetMonth(n).ToString() + "/" + pc.GetDayOfMonth(n).ToString();
            Employee empp = StartForm.EmpDb.Employees.First(i => i.ID == idd);
            empp.Print++;
            empp.PrintDate = DateTime.Parse(tm);

            StartForm.EmpDb.SaveChanges();
        }
        static void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            Graphics graphic = e.Graphics;

            e.PageSettings.PrinterSettings.DefaultPageSettings.PaperSize = new PaperSize("A4", 1240, 1754);

            
            float pageHeight = e.PageSettings.PrintableArea.Height;
            int startx = 65;
            int starty = 50;
            int offsetY = 0;

            for (int i = 0; i < intial; i++)
            {
                if (i == 0)
                {

                    graphic.DrawImage(card, new PointF(startx, starty));
                    offsetY += 350;
                }
                if (i > 0)
                {
                    graphic.DrawImage(card, new PointF(startx, starty + offsetY));
                    offsetY += 350;

                }
                if (offsetY >= pageHeight)
                {
                    e.HasMorePages = true;
                    offsetY = 0;
                }
                else
                {
                    e.HasMorePages = false;
                }
            }
        }
    }
}
