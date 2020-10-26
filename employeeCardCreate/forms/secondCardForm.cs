using MessagingToolkit.QRCode.Codec;
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
    public partial class secondCardForm : Form
    {
        public secondCardForm()
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
                pictureBox1.BackgroundImage = printSecond.CardEmp(id);
            }
            catch
            {

                MessageBox.Show("خطا در جستجو");
            }
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult dlg = new DialogResult();
            dlg = MessageBox.Show("آیا مطمئن هستید؟","هشدار",MessageBoxButtons.OKCancel,MessageBoxIcon.Question);
            if (dlg == DialogResult.OK)
            {
                PersianCalendar pc = new PersianCalendar();
                var n = DateTime.Now;
                var tm = pc.GetYear(n).ToString() + "/" + pc.GetMonth(n).ToString() + "/" +
                         pc.GetDayOfMonth(n).ToString();
                Employee empp = StartForm.EmpDb.Employees.First(i => i.ID == id);
                if (empp.DateSecondaryCard == null)
                {
                    empp.SecondaryCard = 1;
                }
                else
                {
                    empp.SecondaryCard++;
                }
                empp.DateSecondaryCard = DateTime.Parse(tm);

                StartForm.EmpDb.SaveChanges();
                button2.Enabled = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            printSecond.card = printSecond.CardEmp(id);
            printSecond.idd = id;
            printSecond.intial = 1;
            printSecond.printTest();
        }

        private void secondCardForm_Load(object sender, EventArgs e)
        {
            var emp = StartForm.EmpDb.Employees.Select(lastname => lastname.LastName + " " + lastname.FirstName).ToList();

            foreach (var item in emp)
            {
                comboBox1.Items.Add(item);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;

            try
            {
                var name =
                    StartForm.EmpDb.Employees.Where(i => (i.LastName + " " + i.FirstName) == (string)comboBox1.SelectedItem);
                dataGridView1.DataSource = name.ToList();



                id = long.Parse(dataGridView1.Rows[0].Cells[0].Value.ToString());
                pictureBox1.BackgroundImage = printSecond.CardEmp(id);
            }
            catch
            {

                MessageBox.Show("خطا در جستجو");
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
