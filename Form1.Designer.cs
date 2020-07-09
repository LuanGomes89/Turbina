using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Threading;
using System.Windows.Forms.DataVisualization.Charting;

namespace SimpleModBusforPLC
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.portconnect = new System.Windows.Forms.Button();
            this.portname = new System.Windows.Forms.ComboBox();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configuraçãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fichaTécnicaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comunicaçãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aferiçaçãoDeVazãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sobreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label30 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label31 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblt95 = new System.Windows.Forms.Label();
            this.txtt95 = new System.Windows.Forms.TextBox();
            this.label28 = new System.Windows.Forms.Label();
            this.Dp = new System.Windows.Forms.TextBox();
            this.Nvezes = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Qt = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.TxtVazaoM = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.Qmax = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Qmin = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.GroupTeste = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label32 = new System.Windows.Forms.Label();
            this.Volume = new System.Windows.Forms.TextBox();
            this.Vazao_T100 = new System.Windows.Forms.TextBox();
            this.Pres_T100 = new System.Windows.Forms.TextBox();
            this.Temp_T100 = new System.Windows.Forms.TextBox();
            this.Pulso_Tot_T100 = new System.Windows.Forms.TextBox();
            this.Vol_Tot_T100 = new System.Windows.Forms.TextBox();
            this.Pulso_Min_T100 = new System.Windows.Forms.TextBox();
            this.Vazao_T70 = new System.Windows.Forms.TextBox();
            this.Pres_T70 = new System.Windows.Forms.TextBox();
            this.Temp_T70 = new System.Windows.Forms.TextBox();
            this.Pulso_Tot_T70 = new System.Windows.Forms.TextBox();
            this.Vol_Tot_T70 = new System.Windows.Forms.TextBox();
            this.Pulso_Min_T70 = new System.Windows.Forms.TextBox();
            this.Vazao_T50 = new System.Windows.Forms.TextBox();
            this.Pres_T50 = new System.Windows.Forms.TextBox();
            this.Temp_T50 = new System.Windows.Forms.TextBox();
            this.Pulso_Tot_T50 = new System.Windows.Forms.TextBox();
            this.Vol_Tot_T50 = new System.Windows.Forms.TextBox();
            this.Pulso_Min_T50 = new System.Windows.Forms.TextBox();
            this.Vazao_T30 = new System.Windows.Forms.TextBox();
            this.Pres_T30 = new System.Windows.Forms.TextBox();
            this.Temp_T30 = new System.Windows.Forms.TextBox();
            this.Pulso_Tot_T30 = new System.Windows.Forms.TextBox();
            this.Vol_Tot_T30 = new System.Windows.Forms.TextBox();
            this.Pulso_Min_T30 = new System.Windows.Forms.TextBox();
            this.Vazao_T20 = new System.Windows.Forms.TextBox();
            this.Pres_T20 = new System.Windows.Forms.TextBox();
            this.Temp_T20 = new System.Windows.Forms.TextBox();
            this.Pulso_Tot_T20 = new System.Windows.Forms.TextBox();
            this.Vol_Tot_T20 = new System.Windows.Forms.TextBox();
            this.Pulso_Min_T20 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.Fator_T100 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.Fator_T70 = new System.Windows.Forms.TextBox();
            this.Fator_T50 = new System.Windows.Forms.TextBox();
            this.Fator_T30 = new System.Windows.Forms.TextBox();
            this.Fator_T20 = new System.Windows.Forms.TextBox();
            this.Vazao_T10 = new System.Windows.Forms.TextBox();
            this.Pres_T10 = new System.Windows.Forms.TextBox();
            this.Temp_T10 = new System.Windows.Forms.TextBox();
            this.Pulso_Tot_T10 = new System.Windows.Forms.TextBox();
            this.Vol_Tot_T10 = new System.Windows.Forms.TextBox();
            this.Pulso_Min_T10 = new System.Windows.Forms.TextBox();
            this.Fator_T10 = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.ErrorR = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.faixaM = new System.Windows.Forms.ComboBox();
            this.Restante = new System.Windows.Forms.TextBox();
            this.Vazao_T = new System.Windows.Forms.TextBox();
            this.label27 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.Pres_T = new System.Windows.Forms.TextBox();
            this.Temp_T = new System.Windows.Forms.TextBox();
            this.Pulso_Tot_T = new System.Windows.Forms.TextBox();
            this.Vol_Tot_T = new System.Windows.Forms.TextBox();
            this.Pulso_Min_T = new System.Windows.Forms.TextBox();
            this.Fator_T = new System.Windows.Forms.TextBox();
            this.btnTransfer = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.Percentual = new System.Windows.Forms.ComboBox();
            this.Vazao_M = new System.Windows.Forms.TextBox();
            this.Pres_M = new System.Windows.Forms.TextBox();
            this.Temp_M = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.Pulso_Tot_M = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.Vol_Tot_M = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.Pulso_Min_M = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.Fator_M = new System.Windows.Forms.TextBox();
            this.GroupMaster = new System.Windows.Forms.GroupBox();
            this.label38 = new System.Windows.Forms.Label();
            this.label37 = new System.Windows.Forms.Label();
            this.label36 = new System.Windows.Forms.Label();
            this.label35 = new System.Windows.Forms.Label();
            this.label34 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.Erro_100 = new System.Windows.Forms.TextBox();
            this.Erro_70 = new System.Windows.Forms.TextBox();
            this.Erro_50 = new System.Windows.Forms.TextBox();
            this.Erro_30 = new System.Windows.Forms.TextBox();
            this.Erro_20 = new System.Windows.Forms.TextBox();
            this.Erro_10 = new System.Windows.Forms.TextBox();
            this.Vazao_M100 = new System.Windows.Forms.TextBox();
            this.Pres_M100 = new System.Windows.Forms.TextBox();
            this.Fator_M10 = new System.Windows.Forms.TextBox();
            this.Temp_M100 = new System.Windows.Forms.TextBox();
            this.Pulso_Tot_M100 = new System.Windows.Forms.TextBox();
            this.Vol_Tot_M100 = new System.Windows.Forms.TextBox();
            this.Pulso_Min_M100 = new System.Windows.Forms.TextBox();
            this.Vazao_M70 = new System.Windows.Forms.TextBox();
            this.Pres_M70 = new System.Windows.Forms.TextBox();
            this.Temp_M70 = new System.Windows.Forms.TextBox();
            this.Pulso_Tot_M70 = new System.Windows.Forms.TextBox();
            this.Vol_Tot_M70 = new System.Windows.Forms.TextBox();
            this.Pulso_Min_M70 = new System.Windows.Forms.TextBox();
            this.Vazao_M50 = new System.Windows.Forms.TextBox();
            this.Pres_M50 = new System.Windows.Forms.TextBox();
            this.Temp_M50 = new System.Windows.Forms.TextBox();
            this.Pulso_Tot_M50 = new System.Windows.Forms.TextBox();
            this.Vol_Tot_M50 = new System.Windows.Forms.TextBox();
            this.Pulso_Min_M50 = new System.Windows.Forms.TextBox();
            this.Vazao_M30 = new System.Windows.Forms.TextBox();
            this.Pres_M30 = new System.Windows.Forms.TextBox();
            this.Temp_M30 = new System.Windows.Forms.TextBox();
            this.Pulso_Tot_M30 = new System.Windows.Forms.TextBox();
            this.Vol_Tot_M30 = new System.Windows.Forms.TextBox();
            this.Pulso_Min_M30 = new System.Windows.Forms.TextBox();
            this.Vazao_M20 = new System.Windows.Forms.TextBox();
            this.Pres_M20 = new System.Windows.Forms.TextBox();
            this.Temp_M20 = new System.Windows.Forms.TextBox();
            this.Pulso_Tot_M20 = new System.Windows.Forms.TextBox();
            this.Vol_Tot_M20 = new System.Windows.Forms.TextBox();
            this.Pulso_Min_M20 = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.Fator_M100 = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.Fator_M70 = new System.Windows.Forms.TextBox();
            this.Fator_M50 = new System.Windows.Forms.TextBox();
            this.Fator_M30 = new System.Windows.Forms.TextBox();
            this.Fator_M20 = new System.Windows.Forms.TextBox();
            this.Vazao_M10 = new System.Windows.Forms.TextBox();
            this.Pres_M10 = new System.Windows.Forms.TextBox();
            this.Temp_M10 = new System.Windows.Forms.TextBox();
            this.Pulso_Tot_M10 = new System.Windows.Forms.TextBox();
            this.Vol_Tot_M10 = new System.Windows.Forms.TextBox();
            this.Pulso_Min_M10 = new System.Windows.Forms.TextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.timer_parada = new System.Windows.Forms.Timer(this.components);
            this.timer_corrida = new System.Windows.Forms.Timer(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.StatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.TempoLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBox2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.GroupTeste.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.GroupMaster.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox2.Controls.Add(this.portconnect);
            this.groupBox2.Controls.Add(this.portname);
            this.groupBox2.Location = new System.Drawing.Point(844, 390);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(132, 108);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Port Setting";
            // 
            // portconnect
            // 
            this.portconnect.Location = new System.Drawing.Point(5, 54);
            this.portconnect.Name = "portconnect";
            this.portconnect.Size = new System.Drawing.Size(118, 23);
            this.portconnect.TabIndex = 5;
            this.portconnect.Text = "Open Port";
            this.portconnect.UseVisualStyleBackColor = true;
            this.portconnect.Click += new System.EventHandler(this.portconnect_Click);
            // 
            // portname
            // 
            this.portname.FormattingEnabled = true;
            this.portname.Location = new System.Drawing.Point(5, 23);
            this.portname.Name = "portname";
            this.portname.Size = new System.Drawing.Size(121, 21);
            this.portname.TabIndex = 4;
            this.portname.Text = "COM3";
            this.portname.DragDrop += new System.Windows.Forms.DragEventHandler(this.portname_DragDrop);
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.configuraçãoToolStripMenuItem,
            this.sobreToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1079, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.fileToolStripMenuItem.Text = "Arquivo";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(93, 22);
            this.exitToolStripMenuItem.Text = "Sair";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // configuraçãoToolStripMenuItem
            // 
            this.configuraçãoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fichaTécnicaToolStripMenuItem,
            this.comunicaçãoToolStripMenuItem,
            this.aferiçaçãoDeVazãoToolStripMenuItem});
            this.configuraçãoToolStripMenuItem.Name = "configuraçãoToolStripMenuItem";
            this.configuraçãoToolStripMenuItem.Size = new System.Drawing.Size(91, 20);
            this.configuraçãoToolStripMenuItem.Text = "Configuração";
            // 
            // fichaTécnicaToolStripMenuItem
            // 
            this.fichaTécnicaToolStripMenuItem.Name = "fichaTécnicaToolStripMenuItem";
            this.fichaTécnicaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.fichaTécnicaToolStripMenuItem.Text = "Ficha Técnica";
            this.fichaTécnicaToolStripMenuItem.Click += new System.EventHandler(this.fichaTécnicaToolStripMenuItem_Click);
            // 
            // comunicaçãoToolStripMenuItem
            // 
            this.comunicaçãoToolStripMenuItem.Name = "comunicaçãoToolStripMenuItem";
            this.comunicaçãoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.comunicaçãoToolStripMenuItem.Text = "Comunicação";
            this.comunicaçãoToolStripMenuItem.Click += new System.EventHandler(this.comunicaçãoToolStripMenuItem_Click);
            // 
            // aferiçaçãoDeVazãoToolStripMenuItem
            // 
            this.aferiçaçãoDeVazãoToolStripMenuItem.Name = "aferiçaçãoDeVazãoToolStripMenuItem";
            this.aferiçaçãoDeVazãoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.aferiçaçãoDeVazãoToolStripMenuItem.Text = "Aferiçação de Vazão";
            this.aferiçaçãoDeVazãoToolStripMenuItem.Click += new System.EventHandler(this.aferiçaçãoDeVazãoToolStripMenuItem_Click);
            // 
            // sobreToolStripMenuItem
            // 
            this.sobreToolStripMenuItem.Name = "sobreToolStripMenuItem";
            this.sobreToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.sobreToolStripMenuItem.Text = "Sobre";
            this.sobreToolStripMenuItem.Click += new System.EventHandler(this.sobreToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label30);
            this.panel1.Controls.Add(this.textBox3);
            this.panel1.Controls.Add(this.label31);
            this.panel1.Controls.Add(this.label29);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.lblt95);
            this.panel1.Controls.Add(this.txtt95);
            this.panel1.Controls.Add(this.label28);
            this.panel1.Controls.Add(this.Dp);
            this.panel1.Controls.Add(this.Nvezes);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.Qt);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.TxtVazaoM);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.Qmax);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.Qmin);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.GroupTeste);
            this.panel1.Controls.Add(this.groupBox5);
            this.panel1.Controls.Add(this.GroupMaster);
            this.panel1.Location = new System.Drawing.Point(12, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1067, 358);
            this.panel1.TabIndex = 5;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(603, 252);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(62, 13);
            this.label30.TabIndex = 69;
            this.label30.Text = "erro medio2";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(606, 265);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(67, 20);
            this.textBox3.TabIndex = 68;
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(532, 303);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(67, 13);
            this.label31.TabIndex = 70;
            this.label31.Text = "vazao media";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(474, 304);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(56, 13);
            this.label29.TabIndex = 87;
            this.label29.Text = "erro medio";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(477, 320);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(52, 20);
            this.textBox2.TabIndex = 86;
            this.textBox2.Visible = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(535, 319);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(65, 20);
            this.textBox1.TabIndex = 85;
            // 
            // lblt95
            // 
            this.lblt95.AutoSize = true;
            this.lblt95.Location = new System.Drawing.Point(962, 330);
            this.lblt95.Name = "lblt95";
            this.lblt95.Size = new System.Drawing.Size(22, 13);
            this.lblt95.TabIndex = 84;
            this.lblt95.Text = "t95";
            // 
            // txtt95
            // 
            this.txtt95.Location = new System.Drawing.Point(993, 323);
            this.txtt95.Name = "txtt95";
            this.txtt95.Size = new System.Drawing.Size(55, 20);
            this.txtt95.TabIndex = 83;
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(874, 330);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(21, 13);
            this.label28.TabIndex = 82;
            this.label28.Text = "Dp";
            // 
            // Dp
            // 
            this.Dp.Location = new System.Drawing.Point(901, 323);
            this.Dp.Name = "Dp";
            this.Dp.Size = new System.Drawing.Size(55, 20);
            this.Dp.TabIndex = 71;
            // 
            // Nvezes
            // 
            this.Nvezes.AutoSize = true;
            this.Nvezes.Location = new System.Drawing.Point(677, 326);
            this.Nvezes.Name = "Nvezes";
            this.Nvezes.Size = new System.Drawing.Size(13, 13);
            this.Nvezes.TabIndex = 81;
            this.Nvezes.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(623, 155);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(18, 13);
            this.label6.TabIndex = 80;
            this.label6.Text = "Qt";
            // 
            // Qt
            // 
            this.Qt.Location = new System.Drawing.Point(621, 171);
            this.Qt.Name = "Qt";
            this.Qt.Size = new System.Drawing.Size(49, 20);
            this.Qt.TabIndex = 79;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(604, 291);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(86, 23);
            this.button3.TabIndex = 78;
            this.button3.Text = "Vazão Média";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // TxtVazaoM
            // 
            this.TxtVazaoM.Location = new System.Drawing.Point(606, 320);
            this.TxtVazaoM.Name = "TxtVazaoM";
            this.TxtVazaoM.Size = new System.Drawing.Size(65, 20);
            this.TxtVazaoM.TabIndex = 30;
            this.TxtVazaoM.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(621, 81);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(73, 23);
            this.button2.TabIndex = 76;
            this.button2.Text = "Q.Min e Qt";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_3);
            // 
            // Qmax
            // 
            this.Qmax.Location = new System.Drawing.Point(621, 44);
            this.Qmax.Name = "Qmax";
            this.Qmax.Size = new System.Drawing.Size(50, 20);
            this.Qmax.TabIndex = 75;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(623, 116);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 74;
            this.label5.Text = "Q.Min";
            // 
            // Qmin
            // 
            this.Qmin.Location = new System.Drawing.Point(621, 132);
            this.Qmin.Name = "Qmin";
            this.Qmin.Size = new System.Drawing.Size(50, 20);
            this.Qmin.TabIndex = 73;
            this.Qmin.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(621, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 72;
            this.label4.Text = "Q.Max";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(256, 323);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 13);
            this.label2.TabIndex = 69;
            this.label2.Text = "Relatório / Gráfico";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(356, 313);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 30;
            this.button1.Text = "Gerar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_3);
            // 
            // GroupTeste
            // 
            this.GroupTeste.Controls.Add(this.groupBox3);
            this.GroupTeste.Controls.Add(this.Vazao_T100);
            this.GroupTeste.Controls.Add(this.Pres_T100);
            this.GroupTeste.Controls.Add(this.Temp_T100);
            this.GroupTeste.Controls.Add(this.Pulso_Tot_T100);
            this.GroupTeste.Controls.Add(this.Vol_Tot_T100);
            this.GroupTeste.Controls.Add(this.Pulso_Min_T100);
            this.GroupTeste.Controls.Add(this.Vazao_T70);
            this.GroupTeste.Controls.Add(this.Pres_T70);
            this.GroupTeste.Controls.Add(this.Temp_T70);
            this.GroupTeste.Controls.Add(this.Pulso_Tot_T70);
            this.GroupTeste.Controls.Add(this.Vol_Tot_T70);
            this.GroupTeste.Controls.Add(this.Pulso_Min_T70);
            this.GroupTeste.Controls.Add(this.Vazao_T50);
            this.GroupTeste.Controls.Add(this.Pres_T50);
            this.GroupTeste.Controls.Add(this.Temp_T50);
            this.GroupTeste.Controls.Add(this.Pulso_Tot_T50);
            this.GroupTeste.Controls.Add(this.Vol_Tot_T50);
            this.GroupTeste.Controls.Add(this.Pulso_Min_T50);
            this.GroupTeste.Controls.Add(this.Vazao_T30);
            this.GroupTeste.Controls.Add(this.Pres_T30);
            this.GroupTeste.Controls.Add(this.Temp_T30);
            this.GroupTeste.Controls.Add(this.Pulso_Tot_T30);
            this.GroupTeste.Controls.Add(this.Vol_Tot_T30);
            this.GroupTeste.Controls.Add(this.Pulso_Min_T30);
            this.GroupTeste.Controls.Add(this.Vazao_T20);
            this.GroupTeste.Controls.Add(this.Pres_T20);
            this.GroupTeste.Controls.Add(this.Temp_T20);
            this.GroupTeste.Controls.Add(this.Pulso_Tot_T20);
            this.GroupTeste.Controls.Add(this.Vol_Tot_T20);
            this.GroupTeste.Controls.Add(this.Pulso_Min_T20);
            this.GroupTeste.Controls.Add(this.label11);
            this.GroupTeste.Controls.Add(this.Fator_T100);
            this.GroupTeste.Controls.Add(this.label12);
            this.GroupTeste.Controls.Add(this.label13);
            this.GroupTeste.Controls.Add(this.label14);
            this.GroupTeste.Controls.Add(this.label18);
            this.GroupTeste.Controls.Add(this.Fator_T70);
            this.GroupTeste.Controls.Add(this.Fator_T50);
            this.GroupTeste.Controls.Add(this.Fator_T30);
            this.GroupTeste.Controls.Add(this.Fator_T20);
            this.GroupTeste.Controls.Add(this.Vazao_T10);
            this.GroupTeste.Controls.Add(this.Pres_T10);
            this.GroupTeste.Controls.Add(this.Temp_T10);
            this.GroupTeste.Controls.Add(this.Pulso_Tot_T10);
            this.GroupTeste.Controls.Add(this.Vol_Tot_T10);
            this.GroupTeste.Controls.Add(this.Pulso_Min_T10);
            this.GroupTeste.Controls.Add(this.Fator_T10);
            this.GroupTeste.Controls.Add(this.label19);
            this.GroupTeste.Location = new System.Drawing.Point(705, 18);
            this.GroupTeste.Name = "GroupTeste";
            this.GroupTeste.Size = new System.Drawing.Size(350, 290);
            this.GroupTeste.TabIndex = 68;
            this.GroupTeste.TabStop = false;
            this.GroupTeste.Text = "Turbina Teste";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label32);
            this.groupBox3.Controls.Add(this.Volume);
            this.groupBox3.Location = new System.Drawing.Point(8, 236);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(330, 46);
            this.groupBox3.TabIndex = 68;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Critério de Parada";
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(17, 23);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(93, 13);
            this.label32.TabIndex = 4;
            this.label32.Text = "Volume da Corrida";
            this.label32.Click += new System.EventHandler(this.label32_Click);
            // 
            // Volume
            // 
            this.Volume.Location = new System.Drawing.Point(124, 20);
            this.Volume.Name = "Volume";
            this.Volume.Size = new System.Drawing.Size(61, 20);
            this.Volume.TabIndex = 3;
            this.Volume.Text = "0";
            this.Volume.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Volume.TextChanged += new System.EventHandler(this.Volume_TextChanged);
            // 
            // Vazao_T100
            // 
            this.Vazao_T100.Location = new System.Drawing.Point(288, 205);
            this.Vazao_T100.Name = "Vazao_T100";
            this.Vazao_T100.Size = new System.Drawing.Size(50, 20);
            this.Vazao_T100.TabIndex = 67;
            this.Vazao_T100.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Pres_T100
            // 
            this.Pres_T100.Location = new System.Drawing.Point(288, 179);
            this.Pres_T100.Name = "Pres_T100";
            this.Pres_T100.Size = new System.Drawing.Size(50, 20);
            this.Pres_T100.TabIndex = 66;
            this.Pres_T100.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Temp_T100
            // 
            this.Temp_T100.Location = new System.Drawing.Point(288, 153);
            this.Temp_T100.Name = "Temp_T100";
            this.Temp_T100.Size = new System.Drawing.Size(50, 20);
            this.Temp_T100.TabIndex = 65;
            this.Temp_T100.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Pulso_Tot_T100
            // 
            this.Pulso_Tot_T100.Location = new System.Drawing.Point(288, 125);
            this.Pulso_Tot_T100.Name = "Pulso_Tot_T100";
            this.Pulso_Tot_T100.Size = new System.Drawing.Size(50, 20);
            this.Pulso_Tot_T100.TabIndex = 64;
            this.Pulso_Tot_T100.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Vol_Tot_T100
            // 
            this.Vol_Tot_T100.Location = new System.Drawing.Point(288, 99);
            this.Vol_Tot_T100.Name = "Vol_Tot_T100";
            this.Vol_Tot_T100.Size = new System.Drawing.Size(50, 20);
            this.Vol_Tot_T100.TabIndex = 63;
            this.Vol_Tot_T100.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Pulso_Min_T100
            // 
            this.Pulso_Min_T100.Location = new System.Drawing.Point(288, 73);
            this.Pulso_Min_T100.Name = "Pulso_Min_T100";
            this.Pulso_Min_T100.Size = new System.Drawing.Size(50, 20);
            this.Pulso_Min_T100.TabIndex = 62;
            this.Pulso_Min_T100.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Vazao_T70
            // 
            this.Vazao_T70.Location = new System.Drawing.Point(232, 205);
            this.Vazao_T70.Name = "Vazao_T70";
            this.Vazao_T70.Size = new System.Drawing.Size(50, 20);
            this.Vazao_T70.TabIndex = 61;
            this.Vazao_T70.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Pres_T70
            // 
            this.Pres_T70.Location = new System.Drawing.Point(232, 179);
            this.Pres_T70.Name = "Pres_T70";
            this.Pres_T70.Size = new System.Drawing.Size(50, 20);
            this.Pres_T70.TabIndex = 60;
            this.Pres_T70.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Temp_T70
            // 
            this.Temp_T70.Location = new System.Drawing.Point(232, 153);
            this.Temp_T70.Name = "Temp_T70";
            this.Temp_T70.Size = new System.Drawing.Size(50, 20);
            this.Temp_T70.TabIndex = 59;
            this.Temp_T70.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Pulso_Tot_T70
            // 
            this.Pulso_Tot_T70.Location = new System.Drawing.Point(232, 125);
            this.Pulso_Tot_T70.Name = "Pulso_Tot_T70";
            this.Pulso_Tot_T70.Size = new System.Drawing.Size(50, 20);
            this.Pulso_Tot_T70.TabIndex = 58;
            this.Pulso_Tot_T70.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Vol_Tot_T70
            // 
            this.Vol_Tot_T70.Location = new System.Drawing.Point(232, 99);
            this.Vol_Tot_T70.Name = "Vol_Tot_T70";
            this.Vol_Tot_T70.Size = new System.Drawing.Size(50, 20);
            this.Vol_Tot_T70.TabIndex = 57;
            this.Vol_Tot_T70.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Pulso_Min_T70
            // 
            this.Pulso_Min_T70.Location = new System.Drawing.Point(232, 73);
            this.Pulso_Min_T70.Name = "Pulso_Min_T70";
            this.Pulso_Min_T70.Size = new System.Drawing.Size(50, 20);
            this.Pulso_Min_T70.TabIndex = 56;
            this.Pulso_Min_T70.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Vazao_T50
            // 
            this.Vazao_T50.Location = new System.Drawing.Point(176, 205);
            this.Vazao_T50.Name = "Vazao_T50";
            this.Vazao_T50.Size = new System.Drawing.Size(50, 20);
            this.Vazao_T50.TabIndex = 55;
            this.Vazao_T50.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Pres_T50
            // 
            this.Pres_T50.Location = new System.Drawing.Point(176, 179);
            this.Pres_T50.Name = "Pres_T50";
            this.Pres_T50.Size = new System.Drawing.Size(50, 20);
            this.Pres_T50.TabIndex = 54;
            this.Pres_T50.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Temp_T50
            // 
            this.Temp_T50.Location = new System.Drawing.Point(176, 153);
            this.Temp_T50.Name = "Temp_T50";
            this.Temp_T50.Size = new System.Drawing.Size(50, 20);
            this.Temp_T50.TabIndex = 53;
            this.Temp_T50.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Pulso_Tot_T50
            // 
            this.Pulso_Tot_T50.Location = new System.Drawing.Point(176, 125);
            this.Pulso_Tot_T50.Name = "Pulso_Tot_T50";
            this.Pulso_Tot_T50.Size = new System.Drawing.Size(50, 20);
            this.Pulso_Tot_T50.TabIndex = 52;
            this.Pulso_Tot_T50.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Vol_Tot_T50
            // 
            this.Vol_Tot_T50.Location = new System.Drawing.Point(176, 99);
            this.Vol_Tot_T50.Name = "Vol_Tot_T50";
            this.Vol_Tot_T50.Size = new System.Drawing.Size(50, 20);
            this.Vol_Tot_T50.TabIndex = 51;
            this.Vol_Tot_T50.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Pulso_Min_T50
            // 
            this.Pulso_Min_T50.Location = new System.Drawing.Point(176, 73);
            this.Pulso_Min_T50.Name = "Pulso_Min_T50";
            this.Pulso_Min_T50.Size = new System.Drawing.Size(50, 20);
            this.Pulso_Min_T50.TabIndex = 50;
            this.Pulso_Min_T50.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Vazao_T30
            // 
            this.Vazao_T30.Location = new System.Drawing.Point(120, 205);
            this.Vazao_T30.Name = "Vazao_T30";
            this.Vazao_T30.Size = new System.Drawing.Size(50, 20);
            this.Vazao_T30.TabIndex = 49;
            this.Vazao_T30.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Pres_T30
            // 
            this.Pres_T30.Location = new System.Drawing.Point(120, 179);
            this.Pres_T30.Name = "Pres_T30";
            this.Pres_T30.Size = new System.Drawing.Size(50, 20);
            this.Pres_T30.TabIndex = 48;
            this.Pres_T30.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Temp_T30
            // 
            this.Temp_T30.Location = new System.Drawing.Point(120, 153);
            this.Temp_T30.Name = "Temp_T30";
            this.Temp_T30.Size = new System.Drawing.Size(50, 20);
            this.Temp_T30.TabIndex = 47;
            this.Temp_T30.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Pulso_Tot_T30
            // 
            this.Pulso_Tot_T30.Location = new System.Drawing.Point(120, 125);
            this.Pulso_Tot_T30.Name = "Pulso_Tot_T30";
            this.Pulso_Tot_T30.Size = new System.Drawing.Size(50, 20);
            this.Pulso_Tot_T30.TabIndex = 46;
            this.Pulso_Tot_T30.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Vol_Tot_T30
            // 
            this.Vol_Tot_T30.Location = new System.Drawing.Point(120, 99);
            this.Vol_Tot_T30.Name = "Vol_Tot_T30";
            this.Vol_Tot_T30.Size = new System.Drawing.Size(50, 20);
            this.Vol_Tot_T30.TabIndex = 45;
            this.Vol_Tot_T30.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Pulso_Min_T30
            // 
            this.Pulso_Min_T30.Location = new System.Drawing.Point(120, 73);
            this.Pulso_Min_T30.Name = "Pulso_Min_T30";
            this.Pulso_Min_T30.Size = new System.Drawing.Size(50, 20);
            this.Pulso_Min_T30.TabIndex = 44;
            this.Pulso_Min_T30.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Vazao_T20
            // 
            this.Vazao_T20.Location = new System.Drawing.Point(64, 205);
            this.Vazao_T20.Name = "Vazao_T20";
            this.Vazao_T20.Size = new System.Drawing.Size(50, 20);
            this.Vazao_T20.TabIndex = 43;
            this.Vazao_T20.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Pres_T20
            // 
            this.Pres_T20.Location = new System.Drawing.Point(64, 179);
            this.Pres_T20.Name = "Pres_T20";
            this.Pres_T20.Size = new System.Drawing.Size(50, 20);
            this.Pres_T20.TabIndex = 42;
            this.Pres_T20.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Temp_T20
            // 
            this.Temp_T20.Location = new System.Drawing.Point(64, 153);
            this.Temp_T20.Name = "Temp_T20";
            this.Temp_T20.Size = new System.Drawing.Size(50, 20);
            this.Temp_T20.TabIndex = 41;
            this.Temp_T20.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Pulso_Tot_T20
            // 
            this.Pulso_Tot_T20.Location = new System.Drawing.Point(64, 125);
            this.Pulso_Tot_T20.Name = "Pulso_Tot_T20";
            this.Pulso_Tot_T20.Size = new System.Drawing.Size(50, 20);
            this.Pulso_Tot_T20.TabIndex = 40;
            this.Pulso_Tot_T20.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Vol_Tot_T20
            // 
            this.Vol_Tot_T20.Location = new System.Drawing.Point(64, 99);
            this.Vol_Tot_T20.Name = "Vol_Tot_T20";
            this.Vol_Tot_T20.Size = new System.Drawing.Size(50, 20);
            this.Vol_Tot_T20.TabIndex = 39;
            this.Vol_Tot_T20.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Pulso_Min_T20
            // 
            this.Pulso_Min_T20.Location = new System.Drawing.Point(64, 73);
            this.Pulso_Min_T20.Name = "Pulso_Min_T20";
            this.Pulso_Min_T20.Size = new System.Drawing.Size(50, 20);
            this.Pulso_Min_T20.TabIndex = 38;
            this.Pulso_Min_T20.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label11.Location = new System.Drawing.Point(288, 20);
            this.label11.MinimumSize = new System.Drawing.Size(50, 2);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(50, 15);
            this.label11.TabIndex = 37;
            this.label11.Text = "100%";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Fator_T100
            // 
            this.Fator_T100.Location = new System.Drawing.Point(288, 47);
            this.Fator_T100.Name = "Fator_T100";
            this.Fator_T100.Size = new System.Drawing.Size(50, 20);
            this.Fator_T100.TabIndex = 36;
            this.Fator_T100.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label12.Location = new System.Drawing.Point(232, 20);
            this.label12.MinimumSize = new System.Drawing.Size(50, 2);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(50, 15);
            this.label12.TabIndex = 35;
            this.label12.Text = "70%";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label13.Location = new System.Drawing.Point(176, 20);
            this.label13.MinimumSize = new System.Drawing.Size(50, 2);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(50, 15);
            this.label13.TabIndex = 34;
            this.label13.Text = "50%";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label14.Location = new System.Drawing.Point(120, 20);
            this.label14.MinimumSize = new System.Drawing.Size(50, 2);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(50, 15);
            this.label14.TabIndex = 33;
            this.label14.Text = "30%";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label18.Location = new System.Drawing.Point(64, 20);
            this.label18.MinimumSize = new System.Drawing.Size(50, 2);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(50, 15);
            this.label18.TabIndex = 32;
            this.label18.Text = "20%";
            this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Fator_T70
            // 
            this.Fator_T70.Location = new System.Drawing.Point(232, 47);
            this.Fator_T70.Name = "Fator_T70";
            this.Fator_T70.Size = new System.Drawing.Size(50, 20);
            this.Fator_T70.TabIndex = 31;
            this.Fator_T70.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Fator_T50
            // 
            this.Fator_T50.Location = new System.Drawing.Point(176, 47);
            this.Fator_T50.Name = "Fator_T50";
            this.Fator_T50.Size = new System.Drawing.Size(50, 20);
            this.Fator_T50.TabIndex = 30;
            this.Fator_T50.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Fator_T30
            // 
            this.Fator_T30.Location = new System.Drawing.Point(120, 47);
            this.Fator_T30.Name = "Fator_T30";
            this.Fator_T30.Size = new System.Drawing.Size(50, 20);
            this.Fator_T30.TabIndex = 29;
            this.Fator_T30.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Fator_T20
            // 
            this.Fator_T20.Location = new System.Drawing.Point(64, 47);
            this.Fator_T20.Name = "Fator_T20";
            this.Fator_T20.Size = new System.Drawing.Size(50, 20);
            this.Fator_T20.TabIndex = 28;
            this.Fator_T20.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Vazao_T10
            // 
            this.Vazao_T10.Location = new System.Drawing.Point(8, 205);
            this.Vazao_T10.Name = "Vazao_T10";
            this.Vazao_T10.Size = new System.Drawing.Size(50, 20);
            this.Vazao_T10.TabIndex = 27;
            this.Vazao_T10.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Pres_T10
            // 
            this.Pres_T10.Location = new System.Drawing.Point(8, 179);
            this.Pres_T10.Name = "Pres_T10";
            this.Pres_T10.Size = new System.Drawing.Size(50, 20);
            this.Pres_T10.TabIndex = 26;
            this.Pres_T10.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Temp_T10
            // 
            this.Temp_T10.Location = new System.Drawing.Point(8, 153);
            this.Temp_T10.Name = "Temp_T10";
            this.Temp_T10.Size = new System.Drawing.Size(50, 20);
            this.Temp_T10.TabIndex = 25;
            this.Temp_T10.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Pulso_Tot_T10
            // 
            this.Pulso_Tot_T10.Location = new System.Drawing.Point(8, 125);
            this.Pulso_Tot_T10.Name = "Pulso_Tot_T10";
            this.Pulso_Tot_T10.Size = new System.Drawing.Size(50, 20);
            this.Pulso_Tot_T10.TabIndex = 21;
            this.Pulso_Tot_T10.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Vol_Tot_T10
            // 
            this.Vol_Tot_T10.Location = new System.Drawing.Point(8, 99);
            this.Vol_Tot_T10.Name = "Vol_Tot_T10";
            this.Vol_Tot_T10.Size = new System.Drawing.Size(50, 20);
            this.Vol_Tot_T10.TabIndex = 19;
            this.Vol_Tot_T10.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Pulso_Min_T10
            // 
            this.Pulso_Min_T10.Location = new System.Drawing.Point(8, 73);
            this.Pulso_Min_T10.Name = "Pulso_Min_T10";
            this.Pulso_Min_T10.Size = new System.Drawing.Size(50, 20);
            this.Pulso_Min_T10.TabIndex = 17;
            this.Pulso_Min_T10.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Fator_T10
            // 
            this.Fator_T10.Location = new System.Drawing.Point(8, 47);
            this.Fator_T10.Name = "Fator_T10";
            this.Fator_T10.Size = new System.Drawing.Size(50, 20);
            this.Fator_T10.TabIndex = 14;
            this.Fator_T10.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label19.Location = new System.Drawing.Point(8, 20);
            this.label19.MinimumSize = new System.Drawing.Size(50, 2);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(50, 15);
            this.label19.TabIndex = 0;
            this.label19.Text = "10%";
            this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.ErrorR);
            this.groupBox5.Controls.Add(this.label3);
            this.groupBox5.Controls.Add(this.label1);
            this.groupBox5.Controls.Add(this.faixaM);
            this.groupBox5.Controls.Add(this.Restante);
            this.groupBox5.Controls.Add(this.Vazao_T);
            this.groupBox5.Controls.Add(this.label27);
            this.groupBox5.Controls.Add(this.label26);
            this.groupBox5.Controls.Add(this.Pres_T);
            this.groupBox5.Controls.Add(this.Temp_T);
            this.groupBox5.Controls.Add(this.Pulso_Tot_T);
            this.groupBox5.Controls.Add(this.Vol_Tot_T);
            this.groupBox5.Controls.Add(this.Pulso_Min_T);
            this.groupBox5.Controls.Add(this.Fator_T);
            this.groupBox5.Controls.Add(this.btnTransfer);
            this.groupBox5.Controls.Add(this.btnStop);
            this.groupBox5.Controls.Add(this.btnStart);
            this.groupBox5.Controls.Add(this.Percentual);
            this.groupBox5.Controls.Add(this.Vazao_M);
            this.groupBox5.Controls.Add(this.Pres_M);
            this.groupBox5.Controls.Add(this.Temp_M);
            this.groupBox5.Controls.Add(this.label7);
            this.groupBox5.Controls.Add(this.label8);
            this.groupBox5.Controls.Add(this.label15);
            this.groupBox5.Controls.Add(this.Pulso_Tot_M);
            this.groupBox5.Controls.Add(this.label9);
            this.groupBox5.Controls.Add(this.Vol_Tot_M);
            this.groupBox5.Controls.Add(this.label10);
            this.groupBox5.Controls.Add(this.Pulso_Min_M);
            this.groupBox5.Controls.Add(this.label16);
            this.groupBox5.Controls.Add(this.label17);
            this.groupBox5.Controls.Add(this.Fator_M);
            this.groupBox5.Location = new System.Drawing.Point(3, 18);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(242, 324);
            this.groupBox5.TabIndex = 10;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Itens";
            // 
            // ErrorR
            // 
            this.ErrorR.Location = new System.Drawing.Point(187, 296);
            this.ErrorR.Name = "ErrorR";
            this.ErrorR.Size = new System.Drawing.Size(49, 20);
            this.ErrorR.TabIndex = 83;
            this.ErrorR.TextChanged += new System.EventHandler(this.ErrorR_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(184, 283);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 82;
            this.label3.Text = "Erro r%";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 305);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 29;
            this.label1.Text = "Faixa a ser medida";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // faixaM
            // 
            this.faixaM.FormattingEnabled = true;
            this.faixaM.Items.AddRange(new object[] {
            "1:10",
            "1:20",
            "1:30",
            "1:50"});
            this.faixaM.Location = new System.Drawing.Point(111, 296);
            this.faixaM.Name = "faixaM";
            this.faixaM.Size = new System.Drawing.Size(50, 21);
            this.faixaM.TabIndex = 28;
            this.faixaM.SelectedIndexChanged += new System.EventHandler(this.faixaM_SelectedIndexChanged);
            // 
            // Restante
            // 
            this.Restante.Location = new System.Drawing.Point(161, 259);
            this.Restante.Name = "Restante";
            this.Restante.Size = new System.Drawing.Size(75, 20);
            this.Restante.TabIndex = 27;
            // 
            // Vazao_T
            // 
            this.Vazao_T.Location = new System.Drawing.Point(170, 205);
            this.Vazao_T.Name = "Vazao_T";
            this.Vazao_T.Size = new System.Drawing.Size(50, 20);
            this.Vazao_T.TabIndex = 26;
            this.Vazao_T.Text = "0";
            this.Vazao_T.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(175, 26);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(34, 13);
            this.label27.TabIndex = 25;
            this.label27.Text = "Teste";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(115, 26);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(39, 13);
            this.label26.TabIndex = 24;
            this.label26.Text = "Master";
            // 
            // Pres_T
            // 
            this.Pres_T.Location = new System.Drawing.Point(170, 179);
            this.Pres_T.Name = "Pres_T";
            this.Pres_T.Size = new System.Drawing.Size(50, 20);
            this.Pres_T.TabIndex = 23;
            this.Pres_T.Text = "0";
            this.Pres_T.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Temp_T
            // 
            this.Temp_T.Location = new System.Drawing.Point(170, 153);
            this.Temp_T.Name = "Temp_T";
            this.Temp_T.Size = new System.Drawing.Size(50, 20);
            this.Temp_T.TabIndex = 22;
            this.Temp_T.Text = "0";
            this.Temp_T.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Pulso_Tot_T
            // 
            this.Pulso_Tot_T.Location = new System.Drawing.Point(170, 125);
            this.Pulso_Tot_T.Name = "Pulso_Tot_T";
            this.Pulso_Tot_T.Size = new System.Drawing.Size(50, 20);
            this.Pulso_Tot_T.TabIndex = 21;
            this.Pulso_Tot_T.Text = "0";
            this.Pulso_Tot_T.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Vol_Tot_T
            // 
            this.Vol_Tot_T.Location = new System.Drawing.Point(170, 99);
            this.Vol_Tot_T.Name = "Vol_Tot_T";
            this.Vol_Tot_T.Size = new System.Drawing.Size(50, 20);
            this.Vol_Tot_T.TabIndex = 20;
            this.Vol_Tot_T.Text = "0";
            this.Vol_Tot_T.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Vol_Tot_T.TextChanged += new System.EventHandler(this.Vol_Tot_T_TextChanged);
            // 
            // Pulso_Min_T
            // 
            this.Pulso_Min_T.Location = new System.Drawing.Point(170, 73);
            this.Pulso_Min_T.Name = "Pulso_Min_T";
            this.Pulso_Min_T.Size = new System.Drawing.Size(50, 20);
            this.Pulso_Min_T.TabIndex = 19;
            this.Pulso_Min_T.Text = "0";
            this.Pulso_Min_T.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Fator_T
            // 
            this.Fator_T.Location = new System.Drawing.Point(170, 47);
            this.Fator_T.Name = "Fator_T";
            this.Fator_T.Size = new System.Drawing.Size(50, 20);
            this.Fator_T.TabIndex = 18;
            this.Fator_T.Text = "1";
            this.Fator_T.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Fator_T.Validating += new System.ComponentModel.CancelEventHandler(this.Fator_T_Validating);
            // 
            // btnTransfer
            // 
            this.btnTransfer.Location = new System.Drawing.Point(15, 232);
            this.btnTransfer.Name = "btnTransfer";
            this.btnTransfer.Size = new System.Drawing.Size(88, 20);
            this.btnTransfer.TabIndex = 17;
            this.btnTransfer.Text = "Transferir";
            this.btnTransfer.UseVisualStyleBackColor = true;
            this.btnTransfer.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(84, 259);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(52, 20);
            this.btnStop.TabIndex = 16;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(15, 259);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(54, 20);
            this.btnStart.TabIndex = 15;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Percentual
            // 
            this.Percentual.FormattingEnabled = true;
            this.Percentual.Items.AddRange(new object[] {
            ""});
            this.Percentual.Location = new System.Drawing.Point(111, 231);
            this.Percentual.Name = "Percentual";
            this.Percentual.Size = new System.Drawing.Size(50, 21);
            this.Percentual.TabIndex = 14;
            this.Percentual.SelectedIndexChanged += new System.EventHandler(this.Percentual_SelectedIndexChanged);
            // 
            // Vazao_M
            // 
            this.Vazao_M.Location = new System.Drawing.Point(111, 205);
            this.Vazao_M.Name = "Vazao_M";
            this.Vazao_M.Size = new System.Drawing.Size(50, 20);
            this.Vazao_M.TabIndex = 13;
            this.Vazao_M.Text = "0";
            this.Vazao_M.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Pres_M
            // 
            this.Pres_M.Location = new System.Drawing.Point(111, 179);
            this.Pres_M.Name = "Pres_M";
            this.Pres_M.Size = new System.Drawing.Size(50, 20);
            this.Pres_M.TabIndex = 12;
            this.Pres_M.Text = "0";
            this.Pres_M.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Temp_M
            // 
            this.Temp_M.Location = new System.Drawing.Point(111, 153);
            this.Temp_M.Name = "Temp_M";
            this.Temp_M.Size = new System.Drawing.Size(50, 20);
            this.Temp_M.TabIndex = 11;
            this.Temp_M.Text = "0";
            this.Temp_M.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 125);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Pulsos Totalizados";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 99);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(94, 13);
            this.label8.TabIndex = 9;
            this.label8.Text = "Volume Totalizado";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(12, 73);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(91, 13);
            this.label15.TabIndex = 8;
            this.label15.Text = "Pulsos por Minuto";
            // 
            // Pulso_Tot_M
            // 
            this.Pulso_Tot_M.Location = new System.Drawing.Point(111, 125);
            this.Pulso_Tot_M.Name = "Pulso_Tot_M";
            this.Pulso_Tot_M.Size = new System.Drawing.Size(50, 20);
            this.Pulso_Tot_M.TabIndex = 7;
            this.Pulso_Tot_M.Text = "0";
            this.Pulso_Tot_M.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(10, 205);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 13);
            this.label9.TabIndex = 6;
            this.label9.Text = "Vazão m3/h";
            // 
            // Vol_Tot_M
            // 
            this.Vol_Tot_M.Location = new System.Drawing.Point(111, 99);
            this.Vol_Tot_M.Name = "Vol_Tot_M";
            this.Vol_Tot_M.Size = new System.Drawing.Size(50, 20);
            this.Vol_Tot_M.TabIndex = 5;
            this.Vol_Tot_M.Text = "0";
            this.Vol_Tot_M.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Vol_Tot_M.TextChanged += new System.EventHandler(this.Vol_Tot_M_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(10, 179);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(45, 13);
            this.label10.TabIndex = 4;
            this.label10.Text = "Pressão";
            // 
            // Pulso_Min_M
            // 
            this.Pulso_Min_M.Location = new System.Drawing.Point(111, 73);
            this.Pulso_Min_M.Name = "Pulso_Min_M";
            this.Pulso_Min_M.Size = new System.Drawing.Size(50, 20);
            this.Pulso_Min_M.TabIndex = 3;
            this.Pulso_Min_M.Text = "0";
            this.Pulso_Min_M.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(10, 153);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(67, 13);
            this.label16.TabIndex = 2;
            this.label16.Text = "Temperatura";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(12, 46);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(41, 13);
            this.label17.TabIndex = 1;
            this.label17.Text = "Fator K";
            // 
            // Fator_M
            // 
            this.Fator_M.Location = new System.Drawing.Point(111, 47);
            this.Fator_M.Name = "Fator_M";
            this.Fator_M.Size = new System.Drawing.Size(50, 20);
            this.Fator_M.TabIndex = 0;
            this.Fator_M.Text = "1";
            this.Fator_M.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Fator_M.TextChanged += new System.EventHandler(this.Fator_M_TextChanged);
            this.Fator_M.Validating += new System.ComponentModel.CancelEventHandler(this.Fator_M_Validating);
            // 
            // GroupMaster
            // 
            this.GroupMaster.Controls.Add(this.label38);
            this.GroupMaster.Controls.Add(this.label37);
            this.GroupMaster.Controls.Add(this.label36);
            this.GroupMaster.Controls.Add(this.label35);
            this.GroupMaster.Controls.Add(this.label34);
            this.GroupMaster.Controls.Add(this.label33);
            this.GroupMaster.Controls.Add(this.Erro_100);
            this.GroupMaster.Controls.Add(this.Erro_70);
            this.GroupMaster.Controls.Add(this.Erro_50);
            this.GroupMaster.Controls.Add(this.Erro_30);
            this.GroupMaster.Controls.Add(this.Erro_20);
            this.GroupMaster.Controls.Add(this.Erro_10);
            this.GroupMaster.Controls.Add(this.Vazao_M100);
            this.GroupMaster.Controls.Add(this.Pres_M100);
            this.GroupMaster.Controls.Add(this.Fator_M10);
            this.GroupMaster.Controls.Add(this.Temp_M100);
            this.GroupMaster.Controls.Add(this.Pulso_Tot_M100);
            this.GroupMaster.Controls.Add(this.Vol_Tot_M100);
            this.GroupMaster.Controls.Add(this.Pulso_Min_M100);
            this.GroupMaster.Controls.Add(this.Vazao_M70);
            this.GroupMaster.Controls.Add(this.Pres_M70);
            this.GroupMaster.Controls.Add(this.Temp_M70);
            this.GroupMaster.Controls.Add(this.Pulso_Tot_M70);
            this.GroupMaster.Controls.Add(this.Vol_Tot_M70);
            this.GroupMaster.Controls.Add(this.Pulso_Min_M70);
            this.GroupMaster.Controls.Add(this.Vazao_M50);
            this.GroupMaster.Controls.Add(this.Pres_M50);
            this.GroupMaster.Controls.Add(this.Temp_M50);
            this.GroupMaster.Controls.Add(this.Pulso_Tot_M50);
            this.GroupMaster.Controls.Add(this.Vol_Tot_M50);
            this.GroupMaster.Controls.Add(this.Pulso_Min_M50);
            this.GroupMaster.Controls.Add(this.Vazao_M30);
            this.GroupMaster.Controls.Add(this.Pres_M30);
            this.GroupMaster.Controls.Add(this.Temp_M30);
            this.GroupMaster.Controls.Add(this.Pulso_Tot_M30);
            this.GroupMaster.Controls.Add(this.Vol_Tot_M30);
            this.GroupMaster.Controls.Add(this.Pulso_Min_M30);
            this.GroupMaster.Controls.Add(this.Vazao_M20);
            this.GroupMaster.Controls.Add(this.Pres_M20);
            this.GroupMaster.Controls.Add(this.Temp_M20);
            this.GroupMaster.Controls.Add(this.Pulso_Tot_M20);
            this.GroupMaster.Controls.Add(this.Vol_Tot_M20);
            this.GroupMaster.Controls.Add(this.Pulso_Min_M20);
            this.GroupMaster.Controls.Add(this.label20);
            this.GroupMaster.Controls.Add(this.Fator_M100);
            this.GroupMaster.Controls.Add(this.label21);
            this.GroupMaster.Controls.Add(this.label22);
            this.GroupMaster.Controls.Add(this.label23);
            this.GroupMaster.Controls.Add(this.label24);
            this.GroupMaster.Controls.Add(this.Fator_M70);
            this.GroupMaster.Controls.Add(this.Fator_M50);
            this.GroupMaster.Controls.Add(this.Fator_M30);
            this.GroupMaster.Controls.Add(this.Fator_M20);
            this.GroupMaster.Controls.Add(this.Vazao_M10);
            this.GroupMaster.Controls.Add(this.Pres_M10);
            this.GroupMaster.Controls.Add(this.Temp_M10);
            this.GroupMaster.Controls.Add(this.Pulso_Tot_M10);
            this.GroupMaster.Controls.Add(this.Vol_Tot_M10);
            this.GroupMaster.Controls.Add(this.Pulso_Min_M10);
            this.GroupMaster.Controls.Add(this.label25);
            this.GroupMaster.Location = new System.Drawing.Point(251, 18);
            this.GroupMaster.Name = "GroupMaster";
            this.GroupMaster.Size = new System.Drawing.Size(348, 276);
            this.GroupMaster.TabIndex = 9;
            this.GroupMaster.TabStop = false;
            this.GroupMaster.Text = "Turbina Master";
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label38.Location = new System.Drawing.Point(288, 234);
            this.label38.MinimumSize = new System.Drawing.Size(50, 2);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(50, 15);
            this.label38.TabIndex = 101;
            this.label38.Text = "10%";
            this.label38.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label37.Location = new System.Drawing.Point(232, 234);
            this.label37.MinimumSize = new System.Drawing.Size(50, 2);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(50, 15);
            this.label37.TabIndex = 100;
            this.label37.Text = "10%";
            this.label37.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label36.Location = new System.Drawing.Point(176, 234);
            this.label36.MinimumSize = new System.Drawing.Size(50, 2);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(50, 15);
            this.label36.TabIndex = 99;
            this.label36.Text = "10%";
            this.label36.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label35.Location = new System.Drawing.Point(120, 234);
            this.label35.MinimumSize = new System.Drawing.Size(50, 2);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(50, 15);
            this.label35.TabIndex = 98;
            this.label35.Text = "10%";
            this.label35.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label34.Location = new System.Drawing.Point(64, 234);
            this.label34.MinimumSize = new System.Drawing.Size(50, 2);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(50, 15);
            this.label34.TabIndex = 97;
            this.label34.Text = "10%";
            this.label34.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label33.Location = new System.Drawing.Point(8, 234);
            this.label33.MinimumSize = new System.Drawing.Size(50, 2);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(50, 15);
            this.label33.TabIndex = 96;
            this.label33.Text = "10%";
            this.label33.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Erro_100
            // 
            this.Erro_100.Location = new System.Drawing.Point(288, 249);
            this.Erro_100.Name = "Erro_100";
            this.Erro_100.Size = new System.Drawing.Size(50, 20);
            this.Erro_100.TabIndex = 95;
            // 
            // Erro_70
            // 
            this.Erro_70.Location = new System.Drawing.Point(232, 249);
            this.Erro_70.Name = "Erro_70";
            this.Erro_70.Size = new System.Drawing.Size(50, 20);
            this.Erro_70.TabIndex = 93;
            this.Erro_70.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Erro_50
            // 
            this.Erro_50.Location = new System.Drawing.Point(176, 249);
            this.Erro_50.Name = "Erro_50";
            this.Erro_50.Size = new System.Drawing.Size(50, 20);
            this.Erro_50.TabIndex = 91;
            this.Erro_50.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Erro_30
            // 
            this.Erro_30.Location = new System.Drawing.Point(120, 249);
            this.Erro_30.Name = "Erro_30";
            this.Erro_30.Size = new System.Drawing.Size(50, 20);
            this.Erro_30.TabIndex = 89;
            this.Erro_30.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Erro_20
            // 
            this.Erro_20.Location = new System.Drawing.Point(64, 249);
            this.Erro_20.Name = "Erro_20";
            this.Erro_20.Size = new System.Drawing.Size(50, 20);
            this.Erro_20.TabIndex = 87;
            this.Erro_20.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Erro_10
            // 
            this.Erro_10.Location = new System.Drawing.Point(8, 249);
            this.Erro_10.Name = "Erro_10";
            this.Erro_10.Size = new System.Drawing.Size(50, 20);
            this.Erro_10.TabIndex = 85;
            this.Erro_10.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Vazao_M100
            // 
            this.Vazao_M100.Location = new System.Drawing.Point(288, 205);
            this.Vazao_M100.Name = "Vazao_M100";
            this.Vazao_M100.Size = new System.Drawing.Size(50, 20);
            this.Vazao_M100.TabIndex = 67;
            this.Vazao_M100.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Pres_M100
            // 
            this.Pres_M100.Location = new System.Drawing.Point(288, 179);
            this.Pres_M100.Name = "Pres_M100";
            this.Pres_M100.Size = new System.Drawing.Size(50, 20);
            this.Pres_M100.TabIndex = 66;
            this.Pres_M100.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Fator_M10
            // 
            this.Fator_M10.Location = new System.Drawing.Point(8, 46);
            this.Fator_M10.Name = "Fator_M10";
            this.Fator_M10.Size = new System.Drawing.Size(50, 20);
            this.Fator_M10.TabIndex = 14;
            this.Fator_M10.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Temp_M100
            // 
            this.Temp_M100.Location = new System.Drawing.Point(288, 153);
            this.Temp_M100.Name = "Temp_M100";
            this.Temp_M100.Size = new System.Drawing.Size(50, 20);
            this.Temp_M100.TabIndex = 65;
            this.Temp_M100.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Pulso_Tot_M100
            // 
            this.Pulso_Tot_M100.Location = new System.Drawing.Point(288, 125);
            this.Pulso_Tot_M100.Name = "Pulso_Tot_M100";
            this.Pulso_Tot_M100.Size = new System.Drawing.Size(50, 20);
            this.Pulso_Tot_M100.TabIndex = 64;
            this.Pulso_Tot_M100.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Vol_Tot_M100
            // 
            this.Vol_Tot_M100.Location = new System.Drawing.Point(288, 99);
            this.Vol_Tot_M100.Name = "Vol_Tot_M100";
            this.Vol_Tot_M100.Size = new System.Drawing.Size(50, 20);
            this.Vol_Tot_M100.TabIndex = 63;
            this.Vol_Tot_M100.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Pulso_Min_M100
            // 
            this.Pulso_Min_M100.Location = new System.Drawing.Point(288, 73);
            this.Pulso_Min_M100.Name = "Pulso_Min_M100";
            this.Pulso_Min_M100.Size = new System.Drawing.Size(50, 20);
            this.Pulso_Min_M100.TabIndex = 62;
            this.Pulso_Min_M100.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Vazao_M70
            // 
            this.Vazao_M70.Location = new System.Drawing.Point(232, 205);
            this.Vazao_M70.Name = "Vazao_M70";
            this.Vazao_M70.Size = new System.Drawing.Size(50, 20);
            this.Vazao_M70.TabIndex = 61;
            this.Vazao_M70.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Pres_M70
            // 
            this.Pres_M70.Location = new System.Drawing.Point(232, 179);
            this.Pres_M70.Name = "Pres_M70";
            this.Pres_M70.Size = new System.Drawing.Size(50, 20);
            this.Pres_M70.TabIndex = 60;
            this.Pres_M70.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Temp_M70
            // 
            this.Temp_M70.Location = new System.Drawing.Point(232, 153);
            this.Temp_M70.Name = "Temp_M70";
            this.Temp_M70.Size = new System.Drawing.Size(50, 20);
            this.Temp_M70.TabIndex = 59;
            this.Temp_M70.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Pulso_Tot_M70
            // 
            this.Pulso_Tot_M70.Location = new System.Drawing.Point(232, 125);
            this.Pulso_Tot_M70.Name = "Pulso_Tot_M70";
            this.Pulso_Tot_M70.Size = new System.Drawing.Size(50, 20);
            this.Pulso_Tot_M70.TabIndex = 58;
            this.Pulso_Tot_M70.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Vol_Tot_M70
            // 
            this.Vol_Tot_M70.Location = new System.Drawing.Point(232, 99);
            this.Vol_Tot_M70.Name = "Vol_Tot_M70";
            this.Vol_Tot_M70.Size = new System.Drawing.Size(50, 20);
            this.Vol_Tot_M70.TabIndex = 57;
            this.Vol_Tot_M70.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Pulso_Min_M70
            // 
            this.Pulso_Min_M70.Location = new System.Drawing.Point(232, 73);
            this.Pulso_Min_M70.Name = "Pulso_Min_M70";
            this.Pulso_Min_M70.Size = new System.Drawing.Size(50, 20);
            this.Pulso_Min_M70.TabIndex = 56;
            this.Pulso_Min_M70.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Vazao_M50
            // 
            this.Vazao_M50.Location = new System.Drawing.Point(176, 205);
            this.Vazao_M50.Name = "Vazao_M50";
            this.Vazao_M50.Size = new System.Drawing.Size(50, 20);
            this.Vazao_M50.TabIndex = 55;
            this.Vazao_M50.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Pres_M50
            // 
            this.Pres_M50.Location = new System.Drawing.Point(176, 179);
            this.Pres_M50.Name = "Pres_M50";
            this.Pres_M50.Size = new System.Drawing.Size(50, 20);
            this.Pres_M50.TabIndex = 54;
            this.Pres_M50.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Temp_M50
            // 
            this.Temp_M50.Location = new System.Drawing.Point(176, 153);
            this.Temp_M50.Name = "Temp_M50";
            this.Temp_M50.Size = new System.Drawing.Size(50, 20);
            this.Temp_M50.TabIndex = 53;
            this.Temp_M50.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Pulso_Tot_M50
            // 
            this.Pulso_Tot_M50.Location = new System.Drawing.Point(176, 125);
            this.Pulso_Tot_M50.Name = "Pulso_Tot_M50";
            this.Pulso_Tot_M50.Size = new System.Drawing.Size(50, 20);
            this.Pulso_Tot_M50.TabIndex = 52;
            this.Pulso_Tot_M50.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Vol_Tot_M50
            // 
            this.Vol_Tot_M50.Location = new System.Drawing.Point(176, 99);
            this.Vol_Tot_M50.Name = "Vol_Tot_M50";
            this.Vol_Tot_M50.Size = new System.Drawing.Size(50, 20);
            this.Vol_Tot_M50.TabIndex = 51;
            this.Vol_Tot_M50.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Pulso_Min_M50
            // 
            this.Pulso_Min_M50.Location = new System.Drawing.Point(176, 73);
            this.Pulso_Min_M50.Name = "Pulso_Min_M50";
            this.Pulso_Min_M50.Size = new System.Drawing.Size(50, 20);
            this.Pulso_Min_M50.TabIndex = 50;
            this.Pulso_Min_M50.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Vazao_M30
            // 
            this.Vazao_M30.Location = new System.Drawing.Point(120, 205);
            this.Vazao_M30.Name = "Vazao_M30";
            this.Vazao_M30.Size = new System.Drawing.Size(50, 20);
            this.Vazao_M30.TabIndex = 49;
            this.Vazao_M30.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Pres_M30
            // 
            this.Pres_M30.Location = new System.Drawing.Point(120, 179);
            this.Pres_M30.Name = "Pres_M30";
            this.Pres_M30.Size = new System.Drawing.Size(50, 20);
            this.Pres_M30.TabIndex = 48;
            this.Pres_M30.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Temp_M30
            // 
            this.Temp_M30.Location = new System.Drawing.Point(120, 153);
            this.Temp_M30.Name = "Temp_M30";
            this.Temp_M30.Size = new System.Drawing.Size(50, 20);
            this.Temp_M30.TabIndex = 47;
            this.Temp_M30.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Pulso_Tot_M30
            // 
            this.Pulso_Tot_M30.Location = new System.Drawing.Point(120, 125);
            this.Pulso_Tot_M30.Name = "Pulso_Tot_M30";
            this.Pulso_Tot_M30.Size = new System.Drawing.Size(50, 20);
            this.Pulso_Tot_M30.TabIndex = 46;
            this.Pulso_Tot_M30.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Vol_Tot_M30
            // 
            this.Vol_Tot_M30.Location = new System.Drawing.Point(120, 99);
            this.Vol_Tot_M30.Name = "Vol_Tot_M30";
            this.Vol_Tot_M30.Size = new System.Drawing.Size(50, 20);
            this.Vol_Tot_M30.TabIndex = 45;
            this.Vol_Tot_M30.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Pulso_Min_M30
            // 
            this.Pulso_Min_M30.Location = new System.Drawing.Point(120, 73);
            this.Pulso_Min_M30.Name = "Pulso_Min_M30";
            this.Pulso_Min_M30.Size = new System.Drawing.Size(50, 20);
            this.Pulso_Min_M30.TabIndex = 44;
            this.Pulso_Min_M30.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Vazao_M20
            // 
            this.Vazao_M20.Location = new System.Drawing.Point(64, 205);
            this.Vazao_M20.Name = "Vazao_M20";
            this.Vazao_M20.Size = new System.Drawing.Size(50, 20);
            this.Vazao_M20.TabIndex = 43;
            this.Vazao_M20.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Pres_M20
            // 
            this.Pres_M20.Location = new System.Drawing.Point(64, 179);
            this.Pres_M20.Name = "Pres_M20";
            this.Pres_M20.Size = new System.Drawing.Size(50, 20);
            this.Pres_M20.TabIndex = 42;
            this.Pres_M20.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Temp_M20
            // 
            this.Temp_M20.Location = new System.Drawing.Point(64, 153);
            this.Temp_M20.Name = "Temp_M20";
            this.Temp_M20.Size = new System.Drawing.Size(50, 20);
            this.Temp_M20.TabIndex = 41;
            this.Temp_M20.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Pulso_Tot_M20
            // 
            this.Pulso_Tot_M20.Location = new System.Drawing.Point(64, 125);
            this.Pulso_Tot_M20.Name = "Pulso_Tot_M20";
            this.Pulso_Tot_M20.Size = new System.Drawing.Size(50, 20);
            this.Pulso_Tot_M20.TabIndex = 40;
            this.Pulso_Tot_M20.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Vol_Tot_M20
            // 
            this.Vol_Tot_M20.Location = new System.Drawing.Point(64, 99);
            this.Vol_Tot_M20.Name = "Vol_Tot_M20";
            this.Vol_Tot_M20.Size = new System.Drawing.Size(50, 20);
            this.Vol_Tot_M20.TabIndex = 39;
            this.Vol_Tot_M20.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Pulso_Min_M20
            // 
            this.Pulso_Min_M20.Location = new System.Drawing.Point(64, 73);
            this.Pulso_Min_M20.Name = "Pulso_Min_M20";
            this.Pulso_Min_M20.Size = new System.Drawing.Size(50, 20);
            this.Pulso_Min_M20.TabIndex = 38;
            this.Pulso_Min_M20.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label20.Location = new System.Drawing.Point(288, 20);
            this.label20.MinimumSize = new System.Drawing.Size(50, 2);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(50, 15);
            this.label20.TabIndex = 37;
            this.label20.Text = "100%";
            this.label20.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Fator_M100
            // 
            this.Fator_M100.Location = new System.Drawing.Point(288, 47);
            this.Fator_M100.Name = "Fator_M100";
            this.Fator_M100.Size = new System.Drawing.Size(50, 20);
            this.Fator_M100.TabIndex = 36;
            this.Fator_M100.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label21.Location = new System.Drawing.Point(232, 20);
            this.label21.MinimumSize = new System.Drawing.Size(50, 2);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(50, 15);
            this.label21.TabIndex = 35;
            this.label21.Text = "70%";
            this.label21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label22.Location = new System.Drawing.Point(176, 20);
            this.label22.MinimumSize = new System.Drawing.Size(50, 2);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(50, 15);
            this.label22.TabIndex = 34;
            this.label22.Text = "50%";
            this.label22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label23.Location = new System.Drawing.Point(120, 20);
            this.label23.MinimumSize = new System.Drawing.Size(50, 2);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(50, 15);
            this.label23.TabIndex = 33;
            this.label23.Text = "30%";
            this.label23.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label24.Location = new System.Drawing.Point(64, 20);
            this.label24.MinimumSize = new System.Drawing.Size(50, 2);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(50, 15);
            this.label24.TabIndex = 32;
            this.label24.Text = "20%";
            this.label24.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Fator_M70
            // 
            this.Fator_M70.Location = new System.Drawing.Point(232, 47);
            this.Fator_M70.Name = "Fator_M70";
            this.Fator_M70.Size = new System.Drawing.Size(50, 20);
            this.Fator_M70.TabIndex = 31;
            this.Fator_M70.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Fator_M50
            // 
            this.Fator_M50.Location = new System.Drawing.Point(176, 47);
            this.Fator_M50.Name = "Fator_M50";
            this.Fator_M50.Size = new System.Drawing.Size(50, 20);
            this.Fator_M50.TabIndex = 30;
            this.Fator_M50.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Fator_M30
            // 
            this.Fator_M30.Location = new System.Drawing.Point(120, 47);
            this.Fator_M30.Name = "Fator_M30";
            this.Fator_M30.Size = new System.Drawing.Size(50, 20);
            this.Fator_M30.TabIndex = 29;
            this.Fator_M30.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Fator_M20
            // 
            this.Fator_M20.Location = new System.Drawing.Point(64, 47);
            this.Fator_M20.Name = "Fator_M20";
            this.Fator_M20.Size = new System.Drawing.Size(50, 20);
            this.Fator_M20.TabIndex = 28;
            this.Fator_M20.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Vazao_M10
            // 
            this.Vazao_M10.Location = new System.Drawing.Point(8, 205);
            this.Vazao_M10.Name = "Vazao_M10";
            this.Vazao_M10.Size = new System.Drawing.Size(50, 20);
            this.Vazao_M10.TabIndex = 27;
            this.Vazao_M10.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Pres_M10
            // 
            this.Pres_M10.Location = new System.Drawing.Point(8, 179);
            this.Pres_M10.Name = "Pres_M10";
            this.Pres_M10.Size = new System.Drawing.Size(50, 20);
            this.Pres_M10.TabIndex = 26;
            this.Pres_M10.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Temp_M10
            // 
            this.Temp_M10.Location = new System.Drawing.Point(8, 153);
            this.Temp_M10.Name = "Temp_M10";
            this.Temp_M10.Size = new System.Drawing.Size(50, 20);
            this.Temp_M10.TabIndex = 25;
            this.Temp_M10.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Pulso_Tot_M10
            // 
            this.Pulso_Tot_M10.Location = new System.Drawing.Point(8, 125);
            this.Pulso_Tot_M10.Name = "Pulso_Tot_M10";
            this.Pulso_Tot_M10.Size = new System.Drawing.Size(50, 20);
            this.Pulso_Tot_M10.TabIndex = 21;
            this.Pulso_Tot_M10.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Vol_Tot_M10
            // 
            this.Vol_Tot_M10.Location = new System.Drawing.Point(8, 99);
            this.Vol_Tot_M10.Name = "Vol_Tot_M10";
            this.Vol_Tot_M10.Size = new System.Drawing.Size(50, 20);
            this.Vol_Tot_M10.TabIndex = 19;
            this.Vol_Tot_M10.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Pulso_Min_M10
            // 
            this.Pulso_Min_M10.Location = new System.Drawing.Point(8, 73);
            this.Pulso_Min_M10.Name = "Pulso_Min_M10";
            this.Pulso_Min_M10.Size = new System.Drawing.Size(50, 20);
            this.Pulso_Min_M10.TabIndex = 17;
            this.Pulso_Min_M10.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label25.Location = new System.Drawing.Point(8, 20);
            this.label25.MinimumSize = new System.Drawing.Size(50, 2);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(50, 15);
            this.label25.TabIndex = 0;
            this.label25.Text = "10%";
            this.label25.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label25.Click += new System.EventHandler(this.label25_Click);
            // 
            // timer_parada
            // 
            this.timer_parada.Interval = 1000;
            this.timer_parada.Tick += new System.EventHandler(this.timer_parada_Tick);
            // 
            // timer_corrida
            // 
            this.timer_corrida.Interval = 1000;
            this.timer_corrida.Tick += new System.EventHandler(this.timer_corrida_Tick);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StatusLabel,
            this.TempoLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 747);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 10, 0);
            this.statusStrip1.Size = new System.Drawing.Size(1079, 22);
            this.statusStrip1.TabIndex = 70;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // StatusLabel
            // 
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(44, 17);
            this.StatusLabel.Text = "Ocioso";
            // 
            // TempoLabel
            // 
            this.TempoLabel.Name = "TempoLabel";
            this.TempoLabel.Size = new System.Drawing.Size(16, 17);
            this.TempoLabel.Text = "   ";
            // 
            // chart1
            // 
            this.chart1.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.TopBottom;
            this.chart1.BackSecondaryColor = System.Drawing.Color.White;
            this.chart1.BorderlineColor = System.Drawing.Color.Transparent;
            this.chart1.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(15, 391);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "Gráfico ";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(823, 343);
            this.chart1.TabIndex = 71;
            this.chart1.Text = "chart1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1079, 769);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TurbinaCEG";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox2.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.GroupTeste.ResumeLayout(false);
            this.GroupTeste.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.GroupMaster.ResumeLayout(false);
            this.GroupMaster.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox portname;
        private System.Windows.Forms.Button portconnect;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox GroupTeste;
        private System.Windows.Forms.TextBox Vazao_T100;
        private System.Windows.Forms.TextBox Pres_T100;
        private System.Windows.Forms.TextBox Temp_T100;
        private System.Windows.Forms.TextBox Pulso_Tot_T100;
        private System.Windows.Forms.TextBox Vol_Tot_T100;
        private System.Windows.Forms.TextBox Pulso_Min_T100;
        private System.Windows.Forms.TextBox Vazao_T70;
        private System.Windows.Forms.TextBox Pres_T70;
        private System.Windows.Forms.TextBox Temp_T70;
        private System.Windows.Forms.TextBox Pulso_Tot_T70;
        private System.Windows.Forms.TextBox Vol_Tot_T70;
        private System.Windows.Forms.TextBox Pulso_Min_T70;
        private System.Windows.Forms.TextBox Vazao_T50;
        private System.Windows.Forms.TextBox Pres_T50;
        private System.Windows.Forms.TextBox Temp_T50;
        private System.Windows.Forms.TextBox Pulso_Tot_T50;
        private System.Windows.Forms.TextBox Vol_Tot_T50;
        private System.Windows.Forms.TextBox Pulso_Min_T50;
        private System.Windows.Forms.TextBox Vazao_T30;
        private System.Windows.Forms.TextBox Pres_T30;
        private System.Windows.Forms.TextBox Temp_T30;
        private System.Windows.Forms.TextBox Pulso_Tot_T30;
        private System.Windows.Forms.TextBox Vol_Tot_T30;
        private System.Windows.Forms.TextBox Pulso_Min_T30;
        private System.Windows.Forms.TextBox Vazao_T20;
        private System.Windows.Forms.TextBox Pres_T20;
        private System.Windows.Forms.TextBox Temp_T20;
        private System.Windows.Forms.TextBox Pulso_Tot_T20;
        private System.Windows.Forms.TextBox Vol_Tot_T20;
        private System.Windows.Forms.TextBox Pulso_Min_T20;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox Fator_T100;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox Fator_T70;
        private System.Windows.Forms.TextBox Fator_T50;
        private System.Windows.Forms.TextBox Fator_T30;
        private System.Windows.Forms.TextBox Fator_T20;
        private System.Windows.Forms.TextBox Vazao_T10;
        private System.Windows.Forms.TextBox Pres_T10;
        private System.Windows.Forms.TextBox Temp_T10;
        private System.Windows.Forms.TextBox Pulso_Tot_T10;
        private System.Windows.Forms.TextBox Vol_Tot_T10;
        private System.Windows.Forms.TextBox Pulso_Min_T10;
        private System.Windows.Forms.TextBox Fator_T10;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button btnTransfer;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.ComboBox Percentual;
        private System.Windows.Forms.TextBox Pres_M;
        private System.Windows.Forms.TextBox Temp_M;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox Pulso_Tot_M;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox Vol_Tot_M;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox Pulso_Min_M;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox Fator_M;
        private System.Windows.Forms.GroupBox GroupMaster;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.TextBox Pres_T;
        private System.Windows.Forms.TextBox Temp_T;
        private System.Windows.Forms.TextBox Pulso_Tot_T;
        private System.Windows.Forms.TextBox Vol_Tot_T;
        private System.Windows.Forms.TextBox Pulso_Min_T;
        private System.Windows.Forms.TextBox Fator_T;
        private System.Windows.Forms.TextBox Vazao_T;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox Volume;
        private System.Windows.Forms.Timer timer_parada;
        private System.Windows.Forms.TextBox Restante;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Timer timer_corrida;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel StatusLabel;
        private System.Windows.Forms.ToolStripStatusLabel TempoLabel;
        private System.Windows.Forms.ToolStripMenuItem configuraçãoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fichaTécnicaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sobreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem comunicaçãoToolStripMenuItem;
        private ToolStripMenuItem aferiçaçãoDeVazãoToolStripMenuItem;
        private Label label1;
        private ComboBox faixaM;
        private TextBox Vazao_M100;
        private TextBox Pres_M100;
        private TextBox Fator_M10;
        private TextBox Temp_M100;
        private TextBox Pulso_Tot_M100;
        private TextBox Vol_Tot_M100;
        private TextBox Pulso_Min_M100;
        private TextBox Vazao_M70;
        private TextBox Pres_M70;
        private TextBox Temp_M70;
        private TextBox Pulso_Tot_M70;
        private TextBox Vol_Tot_M70;
        private TextBox Pulso_Min_M70;
        private TextBox Vazao_M50;
        private TextBox Pres_M50;
        private TextBox Temp_M50;
        private TextBox Pulso_Tot_M50;
        private TextBox Vol_Tot_M50;
        private TextBox Pulso_Min_M50;
        private TextBox Vazao_M30;
        private TextBox Pres_M30;
        private TextBox Temp_M30;
        private TextBox Pulso_Tot_M30;
        private TextBox Vol_Tot_M30;
        private TextBox Pulso_Min_M30;
        private TextBox Vazao_M20;
        private TextBox Pres_M20;
        private TextBox Temp_M20;
        private TextBox Pulso_Tot_M20;
        private TextBox Vol_Tot_M20;
        private TextBox Pulso_Min_M20;
        private TextBox Fator_M100;
        private TextBox Fator_M70;
        private TextBox Fator_M50;
        private TextBox Fator_M30;
        private TextBox Fator_M20;
        private TextBox Vazao_M10;
        private TextBox Pres_M10;
        private TextBox Temp_M10;
        private TextBox Pulso_Tot_M10;
        private TextBox Vol_Tot_M10;
        private TextBox Pulso_Min_M10;
        private Label label2;
        private Button button1;
        private Label label5;
        private TextBox Qmin;
        private Label label4;
        private TextBox Qmax;
        private Button button2;
        private TextBox TxtVazaoM;
        private Button button3;
        private Label label6;
        private TextBox Qt;
        private Label label3;
        private Label Nvezes;
        private Label label28;
        private TextBox Dp;
        private Label lblt95;
        private TextBox txtt95;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Label label31;
        private Label label29;
        private Label label30;
        private Chart chart1;
        private TextBox Erro_100;
        private TextBox Erro_70;
        private TextBox Erro_50;
        private TextBox Erro_30;
        private TextBox Erro_20;
        private TextBox Erro_10;
        private Label label38;
        private Label label37;
        private Label label36;
        private Label label35;
        private Label label34;
        private Label label33;
        public TextBox ErrorR;
        public TextBox Vazao_M;
    }
}

