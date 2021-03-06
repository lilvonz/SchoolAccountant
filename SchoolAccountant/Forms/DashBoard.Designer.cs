﻿using System.ComponentModel;
using System.Windows.Forms;

namespace SchoolAccountant.Forms
{
    partial class DashBoard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DashBoard));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tsslTableStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslShowAll = new System.Windows.Forms.ToolStripStatusLabel();
            this.dgvViewStudent = new System.Windows.Forms.DataGridView();
            this.label19 = new System.Windows.Forms.Label();
            this.tboSearchMS = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.cboFeeStatusMS = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.cboArmMS = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.cboClassMS = new System.Windows.Forms.ComboBox();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.llAddStudentsWithExcel = new System.Windows.Forms.LinkLabel();
            this.llOpenExcelToAddStudents = new System.Windows.Forms.LinkLabel();
            this.tboOutstandingFeeAS = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cboPresentArmAS = new System.Windows.Forms.ComboBox();
            this.dtpBirthDateAS = new System.Windows.Forms.DateTimePicker();
            this.label15 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cboPresentTermAS = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cboPresentClassAS = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.btnClearTextBoxes = new System.Windows.Forms.Button();
            this.btnAddStudent = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.tboMiddleNameAS = new System.Windows.Forms.TextBox();
            this.dtpStartDateAS = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.tboLastNameAS = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.cboStartClassAS = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cboStartTermAS = new System.Windows.Forms.ComboBox();
            this.tboFirstNameAS = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnAddUser = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tboPasswordAU = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tboUsernameAU = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tboFullNameAU = new System.Windows.Forms.TextBox();
            this.AddNewTerm = new System.Windows.Forms.TabPage();
            this.statusStrip2 = new System.Windows.Forms.StatusStrip();
            this.tsslAddNewTerm = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label29 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.tboSssANT = new System.Windows.Forms.TextBox();
            this.tboJssANT = new System.Windows.Forms.TextBox();
            this.btnUndoLastAddFeesANT = new System.Windows.Forms.Button();
            this.btnSaveSchoolFeesANT = new System.Windows.Forms.Button();
            this.tboSss3ANT = new System.Windows.Forms.TextBox();
            this.tboJss3ANT = new System.Windows.Forms.TextBox();
            this.label27 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.tboSss2ANT = new System.Windows.Forms.TextBox();
            this.tboJss2ANT = new System.Windows.Forms.TextBox();
            this.label26 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.tboSss1ANT = new System.Windows.Forms.TextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.tboJss1ANT = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.llPromoteStudents = new System.Windows.Forms.LinkLabel();
            this.label13 = new System.Windows.Forms.Label();
            this.cboTermANT = new System.Windows.Forms.ComboBox();
            this.label21 = new System.Windows.Forms.Label();
            this.cboSessionANT = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Promotion = new System.Windows.Forms.TabPage();
            this.statusStrip3 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslShowAllPS = new System.Windows.Forms.ToolStripStatusLabel();
            this.dgvRepeatingStudents = new System.Windows.Forms.DataGridView();
            this.btnSubmitRepeatingStudentsPS = new System.Windows.Forms.Button();
            this.label33 = new System.Windows.Forms.Label();
            this.dgvStudentsPS = new System.Windows.Forms.DataGridView();
            this.label30 = new System.Windows.Forms.Label();
            this.tboSearchPS = new System.Windows.Forms.TextBox();
            this.label31 = new System.Windows.Forms.Label();
            this.cboArmPS = new System.Windows.Forms.ComboBox();
            this.label32 = new System.Windows.Forms.Label();
            this.cboClassPS = new System.Windows.Forms.ComboBox();
            this.tabControl1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvViewStudent)).BeginInit();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.AddNewTerm.SuspendLayout();
            this.statusStrip2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.Promotion.SuspendLayout();
            this.statusStrip3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRepeatingStudents)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudentsPS)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.AddNewTerm);
            this.tabControl1.Controls.Add(this.Promotion);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(775, 638);
            this.tabControl1.TabIndex = 6;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.btnRefresh);
            this.tabPage3.Controls.Add(this.statusStrip1);
            this.tabPage3.Controls.Add(this.dgvViewStudent);
            this.tabPage3.Controls.Add(this.label19);
            this.tabPage3.Controls.Add(this.tboSearchMS);
            this.tabPage3.Controls.Add(this.label18);
            this.tabPage3.Controls.Add(this.cboFeeStatusMS);
            this.tabPage3.Controls.Add(this.label17);
            this.tabPage3.Controls.Add(this.cboArmMS);
            this.tabPage3.Controls.Add(this.label16);
            this.tabPage3.Controls.Add(this.cboClassMS);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(767, 612);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Manage Students";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(338, 550);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnRefresh.TabIndex = 4;
            this.btnRefresh.Text = "&Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslTableStatus,
            this.tsslShowAll});
            this.statusStrip1.Location = new System.Drawing.Point(0, 590);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(767, 22);
            this.statusStrip1.TabIndex = 10;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tsslTableStatus
            // 
            this.tsslTableStatus.Name = "tsslTableStatus";
            this.tsslTableStatus.Size = new System.Drawing.Size(0, 17);
            // 
            // tsslShowAll
            // 
            this.tsslShowAll.IsLink = true;
            this.tsslShowAll.Name = "tsslShowAll";
            this.tsslShowAll.Size = new System.Drawing.Size(53, 17);
            this.tsslShowAll.Text = "Show All";
            this.tsslShowAll.Click += new System.EventHandler(this.tsslShowAll_Click);
            // 
            // dgvViewStudent
            // 
            this.dgvViewStudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvViewStudent.Location = new System.Drawing.Point(11, 31);
            this.dgvViewStudent.Name = "dgvViewStudent";
            this.dgvViewStudent.Size = new System.Drawing.Size(749, 501);
            this.dgvViewStudent.TabIndex = 8;
            this.dgvViewStudent.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvViewStudent_CellContentClick);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(385, 8);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(41, 13);
            this.label19.TabIndex = 7;
            this.label19.Text = "Search";
            // 
            // tboSearchMS
            // 
            this.tboSearchMS.Location = new System.Drawing.Point(434, 4);
            this.tboSearchMS.Name = "tboSearchMS";
            this.tboSearchMS.Size = new System.Drawing.Size(211, 20);
            this.tboSearchMS.TabIndex = 0;
            this.tboSearchMS.TextChanged += new System.EventHandler(this.tboSearchMS_TextChanged);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(217, 8);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(58, 13);
            this.label18.TabIndex = 5;
            this.label18.Text = "Fee Status";
            // 
            // cboFeeStatusMS
            // 
            this.cboFeeStatusMS.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFeeStatusMS.FormattingEnabled = true;
            this.cboFeeStatusMS.Location = new System.Drawing.Point(284, 4);
            this.cboFeeStatusMS.Name = "cboFeeStatusMS";
            this.cboFeeStatusMS.Size = new System.Drawing.Size(95, 21);
            this.cboFeeStatusMS.TabIndex = 3;
            this.cboFeeStatusMS.SelectedIndexChanged += new System.EventHandler(this.cboFeeStatusMS_SelectedIndexChanged);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(116, 8);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(25, 13);
            this.label17.TabIndex = 3;
            this.label17.Text = "Arm";
            // 
            // cboArmMS
            // 
            this.cboArmMS.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboArmMS.FormattingEnabled = true;
            this.cboArmMS.Location = new System.Drawing.Point(150, 4);
            this.cboArmMS.Name = "cboArmMS";
            this.cboArmMS.Size = new System.Drawing.Size(58, 21);
            this.cboArmMS.TabIndex = 2;
            this.cboArmMS.SelectedIndexChanged += new System.EventHandler(this.cboArmMS_SelectedIndexChanged);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(8, 8);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(32, 13);
            this.label16.TabIndex = 1;
            this.label16.Text = "Class";
            // 
            // cboClassMS
            // 
            this.cboClassMS.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboClassMS.FormattingEnabled = true;
            this.cboClassMS.Location = new System.Drawing.Point(49, 4);
            this.cboClassMS.Name = "cboClassMS";
            this.cboClassMS.Size = new System.Drawing.Size(58, 21);
            this.cboClassMS.TabIndex = 1;
            this.cboClassMS.SelectedIndexChanged += new System.EventHandler(this.cboClassMS_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.llAddStudentsWithExcel);
            this.tabPage1.Controls.Add(this.llOpenExcelToAddStudents);
            this.tabPage1.Controls.Add(this.tboOutstandingFeeAS);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.label20);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.cboPresentArmAS);
            this.tabPage1.Controls.Add(this.dtpBirthDateAS);
            this.tabPage1.Controls.Add(this.label15);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.cboPresentTermAS);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.cboPresentClassAS);
            this.tabPage1.Controls.Add(this.label14);
            this.tabPage1.Controls.Add(this.btnClearTextBoxes);
            this.tabPage1.Controls.Add(this.btnAddStudent);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.tboMiddleNameAS);
            this.tabPage1.Controls.Add(this.dtpStartDateAS);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.tboLastNameAS);
            this.tabPage1.Controls.Add(this.label12);
            this.tabPage1.Controls.Add(this.cboStartClassAS);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.cboStartTermAS);
            this.tabPage1.Controls.Add(this.tboFirstNameAS);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(729, 612);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Add Student";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // llAddStudentsWithExcel
            // 
            this.llAddStudentsWithExcel.AutoSize = true;
            this.llAddStudentsWithExcel.Location = new System.Drawing.Point(260, 23);
            this.llAddStudentsWithExcel.Name = "llAddStudentsWithExcel";
            this.llAddStudentsWithExcel.Size = new System.Drawing.Size(122, 13);
            this.llAddStudentsWithExcel.TabIndex = 24;
            this.llAddStudentsWithExcel.TabStop = true;
            this.llAddStudentsWithExcel.Text = "Add Students with Excel";
            this.llAddStudentsWithExcel.Visible = false;
            this.llAddStudentsWithExcel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llAddStudentsWithExcel_LinkClicked);
            // 
            // llOpenExcelToAddStudents
            // 
            this.llOpenExcelToAddStudents.AutoSize = true;
            this.llOpenExcelToAddStudents.Location = new System.Drawing.Point(29, 23);
            this.llOpenExcelToAddStudents.Name = "llOpenExcelToAddStudents";
            this.llOpenExcelToAddStudents.Size = new System.Drawing.Size(145, 13);
            this.llOpenExcelToAddStudents.TabIndex = 23;
            this.llOpenExcelToAddStudents.TabStop = true;
            this.llOpenExcelToAddStudents.Text = "Open Excel To Add Students";
            this.llOpenExcelToAddStudents.Visible = false;
            this.llOpenExcelToAddStudents.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llOpenExcelToAddStudents_LinkClicked);
            // 
            // tboOutstandingFeeAS
            // 
            this.tboOutstandingFeeAS.Location = new System.Drawing.Point(498, 163);
            this.tboOutstandingFeeAS.Name = "tboOutstandingFeeAS";
            this.tboOutstandingFeeAS.Size = new System.Drawing.Size(206, 20);
            this.tboOutstandingFeeAS.TabIndex = 6;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(495, 139);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(85, 13);
            this.label10.TabIndex = 22;
            this.label10.Text = "Outstanding Fee";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(498, 289);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(64, 13);
            this.label20.TabIndex = 20;
            this.label20.Text = "Present Arm";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(29, 139);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(66, 13);
            this.label9.TabIndex = 21;
            this.label9.Text = "Date of Birth";
            // 
            // cboPresentArmAS
            // 
            this.cboPresentArmAS.DropDownHeight = 120;
            this.cboPresentArmAS.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPresentArmAS.DropDownWidth = 78;
            this.cboPresentArmAS.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cboPresentArmAS.FormattingEnabled = true;
            this.cboPresentArmAS.IntegralHeight = false;
            this.cboPresentArmAS.ItemHeight = 13;
            this.cboPresentArmAS.Location = new System.Drawing.Point(498, 318);
            this.cboPresentArmAS.Name = "cboPresentArmAS";
            this.cboPresentArmAS.Size = new System.Drawing.Size(206, 21);
            this.cboPresentArmAS.TabIndex = 11;
            // 
            // dtpBirthDateAS
            // 
            this.dtpBirthDateAS.Location = new System.Drawing.Point(29, 163);
            this.dtpBirthDateAS.Name = "dtpBirthDateAS";
            this.dtpBirthDateAS.Size = new System.Drawing.Size(207, 20);
            this.dtpBirthDateAS.TabIndex = 4;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(263, 289);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(70, 13);
            this.label15.TabIndex = 18;
            this.label15.Text = "Present Term";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Last Name";
            // 
            // cboPresentTermAS
            // 
            this.cboPresentTermAS.DropDownHeight = 120;
            this.cboPresentTermAS.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPresentTermAS.DropDownWidth = 78;
            this.cboPresentTermAS.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cboPresentTermAS.FormattingEnabled = true;
            this.cboPresentTermAS.IntegralHeight = false;
            this.cboPresentTermAS.ItemHeight = 13;
            this.cboPresentTermAS.Location = new System.Drawing.Point(263, 318);
            this.cboPresentTermAS.Name = "cboPresentTermAS";
            this.cboPresentTermAS.Size = new System.Drawing.Size(206, 21);
            this.cboPresentTermAS.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(263, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "First Name";
            // 
            // cboPresentClassAS
            // 
            this.cboPresentClassAS.DropDownHeight = 120;
            this.cboPresentClassAS.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPresentClassAS.DropDownWidth = 78;
            this.cboPresentClassAS.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cboPresentClassAS.FormattingEnabled = true;
            this.cboPresentClassAS.IntegralHeight = false;
            this.cboPresentClassAS.ItemHeight = 13;
            this.cboPresentClassAS.Location = new System.Drawing.Point(29, 318);
            this.cboPresentClassAS.Name = "cboPresentClassAS";
            this.cboPresentClassAS.Size = new System.Drawing.Size(207, 21);
            this.cboPresentClassAS.TabIndex = 9;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(29, 289);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(71, 13);
            this.label14.TabIndex = 16;
            this.label14.Text = "Present Class";
            // 
            // btnClearTextBoxes
            // 
            this.btnClearTextBoxes.Location = new System.Drawing.Point(626, 18);
            this.btnClearTextBoxes.Name = "btnClearTextBoxes";
            this.btnClearTextBoxes.Size = new System.Drawing.Size(78, 23);
            this.btnClearTextBoxes.TabIndex = 13;
            this.btnClearTextBoxes.Text = "&Reset";
            this.btnClearTextBoxes.UseVisualStyleBackColor = true;
            this.btnClearTextBoxes.Click += new System.EventHandler(this.btnClearTextBoxes_Click);
            // 
            // btnAddStudent
            // 
            this.btnAddStudent.Location = new System.Drawing.Point(312, 414);
            this.btnAddStudent.Name = "btnAddStudent";
            this.btnAddStudent.Size = new System.Drawing.Size(98, 23);
            this.btnAddStudent.TabIndex = 12;
            this.btnAddStudent.Text = "&Save";
            this.btnAddStudent.UseVisualStyleBackColor = true;
            this.btnAddStudent.Click += new System.EventHandler(this.btnAddStudent_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(263, 139);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Start Date";
            // 
            // tboMiddleNameAS
            // 
            this.tboMiddleNameAS.Location = new System.Drawing.Point(498, 92);
            this.tboMiddleNameAS.Name = "tboMiddleNameAS";
            this.tboMiddleNameAS.Size = new System.Drawing.Size(206, 20);
            this.tboMiddleNameAS.TabIndex = 3;
            // 
            // dtpStartDateAS
            // 
            this.dtpStartDateAS.Location = new System.Drawing.Point(263, 163);
            this.dtpStartDateAS.Name = "dtpStartDateAS";
            this.dtpStartDateAS.Size = new System.Drawing.Size(206, 20);
            this.dtpStartDateAS.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(498, 68);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Middle Name";
            // 
            // tboLastNameAS
            // 
            this.tboLastNameAS.Location = new System.Drawing.Point(29, 92);
            this.tboLastNameAS.Name = "tboLastNameAS";
            this.tboLastNameAS.Size = new System.Drawing.Size(206, 20);
            this.tboLastNameAS.TabIndex = 1;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(263, 214);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(56, 13);
            this.label12.TabIndex = 11;
            this.label12.Text = "Start Term";
            // 
            // cboStartClassAS
            // 
            this.cboStartClassAS.DropDownHeight = 120;
            this.cboStartClassAS.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboStartClassAS.DropDownWidth = 78;
            this.cboStartClassAS.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cboStartClassAS.FormattingEnabled = true;
            this.cboStartClassAS.IntegralHeight = false;
            this.cboStartClassAS.ItemHeight = 13;
            this.cboStartClassAS.Location = new System.Drawing.Point(29, 241);
            this.cboStartClassAS.Name = "cboStartClassAS";
            this.cboStartClassAS.Size = new System.Drawing.Size(207, 21);
            this.cboStartClassAS.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(29, 214);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 13);
            this.label8.TabIndex = 9;
            this.label8.Text = "Start Class";
            // 
            // cboStartTermAS
            // 
            this.cboStartTermAS.DropDownHeight = 120;
            this.cboStartTermAS.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboStartTermAS.DropDownWidth = 78;
            this.cboStartTermAS.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cboStartTermAS.FormattingEnabled = true;
            this.cboStartTermAS.IntegralHeight = false;
            this.cboStartTermAS.ItemHeight = 13;
            this.cboStartTermAS.Location = new System.Drawing.Point(263, 241);
            this.cboStartTermAS.Name = "cboStartTermAS";
            this.cboStartTermAS.Size = new System.Drawing.Size(206, 21);
            this.cboStartTermAS.TabIndex = 8;
            // 
            // tboFirstNameAS
            // 
            this.tboFirstNameAS.Location = new System.Drawing.Point(263, 92);
            this.tboFirstNameAS.Name = "tboFirstNameAS";
            this.tboFirstNameAS.Size = new System.Drawing.Size(206, 20);
            this.tboFirstNameAS.TabIndex = 2;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnAddUser);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.tboPasswordAU);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.tboUsernameAU);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.tboFullNameAU);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(729, 612);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Add User";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnAddUser
            // 
            this.btnAddUser.Location = new System.Drawing.Point(128, 164);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(75, 23);
            this.btnAddUser.TabIndex = 4;
            this.btnAddUser.Text = "&Add User";
            this.btnAddUser.UseVisualStyleBackColor = true;
            this.btnAddUser.Click += new System.EventHandler(this.btnAddUser_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Password";
            // 
            // tboPasswordAU
            // 
            this.tboPasswordAU.Location = new System.Drawing.Point(128, 118);
            this.tboPasswordAU.Name = "tboPasswordAU";
            this.tboPasswordAU.PasswordChar = '*';
            this.tboPasswordAU.Size = new System.Drawing.Size(163, 20);
            this.tboPasswordAU.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Username";
            // 
            // tboUsernameAU
            // 
            this.tboUsernameAU.Location = new System.Drawing.Point(128, 79);
            this.tboUsernameAU.Name = "tboUsernameAU";
            this.tboUsernameAU.Size = new System.Drawing.Size(163, 20);
            this.tboUsernameAU.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Full Name";
            // 
            // tboFullNameAU
            // 
            this.tboFullNameAU.Location = new System.Drawing.Point(128, 42);
            this.tboFullNameAU.Name = "tboFullNameAU";
            this.tboFullNameAU.Size = new System.Drawing.Size(163, 20);
            this.tboFullNameAU.TabIndex = 1;
            // 
            // AddNewTerm
            // 
            this.AddNewTerm.Controls.Add(this.statusStrip2);
            this.AddNewTerm.Controls.Add(this.groupBox2);
            this.AddNewTerm.Controls.Add(this.btnUndoLastAddFeesANT);
            this.AddNewTerm.Controls.Add(this.btnSaveSchoolFeesANT);
            this.AddNewTerm.Controls.Add(this.tboSss3ANT);
            this.AddNewTerm.Controls.Add(this.tboJss3ANT);
            this.AddNewTerm.Controls.Add(this.label27);
            this.AddNewTerm.Controls.Add(this.label24);
            this.AddNewTerm.Controls.Add(this.tboSss2ANT);
            this.AddNewTerm.Controls.Add(this.tboJss2ANT);
            this.AddNewTerm.Controls.Add(this.label26);
            this.AddNewTerm.Controls.Add(this.label23);
            this.AddNewTerm.Controls.Add(this.tboSss1ANT);
            this.AddNewTerm.Controls.Add(this.label25);
            this.AddNewTerm.Controls.Add(this.tboJss1ANT);
            this.AddNewTerm.Controls.Add(this.label22);
            this.AddNewTerm.Controls.Add(this.llPromoteStudents);
            this.AddNewTerm.Controls.Add(this.label13);
            this.AddNewTerm.Controls.Add(this.cboTermANT);
            this.AddNewTerm.Controls.Add(this.label21);
            this.AddNewTerm.Controls.Add(this.cboSessionANT);
            this.AddNewTerm.Controls.Add(this.label11);
            this.AddNewTerm.Controls.Add(this.groupBox1);
            this.AddNewTerm.Location = new System.Drawing.Point(4, 22);
            this.AddNewTerm.Name = "AddNewTerm";
            this.AddNewTerm.Padding = new System.Windows.Forms.Padding(3);
            this.AddNewTerm.Size = new System.Drawing.Size(729, 612);
            this.AddNewTerm.TabIndex = 3;
            this.AddNewTerm.Text = "Add New Term";
            this.AddNewTerm.UseVisualStyleBackColor = true;
            // 
            // statusStrip2
            // 
            this.statusStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslAddNewTerm});
            this.statusStrip2.Location = new System.Drawing.Point(3, 587);
            this.statusStrip2.Name = "statusStrip2";
            this.statusStrip2.Size = new System.Drawing.Size(723, 22);
            this.statusStrip2.TabIndex = 9;
            this.statusStrip2.Text = "statusStrip2";
            // 
            // tsslAddNewTerm
            // 
            this.tsslAddNewTerm.Name = "tsslAddNewTerm";
            this.tsslAddNewTerm.Size = new System.Drawing.Size(0, 17);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label29);
            this.groupBox2.Controls.Add(this.label28);
            this.groupBox2.Controls.Add(this.tboSssANT);
            this.groupBox2.Controls.Add(this.tboJssANT);
            this.groupBox2.Location = new System.Drawing.Point(42, 328);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(571, 124);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "New Intakes";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(212, 34);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(61, 13);
            this.label29.TabIndex = 10;
            this.label29.Text = "SSS (NGN)";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(22, 34);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(59, 13);
            this.label28.TabIndex = 10;
            this.label28.Text = "JSS (NGN)";
            // 
            // tboSssANT
            // 
            this.tboSssANT.Location = new System.Drawing.Point(215, 60);
            this.tboSssANT.Name = "tboSssANT";
            this.tboSssANT.Size = new System.Drawing.Size(135, 20);
            this.tboSssANT.TabIndex = 10;
            // 
            // tboJssANT
            // 
            this.tboJssANT.Location = new System.Drawing.Point(25, 60);
            this.tboJssANT.Name = "tboJssANT";
            this.tboJssANT.Size = new System.Drawing.Size(135, 20);
            this.tboJssANT.TabIndex = 9;
            // 
            // btnUndoLastAddFeesANT
            // 
            this.btnUndoLastAddFeesANT.Location = new System.Drawing.Point(366, 494);
            this.btnUndoLastAddFeesANT.Name = "btnUndoLastAddFeesANT";
            this.btnUndoLastAddFeesANT.Size = new System.Drawing.Size(75, 23);
            this.btnUndoLastAddFeesANT.TabIndex = 12;
            this.btnUndoLastAddFeesANT.Text = "Undo Add";
            this.btnUndoLastAddFeesANT.UseVisualStyleBackColor = true;
            this.btnUndoLastAddFeesANT.Click += new System.EventHandler(this.btnUndoLastAddFeesANT_Click);
            // 
            // btnSaveSchoolFeesANT
            // 
            this.btnSaveSchoolFeesANT.Location = new System.Drawing.Point(257, 494);
            this.btnSaveSchoolFeesANT.Name = "btnSaveSchoolFeesANT";
            this.btnSaveSchoolFeesANT.Size = new System.Drawing.Size(75, 23);
            this.btnSaveSchoolFeesANT.TabIndex = 11;
            this.btnSaveSchoolFeesANT.Text = "&Save";
            this.btnSaveSchoolFeesANT.UseVisualStyleBackColor = true;
            this.btnSaveSchoolFeesANT.Click += new System.EventHandler(this.btnSaveSchoolFeesANT_Click);
            // 
            // tboSss3ANT
            // 
            this.tboSss3ANT.Location = new System.Drawing.Point(447, 268);
            this.tboSss3ANT.Name = "tboSss3ANT";
            this.tboSss3ANT.Size = new System.Drawing.Size(135, 20);
            this.tboSss3ANT.TabIndex = 8;
            // 
            // tboJss3ANT
            // 
            this.tboJss3ANT.Location = new System.Drawing.Point(447, 194);
            this.tboJss3ANT.Name = "tboJss3ANT";
            this.tboJss3ANT.Size = new System.Drawing.Size(135, 20);
            this.tboJss3ANT.TabIndex = 5;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(444, 243);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(70, 13);
            this.label27.TabIndex = 4;
            this.label27.Text = "SSS 3 (NGN)";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(444, 169);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(68, 13);
            this.label24.TabIndex = 4;
            this.label24.Text = "JSS 3 (NGN)";
            // 
            // tboSss2ANT
            // 
            this.tboSss2ANT.Location = new System.Drawing.Point(257, 268);
            this.tboSss2ANT.Name = "tboSss2ANT";
            this.tboSss2ANT.Size = new System.Drawing.Size(135, 20);
            this.tboSss2ANT.TabIndex = 7;
            // 
            // tboJss2ANT
            // 
            this.tboJss2ANT.Location = new System.Drawing.Point(257, 194);
            this.tboJss2ANT.Name = "tboJss2ANT";
            this.tboJss2ANT.Size = new System.Drawing.Size(135, 20);
            this.tboJss2ANT.TabIndex = 4;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(254, 243);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(73, 13);
            this.label26.TabIndex = 4;
            this.label26.Text = "SSS  2 (NGN)";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(254, 168);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(68, 13);
            this.label23.TabIndex = 4;
            this.label23.Text = "JSS 2 (NGN)";
            // 
            // tboSss1ANT
            // 
            this.tboSss1ANT.Location = new System.Drawing.Point(67, 268);
            this.tboSss1ANT.Name = "tboSss1ANT";
            this.tboSss1ANT.Size = new System.Drawing.Size(135, 20);
            this.tboSss1ANT.TabIndex = 6;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(64, 243);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(70, 13);
            this.label25.TabIndex = 4;
            this.label25.Text = "SSS 1 (NGN)";
            // 
            // tboJss1ANT
            // 
            this.tboJss1ANT.Location = new System.Drawing.Point(67, 194);
            this.tboJss1ANT.Name = "tboJss1ANT";
            this.tboJss1ANT.Size = new System.Drawing.Size(135, 20);
            this.tboJss1ANT.TabIndex = 3;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(64, 168);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(68, 13);
            this.label22.TabIndex = 4;
            this.label22.Text = "JSS 1 (NGN)";
            // 
            // llPromoteStudents
            // 
            this.llPromoteStudents.AutoSize = true;
            this.llPromoteStudents.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llPromoteStudents.Location = new System.Drawing.Point(268, 34);
            this.llPromoteStudents.Name = "llPromoteStudents";
            this.llPromoteStudents.Size = new System.Drawing.Size(215, 15);
            this.llPromoteStudents.TabIndex = 0;
            this.llPromoteStudents.TabStop = true;
            this.llPromoteStudents.Text = "Click here to submit repeating students\r\n";
            this.llPromoteStudents.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llPromoteStudents_LinkClicked);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Red;
            this.label13.Location = new System.Drawing.Point(43, 19);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(478, 30);
            this.label13.TabIndex = 2;
            this.label13.Text = "If it is the start of a new session (First Term), Please submit the list of stude" +
    "nts repeating.\r\nIgnore if there are no students repeating.";
            // 
            // cboTermANT
            // 
            this.cboTermANT.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTermANT.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cboTermANT.FormattingEnabled = true;
            this.cboTermANT.Location = new System.Drawing.Point(257, 96);
            this.cboTermANT.Name = "cboTermANT";
            this.cboTermANT.Size = new System.Drawing.Size(135, 21);
            this.cboTermANT.TabIndex = 2;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(254, 70);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(31, 13);
            this.label21.TabIndex = 0;
            this.label21.Text = "Term";
            // 
            // cboSessionANT
            // 
            this.cboSessionANT.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSessionANT.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cboSessionANT.FormattingEnabled = true;
            this.cboSessionANT.Location = new System.Drawing.Point(67, 96);
            this.cboSessionANT.Name = "cboSessionANT";
            this.cboSessionANT.Size = new System.Drawing.Size(135, 21);
            this.cboSessionANT.TabIndex = 1;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(64, 70);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(44, 13);
            this.label11.TabIndex = 0;
            this.label11.Text = "Session";
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(42, 140);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(571, 182);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add School Fees";
            // 
            // Promotion
            // 
            this.Promotion.Controls.Add(this.statusStrip3);
            this.Promotion.Controls.Add(this.dgvRepeatingStudents);
            this.Promotion.Controls.Add(this.btnSubmitRepeatingStudentsPS);
            this.Promotion.Controls.Add(this.label33);
            this.Promotion.Controls.Add(this.dgvStudentsPS);
            this.Promotion.Controls.Add(this.label30);
            this.Promotion.Controls.Add(this.tboSearchPS);
            this.Promotion.Controls.Add(this.label31);
            this.Promotion.Controls.Add(this.cboArmPS);
            this.Promotion.Controls.Add(this.label32);
            this.Promotion.Controls.Add(this.cboClassPS);
            this.Promotion.Location = new System.Drawing.Point(4, 22);
            this.Promotion.Name = "Promotion";
            this.Promotion.Padding = new System.Windows.Forms.Padding(3);
            this.Promotion.Size = new System.Drawing.Size(729, 612);
            this.Promotion.TabIndex = 4;
            this.Promotion.Text = "Submit Repeating Students";
            this.Promotion.UseVisualStyleBackColor = true;
            // 
            // statusStrip3
            // 
            this.statusStrip3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.tsslShowAllPS});
            this.statusStrip3.Location = new System.Drawing.Point(3, 587);
            this.statusStrip3.Name = "statusStrip3";
            this.statusStrip3.Size = new System.Drawing.Size(723, 22);
            this.statusStrip3.TabIndex = 19;
            this.statusStrip3.Text = "statusStrip3";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 17);
            // 
            // tsslShowAllPS
            // 
            this.tsslShowAllPS.IsLink = true;
            this.tsslShowAllPS.Name = "tsslShowAllPS";
            this.tsslShowAllPS.Size = new System.Drawing.Size(53, 17);
            this.tsslShowAllPS.Text = "Show All";
            this.tsslShowAllPS.Click += new System.EventHandler(this.tsslShowAllPS_Click);
            // 
            // dgvRepeatingStudents
            // 
            this.dgvRepeatingStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRepeatingStudents.Location = new System.Drawing.Point(8, 356);
            this.dgvRepeatingStudents.Name = "dgvRepeatingStudents";
            this.dgvRepeatingStudents.Size = new System.Drawing.Size(448, 172);
            this.dgvRepeatingStudents.TabIndex = 18;
            this.dgvRepeatingStudents.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRepeatingStudents_CellContentClick);
            // 
            // btnSubmitRepeatingStudentsPS
            // 
            this.btnSubmitRepeatingStudentsPS.Location = new System.Drawing.Point(201, 549);
            this.btnSubmitRepeatingStudentsPS.Name = "btnSubmitRepeatingStudentsPS";
            this.btnSubmitRepeatingStudentsPS.Size = new System.Drawing.Size(75, 23);
            this.btnSubmitRepeatingStudentsPS.TabIndex = 17;
            this.btnSubmitRepeatingStudentsPS.Text = "&Submit";
            this.btnSubmitRepeatingStudentsPS.UseVisualStyleBackColor = true;
            this.btnSubmitRepeatingStudentsPS.Click += new System.EventHandler(this.btnSubmitRepeatingStudentsPS_Click);
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Location = new System.Drawing.Point(9, 340);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(132, 13);
            this.label33.TabIndex = 15;
            this.label33.Text = "List of Repeating Students";
            // 
            // dgvStudentsPS
            // 
            this.dgvStudentsPS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudentsPS.Location = new System.Drawing.Point(8, 37);
            this.dgvStudentsPS.Name = "dgvStudentsPS";
            this.dgvStudentsPS.Size = new System.Drawing.Size(448, 284);
            this.dgvStudentsPS.TabIndex = 14;
            this.dgvStudentsPS.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStudentsPS_CellContentClick);
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(222, 13);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(41, 13);
            this.label30.TabIndex = 13;
            this.label30.Text = "Search";
            // 
            // tboSearchPS
            // 
            this.tboSearchPS.Location = new System.Drawing.Point(271, 9);
            this.tboSearchPS.Name = "tboSearchPS";
            this.tboSearchPS.Size = new System.Drawing.Size(185, 20);
            this.tboSearchPS.TabIndex = 8;
            this.tboSearchPS.TextChanged += new System.EventHandler(this.tboSearchPS_TextChanged);
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(116, 13);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(25, 13);
            this.label31.TabIndex = 12;
            this.label31.Text = "Arm";
            // 
            // cboArmPS
            // 
            this.cboArmPS.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboArmPS.FormattingEnabled = true;
            this.cboArmPS.Location = new System.Drawing.Point(150, 9);
            this.cboArmPS.Name = "cboArmPS";
            this.cboArmPS.Size = new System.Drawing.Size(58, 21);
            this.cboArmPS.TabIndex = 11;
            this.cboArmPS.SelectedIndexChanged += new System.EventHandler(this.cboArmPS_SelectedIndexChanged);
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(9, 14);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(32, 13);
            this.label32.TabIndex = 9;
            this.label32.Text = "Class";
            // 
            // cboClassPS
            // 
            this.cboClassPS.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboClassPS.FormattingEnabled = true;
            this.cboClassPS.Location = new System.Drawing.Point(50, 10);
            this.cboClassPS.Name = "cboClassPS";
            this.cboClassPS.Size = new System.Drawing.Size(58, 21);
            this.cboClassPS.TabIndex = 10;
            this.cboClassPS.SelectedIndexChanged += new System.EventHandler(this.cboClassPS_SelectedIndexChanged);
            // 
            // DashBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(776, 639);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "DashBoard";
            this.Text = "School Accountant DashBoard";
            this.Load += new System.EventHandler(this.DashBoard_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvViewStudent)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.AddNewTerm.ResumeLayout(false);
            this.AddNewTerm.PerformLayout();
            this.statusStrip2.ResumeLayout(false);
            this.statusStrip2.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.Promotion.ResumeLayout(false);
            this.Promotion.PerformLayout();
            this.statusStrip3.ResumeLayout(false);
            this.statusStrip3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRepeatingStudents)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudentsPS)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Button btnAddUser;
        private Label label3;
        private TextBox tboPasswordAU;
        private Label label2;
        private TextBox tboUsernameAU;
        private Label label1;
        private TextBox tboFullNameAU;
        private TextBox tboMiddleNameAS;
        private Label label6;
        private TextBox tboLastNameAS;
        private TextBox tboFirstNameAS;
        private Label label12;
        private ComboBox cboStartTermAS;
        private Label label8;
        private ComboBox cboStartClassAS;
        private Button btnAddStudent;
        private Button btnClearTextBoxes;
        private TabPage tabPage3;
        private Label label7;
        private DateTimePicker dtpStartDateAS;
        private Label label19;
        private TextBox tboSearchMS;
        private Label label18;
        private ComboBox cboFeeStatusMS;
        private Label label17;
        private ComboBox cboArmMS;
        private Label label16;
        private ComboBox cboClassMS;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel tsslTableStatus;
        private Label label4;
        private Label label5;
        private Label label9;
        private DateTimePicker dtpBirthDateAS;
        private Label label20;
        private ComboBox cboPresentArmAS;
        private Label label15;
        private ComboBox cboPresentTermAS;
        private ComboBox cboPresentClassAS;
        private Label label14;
        private TextBox tboOutstandingFeeAS;
        private Label label10;
        private ToolStripStatusLabel tsslShowAll;
        private Button btnRefresh;
        private TabPage AddNewTerm;
        private Button btnUndoLastAddFeesANT;
        private Button btnSaveSchoolFeesANT;
        private TextBox tboSss3ANT;
        private TextBox tboJss3ANT;
        private Label label27;
        private Label label24;
        private TextBox tboSss2ANT;
        private TextBox tboJss2ANT;
        private Label label26;
        private Label label23;
        private TextBox tboSss1ANT;
        private Label label25;
        private TextBox tboJss1ANT;
        private Label label22;
        private LinkLabel llPromoteStudents;
        private ComboBox cboTermANT;
        private Label label21;
        private ComboBox cboSessionANT;
        private Label label11;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Label label29;
        private Label label28;
        private TextBox tboSssANT;
        private TextBox tboJssANT;
        private StatusStrip statusStrip2;
        private ToolStripStatusLabel tsslAddNewTerm;
        private Label label13;
        private TabPage Promotion;
        private Label label32;
        private Button btnSubmitRepeatingStudentsPS;
        private Label label33;
        private DataGridView dgvStudentsPS;
        private Label label30;
        private TextBox tboSearchPS;
        private Label label31;
        private ComboBox cboArmPS;
        private ComboBox cboClassPS;
        private StatusStrip statusStrip3;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private ToolStripStatusLabel tsslShowAllPS;
        private DataGridView dgvRepeatingStudents;
        private DataGridView dgvViewStudent;
        private LinkLabel llOpenExcelToAddStudents;
        private LinkLabel llAddStudentsWithExcel;
    }
}