using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Collections.Generic;

namespace employeeCardCreate
{
    public partial class StartForm : Form
    {
        
        
        ///////////////////
        public static string user;
        public static string ConnectionString_main;
        public string access;
        private string admin;

        
        //
        

        public static EmployeeCardentities EmpDb = new EmployeeCardentities();
       


        private static NotifyIcon notifyIcon1 = new NotifyIcon();



        public StartForm()
        {
            InitializeComponent();
        }

        
        public static void showBalloon(string title, string body)
        {
            

            notifyIcon1.Text = "نرم افزار صدور کارت فرصت";
            notifyIcon1.Visible = true;
            notifyIcon1.Icon = new System.Drawing.Icon(@"resources\icon.ico");
            
            if (title != null)
            {
                notifyIcon1.BalloonTipTitle = title;
            }

            if (body != null)
            {
                notifyIcon1.BalloonTipText = body;
            }
            notifyIcon1.BalloonTipIcon = ToolTipIcon.Info;
            
            notifyIcon1.ShowBalloonTip(1000);


        }

        private void startForm_Load(object sender, EventArgs e)
        {


            showBalloon("نرم افزار صدور کارت فرصت","برنامه نویس: مهندسی علی ارشادیان");
            

            Charting();
            Tree();

            admin = access == "true      " ? "ادمین" : "معمولی";
            usersBTN.Enabled = access == "true      ";
            
        }

        public void Tree()
        {
            int y = 0;
            List<string> company = EmpDb.CompanyProperties.Select(i => i.CompanyName).ToList();
            List<string> contractor = EmpDb.ContractorProperties.Select(i => i.ContractorName).ToList();
            foreach (var item in company)
            {
                treeView1.Nodes.Add(item+"(شرکت)");
                foreach (var itm in contractor)
                {
                    var count = EmpDb.Employees.Count(i => i.ContractorName == itm && i.CompanyName==item);
                    if (count != 0)
                    {
                        TreeNode node=new TreeNode(count.ToString()+"نفر");
                        treeView1.Nodes[y].Nodes.Add(new TreeNode(itm+"(پیمانکار)", new TreeNode[] {node}));
                    }
                    

                }
                y++;
            }
            
        }

