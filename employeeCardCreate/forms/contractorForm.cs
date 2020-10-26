using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace employeeCardCreate
{
    public partial class contractorForm : Form
    {
        public contractorForm()
        {
            InitializeComponent();
        }
        private List<long> coIDLi = new List<long>();
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                var id = (comboBox1.Text + textBox2.Text + textBox3.Text).GetHashCode();


                var emp = new ContractorProperty
                {
                    ID=id,
                    ContractorName = comboBox1.Text,
                    RepresendativeName = textBox2.Text,
                    PhoneNumber = textBox3.Text
                };


                ////////////
                StartForm.EmpDb.ContractorProperties.Add(emp);
                StartForm.EmpDb.SaveChanges();

                /////
                var emp1 = StartForm.EmpDb.ContractorProperties.Select(conytractorname => conytractorname.ContractorName).ToList();
                var emp2 = StartForm.EmpDb.ContractorProperties.Select(ids => ids.ID).ToList();


                comboBox1.Items.Clear();
                coIDLi.Clear();

                foreach (var item in emp1)
                {
                    comboBox1.Items.Add(item);
                }

                coIDLi.AddRange(emp2);

                StartForm.showBalloon("!!!!توجه!!!!", "پیمانکار جدید اضافه شد");

                DialogResult dlgr;
                

                dlgr=MessageBox.Show("پیمانکار مورد نظر  با موفقیت ثبت شد\nآیا قصد ثبت جدید دارید؟","پیام",MessageBoxButtons.OKCancel,MessageBoxIcon.Question);
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
            var emp = StartForm.EmpDb.ContractorProperties.Select(conytractorname => conytractorname.ContractorName).ToList();
            var emp2 = StartForm.EmpDb.ContractorProperties.Select(ids => ids.ID).ToList();

            foreach (var item in emp)
            {
                comboBox1.Items.Add(item);
            }

            coIDLi.AddRange(emp2);
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
                    StartForm.EmpDb.ContractorProperties.Remove(
                        StartForm.EmpDb.ContractorProperties.First(i => i.ID == aa));

                    StartForm.EmpDb.SaveChanges();

                    comboBox1.Text = "";
                    comboBox1.Items.Clear();
                    coIDLi.Clear();

                    var emp =
                        StartForm.EmpDb.ContractorProperties.Select(conytractorname => conytractorname.ContractorName)
                            .ToList();
                    var emp2 = StartForm.EmpDb.ContractorProperties.Select(ids => ids.ID).ToList();



                    foreach (var item in emp)
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
