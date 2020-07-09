using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SimpleModBusforPLC
{
    public partial class Regula : Form
    {
        Form1 form1 = new Form1();

        public Regula()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Regula_Load(object sender, EventArgs e)
        {
            
            if(chart1.Series[0].Points.Count > 20)
            {
                chart1.Series[0].Points.RemoveAt(0);
                chart1.Update();

            }

            chart1.Series[0].Points.AddY(form1.ErrorR.Text);

            Vazao.Text = form1.Vazao_M.Text;
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            {

                if (chart1.Series[0].Points.Count > 20)
                {
                    chart1.Series[0].Points.RemoveAt(0);
                    chart1.Update();

                }

                chart1.Series[0].Points.AddY(form1.ErrorR.Text);

                Vazao.Text = form1.Vazao_M.Text;
            }

        }
    }
}
