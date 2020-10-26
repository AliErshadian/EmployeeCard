namespace employeeCardCreate
{
    partial class closemainformdialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(closemainformdialog));
            this.yesBtn = new System.Windows.Forms.Button();
            this.noBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // yesBtn
            // 
            this.yesBtn.BackColor = System.Drawing.Color.DarkTurquoise;
            this.yesBtn.DialogResult = System.Windows.Forms.DialogResult.Yes;
            this.yesBtn.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.yesBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.yesBtn.Font = new System.Drawing.Font("IRTitr", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.yesBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.yesBtn.Location = new System.Drawing.Point(12, 64);
            this.yesBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.yesBtn.Name = "yesBtn";
            this.yesBtn.Size = new System.Drawing.Size(75, 34);
            this.yesBtn.TabIndex = 1;
            this.yesBtn.Tag = "";
            this.yesBtn.Text = "بله";
            this.yesBtn.UseVisualStyleBackColor = false;
            // 
            // noBtn
            // 
            this.noBtn.BackColor = System.Drawing.Color.DarkTurquoise;
            this.noBtn.DialogResult = System.Windows.Forms.DialogResult.No;
            this.noBtn.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.noBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.noBtn.Font = new System.Drawing.Font("IRTitr", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.noBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.noBtn.Location = new System.Drawing.Point(113, 64);
            this.noBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.noBtn.Name = "noBtn";
            this.noBtn.Size = new System.Drawing.Size(75, 34);
            this.noBtn.TabIndex = 2;
            this.noBtn.Text = "خیر";
            this.noBtn.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("IRTitr", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(21, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 26);
            this.label1.TabIndex = 3;
            this.label1.Text = "آیا از خروج مطمئن هستید؟";
            // 
            // closemainformdialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(200, 111);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.noBtn);
            this.Controls.Add(this.yesBtn);
            this.Font = new System.Drawing.Font("IRTitr", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "closemainformdialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "closemainformdialog";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button yesBtn;
        private System.Windows.Forms.Button noBtn;
        private System.Windows.Forms.Label label1;
    }
}