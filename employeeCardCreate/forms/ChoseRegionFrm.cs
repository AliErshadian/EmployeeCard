using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace employeeCardCreate
{
    public partial class ChoseRegionFrm : Form
    {
        public ChoseRegionFrm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            newCard card=new newCard();
            this.Hide();
            card.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            newCard2 card = new newCard2();
            this.Hide();
            card.Show();
        }
    }
}
