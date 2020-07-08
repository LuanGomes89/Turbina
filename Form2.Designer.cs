namespace TurbinaCEG
{
    partial class Form2
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.Coil = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Addr = new System.Windows.Forms.TextBox();
            this.ResetBtn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.CRCcheck = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Data2 = new System.Windows.Forms.TextBox();
            this.Data1 = new System.Windows.Forms.TextBox();
            this.requestFunc16 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ReqCycle = new System.Windows.Forms.CheckBox();
            this.requestFunc3 = new System.Windows.Forms.Button();
            this.ResponseDisplayFunc3 = new System.Windows.Forms.RichTextBox();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.LightGreen;
            this.groupBox3.Controls.Add(this.Coil);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.Addr);
            this.groupBox3.Controls.Add(this.ResetBtn);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.CRCcheck);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.Data2);
            this.groupBox3.Controls.Add(this.Data1);
            this.groupBox3.Controls.Add(this.requestFunc16);
            this.groupBox3.Location = new System.Drawing.Point(349, 31);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox3.Size = new System.Drawing.Size(267, 215);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Function Code 16 of ModBus";
            // 
            // Coil
            // 
            this.Coil.AutoSize = true;
            this.Coil.Location = new System.Drawing.Point(148, 150);
            this.Coil.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Coil.Name = "Coil";
            this.Coil.Size = new System.Drawing.Size(97, 21);
            this.Coil.TabIndex = 4;
            this.Coil.Text = "Coil Status";
            this.Coil.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 148);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 17);
            this.label6.TabIndex = 10;
            this.label6.Text = "Addr";
            // 
            // Addr
            // 
            this.Addr.Location = new System.Drawing.Point(69, 146);
            this.Addr.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Addr.Name = "Addr";
            this.Addr.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Addr.Size = new System.Drawing.Size(65, 22);
            this.Addr.TabIndex = 9;
            this.Addr.Text = "0";
            // 
            // ResetBtn
            // 
            this.ResetBtn.Location = new System.Drawing.Point(172, 177);
            this.ResetBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ResetBtn.Name = "ResetBtn";
            this.ResetBtn.Size = new System.Drawing.Size(87, 28);
            this.ResetBtn.TabIndex = 8;
            this.ResetBtn.Text = "Set Coil";
            this.ResetBtn.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 114);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 17);
            this.label5.TabIndex = 7;
            this.label5.Text = "CRC Check:";
            // 
            // CRCcheck
            // 
            this.CRCcheck.Location = new System.Drawing.Point(104, 111);
            this.CRCcheck.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CRCcheck.Name = "CRCcheck";
            this.CRCcheck.Size = new System.Drawing.Size(132, 22);
            this.CRCcheck.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 89);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Response:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 60);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Data2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 33);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Data1";
            // 
            // Data2
            // 
            this.Data2.Location = new System.Drawing.Point(64, 57);
            this.Data2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Data2.Name = "Data2";
            this.Data2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Data2.Size = new System.Drawing.Size(132, 22);
            this.Data2.TabIndex = 2;
            this.Data2.Text = "0";
            // 
            // Data1
            // 
            this.Data1.Location = new System.Drawing.Point(64, 28);
            this.Data1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Data1.Name = "Data1";
            this.Data1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Data1.Size = new System.Drawing.Size(132, 22);
            this.Data1.TabIndex = 1;
            this.Data1.Text = "0";
            // 
            // requestFunc16
            // 
            this.requestFunc16.Location = new System.Drawing.Point(200, 53);
            this.requestFunc16.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.requestFunc16.Name = "requestFunc16";
            this.requestFunc16.Size = new System.Drawing.Size(67, 28);
            this.requestFunc16.TabIndex = 0;
            this.requestFunc16.Text = "Request";
            this.requestFunc16.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Khaki;
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.ReqCycle);
            this.groupBox1.Controls.Add(this.requestFunc3);
            this.groupBox1.Controls.Add(this.ResponseDisplayFunc3);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(77, 31);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(241, 191);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Function Code 03 of ModBus";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 66);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Response:";
            // 
            // ReqCycle
            // 
            this.ReqCycle.AutoSize = true;
            this.ReqCycle.Location = new System.Drawing.Point(124, 28);
            this.ReqCycle.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ReqCycle.Name = "ReqCycle";
            this.ReqCycle.Size = new System.Drawing.Size(94, 21);
            this.ReqCycle.TabIndex = 2;
            this.ReqCycle.Text = "Req Cycle";
            this.ReqCycle.UseVisualStyleBackColor = true;
            // 
            // requestFunc3
            // 
            this.requestFunc3.Location = new System.Drawing.Point(16, 23);
            this.requestFunc3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.requestFunc3.Name = "requestFunc3";
            this.requestFunc3.Size = new System.Drawing.Size(100, 28);
            this.requestFunc3.TabIndex = 1;
            this.requestFunc3.Text = "Request";
            this.requestFunc3.UseVisualStyleBackColor = true;
            // 
            // ResponseDisplayFunc3
            // 
            this.ResponseDisplayFunc3.Location = new System.Drawing.Point(16, 86);
            this.ResponseDisplayFunc3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ResponseDisplayFunc3.Name = "ResponseDisplayFunc3";
            this.ResponseDisplayFunc3.Size = new System.Drawing.Size(207, 70);
            this.ResponseDisplayFunc3.TabIndex = 0;
            this.ResponseDisplayFunc3.Text = "";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 308);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox Coil;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Addr;
        private System.Windows.Forms.Button ResetBtn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox CRCcheck;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Data2;
        private System.Windows.Forms.TextBox Data1;
        private System.Windows.Forms.Button requestFunc16;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox ReqCycle;
        private System.Windows.Forms.Button requestFunc3;
        private System.Windows.Forms.RichTextBox ResponseDisplayFunc3;
    }
}