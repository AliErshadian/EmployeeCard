using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace employeeCardCreate
{
    public partial class companyForm : Form
    {
        public companyForm()
        {
            InitializeComponent();
        }
        private List<long> coIDLi = new List<long>();
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                var id = (comboBox1.Text + textBox2.Text + textBox3.Text).GetHashCode();


                var emp = new CompanyProperty
                {
                    ID=id,
                    CompanyName = comboBox1.Text,
                    RepresendativeName = textBox2.Text,
                    PhoneNumber = textBox3.Text
                };


                ////////////
                StartForm.EmpDb.CompanyProperties.Add(emp);
                StartForm.EmpDb.SaveChanges();

                /////
                var emp1 = StartForm.EmpDb.CompanyProperties.Select(companyname => companyname.CompanyName).ToList();
                var emp2 = StartForm.EmpDb.CompanyProperties.Select(ids => ids.ID).ToList();

                comboBox1.Items.Clear();
                coIDLi.Clear();

                foreach (var item in emp1)
                {
                    comboBox1.Items.Add(item);
                }

                coIDLi.AddRange(emp2);

                StartForm.showBalloon("!!!!توجه!!!!", "شرکت یا طرح جدید اضافه شد");

                DialogResult dlgr;
                

                dlgr=MessageBox.Show("طرح یا شرکت مورد نظر  با موفقیت ثبت شد\nآیا قصد ثبت جدید دارید؟","پیام",MessageBoxButtons.OKCancel,MessageBoxIcon.Question);
                if (dlgr == DialogResult.Cancel)
                {
                    this.Close();
                }

                else
                {
                    comboBox1.Text = null;
                    textBox2.Clear();
                    textBox3.Clear();
                    comboBox1.Focus();
                }
            }
            catch
            {
            }


            
        }

        private void companyForm_Load(object sender, EventArgs e)
        {
            var emp = StartForm.EmpDb.CompanyProperties.Select(companyname => companyname.CompanyName).ToList();
            var emp2 = StartForm.EmpDb.CompanyProperties.Select(ids => ids.ID).ToList();

            foreach (var item in emp)
            {
                comboBox1.Items.Add(item);
            }
            coIDLi.AddRange(emp2);
        }

        private void companyForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {


                DialogResult dlgr;


                dlgr = MessageBox.Show("آیا قصد حذف دارید؟", "پیام", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (dlgr == DialogResult.Cancel)
                {
                    this.Close();
                }

                else
                {
                    int a = comboBox1.SelectedIndex;
                    long aa = coIDLi[a];
                    StartForm.EmpDb.CompanyProperties.Remove(StartForm.EmpDb.CompanyProperties.First(i => i.ID == aa));

                    StartForm.EmpDb.SaveChanges();

                    comboBox1.Text = "";
                    comboBox1.Items.Clear();
                    coIDLi.Clear();

                    var emp1 = StartForm.EmpDb.CompanyProperties.Select(companyname => companyname.CompanyName).ToList();
                    var emp2 = StartForm.EmpDb.CompanyProperties.Select(ids => ids.ID).ToList();



                    foreach (var item in emp1)
                    {
                        comboBox1.Items.Add(item);
                    }

                    coIDLi.AddRange(emp2);
                }
            }
            catch
            {
                MessageBox.Show("خطا");
            }
            
        }
        
    }
}
