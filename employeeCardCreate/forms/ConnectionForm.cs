using employeeCardCreate.classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace employeeCardCreate.forms
{
    public partial class ConnectionForm : Form
    {
        public ConnectionForm()
        {
            InitializeComponent();
        }

        private void Connect_Btn_Click(object sender, EventArgs e)
        {
            string connectionString = string.Format("Data Source={0};Initial Catalog={1};User ID={2};Password={3};", Server_cmbBox.Text, Database_TxtBox.Text, Username_TxtBox.Text, Password_TxtBox.Text);

            try
            {
                SqlHelper helper = new SqlHelper(connectionString);
                if (helper.IsConnection)
                {
                    StartForm.showBalloon("Sql Connection", "connection succeeded...");
                    StartForm.ConnectionString_main = connectionString;

                    connectionString = string.Format("metadata=res://*/myModel.csdl|res://*/myModel.ssdl|res://*/myModel.msl;provider=System.Data.SqlClient;provider connection string=&quot;data source={0};initial catalog={1};persist security info=True;user id={2};password={3};MultipleActiveResultSets=True;App=EntityFramework&quot;", Server_cmbBox.Text, Database_TxtBox.Text, Username_TxtBox.Text, Password_TxtBox.Text);

                    AppSetting setting = new AppSetting();

                    string apps = setting.GetConnectionString("EmployeeCardentities");

                    setting.SaveConnectionString("EmployeeCardentities", connectionString);
                    
                    StartForm.showBalloon("App Config", "Your connection string has been successfully saved.");
                    
                    apps = setting.GetConnectionString("EmployeeCardentities");

                    this.Hide();
                    pass form = new pass();
                    form.Show();

                }
                    
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void ConnectionForm_Load(object sender, EventArgs e)
        {
            Server_cmbBox.Items.Add(".");
            Server_cmbBox.Items.Add(Environment.MachineName);
            Server_cmbBox.SelectedIndex = 1;
        }
    }
}
