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
    public partial class lostCardform : Form
    {
        public lostCardform()
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
                    StartForm.EmpDb.Employees.Where(i => (i.LastName + " " + i.FirstName) == (string)comboBox1.SelectedItem);
                dataGridView1.DataSource = name.ToList();



                id = long.Parse(dataGridView1.Rows[0].Cells[0].Value.ToString());
            }
            catch
            {

                MessageBox.Show("خطا در جستجو");
            }
        }

        private void lostCardform_Load(object sender, EventArgs e)
        {
            var emp = StartForm.EmpDb.Employees.Select(lastname => lastname.LastName + " " + lastname.FirstName).ToList();

            foreach (var item in emp)
            {
                comboBox1.Items.Add(item);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PersianCalendar pc = new PersianCalendar();
            var n = DateTime.Now;
            string st = pc.GetYear(n).ToString() + "/" + pc.GetMonth(n).ToString() + "/" + pc.GetDayOfMonth(n).ToString();
            


            DialogResult dlg = new DialogResult();
            dlg = MessageBox.Show("آیا مطمئن هستید؟", "هشدار", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            try
            {
                if (dlg == DialogResult.OK)
                {

                    Employee empp = StartForm.EmpDb.Employees.First(i => i.ID == id);
                    empp.LostCard = "true";
                    empp.TypeLostCard = textBox1.Text;
                    empp.LostCardDate = DateTime.Parse(st);

                    StartForm.EmpDb.SaveChanges();
                    MessageBox.Show("با موفقیت انجام شد");
                }
            }
            catch
            {

                MessageBox.Show("انتخاب کنید");
            }
           
        }
    }
}
