using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace employeeCardCreate
{
    partial class StartForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartForm));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.فایلToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.جدیدToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.جستجوToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.شرکتیاطرحجدیدToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.پیمانکارجدیدToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.خروجToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.چاپToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.چاپعادیToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.چاپگروهیToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.پیداشدنکارتمفقودیToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.گزارشToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.گزارشکلیازکارتهایصادرشدهToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.گزارشکلیبهExcelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.تنضیماتToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backUpگیریToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.بروزآوریازBackUpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.smsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usersBTN = new System.Windows.Forms.ToolStripMenuItem();
            this.کاربرجدیدToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.مدیریتکاربرهاToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clock = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblTimeUp = new System.Windows.Forms.Label();
            this.backupTime = new System.Windows.Forms.Timer(this.components);
            this.button11 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.BackColor = System.Drawing.Color.DimGray;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Font = new System.Drawing.Font("IRTitr", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.فایلToolStripMenuItem,
            this.چاپToolStripMenuItem,
            this.گزارشToolStripMenuItem,
            this.تنضیماتToolStripMenuItem});
            this.menuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.menuStrip1.Location = new System.Drawing.Point(0, 23);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 3, 0, 3);
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.Size = new System.Drawing.Size(1008, 33);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // فایلToolStripMenuItem
            // 
            this.فایلToolStripMenuItem.BackColor = System.Drawing.Color.DimGray;
            this.فایلToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.جدیدToolStripMenuItem,
            this.جستجوToolStripMenuItem,
            this.شرکتیاطرحجدیدToolStripMenuItem,
            this.پیمانکارجدیدToolStripMenuItem,
            this.خروجToolStripMenuItem});
            this.فایلToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.فایلToolStripMenuItem.Name = "فایلToolStripMenuItem";
            this.فایلToolStripMenuItem.Size = new System.Drawing.Size(43, 27);
            this.فایلToolStripMenuItem.Text = "فایل";
            // 
            // جدیدToolStripMenuItem
            // 
            this.جدیدToolStripMenuItem.BackColor = System.Drawing.Color.DimGray;
            this.جدیدToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.جدیدToolStripMenuItem.Name = "جدیدToolStripMenuItem";
            this.جدیدToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.جدیدToolStripMenuItem.Size = new System.Drawing.Size(226, 28);
            this.جدیدToolStripMenuItem.Text = "جدید";
            this.جدیدToolStripMenuItem.Click += new System.EventHandler(this.جدیدToolStripMenuItem_Click);
            // 
            // جستجوToolStripMenuItem
            // 
            this.جستجوToolStripMenuItem.BackColor = System.Drawing.Color.DimGray;
            this.جستجوToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.جستجوToolStripMenuItem.Name = "جستجوToolStripMenuItem";
            this.جستجوToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.جستجوToolStripMenuItem.Size = new System.Drawing.Size(226, 28);
            this.جستجوToolStripMenuItem.Text = "جستجو و پرینت";
            this.جستجوToolStripMenuItem.Click += new System.EventHandler(this.جستجوToolStripMenuItem_Click);
            // 
            // شرکتیاطرحجدیدToolStripMenuItem
            // 
            this.شرکتیاطرحجدیدToolStripMenuItem.BackColor = System.Drawing.Color.DimGray;
            this.شرکتیاطرحجدیدToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.شرکتیاطرحجدیدToolStripMenuItem.Name = "شرکتیاطرحجدیدToolStripMenuItem";
            this.شرکتیاطرحجدیدToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.M)));
            this.شرکتیاطرحجدیدToolStripMenuItem.Size = new System.Drawing.Size(226, 28);
            this.شرکتیاطرحجدیدToolStripMenuItem.Text = "شرکت یا طرح جدید";
            this.شرکتیاطرحجدیدToolStripMenuItem.Click += new System.EventHandler(this.شرکتیاطرحجدیدToolStripMenuItem_Click);
            // 
            // پیمانکارجدیدToolStripMenuItem
            // 
            this.پیمانکارجدیدToolStripMenuItem.BackColor = System.Drawing.Color.DimGray;
            this.پیمانکارجدیدToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.پیمانکارجدیدToolStripMenuItem.Name = "پیمانکارجدیدToolStripMenuItem";
            this.پیمانکارجدیدToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.M)));
            this.پیمانکارجدیدToolStripMenuItem.Size = new System.Drawing.Size(226, 28);
            this.پیمانکارجدیدToolStripMenuItem.Text = "پیمانکار جدید";
            this.پیمانکارجدیدToolStripMenuItem.Click += new System.EventHandler(this.پیمانکارجدیدToolStripMenuItem_Click);
            // 
            // خروجToolStripMenuItem
            // 
            this.خروجToolStripMenuItem.BackColor = System.Drawing.Color.DimGray;
            this.خروجToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.خروجToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("خروجToolStripMenuItem.Image")));
            this.خروجToolStripMenuItem.Name = "خروجToolStripMenuItem";
            this.خروجToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
            this.خروجToolStripMenuItem.Size = new System.Drawing.Size(226, 28);
            this.خروجToolStripMenuItem.Text = "خروج";
            this.خروجToolStripMenuItem.Click += new System.EventHandler(this.خروجToolStripMenuItem_Click);
            // 
            // چاپToolStripMenuItem
            // 
            this.چاپToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.چاپعادیToolStripMenuItem,
            this.چاپگروهیToolStripMenuItem,
            this.پیداشدنکارتمفقودیToolStripMenuItem});
            this.چاپToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.چاپToolStripMenuItem.Name = "چاپToolStripMenuItem";
            this.چاپToolStripMenuItem.Size = new System.Drawing.Size(58, 27);
            this.چاپToolStripMenuItem.Text = "ویرایش";
            // 
            // چاپعادیToolStripMenuItem
            // 
            this.چاپعادیToolStripMenuItem.BackColor = System.Drawing.Color.DimGray;
            this.چاپعادیToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.چاپعادیToolStripMenuItem.Name = "چاپعادیToolStripMenuItem";
            this.چاپعادیToolStripMenuItem.Size = new System.Drawing.Size(195, 28);
            this.چاپعادیToolStripMenuItem.Text = "کارت المثنی";
            this.چاپعادیToolStripMenuItem.Click += new System.EventHandler(this.button8_Click);
            // 
            // چاپگروهیToolStripMenuItem
            // 
            this.چاپگروهیToolStripMenuItem.BackColor = System.Drawing.Color.DimGray;
            this.چاپگروهیToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.چاپگروهیToolStripMenuItem.Name = "چاپگروهیToolStripMenuItem";
            this.چاپگروهیToolStripMenuItem.Size = new System.Drawing.Size(195, 28);
            this.چاپگروهیToolStripMenuItem.Text = "ثبت کارت مفقودی";
            this.چاپگروهیToolStripMenuItem.Click += new System.EventHandler(this.button9_Click);
            // 
            // پیداشدنکارتمفقودیToolStripMenuItem
            // 
            this.پیداشدنکارتمفقودیToolStripMenuItem.BackColor = System.Drawing.Color.DimGray;
            this.پیداشدنکارتمفقودیToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.پیداشدنکارتمفقودیToolStripMenuItem.Name = "پیداشدنکارتمفقودیToolStripMenuItem";
            this.پیداشدنکارتمفقودیToolStripMenuItem.Size = new System.Drawing.Size(195, 28);
            this.پیداشدنکارتمفقودیToolStripMenuItem.Text = "پیدا شدن کارت مفقودی";
            this.پیداشدنکارتمفقودیToolStripMenuItem.Click += new System.EventHandler(this.button10_Click);
            // 
            // گزارشToolStripMenuItem
            // 
            this.گزارشToolStripMenuItem.BackColor = System.Drawing.Color.DimGray;
            this.گزارشToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.گزارشکلیازکارتهایصادرشدهToolStripMenuItem,
            this.گزارشکلیبهExcelToolStripMenuItem});
            this.گزارشToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.گزارشToolStripMenuItem.Name = "گزارشToolStripMenuItem";
            this.گزارشToolStripMenuItem.Size = new System.Drawing.Size(56, 27);
            this.گزارشToolStripMenuItem.Text = "گزارش";
            // 
            // گزارشکلیازکارتهایصادرشدهToolStripMenuItem
            // 
            this.گزارشکلیازکارتهایصادرشدهToolStripMenuItem.BackColor = System.Drawing.Color.DimGray;
            this.گزارشکلیازکارتهایصادرشدهToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.گزارشکلیازکارتهایصادرشدهToolStripMenuItem.Name = "گزارشکلیازکارتهایصادرشدهToolStripMenuItem";
            this.گزارشکلیازکارتهایصادرشدهToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
            this.گزارشکلیازکارتهایصادرشدهToolStripMenuItem.Size = new System.Drawing.Size(301, 28);
            this.گزارشکلیازکارتهایصادرشدهToolStripMenuItem.Text = "گزارش کلی از کارت های صادر شده";
            this.گزارشکلیازکارتهایصادرشدهToolStripMenuItem.Click += new System.EventHandler(this.گزارشکلیازکارتهایصادرشدهToolStripMenuItem_Click);
            // 
            // گزارشکلیبهExcelToolStripMenuItem
            // 
            this.گزارشکلیبهExcelToolStripMenuItem.BackColor = System.Drawing.Color.DimGray;
            this.گزارشکلیبهExcelToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.گزارشکلیبهExcelToolStripMenuItem.Name = "گزارشکلیبهExcelToolStripMenuItem";
            this.گزارشکلیبهExcelToolStripMenuItem.Size = new System.Drawing.Size(301, 28);
            this.گزارشکلیبهExcelToolStripMenuItem.Text = "گزارش کلی به excel";
            this.گزارشکلیبهExcelToolStripMenuItem.Click += new System.EventHandler(this.button6_Click);
            // 
            // تنضیماتToolStripMenuItem
            // 
            this.تنضیماتToolStripMenuItem.BackColor = System.Drawing.Color.DimGray;
            this.تنضیماتToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.backUpگیریToolStripMenuItem,
            this.بروزآوریازBackUpToolStripMenuItem,
            this.smsToolStripMenuItem,
            this.usersBTN});
            this.تنضیماتToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.تنضیماتToolStripMenuItem.Name = "تنضیماتToolStripMenuItem";
            this.تنضیماتToolStripMenuItem.Size = new System.Drawing.Size(63, 27);
            this.تنضیماتToolStripMenuItem.Text = "تنضیمات";
            // 
            // backUpگیریToolStripMenuItem
            // 
            this.backUpگیریToolStripMenuItem.BackColor = System.Drawing.Color.DimGray;
            this.backUpگیریToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.backUpگیریToolStripMenuItem.Name = "backUpگیریToolStripMenuItem";
            this.backUpگیریToolStripMenuItem.Size = new System.Drawing.Size(186, 28);
            this.backUpگیریToolStripMenuItem.Text = "BackUp گیری";
            this.backUpگیریToolStripMenuItem.Click += new System.EventHandler(this.backUpگیریToolStripMenuItem_Click);
            // 
            // بروزآوریازBackUpToolStripMenuItem
            // 
            this.بروزآوریازBackUpToolStripMenuItem.BackColor = System.Drawing.Color.DimGray;
            this.بروزآوریازBackUpToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.بروزآوریازBackUpToolStripMenuItem.Name = "بروزآوریازBackUpToolStripMenuItem";
            this.بروزآوریازBackUpToolStripMenuItem.Size = new System.Drawing.Size(186, 28);
            this.بروزآوریازBackUpToolStripMenuItem.Text = "بروزآوری از BackUp";
            this.بروزآوریازBackUpToolStripMenuItem.Click += new System.EventHandler(this.بروزآوریازBackUpToolStripMenuItem_Click);
            // 
            // smsToolStripMenuItem
            // 
            this.smsToolStripMenuItem.BackColor = System.Drawing.Color.DimGray;
            this.smsToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.smsToolStripMenuItem.Name = "smsToolStripMenuItem";
            this.smsToolStripMenuItem.Size = new System.Drawing.Size(186, 28);
            this.smsToolStripMenuItem.Text = "sms";
            this.smsToolStripMenuItem.Click += new System.EventHandler(this.smsToolStripMenuItem_Click);
            // 
            // usersBTN
            // 
            this.usersBTN.BackColor = System.Drawing.Color.DimGray;
            this.usersBTN.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.کاربرجدیدToolStripMenuItem,
            this.مدیریتکاربرهاToolStripMenuItem});
            this.usersBTN.ForeColor = System.Drawing.Color.White;
            this.usersBTN.Name = "usersBTN";
            this.usersBTN.Size = new System.Drawing.Size(186, 28);
            this.usersBTN.Text = "کاربرها";
            // 
            // کاربرجدیدToolStripMenuItem
            // 
            this.کاربرجدیدToolStripMenuItem.BackColor = System.Drawing.Color.DimGray;
            this.کاربرجدیدToolStripMenuItem.Name = "کاربرجدیدToolStripMenuItem";
            this.کاربرجدیدToolStripMenuItem.Size = new System.Drawing.Size(156, 28);
            this.کاربرجدیدToolStripMenuItem.Text = "کاربر جدید";
            this.کاربرجدیدToolStripMenuItem.Click += new System.EventHandler(this.کاربرجدیدToolStripMenuItem_Click);
            // 
            // مدیریتکاربرهاToolStripMenuItem
            // 
            this.مدیریتکاربرهاToolStripMenuItem.BackColor = System.Drawing.Color.DimGray;
            this.مدیریتکاربرهاToolStripMenuItem.Name = "مدیریتکاربرهاToolStripMenuItem";
            this.مدیریتکاربرهاToolStripMenuItem.Size = new System.Drawing.Size(156, 28);
            this.مدیریتکاربرهاToolStripMenuItem.Text = "مدیریت کاربرها";
            this.مدیریتکاربرهاToolStripMenuItem.Click += new System.EventHandler(this.مدیریتکاربرهاToolStripMenuItem_Click);
            // 
            // clock
            // 
            this.clock.Enabled = true;
            this.clock.Tick += new System.EventHandler(this.clock_Tick);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("IRNazanin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(25, -1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(929, 22);
            this.label1.TabIndex = 8;
            this.label1.Text = "--";
            // 
            // chart1
            // 
            this.chart1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.chart1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.chart1.BackSecondaryColor = System.Drawing.Color.Transparent;
            this.chart1.BorderlineColor = System.Drawing.Color.Red;
            chartArea1.BorderColor = System.Drawing.Color.Transparent;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.BackColor = System.Drawing.Color.Transparent;
            legend1.Font = new System.Drawing.Font("IRTitr", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            legend1.ForeColor = System.Drawing.Color.White;
            legend1.IsTextAutoFit = false;
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(365, 392);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright;
            this.chart1.Size = new System.Drawing.Size(646, 337);
            this.chart1.TabIndex = 22;
            this.chart1.Text = "chart1";
            title1.Font = new System.Drawing.Font("IRTitr", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title1.ForeColor = System.Drawing.Color.White;
            title1.Name = "Title1";
            title1.Text = "تعداد کارتهای صادر شده در این سال";
            this.chart1.Titles.Add(title1);
            // 
            // treeView1
            // 
            this.treeView1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.treeView1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.treeView1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.treeView1.Font = new System.Drawing.Font("IRTitr", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.treeView1.ForeColor = System.Drawing.Color.White;
            this.treeView1.LineColor = System.Drawing.Color.White;
            this.treeView1.Location = new System.Drawing.Point(145, 442);
            this.treeView1.Name = "treeView1";
            this.treeView1.RightToLeftLayout = true;
            this.treeView1.Size = new System.Drawing.Size(236, 275);
            this.treeView1.TabIndex = 23;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("IRTitr", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(154, 404);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(221, 26);
            this.label2.TabIndex = 24;
            this.label2.Text = "لیست شرکتها و پیمانکاران و تعداد افراد";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("IRTitr", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(12, 669);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label3.Size = new System.Drawing.Size(78, 21);
            this.label3.TabIndex = 25;
            this.label3.Text = "last backup:";
            // 
            // lblTimeUp
            // 
            this.lblTimeUp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblTimeUp.AutoSize = true;
            this.lblTimeUp.Font = new System.Drawing.Font("IRTitr", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblTimeUp.ForeColor = System.Drawing.Color.White;
            this.lblTimeUp.Location = new System.Drawing.Point(12, 695);
            this.lblTimeUp.Name = "lblTimeUp";
            this.lblTimeUp.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblTimeUp.Size = new System.Drawing.Size(0, 21);
            this.lblTimeUp.TabIndex = 26;
            // 
            // backupTime
            // 
            this.backupTime.Enabled = true;
            this.backupTime.Interval = 150000;
            this.backupTime.Tick += new System.EventHandler(this.backupTime_Tick);
            // 
            // button11
            // 
            this.button11.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button11.BackgroundImage")));
            this.button11.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button11.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.button11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button11.Location = new System.Drawing.Point(5, 168);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(100, 100);
            this.button11.TabIndex = 27;
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            this.button11.MouseDown += new System.Windows.Forms.MouseEventHandler(this.button11_MouseDown);
            this.button11.MouseEnter += new System.EventHandler(this.button11_MouseEnter);
            this.button11.MouseLeave += new System.EventHandler(this.button11_MouseLeave);
            this.button11.MouseUp += new System.Windows.Forms.MouseEventHandler(this.button11_MouseUp);
            // 
            // button13
            // 
            this.button13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.button13.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button13.BackgroundImage")));
            this.button13.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button13.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.button13.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button13.Location = new System.Drawing.Point(535, 168);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(100, 100);
            this.button13.TabIndex = 21;
            this.button13.UseVisualStyleBackColor = false;
            this.button13.Click += new System.EventHandler(this.بروزآوریازBackUpToolStripMenuItem_Click);
            this.button13.MouseDown += new System.Windows.Forms.MouseEventHandler(this.button13_MouseDown);
            this.button13.MouseEnter += new System.EventHandler(this.button13_MouseEnter);
            this.button13.MouseLeave += new System.EventHandler(this.button13_MouseLeave);
            this.button13.MouseUp += new System.Windows.Forms.MouseEventHandler(this.button13_MouseUp);
            // 
            // button12
            // 
            this.button12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.button12.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button12.BackgroundImage")));
            this.button12.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button12.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.button12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button12.Location = new System.Drawing.Point(535, 62);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(100, 100);
            this.button12.TabIndex = 20;
            this.button12.UseVisualStyleBackColor = false;
            this.button12.Click += new System.EventHandler(this.backUpگیریToolStripMenuItem_Click);
            this.button12.MouseDown += new System.Windows.Forms.MouseEventHandler(this.button12_MouseDown);
            this.button12.MouseEnter += new System.EventHandler(this.button12_MouseEnter);
            this.button12.MouseLeave += new System.EventHandler(this.button12_MouseLeave);
            this.button12.MouseUp += new System.Windows.Forms.MouseEventHandler(this.button12_MouseUp);
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.button10.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button10.BackgroundImage")));
            this.button10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button10.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button10.Location = new System.Drawing.Point(217, 274);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(100, 100);
            this.button10.TabIndex = 18;
            this.button10.UseVisualStyleBackColor = false;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            this.button10.MouseDown += new System.Windows.Forms.MouseEventHandler(this.button10_MouseDown);
            this.button10.MouseEnter += new System.EventHandler(this.button10_MouseEnter);
            this.button10.MouseLeave += new System.EventHandler(this.button10_MouseLeave);
            this.button10.MouseUp += new System.Windows.Forms.MouseEventHandler(this.button10_MouseUp);
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.button9.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button9.BackgroundImage")));
            this.button9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button9.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.Location = new System.Drawing.Point(217, 168);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(100, 100);
            this.button9.TabIndex = 17;
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            this.button9.MouseDown += new System.Windows.Forms.MouseEventHandler(this.button9_MouseDown);
            this.button9.MouseEnter += new System.EventHandler(this.button9_MouseEnter);
            this.button9.MouseLeave += new System.EventHandler(this.button9_MouseLeave);
            this.button9.MouseUp += new System.Windows.Forms.MouseEventHandler(this.button9_MouseUp);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.button8.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button8.BackgroundImage")));
            this.button8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button8.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Location = new System.Drawing.Point(217, 62);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(100, 100);
            this.button8.TabIndex = 16;
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            this.button8.MouseDown += new System.Windows.Forms.MouseEventHandler(this.button8_MouseDown);
            this.button8.MouseEnter += new System.EventHandler(this.button8_MouseEnter);
            this.button8.MouseLeave += new System.EventHandler(this.button8_MouseLeave);
            this.button8.MouseUp += new System.Windows.Forms.MouseEventHandler(this.button8_MouseUp);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.button7.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button7.BackgroundImage")));
            this.button7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button7.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Location = new System.Drawing.Point(641, 62);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(100, 100);
            this.button7.TabIndex = 15;
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            this.button7.MouseDown += new System.Windows.Forms.MouseEventHandler(this.button7_MouseDown);
            this.button7.MouseEnter += new System.EventHandler(this.button7_MouseEnter);
            this.button7.MouseLeave += new System.EventHandler(this.button7_MouseLeave);
            this.button7.MouseUp += new System.Windows.Forms.MouseEventHandler(this.button7_MouseUp);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.button6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button6.BackgroundImage")));
            this.button6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button6.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Location = new System.Drawing.Point(429, 168);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(100, 100);
            this.button6.TabIndex = 14;
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            this.button6.MouseDown += new System.Windows.Forms.MouseEventHandler(this.button6_MouseDown);
            this.button6.MouseEnter += new System.EventHandler(this.button6_MouseEnter);
            this.button6.MouseLeave += new System.EventHandler(this.button6_MouseLeave);
            this.button6.MouseUp += new System.Windows.Forms.MouseEventHandler(this.button6_MouseUp);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.button5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button5.BackgroundImage")));
            this.button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button5.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Location = new System.Drawing.Point(429, 62);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(100, 100);
            this.button5.TabIndex = 13;
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            this.button5.MouseDown += new System.Windows.Forms.MouseEventHandler(this.button5_MouseDown);
            this.button5.MouseEnter += new System.EventHandler(this.button5_MouseEnter);
            this.button5.MouseLeave += new System.EventHandler(this.button5_MouseLeave);
            this.button5.MouseUp += new System.Windows.Forms.MouseEventHandler(this.button5_MouseUp);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.button4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button4.BackgroundImage")));
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button4.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Location = new System.Drawing.Point(111, 168);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(100, 100);
            this.button4.TabIndex = 12;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            this.button4.MouseDown += new System.Windows.Forms.MouseEventHandler(this.button4_MouseDown);
            this.button4.MouseEnter += new System.EventHandler(this.button4_MouseEnter);
            this.button4.MouseLeave += new System.EventHandler(this.button4_MouseLeave);
            this.button4.MouseUp += new System.Windows.Forms.MouseEventHandler(this.button4_MouseUp);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.button3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button3.BackgroundImage")));
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(111, 62);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 100);
            this.button3.TabIndex = 11;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            this.button3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.button3_MouseDown);
            this.button3.MouseEnter += new System.EventHandler(this.button3_MouseEnter);
            this.button3.MouseLeave += new System.EventHandler(this.button3_MouseLeave);
            this.button3.MouseUp += new System.Windows.Forms.MouseEventHandler(this.button3_MouseUp);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(5, 62);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 100);
            this.button2.TabIndex = 10;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            this.button2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.button2_MouseDown);
            this.button2.MouseEnter += new System.EventHandler(this.button2_MouseEnter);
            this.button2.MouseLeave += new System.EventHandler(this.button2_MouseLeave);
            this.button2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.button2_MouseUp);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(323, 62);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 100);
            this.button1.TabIndex = 9;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            this.button1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.button1_MouseDown);
            this.button1.MouseEnter += new System.EventHandler(this.button1_MouseEnter);
            this.button1.MouseLeave += new System.EventHandler(this.button1_MouseLeave);
            this.button1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.button1_MouseUp);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(22, 20);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(794, 26);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(212, 27);
            this.textBox1.TabIndex = 28;
            this.textBox1.UseSystemPasswordChar = true;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // StartForm
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.lblTimeUp);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.button13);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("IRNazanin", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "StartForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.StartForm_FormClosing);
            this.Load += new System.EventHandler(this.startForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem فایلToolStripMenuItem;
        private ToolStripMenuItem جدیدToolStripMenuItem;
        private Timer clock;
        private ToolStripMenuItem جستجوToolStripMenuItem;
        private ToolStripMenuItem چاپToolStripMenuItem;
        private ToolStripMenuItem چاپعادیToolStripMenuItem;
        private ToolStripMenuItem چاپگروهیToolStripMenuItem;
        private ToolStripMenuItem گزارشToolStripMenuItem;
        private ToolStripMenuItem گزارشکلیازکارتهایصادرشدهToolStripMenuItem;
        private ToolStripMenuItem گزارشکلیبهExcelToolStripMenuItem;
        private ToolStripMenuItem شرکتیاطرحجدیدToolStripMenuItem;
        private ToolStripMenuItem پیمانکارجدیدToolStripMenuItem;
        private ToolStripMenuItem خروجToolStripMenuItem;
        private PictureBox pictureBox1;
        private Label label1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button button10;
        private ToolStripMenuItem تنضیماتToolStripMenuItem;
        private ToolStripMenuItem backUpگیریToolStripMenuItem;
        private ToolStripMenuItem بروزآوریازBackUpToolStripMenuItem;
        private SaveFileDialog saveFileDialog1;
        private ToolStripMenuItem پیداشدنکارتمفقودیToolStripMenuItem;
        private Button button12;
        private Button button13;
        private ToolStripMenuItem smsToolStripMenuItem;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private TreeView treeView1;
        private Label label2;
        private ToolStripMenuItem usersBTN;
        private ToolStripMenuItem کاربرجدیدToolStripMenuItem;
        private ToolStripMenuItem مدیریتکاربرهاToolStripMenuItem;
        private Label label3;
        private Label lblTimeUp;
        private Timer backupTime;
        private Button button11;
        private TextBox textBox1;
    }
}

