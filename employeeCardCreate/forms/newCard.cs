using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Drawing.Printing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using MessagingToolkit.QRCode.Codec;


namespace employeeCardCreate
{
    public partial class newCard : Form
    {




        PersianCalendar pc = new PersianCalendar();
        byte[] imageperson = null;
        public static Bitmap newbmp2;
        public string mounth;
        private long IdTotal;

        public newCard()
        {
            InitializeComponent();
        }

        public static string companyName;
        public static string companyResName;
        public static string companyNum;
        public static string contractorName;
        public static string contractorResName;
        public static string contractorNum;
        

        private void buttoncreate_Click(object sender, EventArgs e)
        {
            try
            {
                companyName = comboBox2.SelectedItem.ToString();
                companyResName =
                    StartForm.EmpDb.CompanyProperties.Where(i => i.CompanyName.Equals(companyName))
                        .Select(j => j.RepresendativeName).SingleOrDefault();
                companyNum =
                    StartForm.EmpDb.CompanyProperties.Where(i => i.CompanyName.Equals(companyName))
                        .Select(j => j.PhoneNumber).SingleOrDefault();

                contractorName = comboBox3.SelectedItem.ToString();
                contractorResName =
                    StartForm.EmpDb.ContractorProperties.Where(i => i.ContractorName.Equals(contractorName))
                        .Select(j => j.RepresendativeName).SingleOrDefault();
                contractorNum =
                    StartForm.EmpDb.ContractorProperties.Where(i => i.ContractorName.Equals(contractorName))
                        .Select(j => j.PhoneNumber).SingleOrDefault();


                var id = (FirstNametxt.Text + LastNametxt.Text + BirthDatetxt.Text + BirthPlacetxt.Text).GetHashCode();

                var user = StartForm.user;

                const string photopath = @"photos\";
                newbmp2.Save(photopath + "photo(" + id + ").jpg", ImageFormat.Jpeg);
                
                var fs = new FileStream((photopath + "photo(" + id + ").jpg"), FileMode.Open, FileAccess.Read);
                var br = new BinaryReader(fs);
                imageperson = br.ReadBytes((int)fs.Length);

                /// create new employee to database
                
                var emp = new Employee
                {
                    ID = id,
                    FirstName = FirstNametxt.Text,
                    LastName = LastNametxt.Text,
                    FatherName = FatherNametxt.Text,
                    BirthDate = DateTime.Parse(BirthDatetxt.Text),
                    BirthPlace = BirthPlacetxt.Text,
                    NationalId = NationalIdtxt.Text,
                    NationalCode = NationalCodetxt.Text,
                    PassportId = PassportIdtxt.Text,
                    Region = Regiontxt.Text,
                    JobSituation = JobSituationcmb.SelectedItem.ToString(),
                    LetterId = LetterIdtxt.Text,
                    AnalArea = AnalAreatxt.Text,
                    FirstArea = FirstAreatxt.Text,
                    SecondArea = SecondAreatxt.Text,
                    CreateDate = DateTime.Parse(CreateDatetxt.Text),
                    ExpireDate = DateTime.Parse(ExpireDatetxt.Text),
                    Image = imageperson,
                    CompanyName = companyName,
                    CompanyResName = companyResName,
                    CompanyNum = companyNum,
                    ContractorName = contractorName,
                    ContractorResName = contractorResName,
                    ContarctorNum = contractorNum,
                    Print=0,
                    @is = 1,
                    user=user
                    
                };
                StartForm.EmpDb.Employees.Add(emp);
                StartForm.EmpDb.SaveChanges();
                ///////////////////////////////////////////////////////////////////
                StartForm.showBalloon("!!!!توجه!!!!", "کارمند جدید با موفقیت اضافه شد");
                /// qr
                var encoder = new QRCodeEncoder();
                var qrImg = encoder.Encode(id.ToString());
                var finalimg = (Image) (new Bitmap(qrImg, 65, 65));
                ////////////////////////////////////////////////////////////////////

                

                /// reset start form string bases
                companyName = null;
                companyResName = null;
                companyNum = null;
                contractorName = null;
                contractorResName = null;
                contractorNum = null;
                ///////////////////////////////////////////////////////////////////////

                
                Bitmap bmpaa = new Bitmap(print.CardEmp(id),546,221);
                pictureBox1.Image = bmpaa;
                IdTotal = id;


                button2.Enabled = true;
                button3.Enabled = true;
                buttoncreate.Enabled = false;
                buttoncreate.BackColor = System.Drawing.Color.DarkSlateGray;
                button2.BackColor = System.Drawing.Color.DeepSkyBlue;
                button3.BackColor = System.Drawing.Color.DeepSkyBlue;

                
                



            }
            catch(Exception es)
            {
                MessageBox.Show("ایجاد نا موفق");
            }
        }

