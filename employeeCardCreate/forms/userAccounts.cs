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
    public partial class userAccounts : Form
    {
        public userAccounts()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string a = textBox1.Text;
            string b=StartForm.EmpDb.users.Where(
                i => i.username.Equals(a))
                .Select(j => j.username)
                .SingleOrDefault();
            if (a != b)
            {
                if (textBox2.Text == textBox3.Text)
                {
                    string admin = checkBox1.Checked ? "true      " : "false     ";

                    var user = new user
                    {
                        username = textBox1.Text,
                        password = textBox2.Text.GetHashCode().ToString(CultureInfo.InvariantCulture),
                        access=admin
                    };

                    StartForm.EmpDb.users.Add(user);
                    StartForm.EmpDb.SaveChanges();
                    MessageBox.Show("کاربر با موفقیت ثبت شد");
                }
                else
                {
                    MessageBox.Show("رمز ها با هم همخوانی ندارند لطفا دوباره سعی کنید");
                    textBox2.Text = null;
                    textBox3.Text = null;
                    textBox2.Focus();
                }
            }
            else
            {
                MessageBox.Show("این کاربر موجود می باشد");
                textBox1.Text = null;
                textBox1.Focus();
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (textBox2.Text.Length <= 4)
                textBox2.BackColor = Color.Red;
            if (textBox2.Text.Length > 4 && textBox2.Text.Length<=8)
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
    }
}
