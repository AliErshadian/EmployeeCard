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
    public partial class finalRepor : Form
    {
        public finalRepor()
        {
            InitializeComponent();
        }

        private void finalRepor_Load(object sender, EventArgs e)
        {
            datagridEMP.DataSource = StartForm.EmpDb.Employees.OrderByDescending(i => i.CreateDate).ToList();
        }

        private void چاپToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrintDialog printDialog = new PrintDialog();
            printDialog.Document = printDocument1;
            printDialog.UseEXDialog = true;

            if (DialogResult.OK == printDialog.ShowDialog())
            {
                printDocument1.DocumentName = "Page Print";
                printDocument1.Print();
            }

        }

        private void printDocument1_BeginPrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
           
        }

    }
}