        private void newCard_Load(object sender, EventArgs e)
        {
            var emp1 = StartForm.EmpDb.CompanyProperties.Select(companyname => companyname.CompanyName).ToList();

            foreach (var item in emp1)
            {
                comboBox2.Items.Add(item);
            }

            var emp2 = StartForm.EmpDb.ContractorProperties.Select(contractorname => contractorname.ContractorName).ToList();

            foreach (var item in emp2)
            {
                comboBox3.Items.Add(item);
            }


            var n = DateTime.Now;
            CreateDatetxt.Text = pc.GetYear(n).ToString() + "/" + pc.GetMonth(n).ToString() + "/" + pc.GetDayOfMonth(n).ToString();

            comboBox2.Focus();
        }

        private void photoBox_DoubleClick(object sender, EventArgs e)
        {
            var dlg = new OpenFileDialog {Title = "Open Image", Filter = "jpeg files (*.jpg)|*.jpg"};
            //Bitmap newbmp;
            
            ImageEditing imge=new ImageEditing();
            imge.FormClosing += imge_FormClosing;
            imge.a = 1;

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                imge.Bmpp=new Bitmap(dlg.FileName);
                imge.Show();
                //newbmp = new Bitmap(dlg.FileName);
                
                //photoBox.BackgroundImage = newbmp;
                //newbmp2 = new Bitmap(newbmp,90,120 );


            }

            dlg.Dispose();




        }

        private void imge_FormClosing(object sender, FormClosingEventArgs formClosingEventArgs)
        {
            photoBox.Image = new Bitmap(newbmp2, 112, 141);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var n = DateTime.Now.Date.AddMonths(int.Parse(comboBox1.SelectedItem.ToString()));
            ExpireDatetxt.Text = pc.GetYear(n).ToString() + "/" + pc.GetMonth(n).ToString() + "/" + pc.GetDayOfMonth(n).ToString();


        }

        private void button3_Click(object sender, EventArgs e)
        {
            ChoseRegionFrm frm = new ChoseRegionFrm();
            this.Close();
            frm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            print.card = print.CardEmp(IdTotal);
            print.idd = IdTotal;
            print.intial = 1;
            print.printTest();
        }