        public void Charting()
        {
            string[] seriesArray =
            {
                "فروردین", "اردیبهشت", "خرداد", "تیر", "مرداد", "شهریور", "مهر", "آبان", "آذر", "دی",
                "بهمن", "اسفند"
            };
            var pc = new PersianCalendar();
            var n = DateTime.Now;
            int year = pc.GetYear(n);


            var farvardin = StartForm.EmpDb.Employees.Count(i => i.CreateDate.Month == 1 && i.CreateDate.Year == year && i.@is == 1);
            var oridibehesht = StartForm.EmpDb.Employees.Count(i => i.CreateDate.Month == 2 && i.CreateDate.Year == year && i.@is == 1);
            var khordad = StartForm.EmpDb.Employees.Count(i => i.CreateDate.Month == 3 && i.CreateDate.Year == year && i.@is == 1);
            var tir = StartForm.EmpDb.Employees.Count(i => i.CreateDate.Month == 4 && i.CreateDate.Year == year && i.@is == 1);
            var mordad = StartForm.EmpDb.Employees.Count(i => i.CreateDate.Month == 5 && i.CreateDate.Year == year && i.@is == 1);
            var shahrivar = StartForm.EmpDb.Employees.Count(i => i.CreateDate.Month == 6 && i.CreateDate.Year == year && i.@is == 1);
            var mehr = StartForm.EmpDb.Employees.Count(i => i.CreateDate.Month == 7 && i.CreateDate.Year == year && i.@is == 1);
            var aban = StartForm.EmpDb.Employees.Count(i => i.CreateDate.Month == 8 && i.CreateDate.Year == year && i.@is == 1);
            var azar = StartForm.EmpDb.Employees.Count(i => i.CreateDate.Month == 9 && i.CreateDate.Year == year && i.@is == 1);
            var dey = StartForm.EmpDb.Employees.Count(i => i.CreateDate.Month == 10 && i.CreateDate.Year == year && i.@is == 1);
            var bahman = StartForm.EmpDb.Employees.Count(i => i.CreateDate.Month == 11 && i.CreateDate.Year == year && i.@is == 1);
            var esfand = StartForm.EmpDb.Employees.Count(i => i.CreateDate.Month == 12 && i.CreateDate.Year == year && i.@is == 1);

            var farvardin2 = StartForm.EmpDb.Employees.Count(i => i.CreateDate.Month == 1 && i.CreateDate.Year == year && i.@is == 0);
            var oridibehesht2 = StartForm.EmpDb.Employees.Count(i => i.CreateDate.Month == 2 && i.CreateDate.Year == year && i.@is == 0);
            var khordad2 = StartForm.EmpDb.Employees.Count(i => i.CreateDate.Month == 3 && i.CreateDate.Year == year && i.@is == 0);
            var tir2 = StartForm.EmpDb.Employees.Count(i => i.CreateDate.Month == 4 && i.CreateDate.Year == year && i.@is == 0);
            var mordad2 = StartForm.EmpDb.Employees.Count(i => i.CreateDate.Month == 5 && i.CreateDate.Year == year && i.@is == 0);
            var shahrivar2 = StartForm.EmpDb.Employees.Count(i => i.CreateDate.Month == 6 && i.CreateDate.Year == year && i.@is == 0);
            var mehr2 = StartForm.EmpDb.Employees.Count(i => i.CreateDate.Month == 7 && i.CreateDate.Year == year && i.@is == 0);
            var aban2 = StartForm.EmpDb.Employees.Count(i => i.CreateDate.Month == 8 && i.CreateDate.Year == year && i.@is == 0);
            var azar2 = StartForm.EmpDb.Employees.Count(i => i.CreateDate.Month == 9 && i.CreateDate.Year == year && i.@is == 0);
            var dey2 = StartForm.EmpDb.Employees.Count(i => i.CreateDate.Month == 10 && i.CreateDate.Year == year && i.@is == 0);
            var bahman2 = StartForm.EmpDb.Employees.Count(i => i.CreateDate.Month == 11 && i.CreateDate.Year == year && i.@is == 0);
            var esfand2 = StartForm.EmpDb.Employees.Count(i => i.CreateDate.Month == 12 && i.CreateDate.Year == year && i.@is == 0);

            var farvardin3 = StartForm.EmpDb.Employees.Count(i => i.LostCardDate.Value.Month == 1 && i.LostCardDate.Value.Year == year && i.LostCard == "true");
            var oridibehesht3 = StartForm.EmpDb.Employees.Count(i => i.LostCardDate.Value.Month == 2 && i.LostCardDate.Value.Year == year && i.LostCard == "true");
            var khordad3 = StartForm.EmpDb.Employees.Count(i => i.LostCardDate.Value.Month == 3 && i.LostCardDate.Value.Year == year && i.LostCard == "true");
            var tir3 = StartForm.EmpDb.Employees.Count(i => i.LostCardDate.Value.Month == 4 && i.LostCardDate.Value.Year == year && i.LostCard == "true");
            var mordad3 = StartForm.EmpDb.Employees.Count(i => i.LostCardDate.Value.Month == 5 && i.LostCardDate.Value.Year == year && i.LostCard == "true");
            var shahrivar3 = StartForm.EmpDb.Employees.Count(i => i.LostCardDate.Value.Month == 6 && i.LostCardDate.Value.Year == year && i.LostCard == "true");
            var mehr3 = StartForm.EmpDb.Employees.Count(i => i.LostCardDate.Value.Month == 7 && i.LostCardDate.Value.Year == year && i.LostCard == "true");
            var aban3 = StartForm.EmpDb.Employees.Count(i => i.LostCardDate.Value.Month == 8 && i.LostCardDate.Value.Year == year && i.LostCard == "true");
            var azar3 = StartForm.EmpDb.Employees.Count(i => i.LostCardDate.Value.Month == 9 && i.LostCardDate.Value.Year == year && i.LostCard == "true");
            var dey3 = StartForm.EmpDb.Employees.Count(i => i.LostCardDate.Value.Month == 10 && i.LostCardDate.Value.Year == year && i.LostCard == "true");
            var bahman3 = StartForm.EmpDb.Employees.Count(i => i.LostCardDate.Value.Month == 11 && i.LostCardDate.Value.Year == year && i.LostCard == "true");
            var esfand3 = StartForm.EmpDb.Employees.Count(i => i.LostCardDate.Value.Month == 12 && i.LostCardDate.Value.Year == year && i.LostCard == "true");

            var farvardin4 = StartForm.EmpDb.Employees.Count(i => i.DateSecondaryCard.Value.Month == 1 && i.DateSecondaryCard.Value.Year == year && i.SecondaryCard > 0);
            var oridibehesht4 = StartForm.EmpDb.Employees.Count(i => i.DateSecondaryCard.Value.Month == 2 && i.DateSecondaryCard.Value.Year == year && i.SecondaryCard > 0);
            var khordad4 = StartForm.EmpDb.Employees.Count(i => i.DateSecondaryCard.Value.Month == 3 && i.DateSecondaryCard.Value.Year == year && i.SecondaryCard > 0);
            var tir4 = StartForm.EmpDb.Employees.Count(i => i.DateSecondaryCard.Value.Month == 4 && i.DateSecondaryCard.Value.Year == year && i.SecondaryCard > 0);
            var mordad4 = StartForm.EmpDb.Employees.Count(i => i.DateSecondaryCard.Value.Month == 5 && i.DateSecondaryCard.Value.Year == year && i.SecondaryCard > 0);
            var shahrivar4 = StartForm.EmpDb.Employees.Count(i => i.DateSecondaryCard.Value.Month == 6 && i.DateSecondaryCard.Value.Year == year && i.SecondaryCard > 0);
            var mehr4 = StartForm.EmpDb.Employees.Count(i => i.DateSecondaryCard.Value.Month == 7 && i.DateSecondaryCard.Value.Year == year && i.SecondaryCard > 0);
            var aban4 = StartForm.EmpDb.Employees.Count(i => i.DateSecondaryCard.Value.Month == 8 && i.DateSecondaryCard.Value.Year == year && i.SecondaryCard > 0);
            var azar4 = StartForm.EmpDb.Employees.Count(i => i.DateSecondaryCard.Value.Month == 9 && i.DateSecondaryCard.Value.Year == year && i.SecondaryCard > 0);
            var dey4 = StartForm.EmpDb.Employees.Count(i => i.DateSecondaryCard.Value.Month == 10 && i.DateSecondaryCard.Value.Year == year && i.SecondaryCard > 0);
            var bahman4 = StartForm.EmpDb.Employees.Count(i => i.DateSecondaryCard.Value.Month == 11 && i.DateSecondaryCard.Value.Year == year && i.SecondaryCard > 0);
            var esfand4 = StartForm.EmpDb.Employees.Count(i => i.DateSecondaryCard.Value.Month == 12 && i.DateSecondaryCard.Value.Year == year && i.SecondaryCard > 0);
            
            int[] pointArray =
            {
                farvardin, oridibehesht, khordad, tir, mordad, shahrivar, mehr, aban, azar, dey, bahman,
                esfand
            };
            int[] pointArray2 =
            {
                farvardin2, oridibehesht2, khordad2, tir2, mordad2, shahrivar2, mehr2, aban2, azar2, dey2, bahman2,
                esfand2
            };
            int[] pointArray3 =
            {
                farvardin3, oridibehesht3, khordad3, tir3, mordad3, shahrivar3, mehr3, aban3, azar3, dey3, bahman3,
                esfand3
            };
            int[] pointArray4 =
            {
                farvardin4, oridibehesht4, khordad4, tir4, mordad4, shahrivar4, mehr4, aban4, azar4, dey4, bahman4,
                esfand4
            };
            
            Series series = new Series();
            Series series2 = new Series();
            Series series3 = new Series();
            Series series4 = new Series();
            Series series5 = new Series();
            series.Name = "اتباع ایرانی";
            series2.Name = "اتباع بیگانه";
            series3.Name = "مجموع افراد";
            series4.Name = "کارتهای مفقود شده";
            series5.Name = "کارت های المثنی";
            series.XValueType = ChartValueType.String;
            series2.XValueType = ChartValueType.String;
            series3.XValueType = ChartValueType.String;
            series4.XValueType = ChartValueType.String;
            series5.XValueType = ChartValueType.String;
            series.ChartType = SeriesChartType.Column;
            series2.ChartType = SeriesChartType.Column;
            series3.ChartType = SeriesChartType.Column;
            series4.ChartType = SeriesChartType.Column;
            series5.ChartType = SeriesChartType.Column;
            series.IsXValueIndexed = true;
            
            for (int i = 0; i < seriesArray.Length; i++)
            {
                series.Points.Add(new DataPoint(i + 1,pointArray[i]));
                series2.Points.Add(new DataPoint(i + 1, pointArray2[i]));
                series3.Points.Add(new DataPoint(i + 1,pointArray[i] + pointArray2[i]));
                series4.Points.Add(new DataPoint(i + 1, pointArray3[i]));
                series5.Points.Add(new DataPoint(i + 1, pointArray4[i]));


            }
            chart1.Series.Add(series);
            chart1.Series.Add(series2);
            chart1.Series.Add(series3);
            chart1.Series.Add(series4);
            chart1.Series.Add(series5);
            

            

        }



