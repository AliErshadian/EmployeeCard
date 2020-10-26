using System.Linq;
using MessagingToolkit.QRCode.Codec;
using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Globalization;
using System.IO;
using System.Windows.Forms;

namespace employeeCardCreate
{
    public partial class newCard2 : Form
    {




        PersianCalendar pc = new PersianCalendar();
        byte[] imageperson = null;
        public static Bitmap newbmp2;
        public string mounth;
        private long IdTotal;


        public newCard2()
        {
            InitializeComponent();
        }

        public  string companyName;
        public  string companyResName;
        public  string companyNum;
        public  string contractorName;
        public  string contractorResName;
        public  string contractorNum;
        

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
                    BirthDate = DateTime.Parse(BirthDatetxt.Text),
                    BirthPlace = BirthPlacetxt.Text,
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
                    Print = 0,
                    @is=0,
                    user=user
                };
                StartForm.EmpDb.Employees.Add(emp);
                StartForm.EmpDb.SaveChanges();
                ///////////////////////////////////////////////////////////////////
                StartForm.showBalloon("!!!!توجه!!!!", "کارمند جدید با موفقیت اضافه شد");
                /// qr
                var encoder = new QRCodeEncoder();
                var qrImg = encoder.Encode(id.ToString());
                var finalimg = (Image)(new Bitmap(qrImg, 65, 65));
                ////////////////////////////////////////////////////////////////////



                /// reset start form string bases
                companyName = null;
                companyResName = null;
                companyNum = null;
                contractorName = null;
                contractorResName = null;
                contractorNum = null;
                ///////////////////////////////////////////////////////////////////////


                Bitmap bmpaa = new Bitmap(print.CardEmp(id), 546, 221);
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
                MessageBox.Show(es.ToString());
            }

        }

        private void newCard_Load(object sender, EventArgs e)
        {
            var n = DateTime.Now;
            CreateDatetxt.Text = pc.GetYear(n).ToString() + "/" + pc.GetMonth(n).ToString() + "/" + pc.GetDayOfMonth(n).ToString();


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
        }

        private void photoBox_DoubleClick(object sender, EventArgs e)
        {
            var dlg = new OpenFileDialog { Title = "Open Image", Filter = "jpeg files (*.jpg)|*.jpg" };
            //Bitmap newbmp;
            ImageEditing imge = new ImageEditing();
            imge.FormClosing += imge_FormClosing;
            imge.a = 2;

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                imge.Bmpp = new Bitmap(dlg.FileName);
                imge.Show();
                //newbmp = new Bitmap(dlg.FileName);

                //photoBox.BackgroundImage = newbmp;
                //newbmp2 = new Bitmap(newbmp, 90, 120);

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

        private void button2_Click(object sender, EventArgs e)
        {
            print.card = print.CardEmp(IdTotal);
            print.idd = IdTotal;
            print.intial = 1;
            print.printTest();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ChoseRegionFrm frm = new ChoseRegionFrm();
            this.Close();
            frm.Show();
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

        private void PassportIdtxt_Leave(object sender, EventArgs e)
        {
            var emp =
                StartForm.EmpDb.Employees.Where(i => i.PassportId == PassportIdtxt.Text)
                    .Select(j => j.PassportId)
                    .SingleOrDefault();
            if (PassportIdtxt.Text == emp)
            {
                PassportIdtxt.Text = "";
                PassportIdtxt.Focus();
                MessageBox.Show("شماره گذر نامه موجود می باشد دوباره سعی کنید");
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

        
    }
}
