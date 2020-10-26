using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace employeeCardCreate
{
    public partial class remove : Form
    {
        public remove()
        {
            InitializeComponent();
        }

        private void remove_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = StartForm.EmpDb.Employees.ToList();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int a = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
                Employee table = StartForm.EmpDb.Employees.First(i => i.ID == a);
                StartForm.EmpDb.Employees.Remove(table);
                StartForm.EmpDb.SaveChanges();

                string filepath = @"photos\" + "photo(" + a + ").jpg";

                if (File.Exists(filepath))
                {
                    File.Delete(filepath);

                }
                else
                {
                    MessageBox.Show("عکس کارمند از قبل پاک شده است");
                }

                MessageBox.Show("حذف گردید");



                dataGridView1.DataSource = StartForm.EmpDb.Employees.ToList();
            }
            catch
            {
                
            }
        }
    }
}
