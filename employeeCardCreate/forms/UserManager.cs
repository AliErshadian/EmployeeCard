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
    public partial class UserManager : Form
    {
        public UserManager()
        {
            InitializeComponent();
        }

        public string user;
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string username = listBox1.SelectedItem.ToString();
                var us = StartForm.EmpDb.users.First(i => i.username == username);
                StartForm.EmpDb.users.Remove(us);
                StartForm.EmpDb.SaveChanges();


                label2.Text = "";

                listBox1.Items.Clear();

                var users = StartForm.EmpDb.users.Where(i => i.access == "false     ").Select(j => j.username).ToList();
                foreach (var item in users)
                {
                    listBox1.Items.Add(item);
                }
            }
            catch (Exception)
            {

                label2.Text = "!!!!کاربری انتخاب نشده!!!!";
            }
            


        }

        private void UserManager_Load(object sender, EventArgs e)
        {
            var user = StartForm.EmpDb.users.Where(i => i.access == "false     ").Select(j => j.username).ToList();
            foreach (var item in user)
            {
                listBox1.Items.Add(item);
            }
            
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (textBox2.Text.Length <= 4)
                textBox2.BackColor = Color.Red;
            if (textBox2.Text.Length > 4 && textBox2.Text.Length <= 8)
            {
                textBox2.BackColor = Color.Yellow;
            }
            if (textBox2.Text.Length > 8)
                textBox2.BackColor = Color.LimeGreen;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (textBox3.Text.Length <= 4)
                textBox3.BackColor = Color.Red;
            if (textBox3.Text.Length > 4 && textBox2.Text.Length <= 8)
            {
                textBox3.BackColor = Color.Yellow;
            }
            if (textBox3.Text.Length > 8)
                textBox3.BackColor = Color.LimeGreen;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                textBox2.UseSystemPasswordChar = false;
                textBox3.UseSystemPasswordChar = false;
            }
            else
            {
                textBox2.UseSystemPasswordChar = true;
                textBox3.UseSystemPasswordChar = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                
                string a = textBox1.Text.GetHashCode().ToString(CultureInfo.InvariantCulture);
                string b = StartForm.EmpDb.users.Where(i => i.username == user).Select(j => j.password).SingleOrDefault();


                var pass = StartForm.EmpDb.users.First(i => i.password == b);

                if (a == b)
                {
                        if (textBox2.Text == textBox3.Text)
                        {
                            pass.password = textBox2.Text.GetHashCode().ToString(CultureInfo.InvariantCulture);
                        }
                }

                StartForm.EmpDb.SaveChanges();



                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                MessageBox.Show("رمز با موفقیت تغییر یافت");
            }
            catch
            {
                MessageBox.Show("خطا");
                
            }
            
        }

       
    }
}
