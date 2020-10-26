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
    public partial class pass : Form
    {
        public pass()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string _username = txtUser.Text;
            string _password = txtPass.Text.GetHashCode().ToString(CultureInfo.InvariantCulture);

            string _access = StartForm.EmpDb.users.Where(
                i => i.username.Equals(_username))
                .Select(j => j.access)
                .SingleOrDefault();

            string _DBusername = StartForm.EmpDb.users.Where(
                i => i.username.Equals(_username))
                .Select(j => j.username)
                .SingleOrDefault();
            string _DBpassword = StartForm.EmpDb.users.Where(
                i => i.password.Equals(_password))
                .Select(j => j.password)
                .SingleOrDefault();
            if ((_username == _DBusername) &&
                (_password == _DBpassword))
            {
                this.Hide();
                StartForm frm = new StartForm();
                StartForm.user = _username;
                frm.access = _access;
                frm.Show();
            }
            else if (txtUser.Text == "" && txtPass.Text == "")
            {
                MessageBox.Show("لطفا نام کاربری و رمز عبور را وارد کنید", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtUser.Text == "" && txtPass.Text != "")
            {
                MessageBox.Show("لطفا نام کاربری را وارد کنید", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtUser.Text != "" && txtPass.Text == "")
            {
                MessageBox.Show("لطفا رمز عبور را وارد کنید", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("نام کاربری و رمز عبور اشتباه وارد شده است", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pass_Load(object sender, EventArgs e)
        {
            txtUser.Focus();
            
        }
    }
}
