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
    public partial class Relatorio : Form
    {
        public Relatorio(string medidorM,string ModeloM, string FabricanteM, string BitolaM, string NserieM, string MedidorT, string ModeloT, string FabricanteT
            , string BitolaT, string NserieT, string Parecer, string Data, string Operador, string FatorKM, string FatorKT, string PulsoMM, string PulsoMT, string VolumeM
            , string VolumeT, string PulsoTotalM, string PulsoTotalT, string TemperaturaM, string TemperaturaT, string PressaoM, string PressaoT,string VazaoM, string VazaoT
            , string tx1, string tx2, string tx3, string tx4, string tx5, string tx6, string tx7, string tx8, string tx9, string tx10, string tx11, string tx12, string tx13, string tx14
            , string tx15, string tx16, string tx17, string tx18, string tx19, string tx20, string tx21, string tx22, string tx23, string tx24, string tx25, string tx26
            , string tx27, string tx28, string tx29, string tx30, string tx31, string tx32, string tx33, string tx34, string tx35, string tx36/*, string tx37, string tx38
            , string tx39, string tx40*/ )
        {
            InitializeComponent();


            Microsoft.Reporting.WinForms.ReportParameter[] p = new Microsoft.Reporting.WinForms.ReportParameter[63];

            p[0] = new Microsoft.Reporting.WinForms.ReportParameter("MedidorM",medidorM);
            p[1] = new Microsoft.Reporting.WinForms.ReportParameter("ModeloM", ModeloM);
            p[2] = new Microsoft.Reporting.WinForms.ReportParameter("FabricanteM", FabricanteM);
            p[3] = new Microsoft.Reporting.WinForms.ReportParameter("BitolaM", BitolaM);
            p[4] = new Microsoft.Reporting.WinForms.ReportParameter("NserieM", NserieM);
            p[5] = new Microsoft.Reporting.WinForms.ReportParameter("MedidorT", MedidorT);
            p[6] = new Microsoft.Reporting.WinForms.ReportParameter("ModeloT", ModeloT);
            p[7] = new Microsoft.Reporting.WinForms.ReportParameter("FabricanteT", FabricanteT);
            p[8] = new Microsoft.Reporting.WinForms.ReportParameter("BitolaT", BitolaT);
            p[9] = new Microsoft.Reporting.WinForms.ReportParameter("NserieT", NserieT);
            p[10] = new Microsoft.Reporting.WinForms.ReportParameter("Parecer", Parecer);
            p[11] = new Microsoft.Reporting.WinForms.ReportParameter("Data", Data);
            p[12] = new Microsoft.Reporting.WinForms.ReportParameter("Operador", Operador);
            p[13] = new Microsoft.Reporting.WinForms.ReportParameter("FatorKM", FatorKM);
            p[14] = new Microsoft.Reporting.WinForms.ReportParameter("FatorKT", FatorKT);
            p[15] = new Microsoft.Reporting.WinForms.ReportParameter("PulsoMM", PulsoMM);
            p[16] = new Microsoft.Reporting.WinForms.ReportParameter("PulsoMT", PulsoMT);
            p[17] = new Microsoft.Reporting.WinForms.ReportParameter("VolumeM", VolumeM);
            p[18] = new Microsoft.Reporting.WinForms.ReportParameter("VolumeT", VolumeT);
            p[19] = new Microsoft.Reporting.WinForms.ReportParameter("PulsoTotalM", PulsoTotalM);
            p[20] = new Microsoft.Reporting.WinForms.ReportParameter("PulsoTotalT", PulsoTotalT);
            p[21] = new Microsoft.Reporting.WinForms.ReportParameter("TemperaturaM", TemperaturaM);
            p[22] = new Microsoft.Reporting.WinForms.ReportParameter("TemperaturaT", TemperaturaT);
            p[23] = new Microsoft.Reporting.WinForms.ReportParameter("PressãoM", PressaoM);
            p[24] = new Microsoft.Reporting.WinForms.ReportParameter("PressãoT", PressaoT);
            p[25] = new Microsoft.Reporting.WinForms.ReportParameter("VazaoM", VazaoM);
            p[26] = new Microsoft.Reporting.WinForms.ReportParameter("VazaoT", VazaoT);
            p[27] = new Microsoft.Reporting.WinForms.ReportParameter("tx1", tx1);
            p[28] = new Microsoft.Reporting.WinForms.ReportParameter("tx2", tx2);
            p[29] = new Microsoft.Reporting.WinForms.ReportParameter("tx3", tx3);
            p[30] = new Microsoft.Reporting.WinForms.ReportParameter("tx4", tx4);
            p[31] = new Microsoft.Reporting.WinForms.ReportParameter("tx5", tx5);
            p[32] = new Microsoft.Reporting.WinForms.ReportParameter("tx6", tx6);
            p[33] = new Microsoft.Reporting.WinForms.ReportParameter("tx7", tx7);
            p[34] = new Microsoft.Reporting.WinForms.ReportParameter("tx8", tx8);
            p[35] = new Microsoft.Reporting.WinForms.ReportParameter("tx9", tx9);
            p[36] = new Microsoft.Reporting.WinForms.ReportParameter("tx10", tx10);
            p[37] = new Microsoft.Reporting.WinForms.ReportParameter("tx11", tx11);
            p[38] = new Microsoft.Reporting.WinForms.ReportParameter("tx12", tx12);
            p[39] = new Microsoft.Reporting.WinForms.ReportParameter("tx13", tx13);
            p[40] = new Microsoft.Reporting.WinForms.ReportParameter("tx14", tx14);
            p[41] = new Microsoft.Reporting.WinForms.ReportParameter("tx15", tx15);
            p[42] = new Microsoft.Reporting.WinForms.ReportParameter("tx16", tx16);
            p[43] = new Microsoft.Reporting.WinForms.ReportParameter("tx17", tx17);
            p[44] = new Microsoft.Reporting.WinForms.ReportParameter("tx18", tx18);
            p[45] = new Microsoft.Reporting.WinForms.ReportParameter("tx19", tx19);
            p[46] = new Microsoft.Reporting.WinForms.ReportParameter("tx20", tx20);
            p[47] = new Microsoft.Reporting.WinForms.ReportParameter("tx21", tx21);
            p[48] = new Microsoft.Reporting.WinForms.ReportParameter("tx22", tx22);
            p[49] = new Microsoft.Reporting.WinForms.ReportParameter("tx23", tx23);
            p[50] = new Microsoft.Reporting.WinForms.ReportParameter("tx24", tx24);
            p[51] = new Microsoft.Reporting.WinForms.ReportParameter("tx25", tx25);
            p[52] = new Microsoft.Reporting.WinForms.ReportParameter("tx26", tx26);
            p[53] = new Microsoft.Reporting.WinForms.ReportParameter("tx27", tx27);
            p[54] = new Microsoft.Reporting.WinForms.ReportParameter("tx28", tx28);
            p[55] = new Microsoft.Reporting.WinForms.ReportParameter("tx29", tx29);
            p[56] = new Microsoft.Reporting.WinForms.ReportParameter("tx30", tx30);
            p[57] = new Microsoft.Reporting.WinForms.ReportParameter("tx31", tx31);
            p[58] = new Microsoft.Reporting.WinForms.ReportParameter("tx32", tx32);
            p[59] = new Microsoft.Reporting.WinForms.ReportParameter("tx33", tx33);
            p[60] = new Microsoft.Reporting.WinForms.ReportParameter("tx34", tx34);
            p[61] = new Microsoft.Reporting.WinForms.ReportParameter("tx35", tx35);
            p[62] = new Microsoft.Reporting.WinForms.ReportParameter("tx36", tx36);/*
            p[63] = new Microsoft.Reporting.WinForms.ReportParameter("tx37", tx37);
            p[64] = new Microsoft.Reporting.WinForms.ReportParameter("tx38", tx38);
            p[65] = new Microsoft.Reporting.WinForms.ReportParameter("tx39", tx39);
            p[66] = new Microsoft.Reporting.WinForms.ReportParameter("tx40", tx40);
            */




            // p[1] = new Microsoft.Reporting.WinForms.ReportParameter("Email", Email);
            // p[2] = new Microsoft.Reporting.WinForms.ReportParameter("Cpf", Cpf);
            reportViewer1.LocalReport.SetParameters(p);
            reportViewer1.LocalReport.Refresh();
            reportViewer1.RefreshReport();
        }

        private void Relaório_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
            
        }
    }
}

