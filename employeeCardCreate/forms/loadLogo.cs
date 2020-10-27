using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using employeeCardCreate.forms;
using employeeCardCreate.classes;

namespace employeeCardCreate
{
    public partial class loadLogo : Form
    {
        public loadLogo()
        {
            InitializeComponent();
        }

        private void loadLogo_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Hide();
            //ConnectionForm form = new connectionform();
            pass form = new pass();
            timer1.Stop();
            form.Show();
        }
    }
}