        private void comboBox2_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    
                        companyName = comboBox2.Text;
                        companyResName =
                            StartForm.EmpDb.CompanyProperties.Where(i => i.CompanyName.Equals(companyName))
                                .Select(j => j.RepresendativeName).SingleOrDefault();
                        companyNum =
                            StartForm.EmpDb.CompanyProperties.Where(i => i.CompanyName.Equals(companyName))
                                .Select(j => j.PhoneNumber).SingleOrDefault();
                    comboBox3.Focus();


                }

            }
            catch
            {
                MessageBox.Show("لطفا طرح یا شرکتی را انتخاب کنید");
            }
        }

        private void comboBox3_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    contractorName = comboBox3.Text;
                    contractorResName =
                        StartForm.EmpDb.ContractorProperties.Where(i => i.ContractorName.Equals(contractorName))
                            .Select(j => j.RepresendativeName).SingleOrDefault();
                    contractorNum =
                        StartForm.EmpDb.ContractorProperties.Where(i => i.ContractorName.Equals(contractorName))
                            .Select(j => j.PhoneNumber).SingleOrDefault();
                    FirstNametxt.Focus();
                }

            }
            catch
            {
                MessageBox.Show("لطفا طرح یا شرکتی را انتخاب کنید");
            }
        }

        private void NationalCodetxt_Leave(object sender, EventArgs e)
        {
           
            trueCode(NationalCodetxt.Text);
            
        }

        public void trueCode(string str)
        {
            if (str.Length == 10)
            {
                if (str == "0000000000" || str == "1111111111" ||
                    str == "2222222222"
                    || str == "3333333333" || str == "4444444444" ||
                    str == "5555555555"
                    || str == "6666666666" || str == "7777777777" ||
                    str == "8888888888"
                    || str == "9999999999")
                {
                    MessageBox.Show("کد ملی وارد شده نا معتبر می باشد");
                    NationalCodetxt.Text = null;
                    NationalCodetxt.Focus();

                }
                else
                {
                    var cc = str.ToCharArray();
                    var c = int.Parse(cc.GetValue(9).ToString());
                    var n = int.Parse(cc.GetValue(0).ToString())*10
                            + int.Parse(cc.GetValue(1).ToString())*9 + int.Parse(cc.GetValue(2).ToString())*8
                            + int.Parse(cc.GetValue(3).ToString())*7 + int.Parse(cc.GetValue(4).ToString())*6
                            + int.Parse(cc.GetValue(5).ToString())*5 + int.Parse(cc.GetValue(6).ToString())*4
                            + int.Parse(cc.GetValue(7).ToString())*3 + int.Parse(cc.GetValue(8).ToString())*2;
                    int rr = n/11;
                    var r = n - rr*11;
                    if ((r == 0 && r == c) || (r == 1 && c == 1) || (r > 1 && c == 11 - r))
                    {
                        var emp =
                            StartForm.EmpDb.Employees.Where(i => i.NationalCode == NationalCodetxt.Text)
                                .Select(j => j.NationalCode)
                                .SingleOrDefault();
                        if (NationalCodetxt.Text == emp)
                        {
                            NationalCodetxt.Text = "";
                            NationalCodetxt.Focus();
                            MessageBox.Show("کد ملی موجود می باشد دوباره سعی کنید");
                        }
                    }
                    else
                    {
                        NationalCodetxt.Text = "";
                        NationalCodetxt.Focus();
                        MessageBox.Show("کد ملی نامعتبر است دوباره سعی کنید");
                    }

                }
            }
            else
            {
                  MessageBox.Show("کد ملی باید 10 رقم باشد");
                  NationalCodetxt.Text = null;
                  NationalCodetxt.Focus();
            }
        }

       

        private void comboBox2_Leave(object sender, EventArgs e)
        {
            try
            {
                

                    companyName = comboBox2.Text;
                    companyResName =
                        StartForm.EmpDb.CompanyProperties.Where(i => i.CompanyName.Equals(companyName))
                            .Select(j => j.RepresendativeName).SingleOrDefault();
                    companyNum =
                        StartForm.EmpDb.CompanyProperties.Where(i => i.CompanyName.Equals(companyName))
                            .Select(j => j.PhoneNumber).SingleOrDefault();
                    comboBox3.Focus();


                

            }
            catch
            {
                MessageBox.Show("لطفا طرح یا شرکتی را انتخاب کنید");
            }
        }

        private void comboBox3_Leave(object sender, EventArgs e)
        {
            try
            {
                
                    contractorName = comboBox3.Text;
                    contractorResName =
                        StartForm.EmpDb.ContractorProperties.Where(i => i.ContractorName.Equals(contractorName))
                            .Select(j => j.RepresendativeName).SingleOrDefault();
                    contractorNum =
                        StartForm.EmpDb.ContractorProperties.Where(i => i.ContractorName.Equals(contractorName))
                            .Select(j => j.PhoneNumber).SingleOrDefault();
                    
                

            }
            catch
            {
                MessageBox.Show("لطفا طرح یا شرکتی را انتخاب کنید");
            }
        }

        private void NationalCodetxt_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        

        
    }
}
