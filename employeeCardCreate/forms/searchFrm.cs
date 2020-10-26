using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace employeeCardCreate
{
    public partial class searchFrm : Form
    {
        public searchFrm()
        {
            InitializeComponent();
        }


        PersianCalendar pc = new PersianCalendar();
        
        private void search_Load(object sender, EventArgs e)
        {
            var n = DateTime.Now;
            textBox1.Text = pc.GetYear(n).ToString() +"/"+ "01" +"/"+ "01";
            textBox2.Text = pc.GetYear(n).ToString() + "/" + pc.GetMonth(n).ToString() + "/" + pc.GetDayOfMonth(n).ToString();
            textBox3.Focus();

            var count = StartForm.EmpDb.Employees.Count(i => i.@is == 1).ToString();
            label1.Text = count;
            var count2 = StartForm.EmpDb.Employees.Count(i => i.@is == 0).ToString();
            label2.Text = count2;

            /////////////////////////
            var emp = StartForm.EmpDb.Employees.Select(lastname => lastname.LastName + " " +lastname.FirstName).ToList();
            
            foreach (var item in emp)
            {
                comboBox1.Items.Add(item);
            }

            var emp1 = StartForm.EmpDb.CompanyProperties.Select(companyname => companyname.CompanyName).ToList();

            foreach (var item in emp1)
            {
                comboBox2.Items.Add(item);
            }

            var emp2 = StartForm.EmpDb.ContractorProperties.Select(contractorname => contractorname.ContractorName).ToList();

            foreach (var item in emp2)
            {
                comboBox3.Items.Add(item);
            }



        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                var dat = DateTime.Parse(textBox1.Text);
                var dat1 = DateTime.Parse(textBox2.Text);

                
                var dates = StartForm.EmpDb.Employees.Where(i => i.CreateDate >= dat && i.CreateDate <= dat1);
                datagridSearch.DataSource = dates.ToList();
            }
            catch (Exception)
            {
                MessageBox.Show("خطا در جستجو");
                
            }
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var n = DateTime.Now;
            textBox2.Text = pc.GetYear(n).ToString() + "/" + pc.GetMonth(n).ToString() + "/" + pc.GetDayOfMonth(n).ToString();
        }

        private void todaybtn2_Click(object sender, EventArgs e)
        {
            var n = DateTime.Now;
            textBox1.Text = pc.GetYear(n).ToString() + "/" + pc.GetMonth(n).ToString() + "/" + pc.GetDayOfMonth(n).ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                var name =
                    StartForm.EmpDb.Employees.Where(i => (i.LastName + " " + i.FirstName) == (string) comboBox1.SelectedItem);
                datagridSearch.DataSource = name.ToList();
            }
            catch 
            {

                MessageBox.Show("خطا در جستجو");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                var finalcode = long.Parse(textBox3.Text);
                var code =
                    StartForm.EmpDb.Employees.Where(i => i.ID == finalcode);
                datagridSearch.DataSource = code.ToList();
            }
            catch
            {

                MessageBox.Show("خطا در جستجو");
            }
        }

        



        private void button5_Click(object sender, EventArgs e)
        {
            IQueryable<Employee> em1 = null;
            IQueryable<Employee> em2 = null;
            IQueryable<Employee> em3 = null;
            IQueryable<Employee> em4 = null;
            IQueryable<Employee> em5 = null;

            List<Employee> ali = new List<Employee>();
            Boolean check = true;


            
            
            try
            {



                datagridSearch.DataSource = null;
                ali.Clear();

                if (!string.IsNullOrEmpty(textBox3.Text))
                {
                    var finalcode = long.Parse(textBox3.Text);
                    em1 = StartForm.EmpDb.Employees.Where(i => i.ID == finalcode);

                }


                if (!string.IsNullOrEmpty(comboBox1.Text))
                {
                    string text= comboBox1.SelectedItem.ToString();
                    em2 =
                    StartForm.EmpDb.Employees.Where(i => (i.LastName + " " + i.FirstName) == text);
                }
                if (!string.IsNullOrEmpty(textBox1.Text) && !string.IsNullOrEmpty(textBox2.Text))
                {
                    var dat = DateTime.Parse(textBox1.Text);
                    var dat1 = DateTime.Parse(textBox2.Text);


                    em3 = StartForm.EmpDb.Employees.Where(i => i.CreateDate >= dat && i.CreateDate <= dat1);
                }
                if (!string.IsNullOrEmpty(comboBox2.Text))
                {
                    string text = comboBox2.SelectedItem.ToString();
                    em4 =
                   StartForm.EmpDb.Employees.Where(i => i.CompanyName == text);
                }
                if (!string.IsNullOrEmpty(comboBox3.Text))
                {
                    string text = comboBox3.SelectedItem.ToString();
                    em5 =
                   StartForm.EmpDb.Employees.Where(i => i.ContractorName == text);
                }
                


                if (em1 != null)
                {
                    ali.AddRange(em1.ToList());
                    if (ali.Count == 0)
                    {
                        check = false;
                    }
                    ali.Clear();

                }
                if (em2 != null)
                {
                    ali.AddRange(em2.ToList());
                    if (ali.Count == 0)
                    {
                        check = false;
                        
                    }
                    ali.Clear();
                }
                if (em3 != null)
                {
                    ali.AddRange(em3.ToList());
                    if (ali.Count == 0)
                    {
                        check = false;
                    }
                    ali.Clear();

                }
                if (em4 != null)
                {
                    ali.AddRange(em4.ToList());
                    if (ali.Count == 0)
                    {
                        check = false;
                        
                    }
                    ali.Clear();
                }
                if (em5 != null)
                {
                    ali.AddRange(em5.ToList());
                    if (ali.Count == 0)
                    {
                        check = false;
                        
                    }
                    ali.Clear();
                }

                if (check == false)
                {
                    datagridSearch.DataSource = null;
                    ali.Clear();

                }
                else
                {

                    if (em1 != null)
                        ali.AddRange(em1.ToList());
                    if (em2 != null)
                        ali.AddRange(em2.ToList());
                    if (em3 != null)
                        ali.AddRange(em3.ToList());
                    if (em4 != null)
                        ali.AddRange(em4.ToList());
                    if (em5 != null)
                        ali.AddRange(em5.ToList());

                    List<Employee> distnic = ali.GroupBy(i => i.ID).Select(i => i.First()).ToList();
                    datagridSearch.DataSource = distnic;


                }
                datagridSearch.Focus();
            }
            catch
            {
                MessageBox.Show("خطا در جستجو");
                
            }

            
        }





        
        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar)) e.Handled = true;
            if (e.KeyChar == (decimal)Keys.Back) e.Handled = false;
            if (e.KeyChar == 45) e.Handled = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                var name =
                    StartForm.EmpDb.Employees.Where(i => i.CompanyName == (string)comboBox2.SelectedItem);
                datagridSearch.DataSource = name.ToList();
            }
            catch
            {

                MessageBox.Show("خطا در جستجو");
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                var name =
                    StartForm.EmpDb.Employees.Where(i => i.ContractorName == (string)comboBox3.SelectedItem);
                datagridSearch.DataSource = name.ToList();
            }
            catch
            {

                MessageBox.Show("خطا در جستجو");
            }
        }


        public List<long> ids = new List<long>();
         

        private void button8_Click(object sender, EventArgs e)
        {
            if (datagridSearch.DataSource == null)
            {
                MessageBox.Show("جدول خالی است");
            }
            else
            {
                var count = datagridSearch.RowCount;
                printAll.intial = count;
                string aa;
                for (int i = 0; i < count;i++)
                {
                    aa = datagridSearch.Rows[i].Cells[0].Value.ToString();
                    var aaa = long.Parse(aa);
                    ids.Add(aaa);
                }
                foreach (var empid in ids)
                {
                    printAll.pic.Add(printAll.CardEmp(empid));
                }
                printAll.idd = ids;
                printAll.printTest();
                ids.Clear();

            }
        }

        private void datagridSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                string str = datagridSearch.CurrentRow.Cells[0].Value.ToString();


                if (listBox1.FindString(str) != -1)
                    listBox1.Items.Remove(str);
                else
                {
                    
                    listBox1.Items.Add(str);
                    
                }
            }

        }

        private void button9_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Count == 0)
            {
                MessageBox.Show("لیست خالی است");
            }
            else
            {
                var count = listBox1.Items.Count;
                printAll.intial = count;
                string aa;
                foreach (string st in listBox1.Items)
                {
                    aa = st;
                    var aaa = long.Parse(aa);
                    ids.Add(aaa);
                }
                foreach (var empid in ids)
                {
                    printAll.pic.Add(printAll.CardEmp(empid));
                }
                printAll.idd = ids;
                printAll.printTest();
                ids.Clear();

            }
        }

        private void listBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                if (listBox1.SelectedIndex != -1)
                    listBox1.Items.Remove(listBox1.SelectedItem.ToString());
            }

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {
            var n = DateTime.Now;
            var datee = DateTime.Parse(pc.GetYear(n).ToString() + "/" + pc.GetMonth(n).ToString() + "/" + pc.GetDayOfMonth(n).ToString());
            try
            {

                var dates = StartForm.EmpDb.Employees.Where(i => i.ExpireDate < datee);
                datagridSearch.DataSource = dates.ToList();
            }
            catch (Exception)
            {
                MessageBox.Show("خطا در جستجو");

            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            try
            {
                
                var code =
                    StartForm.EmpDb.Employees.Where(i => i.LetterId == textBox4.Text);
                datagridSearch.DataSource = code.ToList();
            }
            catch
            {
                MessageBox.Show("خطا در جستجو");
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            try
            {

                var code =
                    StartForm.EmpDb.Employees.Where(i => i.@is == 1);
                datagridSearch.DataSource = code.ToList();
            }
            catch
            {

                MessageBox.Show("خطا در جستجو");
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            try
            {

                var code =
                    StartForm.EmpDb.Employees.Where(i => i.@is == 0);
                datagridSearch.DataSource = code.ToList();
            }
            catch
            {

                MessageBox.Show("خطا در جستجو");
            }
        }

        private void datagridSearch_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (datagridSearch.CurrentRow != null)
                {
                    var m = e.RowIndex;
                    var mm = datagridSearch.Rows[m].Cells[0].Value.ToString();
                    pictureBox1.Image = Image.FromFile(@"photos\photo(" + mm + ").jpg");
                }
            }
            catch 
            {

            }
            
        }

        
    }
}