        private void جدیدToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var nfrm = new ChoseRegionFrm();
            nfrm.Show();
        }

       

        private void clock_Tick(object sender, EventArgs e)
        {
            
            label1.Text = ("نرم افزار صدور کارت فرصت         " + "           " +date()
                          + "          " +"ساعت: "+ DateTime.Now.ToLongTimeString()+"          "+"کاربر : "+user+" ("+admin+")");
        }

        private string date()
        {
            var pc = new PersianCalendar();
            var n = DateTime.Now;
            var day = DateTime.Now.DayOfWeek;
            var month = pc.GetMonth(n).ToString();
            var change = "";
            var days = "";
            switch (month)
            {
                case "1":
                    change = " فروردین ";
                    break;
                case "2":
                    change = " اردیبهشت ";
                    break;
                case "3":
                    change = " خرداد ";
                    break;
                case "4":
                    change = " تیر ";
                    break;
                case "5":
                    change = " مرداد ";
                    break;
                case "6":
                    change = " شهریور ";
                    break;
                case "7":
                    change = " مهر ";
                    break;
                case "8":
                    change = " آبان ";
                    break;
                case "9":
                    change = " آذر ";
                    break;
                case "10":
                    change = " دی ";
                    break;
                case "11":
                    change = " بهمن ";
                    break;
                case "12":
                    change = " اسفند ";
                    break;
            }

            switch (day)
            {
                case DayOfWeek.Saturday:
                    days = " شنبه ";
                    break;
                case DayOfWeek.Sunday:
                    days = " یکشنبه ";
                    break;
                case DayOfWeek.Monday:
                    days = " دوشنبه ";
                    break;
                case DayOfWeek.Tuesday:
                    days = " سه شنبه ";
                    break;
                case DayOfWeek.Wednesday:
                    days = " چهار شنبه ";
                    break;
                case DayOfWeek.Thursday:
                    days = " پنج شنبه ";
                    break;
                case DayOfWeek.Friday:
                    days = " جمعه ";
                    break;
            }
            string datew = "امروز" + days + pc.GetDayOfMonth(n).ToString() + " " + change + " " + pc.GetYear(n).ToString();
            return datew;
        }

