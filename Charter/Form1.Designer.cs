﻿namespace Charter
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.tabMain = new System.Windows.Forms.TabControl();
            this.tabSetup = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txtData = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnOpen = new System.Windows.Forms.Button();
            this.cboBaudRate = new System.Windows.Forms.ComboBox();
            this.cboComPort = new System.Windows.Forms.ComboBox();
            this.tabChart = new System.Windows.Forms.TabPage();
            this.tagText3 = new Charter.TagText();
            this.tagText2 = new Charter.TagText();
            this.tagText1 = new Charter.TagText();
            this.ioState3 = new Charter.IOState();
            this.ioState2 = new Charter.IOState();
            this.aGauge3 = new Charter.AGauge();
            this.ioState1 = new Charter.IOState();
            this.aGauge5 = new Charter.AGauge();
            this.panel1 = new System.Windows.Forms.Panel();
            this.stateButton2 = new Charter.StateButton();
            this.stateButton4 = new Charter.StateButton();
            this.stateButton1 = new Charter.StateButton();
            this.stateButton3 = new Charter.StateButton();
            this.tabText = new System.Windows.Forms.TabPage();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.aGauge4 = new Charter.AGauge();
            this.tagText4 = new Charter.TagText();
            this.tabMain.SuspendLayout();
            this.tabSetup.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabChart.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabMain
            // 
            this.tabMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tabMain.Controls.Add(this.tabSetup);
            this.tabMain.Controls.Add(this.tabChart);
            this.tabMain.Controls.Add(this.tabText);
            this.tabMain.Location = new System.Drawing.Point(0, -1);
            this.tabMain.Name = "tabMain";
            this.tabMain.SelectedIndex = 0;
            this.tabMain.Size = new System.Drawing.Size(990, 552);
            this.tabMain.TabIndex = 0;
            // 
            // tabSetup
            // 
            this.tabSetup.Controls.Add(this.groupBox1);
            this.tabSetup.Controls.Add(this.txtData);
            this.tabSetup.Controls.Add(this.label2);
            this.tabSetup.Controls.Add(this.label1);
            this.tabSetup.Controls.Add(this.btnClose);
            this.tabSetup.Controls.Add(this.btnOpen);
            this.tabSetup.Controls.Add(this.cboBaudRate);
            this.tabSetup.Controls.Add(this.cboComPort);
            this.tabSetup.Location = new System.Drawing.Point(4, 22);
            this.tabSetup.Name = "tabSetup";
            this.tabSetup.Size = new System.Drawing.Size(982, 526);
            this.tabSetup.TabIndex = 2;
            this.tabSetup.Text = "Setup";
            this.tabSetup.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Location = new System.Drawing.Point(10, 138);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(284, 204);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chart";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(62, 36);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(49, 20);
            this.textBox4.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Y axis; Min / MAX";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Tag list";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(172, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Select COM port";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(162, 36);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 13;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(13, 83);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox2.Size = new System.Drawing.Size(100, 76);
            this.textBox2.TabIndex = 12;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(13, 36);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(49, 20);
            this.textBox1.TabIndex = 11;
            // 
            // txtData
            // 
            this.txtData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtData.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtData.Location = new System.Drawing.Point(519, 2);
            this.txtData.Multiline = true;
            this.txtData.Name = "txtData";
            this.txtData.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtData.Size = new System.Drawing.Size(334, 421);
            this.txtData.TabIndex = 10;
            this.txtData.WordWrap = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(193, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Select Baud rate";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Select COM port";
            // 
            // btnClose
            // 
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Location = new System.Drawing.Point(192, 99);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 7;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(43, 99);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(75, 23);
            this.btnOpen.TabIndex = 6;
            this.btnOpen.Text = "Open";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // cboBaudRate
            // 
            this.cboBaudRate.FormattingEnabled = true;
            this.cboBaudRate.Items.AddRange(new object[] {
            "2400",
            "9600",
            "14400",
            "28800",
            "56000",
            "115200",
            "128000",
            "256000"});
            this.cboBaudRate.Location = new System.Drawing.Point(174, 45);
            this.cboBaudRate.Name = "cboBaudRate";
            this.cboBaudRate.Size = new System.Drawing.Size(121, 21);
            this.cboBaudRate.TabIndex = 5;
            // 
            // cboComPort
            // 
            this.cboComPort.FormattingEnabled = true;
            this.cboComPort.Location = new System.Drawing.Point(23, 45);
            this.cboComPort.Name = "cboComPort";
            this.cboComPort.Size = new System.Drawing.Size(121, 21);
            this.cboComPort.TabIndex = 4;
            // 
            // tabChart
            // 
            this.tabChart.BackColor = System.Drawing.SystemColors.Control;
            this.tabChart.Controls.Add(this.tagText4);
            this.tabChart.Controls.Add(this.tagText3);
            this.tabChart.Controls.Add(this.tagText2);
            this.tabChart.Controls.Add(this.tagText1);
            this.tabChart.Controls.Add(this.ioState3);
            this.tabChart.Controls.Add(this.ioState2);
            this.tabChart.Controls.Add(this.aGauge3);
            this.tabChart.Controls.Add(this.ioState1);
            this.tabChart.Controls.Add(this.aGauge5);
            this.tabChart.Controls.Add(this.panel1);
            this.tabChart.Location = new System.Drawing.Point(4, 22);
            this.tabChart.Name = "tabChart";
            this.tabChart.Padding = new System.Windows.Forms.Padding(3);
            this.tabChart.Size = new System.Drawing.Size(982, 526);
            this.tabChart.TabIndex = 1;
            this.tabChart.Tag = "Right";
            this.tabChart.Text = "Chart";
            // 
            // tagText3
            // 
            this.tagText3.AcceptsReturn = true;
            this.tagText3.AcceptsTab = true;
            this.tagText3.Location = new System.Drawing.Point(152, 135);
            this.tagText3.Multiline = true;
            this.tagText3.Name = "tagText3";
            this.tagText3.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tagText3.Size = new System.Drawing.Size(189, 153);
            this.tagText3.TabIndex = 49;
            this.tagText3.Tag = "This";
            // 
            // tagText2
            // 
            this.tagText2.AcceptsReturn = true;
            this.tagText2.AcceptsTab = true;
            this.tagText2.Location = new System.Drawing.Point(878, 212);
            this.tagText2.Multiline = true;
            this.tagText2.Name = "tagText2";
            this.tagText2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tagText2.Size = new System.Drawing.Size(96, 153);
            this.tagText2.TabIndex = 48;
            this.tagText2.Tag = "Right";
            // 
            // tagText1
            // 
            this.tagText1.AcceptsReturn = true;
            this.tagText1.AcceptsTab = true;
            this.tagText1.Location = new System.Drawing.Point(6, 212);
            this.tagText1.Multiline = true;
            this.tagText1.Name = "tagText1";
            this.tagText1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tagText1.Size = new System.Drawing.Size(96, 153);
            this.tagText1.TabIndex = 47;
            this.tagText1.Tag = "Left";
            // 
            // ioState3
            // 
            this.ioState3.Checked = false;
            this.ioState3.ForeColor = System.Drawing.Color.Yellow;
            this.ioState3.Location = new System.Drawing.Point(552, 16);
            this.ioState3.Name = "ioState3";
            this.ioState3.Size = new System.Drawing.Size(38, 24);
            this.ioState3.TabIndex = 46;
            this.ioState3.Tag = "LED3";
            // 
            // ioState2
            // 
            this.ioState2.Checked = false;
            this.ioState2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.ioState2.Location = new System.Drawing.Point(509, 16);
            this.ioState2.Name = "ioState2";
            this.ioState2.Size = new System.Drawing.Size(37, 24);
            this.ioState2.TabIndex = 45;
            this.ioState2.Tag = "LED2";
            // 
            // aGauge3
            // 
            this.aGauge3.BaseArcColor = System.Drawing.Color.Gray;
            this.aGauge3.BaseArcRadius = 150;
            this.aGauge3.BaseArcStart = 145;
            this.aGauge3.BaseArcSweep = 70;
            this.aGauge3.BaseArcWidth = 2;
            this.aGauge3.Cap_Idx = ((byte)(1));
            this.aGauge3.CapColors = new System.Drawing.Color[] {
        System.Drawing.Color.Black,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black};
            this.aGauge3.CapPosition = new System.Drawing.Point(10, 10);
            this.aGauge3.CapsPosition = new System.Drawing.Point[] {
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10)};
            this.aGauge3.CapsText = new string[] {
        "",
        "",
        "",
        "",
        ""};
            this.aGauge3.CapText = "";
            this.aGauge3.Center = new System.Drawing.Point(175, 100);
            this.aGauge3.Location = new System.Drawing.Point(8, 6);
            this.aGauge3.MaxValue = 100F;
            this.aGauge3.MinValue = 0F;
            this.aGauge3.Name = "aGauge3";
            this.aGauge3.NeedleColor1 = Charter.AGauge.NeedleColorEnum.Red;
            this.aGauge3.NeedleColor2 = System.Drawing.Color.DimGray;
            this.aGauge3.NeedleRadius = 160;
            this.aGauge3.NeedleType = 0;
            this.aGauge3.NeedleWidth = 2;
            this.aGauge3.Range_Idx = ((byte)(1));
            this.aGauge3.RangeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.aGauge3.RangeEnabled = true;
            this.aGauge3.RangeEndValue = 55F;
            this.aGauge3.RangeInnerRadius = 140;
            this.aGauge3.RangeOuterRadius = 150;
            this.aGauge3.RangesColor = new System.Drawing.Color[] {
        System.Drawing.Color.LightGreen,
        System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128))))),
        System.Drawing.SystemColors.Control,
        System.Drawing.SystemColors.Control,
        System.Drawing.SystemColors.Control};
            this.aGauge3.RangesEnabled = new bool[] {
        false,
        true,
        false,
        false,
        false};
            this.aGauge3.RangesEndValue = new float[] {
        300F,
        55F,
        0F,
        0F,
        0F};
            this.aGauge3.RangesInnerRadius = new int[] {
        70,
        140,
        70,
        70,
        70};
            this.aGauge3.RangesOuterRadius = new int[] {
        80,
        150,
        80,
        80,
        80};
            this.aGauge3.RangesStartValue = new float[] {
        -100F,
        45F,
        0F,
        0F,
        0F};
            this.aGauge3.RangeStartValue = 45F;
            this.aGauge3.ScaleLinesInterColor = System.Drawing.Color.Red;
            this.aGauge3.ScaleLinesInterInnerRadius = 145;
            this.aGauge3.ScaleLinesInterOuterRadius = 150;
            this.aGauge3.ScaleLinesInterWidth = 2;
            this.aGauge3.ScaleLinesMajorColor = System.Drawing.Color.Black;
            this.aGauge3.ScaleLinesMajorInnerRadius = 140;
            this.aGauge3.ScaleLinesMajorOuterRadius = 150;
            this.aGauge3.ScaleLinesMajorStepValue = 10F;
            this.aGauge3.ScaleLinesMajorWidth = 2;
            this.aGauge3.ScaleLinesMinorColor = System.Drawing.Color.Gray;
            this.aGauge3.ScaleLinesMinorInnerRadius = 145;
            this.aGauge3.ScaleLinesMinorNumOf = 9;
            this.aGauge3.ScaleLinesMinorOuterRadius = 150;
            this.aGauge3.ScaleLinesMinorWidth = 1;
            this.aGauge3.ScaleNumbersColor = System.Drawing.Color.Black;
            this.aGauge3.ScaleNumbersFormat = null;
            this.aGauge3.ScaleNumbersRadius = 162;
            this.aGauge3.ScaleNumbersRotation = 90;
            this.aGauge3.ScaleNumbersStartScaleLine = 1;
            this.aGauge3.ScaleNumbersStepScaleLines = 2;
            this.aGauge3.Size = new System.Drawing.Size(94, 200);
            this.aGauge3.TabIndex = 13;
            this.aGauge3.Tag = "Left";
            this.aGauge3.Value = 0F;
            // 
            // ioState1
            // 
            this.ioState1.Checked = false;
            this.ioState1.ForeColor = System.Drawing.Color.Red;
            this.ioState1.Location = new System.Drawing.Point(469, 16);
            this.ioState1.Name = "ioState1";
            this.ioState1.Size = new System.Drawing.Size(34, 24);
            this.ioState1.TabIndex = 44;
            this.ioState1.Tag = "LED1";
            // 
            // aGauge5
            // 
            this.aGauge5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.aGauge5.BaseArcColor = System.Drawing.Color.Gray;
            this.aGauge5.BaseArcRadius = 150;
            this.aGauge5.BaseArcStart = 35;
            this.aGauge5.BaseArcSweep = -70;
            this.aGauge5.BaseArcWidth = 2;
            this.aGauge5.Cap_Idx = ((byte)(1));
            this.aGauge5.CapColors = new System.Drawing.Color[] {
        System.Drawing.Color.Black,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black};
            this.aGauge5.CapPosition = new System.Drawing.Point(10, 10);
            this.aGauge5.CapsPosition = new System.Drawing.Point[] {
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10)};
            this.aGauge5.CapsText = new string[] {
        "",
        "",
        "",
        "",
        ""};
            this.aGauge5.CapText = "";
            this.aGauge5.Center = new System.Drawing.Point(-80, 100);
            this.aGauge5.Location = new System.Drawing.Point(880, 6);
            this.aGauge5.MaxValue = 100F;
            this.aGauge5.MinValue = 0F;
            this.aGauge5.Name = "aGauge5";
            this.aGauge5.NeedleColor1 = Charter.AGauge.NeedleColorEnum.Blue;
            this.aGauge5.NeedleColor2 = System.Drawing.Color.DimGray;
            this.aGauge5.NeedleRadius = 160;
            this.aGauge5.NeedleType = 0;
            this.aGauge5.NeedleWidth = 2;
            this.aGauge5.Range_Idx = ((byte)(1));
            this.aGauge5.RangeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.aGauge5.RangeEnabled = true;
            this.aGauge5.RangeEndValue = 55F;
            this.aGauge5.RangeInnerRadius = 140;
            this.aGauge5.RangeOuterRadius = 150;
            this.aGauge5.RangesColor = new System.Drawing.Color[] {
        System.Drawing.Color.LightGreen,
        System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128))))),
        System.Drawing.SystemColors.Control,
        System.Drawing.SystemColors.Control,
        System.Drawing.SystemColors.Control};
            this.aGauge5.RangesEnabled = new bool[] {
        false,
        true,
        false,
        false,
        false};
            this.aGauge5.RangesEndValue = new float[] {
        300F,
        55F,
        0F,
        0F,
        0F};
            this.aGauge5.RangesInnerRadius = new int[] {
        70,
        140,
        70,
        70,
        70};
            this.aGauge5.RangesOuterRadius = new int[] {
        80,
        150,
        80,
        80,
        80};
            this.aGauge5.RangesStartValue = new float[] {
        -100F,
        45F,
        0F,
        0F,
        0F};
            this.aGauge5.RangeStartValue = 45F;
            this.aGauge5.ScaleLinesInterColor = System.Drawing.Color.Red;
            this.aGauge5.ScaleLinesInterInnerRadius = 145;
            this.aGauge5.ScaleLinesInterOuterRadius = 150;
            this.aGauge5.ScaleLinesInterWidth = 2;
            this.aGauge5.ScaleLinesMajorColor = System.Drawing.Color.Black;
            this.aGauge5.ScaleLinesMajorInnerRadius = 140;
            this.aGauge5.ScaleLinesMajorOuterRadius = 150;
            this.aGauge5.ScaleLinesMajorStepValue = 10F;
            this.aGauge5.ScaleLinesMajorWidth = 2;
            this.aGauge5.ScaleLinesMinorColor = System.Drawing.Color.Gray;
            this.aGauge5.ScaleLinesMinorInnerRadius = 145;
            this.aGauge5.ScaleLinesMinorNumOf = 9;
            this.aGauge5.ScaleLinesMinorOuterRadius = 150;
            this.aGauge5.ScaleLinesMinorWidth = 1;
            this.aGauge5.ScaleNumbersColor = System.Drawing.Color.Black;
            this.aGauge5.ScaleNumbersFormat = null;
            this.aGauge5.ScaleNumbersRadius = 162;
            this.aGauge5.ScaleNumbersRotation = 90;
            this.aGauge5.ScaleNumbersStartScaleLine = 1;
            this.aGauge5.ScaleNumbersStepScaleLines = 2;
            this.aGauge5.Size = new System.Drawing.Size(96, 200);
            this.aGauge5.TabIndex = 14;
            this.aGauge5.Tag = "Right";
            this.aGauge5.Value = 0F;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.stateButton2);
            this.panel1.Controls.Add(this.stateButton4);
            this.panel1.Controls.Add(this.stateButton1);
            this.panel1.Controls.Add(this.stateButton3);
            this.panel1.Location = new System.Drawing.Point(149, 16);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(192, 113);
            this.panel1.TabIndex = 43;
            // 
            // stateButton2
            // 
            this.stateButton2.Checked = false;
            this.stateButton2.Location = new System.Drawing.Point(3, 70);
            this.stateButton2.Name = "stateButton2";
            this.stateButton2.Size = new System.Drawing.Size(75, 23);
            this.stateButton2.TabIndex = 40;
            this.stateButton2.Tag = "This";
            this.stateButton2.Text = "State2";
            // 
            // stateButton4
            // 
            this.stateButton4.Checked = false;
            this.stateButton4.Location = new System.Drawing.Point(99, 70);
            this.stateButton4.Name = "stateButton4";
            this.stateButton4.Size = new System.Drawing.Size(72, 23);
            this.stateButton4.TabIndex = 42;
            this.stateButton4.Tag = "This";
            this.stateButton4.Text = "State4";
            // 
            // stateButton1
            // 
            this.stateButton1.Checked = false;
            this.stateButton1.Location = new System.Drawing.Point(22, 12);
            this.stateButton1.Name = "stateButton1";
            this.stateButton1.Size = new System.Drawing.Size(75, 23);
            this.stateButton1.TabIndex = 39;
            this.stateButton1.Tag = "This";
            this.stateButton1.Text = "State1";
            // 
            // stateButton3
            // 
            this.stateButton3.Checked = false;
            this.stateButton3.Location = new System.Drawing.Point(60, 41);
            this.stateButton3.Name = "stateButton3";
            this.stateButton3.Size = new System.Drawing.Size(75, 23);
            this.stateButton3.TabIndex = 41;
            this.stateButton3.Tag = "This";
            this.stateButton3.Text = "State3";
            // 
            // tabText
            // 
            this.tabText.Location = new System.Drawing.Point(4, 22);
            this.tabText.Name = "tabText";
            this.tabText.Padding = new System.Windows.Forms.Padding(3);
            this.tabText.Size = new System.Drawing.Size(982, 526);
            this.tabText.TabIndex = 0;
            this.tabText.Text = "Text";
            this.tabText.UseVisualStyleBackColor = true;
            // 
            // serialPort1
            // 
            this.serialPort1.ErrorReceived += new System.IO.Ports.SerialErrorReceivedEventHandler(this.serialPort1_ErrorReceived);
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // aGauge4
            // 
            this.aGauge4.BaseArcColor = System.Drawing.Color.Gray;
            this.aGauge4.BaseArcRadius = 150;
            this.aGauge4.BaseArcStart = 120;
            this.aGauge4.BaseArcSweep = 120;
            this.aGauge4.BaseArcWidth = 2;
            this.aGauge4.Cap_Idx = ((byte)(1));
            this.aGauge4.CapColors = new System.Drawing.Color[] {
        System.Drawing.Color.Black,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black};
            this.aGauge4.CapPosition = new System.Drawing.Point(10, 10);
            this.aGauge4.CapsPosition = new System.Drawing.Point[] {
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10)};
            this.aGauge4.CapsText = new string[] {
        "",
        "",
        "",
        "",
        ""};
            this.aGauge4.CapText = "";
            this.aGauge4.Center = new System.Drawing.Point(175, 160);
            this.aGauge4.Location = new System.Drawing.Point(253, 17);
            this.aGauge4.MaxValue = 55F;
            this.aGauge4.MinValue = -55F;
            this.aGauge4.Name = "aGauge4";
            this.aGauge4.NeedleColor1 = Charter.AGauge.NeedleColorEnum.Blue;
            this.aGauge4.NeedleColor2 = System.Drawing.Color.DimGray;
            this.aGauge4.NeedleRadius = 160;
            this.aGauge4.NeedleType = 0;
            this.aGauge4.NeedleWidth = 2;
            this.aGauge4.Range_Idx = ((byte)(1));
            this.aGauge4.RangeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.aGauge4.RangeEnabled = true;
            this.aGauge4.RangeEndValue = 15F;
            this.aGauge4.RangeInnerRadius = 10;
            this.aGauge4.RangeOuterRadius = 150;
            this.aGauge4.RangesColor = new System.Drawing.Color[] {
        System.Drawing.Color.LightGreen,
        System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128))))),
        System.Drawing.SystemColors.Control,
        System.Drawing.SystemColors.Control,
        System.Drawing.SystemColors.Control};
            this.aGauge4.RangesEnabled = new bool[] {
        false,
        true,
        false,
        false,
        false};
            this.aGauge4.RangesEndValue = new float[] {
        300F,
        15F,
        0F,
        0F,
        0F};
            this.aGauge4.RangesInnerRadius = new int[] {
        70,
        10,
        70,
        70,
        70};
            this.aGauge4.RangesOuterRadius = new int[] {
        80,
        150,
        80,
        80,
        80};
            this.aGauge4.RangesStartValue = new float[] {
        -100F,
        -15F,
        0F,
        0F,
        0F};
            this.aGauge4.RangeStartValue = -15F;
            this.aGauge4.ScaleLinesInterColor = System.Drawing.Color.Red;
            this.aGauge4.ScaleLinesInterInnerRadius = 145;
            this.aGauge4.ScaleLinesInterOuterRadius = 150;
            this.aGauge4.ScaleLinesInterWidth = 2;
            this.aGauge4.ScaleLinesMajorColor = System.Drawing.Color.Black;
            this.aGauge4.ScaleLinesMajorInnerRadius = 140;
            this.aGauge4.ScaleLinesMajorOuterRadius = 150;
            this.aGauge4.ScaleLinesMajorStepValue = 10F;
            this.aGauge4.ScaleLinesMajorWidth = 2;
            this.aGauge4.ScaleLinesMinorColor = System.Drawing.Color.Gray;
            this.aGauge4.ScaleLinesMinorInnerRadius = 145;
            this.aGauge4.ScaleLinesMinorNumOf = 9;
            this.aGauge4.ScaleLinesMinorOuterRadius = 150;
            this.aGauge4.ScaleLinesMinorWidth = 1;
            this.aGauge4.ScaleNumbersColor = System.Drawing.Color.Black;
            this.aGauge4.ScaleNumbersFormat = null;
            this.aGauge4.ScaleNumbersRadius = 162;
            this.aGauge4.ScaleNumbersRotation = 90;
            this.aGauge4.ScaleNumbersStartScaleLine = 1;
            this.aGauge4.ScaleNumbersStepScaleLines = 2;
            this.aGauge4.Size = new System.Drawing.Size(135, 324);
            this.aGauge4.TabIndex = 8;
            this.aGauge4.Text = "aGauge4";
            this.aGauge4.Value = 0F;
            // 
            // tagText4
            // 
            this.tagText4.AcceptsReturn = true;
            this.tagText4.AcceptsTab = true;
            this.tagText4.Location = new System.Drawing.Point(469, 68);
            this.tagText4.Multiline = true;
            this.tagText4.Name = "tagText4";
            this.tagText4.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tagText4.Size = new System.Drawing.Size(189, 220);
            this.tagText4.TabIndex = 50;
            this.tagText4.Tag = "*";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(990, 550);
            this.Controls.Add(this.tabMain);
            this.MinimumSize = new System.Drawing.Size(908, 455);
            this.Name = "Form1";
            this.Text = "Arduino Charting Tool";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabMain.ResumeLayout(false);
            this.tabSetup.ResumeLayout(false);
            this.tabSetup.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabChart.ResumeLayout(false);
            this.tabChart.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabMain;
        private System.Windows.Forms.TabPage tabText;
        private System.Windows.Forms.TabPage tabChart;
        private System.Windows.Forms.TabPage tabSetup;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.ComboBox cboBaudRate;
        private System.Windows.Forms.ComboBox cboComPort;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.TextBox txtData;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox4;
        private AGauge aGauge4;
        private IOState ioState3;
        private IOState ioState2;
        private AGauge aGauge3;
        private IOState ioState1;
        private AGauge aGauge5;
        private System.Windows.Forms.Panel panel1;
        private StateButton stateButton2;
        private StateButton stateButton4;
        private StateButton stateButton1;
        private StateButton stateButton3;
        private TagText tagText2;
        private TagText tagText1;
        private TagText tagText3;
        private TagText tagText4;
    }
}

