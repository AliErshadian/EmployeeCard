using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace employeeCardCreate
{
    public partial class cardAgainForm : Form
    {
        public cardAgainForm()
        {
            InitializeComponent();
        }

        public long id;

        private void button4_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            try
            {
                var finalcode = long.Parse(textBox3.Text);
                var code =
                    StartForm.EmpDb.Employees.Where(i => i.ID == finalcode);
                dataGridView1.DataSource = code.ToList();
                id = finalcode;
                pictureBox1.BackgroundImage = print.CardEmp(id);
            }
            catch
            {

                MessageBox.Show("خطا در جستجو");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;

            try
            {
                var name =
                    StartForm.EmpDb.Employees.Where(
                        i => (i.LastName + " " + i.FirstName) == (string) comboBox1.SelectedItem);
                dataGridView1.DataSource = name.ToList();



                id = long.Parse(dataGridView1.Rows[0].Cells[0].Value.ToString());
                pictureBox1.BackgroundImage = print.CardEmp(id);
            }
            catch
            {

                MessageBox.Show("خطا در جستجو");
            }
        }

        private string todayDate;
        private string expireDate;

        private void cardAgainForm_Load(object sender, EventArgs e)
        {
            var emp =
                StartForm.EmpDb.Employees.Select(lastname => lastname.LastName + " " + lastname.FirstName).ToList();

            foreach (var item in emp)
            {
                comboBox1.Items.Add(item);
            }

            var nn = DateTime.Now;
            todayDate = pc.GetYear(nn).ToString() + "/" + pc.GetMonth(nn).ToString() + "/" +
                        pc.GetDayOfMonth(nn).ToString();
            todaytxt.Text = todayDate;
        }

        private PersianCalendar pc = new PersianCalendar();

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult dlg = new DialogResult();
            dlg = MessageBox.Show("آیا مطمئن هستید؟", "هشدار", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dlg == DialogResult.OK)
            {
                Employee empp = StartForm.EmpDb.Employees.First(i => i.ID == id);

                empp.CreateDate = DateTime.Parse(todayDate);
                empp.ExpireDate = DateTime.Parse(expireDate);

                StartForm.EmpDb.SaveChanges();
                pictureBox1.BackgroundImage = print.CardEmp(id);
                button2.Enabled = true;
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            var n = DateTime.Now.Date.AddMonths(int.Parse(comboBox2.SelectedItem.ToString()));
            expireDate = pc.GetYear(n).ToString() + "/" + pc.GetMonth(n).ToString() + "/" +
                         pc.GetDayOfMonth(n).ToString();
            expireTxt.Text = expireDate;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            print.card = print.CardEmp(id);
            print.idd = id;
            print.intial = 1;
            print.printTest();
        }
    }
}