        private void جستجوToolStripMenuItem_Click(object sender, EventArgs e)
        {
            searchFrm frmsch=new searchFrm();
            frmsch.Show();
            
        }

        

        private void گزارشکلیازکارتهایصادرشدهToolStripMenuItem_Click(object sender, EventArgs e)
        {
            finalRepor frm=new finalRepor();
            frm.Show();
        }

        private void copyAlltoClipboard()
        {
            DataGridView dgv = new DataGridView();
            dgv.DataSource = EmpDb.Employees.OrderBy(i => i.CreateDate).ToList();
            dgv.SelectAll();
            DataObject dataObj = dgv.GetClipboardContent();
            if (dataObj != null)
                Clipboard.SetDataObject(dataObj);
        }
        
        

        private void پیمانکارجدیدToolStripMenuItem_Click(object sender, EventArgs e)
        {
            contractorForm cform = new contractorForm();
            cform.Show();
        }

        private void شرکتیاطرحجدیدToolStripMenuItem_Click(object sender, EventArgs e)
        {
            companyForm cfrm = new companyForm();
            cfrm.Show();
        }

        private void خروجToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            Close();
        }

        private void StartForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason != CloseReason.ApplicationExitCall)
            {
                closemainformdialog frm = new closemainformdialog();

                DialogResult answer = new DialogResult();
                answer = frm.ShowDialog();

                if (answer == DialogResult.Yes)
                    Application.Exit();
                else
                    e.Cancel = true;
            }
        }





        #region buttons
        private void button1_MouseEnter(object sender, EventArgs e)
        {
            button1.FlatStyle = FlatStyle.Standard;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.FlatStyle = FlatStyle.Flat;
        }

        private void button1_MouseDown(object sender, MouseEventArgs e)
        {
            button1.Size=new Size(90,90);
            button1.Location=new Point(button1.Location.X+5,button1.Location.Y+5);
        }

        private void button1_MouseUp(object sender, MouseEventArgs e)
        {
            button1.Size = new Size(100, 100);
            button1.Location = new Point(button1.Location.X - 5, button1.Location.Y - 5);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            searchFrm frmsch = new searchFrm();
            frmsch.Show();
        }

        private void button2_MouseEnter(object sender, EventArgs e)
        {
            button2.FlatStyle = FlatStyle.Standard;

        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            button2.FlatStyle = FlatStyle.Flat;

        }

        private void button2_MouseUp(object sender, MouseEventArgs e)
        {
            button2.Size = new Size(100, 100);
            button2.Location = new Point(button2.Location.X - 5, button2.Location.Y - 5);
        }

        private void button2_MouseDown(object sender, MouseEventArgs e)
        {
            button2.Size = new Size(90, 90);
            button2.Location = new Point(button2.Location.X + 5, button2.Location.Y + 5);
        }

        private void button3_MouseEnter(object sender, EventArgs e)
        {
            button3.FlatStyle = FlatStyle.Standard;

        }

        private void button3_MouseLeave(object sender, EventArgs e)
        {
            button3.FlatStyle = FlatStyle.Flat;

        }

        private void button3_MouseUp(object sender, MouseEventArgs e)
        {
            button3.Size = new Size(100, 100);
            button3.Location = new Point(button3.Location.X - 5, button3.Location.Y - 5);
        }

        private void button3_MouseDown(object sender, MouseEventArgs e)
        {
            button3.Size = new Size(90, 90);
            button3.Location = new Point(button3.Location.X + 5, button3.Location.Y + 5);
        }

        private void button4_MouseEnter(object sender, EventArgs e)
        {
            button4.FlatStyle = FlatStyle.Standard;

        }

        private void button4_MouseLeave(object sender, EventArgs e)
        {
            button4.FlatStyle = FlatStyle.Flat;

        }

        private void button4_MouseUp(object sender, MouseEventArgs e)
        {
            button4.Size = new Size(100, 100);
            button4.Location = new Point(button4.Location.X - 5, button4.Location.Y - 5);
        }

        private void button4_MouseDown(object sender, MouseEventArgs e)
        {
            button4.Size = new Size(90, 90);
            button4.Location = new Point(button4.Location.X + 5, button4.Location.Y + 5);
        }

        private void button5_MouseEnter(object sender, EventArgs e)
        {
            button5.FlatStyle = FlatStyle.Standard;

        }

        private void button5_MouseLeave(object sender, EventArgs e)
        {
            button5.FlatStyle = FlatStyle.Flat;

        }

        private void button5_MouseUp(object sender, MouseEventArgs e)
        {
            button5.Size = new Size(100, 100);
            button5.Location = new Point(button5.Location.X - 5, button5.Location.Y - 5);
        }

        private void button5_MouseDown(object sender, MouseEventArgs e)
        {
            button5.Size = new Size(90, 90);
            button5.Location = new Point(button5.Location.X + 5, button5.Location.Y + 5);
        }

        private void button6_MouseEnter(object sender, EventArgs e)
        {
            button6.FlatStyle = FlatStyle.Standard;

        }

        private void button6_MouseLeave(object sender, EventArgs e)
        {
            button6.FlatStyle = FlatStyle.Flat;
        }

        private void button6_MouseUp(object sender, MouseEventArgs e)
        {
            button6.Size = new Size(100, 100);
            button6.Location = new Point(button6.Location.X - 5, button6.Location.Y - 5);
        }

        private void button6_MouseDown(object sender, MouseEventArgs e)
        {
            button6.Size = new Size(90, 90);
            button6.Location = new Point(button6.Location.X + 5, button6.Location.Y + 5);
        }

        private void button7_MouseEnter(object sender, EventArgs e)
        {
            button7.FlatStyle = FlatStyle.Standard;

        }

        private void button7_MouseLeave(object sender, EventArgs e)
        {
            button7.FlatStyle = FlatStyle.Flat;

        }

        private void button7_MouseUp(object sender, MouseEventArgs e)
        {
            button7.Size = new Size(100, 100);
            button7.Location = new Point(button7.Location.X - 5, button7.Location.Y - 5);
        }

        private void button7_MouseDown(object sender, MouseEventArgs e)
        {
            button7.Size = new Size(90, 90);
            button7.Location = new Point(button7.Location.X + 5, button7.Location.Y + 5);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var nfrm = new ChoseRegionFrm();
            nfrm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            companyForm cfrm = new companyForm();
            cfrm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            contractorForm cform = new contractorForm();
            cform.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            finalRepor frm = new finalRepor();
            frm.Show();
        }
        #endregion

        private void button6_Click(object sender, EventArgs e)
        {
            
            var dia = new System.Windows.Forms.SaveFileDialog();
            dia.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            dia.Filter = "Excel Worksheets (*.xlsx)|*.xlsx|xls file (*.xls)|*.xls|All files (*.*)|*.*";
            if (dia.ShowDialog(this) == System.Windows.Forms.DialogResult.OK)
            {
                DataGridView dtg=new DataGridView();
                IEnumerable<Employee> em = StartForm.EmpDb.Employees.OrderBy(i => i.CreateDate).ToList();
                



                var excel = new OfficeOpenXml.ExcelPackage();
                var ws = excel.Workbook.Worksheets.Add("Employees");
                ws.Cells.LoadFromCollection(em, true, OfficeOpenXml.Table.TableStyles.Light1);
                ws.Cells[ws.Dimension.Address.ToString(CultureInfo.InvariantCulture)].AutoFitColumns();

                using (var file = File.Create(dia.FileName))
                    excel.SaveAs(file);
                MessageBox.Show("گزارش در فایل اکسل با موفقیت انجام شد");
            }
        }

        private void backUpگیریToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            try
            {
                PersianCalendar pc = new PersianCalendar();

                var n = DateTime.Now;
                string date = "(" +pc.GetYear(n).ToString() + "-" + pc.GetMonth(n).ToString() + "-" + pc.GetDayOfMonth(n).ToString()+")";
                string time ="("+ pc.GetHour(n).ToString() + "-" + pc.GetMinute(n).ToString() + "-" +
                              pc.GetSecond(n).ToString()+")";

                string str = string.Empty;
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.DefaultExt = "bak";
                sfd.FileName = "empCardBackUp " + date + " " + time;
                sfd.Filter = @"SQL Backup files (*.bak) |*.bak|All files (*.*) |*.*";
                sfd.FilterIndex = 1;
                sfd.OverwritePrompt = true;
                sfd.Title = "فایل بک آپ";

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    str = sfd.FileName;
                    SqlConnection sq =
                       new SqlConnection(ConnectionString_main);
                    sq.Open();
                    SqlCommand scq =
                        new SqlCommand(
                            @"BACKUP DATABASE [EmployeeCard] TO  DISK = N'" + @str +
                            "' WITH NOFORMAT, NOINIT,  NAME = N'EmployeeCard-Full Database Backup', SKIP, NOREWIND, NOUNLOAD,  STATS = 10",
                            sq);
                    scq.ExecuteNonQuery();
                    sq.Close();
                    MessageBox.Show("بک آپ گیری با موفقیت انجام شد");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("خطا در بک آپ گیری دیتا بیس");
            }


        }

        private void بروزآوریازBackUpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                string str = string.Empty;
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.Filter = @"SQL Backup files (*.bak) |*.bak|All files (*.*) |*.*";
                ofd.FilterIndex = 1;
                ofd.Title = "فایل بروز رسان ";

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    str = ofd.FileName;
                    SqlConnection sq =
                        new SqlConnection(ConnectionString_main);
                    sq.Open();
                    SqlCommand scq =
                        new SqlCommand(
                            @"USE [master] RESTORE DATABASE [EmployeeCard] FROM  DISK = N'" + str +
                            "' WITH  FILE = 1,  NOUNLOAD,  STATS = 10 ",
                            sq);

                    scq.ExecuteNonQuery();
                    sq.Close();
                    MessageBox.Show("بروز رسانی از بک آپ با موفقیت انجام شد");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(" خطا در بروز رسانی دیتا بیس");
            }
        }

       



        private void button8_MouseEnter(object sender, EventArgs e)
        {
            button8.FlatStyle = FlatStyle.Standard;
        }

        private void button8_MouseLeave(object sender, EventArgs e)
        {
            button8.FlatStyle = FlatStyle.Flat;
        }

        private void button8_MouseUp(object sender, MouseEventArgs e)
        {
            button8.Size = new Size(100, 100);
            button8.Location = new Point(button8.Location.X - 5, button8.Location.Y - 5);
        }

        private void button8_MouseDown(object sender, MouseEventArgs e)
        {
            button8.Size = new Size(90, 90);
            button8.Location = new Point(button8.Location.X + 5, button8.Location.Y + 5);

           
        }

        private void button9_MouseEnter(object sender, EventArgs e)
        {
            button9.FlatStyle = FlatStyle.Standard;
        }

        private void button9_MouseLeave(object sender, EventArgs e)
        {
            button9.FlatStyle = FlatStyle.Flat;

        }

        private void button9_MouseUp(object sender, MouseEventArgs e)
        {
            button9.Size = new Size(100, 100);
            button9.Location = new Point(button9.Location.X - 5, button9.Location.Y - 5);
        }

        private void button9_MouseDown(object sender, MouseEventArgs e)
        {
            button9.Size = new Size(90, 90);
            button9.Location = new Point(button9.Location.X + 5, button9.Location.Y + 5);

            
        }

        private void button10_MouseEnter(object sender, EventArgs e)
        {
            button10.FlatStyle = FlatStyle.Standard;

        }

        private void button10_MouseLeave(object sender, EventArgs e)
        {
            button10.FlatStyle = FlatStyle.Flat;

        }

        private void button10_MouseUp(object sender, MouseEventArgs e)
        {
            button10.Size = new Size(100, 100);
            button10.Location = new Point(button10.Location.X - 5, button10.Location.Y - 5);
        }

        private void button10_MouseDown(object sender, MouseEventArgs e)
        {
            button10.Size = new Size(90, 90);
            button10.Location = new Point(button10.Location.X + 5, button10.Location.Y + 5);

           
        }

        private void button8_Click(object sender, EventArgs e)
        {
            secondCardForm sc = new secondCardForm();
            sc.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            lostCardform ls=new lostCardform();
            ls.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            dateFindLostForm dt=new dateFindLostForm();
            dt.Show();
        }

        private void button12_MouseEnter(object sender, EventArgs e)
        {
            button12.FlatStyle = FlatStyle.Standard;

        }

        private void button12_MouseLeave(object sender, EventArgs e)
        {
            button12.FlatStyle = FlatStyle.Flat;

        }

        private void button12_MouseDown(object sender, MouseEventArgs e)
        {
            button12.Size = new Size(90, 90);
            button12.Location = new Point(button12.Location.X + 5, button12.Location.Y + 5);
        }

        private void button12_MouseUp(object sender, MouseEventArgs e)
        {
            button12.Size = new Size(100, 100);
            button12.Location = new Point(button12.Location.X - 5, button12.Location.Y - 5);
        }

        private void button13_MouseEnter(object sender, EventArgs e)
        {
            button13.FlatStyle = FlatStyle.Standard;

        }

        private void button13_MouseLeave(object sender, EventArgs e)
        {
            button13.FlatStyle = FlatStyle.Flat;

        }

        private void button13_MouseDown(object sender, MouseEventArgs e)
        {
            button13.Size = new Size(90, 90);
            button13.Location = new Point(button13.Location.X + 5, button13.Location.Y + 5);
        }

        private void button13_MouseUp(object sender, MouseEventArgs e)
        {
            button13.Size = new Size(100, 100);
            button13.Location = new Point(button13.Location.X - 5, button13.Location.Y - 5);
        }

        private void smsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        
       

        private void کاربرجدیدToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var ali = new userAccounts();
            ali.Show();
        }

        private void مدیریتکاربرهاToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var um = new UserManager();
            um.user = user;
            um.Show();
        }

        private void backupTime_Tick(object sender, EventArgs e)
        {
            PersianCalendar pc = new PersianCalendar();

                var n = DateTime.Now;
                string date = "(" + pc.GetYear(n).ToString() + "-" + pc.GetMonth(n).ToString() + "-" + pc.GetDayOfMonth(n).ToString() + ")";
                string time = "(" + pc.GetHour(n).ToString() + "-" + pc.GetMinute(n).ToString() + "-" +
                              pc.GetSecond(n).ToString() + ")";

            try
            {


                string str = "D:\\empCardBackUp " + date + " " + time+".bak";
                

                
                    SqlConnection sq =
                        new SqlConnection(
                            @"data source=.\SQLEXPRESS;initial catalog=EmployeeCard;integrated security=True");
                    sq.Open();
                    SqlCommand scq =
                        new SqlCommand(
                            @"BACKUP DATABASE [EmployeeCard] TO  DISK = N'" + @str +
                            "' WITH NOFORMAT, NOINIT,  NAME = N'EmployeeCard-Full Database Backup', SKIP, NOREWIND, NOUNLOAD,  STATS = 10",
                            sq);
                    scq.ExecuteNonQuery();
                    sq.Close();
                    lblTimeUp.Text = date + " " + time;
                
            }
            catch (Exception ex)
            {
                lblTimeUp.Text = "failed at " + time;
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            cardAgainForm ls=new cardAgainForm();
            ls.Show();
        }

        private void button11_MouseDown(object sender, MouseEventArgs e)
        {
            button11.Size = new Size(90, 90);
            button11.Location = new Point(button11.Location.X + 5, button11.Location.Y + 5);
        }

        private void button11_MouseEnter(object sender, EventArgs e)
        {
            button11.FlatStyle = FlatStyle.Standard;
        }

        private void button11_MouseLeave(object sender, EventArgs e)
        {
            button11.FlatStyle = FlatStyle.Flat;
        }

        private void button11_MouseUp(object sender, MouseEventArgs e)
        {
            button11.Size = new Size(100, 100);
            button11.Location = new Point(button11.Location.X - 5, button11.Location.Y - 5);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text == "iwantdeleteemp")
            {
                textBox1.Text = null;
                remove rmv = new remove();
                rmv.Show();
            }
        }

       

        

        
       

       
       

        

        


    }
}

