namespace employeeCardCreate.forms
{
    partial class ConnectionForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Server_cmbBox = new System.Windows.Forms.ComboBox();
            this.Database_TxtBox = new System.Windows.Forms.TextBox();
            this.Username_TxtBox = new System.Windows.Forms.TextBox();
            this.Password_TxtBox = new System.Windows.Forms.TextBox();
            this.Connect_Btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Server_cmbBox
            // 
            this.Server_cmbBox.FormattingEnabled = true;
            this.Server_cmbBox.Location = new System.Drawing.Point(73, 10);
            this.Server_cmbBox.Name = "Server_cmbBox";
            this.Server_cmbBox.Size = new System.Drawing.Size(313, 21);
            this.Server_cmbBox.TabIndex = 0;
            // 
            // Database_TxtBox
            // 
            this.Database_TxtBox.Location = new System.Drawing.Point(73, 37);
            this.Database_TxtBox.Name = "Database_TxtBox";
            this.Database_TxtBox.Size = new System.Drawing.Size(312, 20);
            this.Database_TxtBox.TabIndex = 1;
            // 
            // Username_TxtBox
            // 
            this.Username_TxtBox.Location = new System.Drawing.Point(73, 63);
            this.Username_TxtBox.Name = "Username_TxtBox";
            this.Username_TxtBox.Size = new System.Drawing.Size(312, 20);
            this.Username_TxtBox.TabIndex = 2;
            // 
            // Password_TxtBox
            // 
            this.Password_TxtBox.Location = new System.Drawing.Point(74, 89);
            this.Password_TxtBox.Name = "Password_TxtBox";
            this.Password_TxtBox.Size = new System.Drawing.Size(312, 20);
            this.Password_TxtBox.TabIndex = 3;
            // 
            // Connect_Btn
            // 
            this.Connect_Btn.Location = new System.Drawing.Point(110, 123);
            this.Connect_Btn.Name = "Connect_Btn";
            this.Connect_Btn.Size = new System.Drawing.Size(231, 33);
            this.Connect_Btn.TabIndex = 5;
            this.Connect_Btn.Text = "Connect...";
            this.Connect_Btn.UseVisualStyleBackColor = true;
            this.Connect_Btn.Click += new System.EventHandler(this.Connect_Btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Server:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "DataBase:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "UserName:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Password:";
            // 
            // ConnectionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 168);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Connect_Btn);
            this.Controls.Add(this.Password_TxtBox);
            this.Controls.Add(this.Username_TxtBox);
            this.Controls.Add(this.Database_TxtBox);
            this.Controls.Add(this.Server_cmbBox);
            this.Name = "ConnectionForm";
            this.Text = "ConnectionForm";
            this.Load += new System.EventHandler(this.ConnectionForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox Server_cmbBox;
        private System.Windows.Forms.TextBox Database_TxtBox;
        private System.Windows.Forms.TextBox Username_TxtBox;
        private System.Windows.Forms.TextBox Password_TxtBox;
        private System.Windows.Forms.Button Connect_Btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}