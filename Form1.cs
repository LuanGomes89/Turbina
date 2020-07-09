using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
//using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.IO;
using System.IO.Ports;
using System.Text.RegularExpressions;

namespace SimpleModBusforPLC
{



    public partial class Form1 : Form
    {
        List<byte> responsecollect = new List<byte>();
        int responseFunc3total;
        int responseFunc4total;
        int responseFunc5total;
        int responseFunc6total;
        int responseFunc16total;
        bool PollingEnable = false;
        bool StartEnable = false;
        long TempoRestante = 0;
        Single VolumeParada = 0;
        Single MediaTempM = 0;
        Single MediaPresM = 0;
        Single MediaTempT = 0;
        Single MediaPresT = 0;
        double MediaVazaoM = 0; // criado 15/06 
        double MediaError = 0;
        double MediaError2 = 0;
        double Mediadp = 0;
        double Mediat95 = 0;
        double error = 0;
        int numAmostras = 0;
        int numAmostras2 = 0; // criando 15/06
        int numAmostras3 = 0;
        int TempoCorrida = 0;
        //double[] ErroRep;
        //double[] VazaoRep;
        int conte;

        int x = 0;

        string Cliente; string Operador; string endereco; string data; string dataemissao; string anodefrabicao;  string tipoM; string tipoT; string desigM; string desigT;
        string fabriM; string fabriT; string diameM; string diameT; string nserieM; string nserieT; string txtpadrao1; string txtpadrao2;
        string txtpadrao3; string instrucao; string descriçao ; string modeloM; string modeloT; string fluido; string press; string temp; string umi;
        string padrao4;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //            parity.Items.Clear(); parity.Items.AddRange(Enum.GetNames(typeof(Parity)));
            //            stopbit.Items.Clear(); stopbit.Items.AddRange(Enum.GetNames(typeof(StopBits)));
            string[] ports = SerialPort.GetPortNames();
            portname.Items.Clear();
            portname.Items.AddRange(ports);
            Percentual.SelectedIndex = 0;
            //            Tempo.Enabled = false;
            Volume.Enabled = true;
            //           radioVolume.Select();
        }

        private void portconnect_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                serialPort1.Close();
                PollingEnable = true;
            }
            else
            {
                //                serialPort1.BaudRate = int.Parse(baudrate.Text);
                //                serialPort1.DataBits = int.Parse(databit.Text);
                //                serialPort1.Parity = Parity.None; // (Parity)Enum.Parse(typeof(Parity), parity.Text);
                //                serialPort1.StopBits = (StopBits)Enum.Parse(typeof(StopBits), stopbit.Text);
                serialPort1.PortName = portname.Text;
                try
                {
                    if (!serialPort1.IsOpen) serialPort1.Open();
                    PollingEnable = true;
                }
                catch (Exception err)
                {
                    MessageBox.Show(this, err.Message);
                }

            }

            if (serialPort1.IsOpen) portconnect.Text = "&Close Port";
            else portconnect.Text = "&Open Port";
        }

        private void portname_DragDrop(object sender, DragEventArgs e)
        {
            string[] ports = SerialPort.GetPortNames();
            portname.Items.Clear();
            portname.Items.AddRange(ports);
        }

        private void requestFunc3_Click(object sender, EventArgs e)
        {
            //Function Code 03 / Read Holding Registers
            //           ResponseDisplayFunc3.Text = "";

            //Function 3 request is always 8 bytes
            byte[] message = new byte[8];
            byte Slave_Address = 1;
            byte Function = 3;
            ushort Starting_Address = 0;
            ushort Number_of_Points = 30;

            //index0 = Slave Address
            message[0] = Slave_Address;
            //index1 = Function
            message[1] = Function;
            //index2 = Starting Address Hi
            message[2] = (byte)(Starting_Address >> 8);
            //index3 = Starting Address Lo
            message[3] = (byte)Starting_Address;
            //index4 = Number of Points Hi
            message[4] = (byte)(Number_of_Points >> 8);
            //index5 = Number of Points Lo
            message[5] = (byte)Number_of_Points;

            // CRC (Cyclical Redundancy Check) Calculation
            ushort CRC = 0xFFFF;
            byte CRCHi = 0xFF;
            byte CRCLo = 0xFF;
            ushort CRCLSB;

            for (int i = 0; i < (message.Length) - 2; i++)
            {
                CRC = (ushort)(CRC ^ message[i]);

                for (int j = 0; j < 8; j++)
                {
                    CRCLSB = (ushort)(CRC & 0x0001);
                    CRC = (ushort)((CRC >> 1) & 0x7FFF);

                    if (CRCLSB == 1)
                        CRC = (ushort)(CRC ^ 0xA001);
                }
            }
            CRCHi = (byte)((CRC >> 8) & 0xFF);
            CRCLo = (byte)(CRC & 0xFF);

            //index6 = CRC Lo
            message[message.Length - 2] = CRCLo;
            //index7 = CRC Hi
            message[message.Length - 1] = CRCHi;

            try
            {
                if (serialPort1.IsOpen)
                {
                    serialPort1.Write(message, 0, message.Length);
                    responseFunc3total = 5 + 2 * Number_of_Points;
                    responsecollect.Clear();
                }
                else
                {
                    MessageBox.Show(this, "The Port is Closed, Please click Open Port Button");
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(this, err.Message);
            }
        }

        private void requestFunc4_Click(object sender, EventArgs e)
        {
            //Function Code 03 / Read Holding Registers
            //           ResponseDisplayFunc3.Text = "";

            //Function 3 request is always 8 bytes
            byte[] message = new byte[8];
            byte Slave_Address = 1;
            byte Function = 4;
            ushort Starting_Address = 0;
            ushort Number_of_Points = 30;

            //index0 = Slave Address
            message[0] = Slave_Address;
            //index1 = Function
            message[1] = Function;
            //index2 = Starting Address Hi
            message[2] = (byte)(Starting_Address >> 8);
            //index3 = Starting Address Lo
            message[3] = (byte)Starting_Address;
            //index4 = Number of Points Hi
            message[4] = (byte)(Number_of_Points >> 8);
            //index5 = Number of Points Lo
            message[5] = (byte)Number_of_Points;

            // CRC (Cyclical Redundancy Check) Calculation
            ushort CRC = 0xFFFF;
            byte CRCHi = 0xFF;
            byte CRCLo = 0xFF;
            ushort CRCLSB;

            for (int i = 0; i < (message.Length) - 2; i++)
            {
                CRC = (ushort)(CRC ^ message[i]);

                for (int j = 0; j < 8; j++)
                {
                    CRCLSB = (ushort)(CRC & 0x0001);
                    CRC = (ushort)((CRC >> 1) & 0x7FFF);

                    if (CRCLSB == 1)
                        CRC = (ushort)(CRC ^ 0xA001);
                }
            }
            CRCHi = (byte)((CRC >> 8) & 0xFF);
            CRCLo = (byte)(CRC & 0xFF);

            //index6 = CRC Lo
            message[message.Length - 2] = CRCLo;
            //index7 = CRC Hi
            message[message.Length - 1] = CRCHi;

            try
            {
                if (serialPort1.IsOpen)
                {
                    serialPort1.Write(message, 0, message.Length);
                    responseFunc4total = 5 + 2 * Number_of_Points;
                    responsecollect.Clear();
                }
                else
                {
                    MessageBox.Show(this, "The Port is Closed, Please click Open Port Button");
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(this, err.Message);
            }
        }

        private void requestFunc5_Click(object sender, EventArgs e)
        {
            //Function Code 03 / Read Holding Registers
            //           ResponseDisplayFunc3.Text = "";

            //Function 3 request is always 8 bytes
            byte[] message = new byte[8];
            byte Slave_Address = 1;
            byte Function = 5;
            ushort Starting_Address = 0;
            //            ushort Number_of_Points = 5;

            //index0 = Slave Address
            message[0] = Slave_Address;
            //index1 = Function
            message[1] = Function;
            //index2 = Starting Address Hi
            message[2] = (byte)(Starting_Address >> 8);
            //index3 = Starting Address Lo
            message[3] = (byte)Starting_Address;
            //index4 = The status to write
            message[4] = (byte)0xFF;
            //index5 = The status to write
            message[5] = (byte)0x00;

            // CRC (Cyclical Redundancy Check) Calculation
            ushort CRC = 0xFFFF;
            byte CRCHi = 0xFF;
            byte CRCLo = 0xFF;
            ushort CRCLSB;

            for (int i = 0; i < (message.Length) - 2; i++)
            {
                CRC = (ushort)(CRC ^ message[i]);

                for (int j = 0; j < 8; j++)
                {
                    CRCLSB = (ushort)(CRC & 0x0001);
                    CRC = (ushort)((CRC >> 1) & 0x7FFF);

                    if (CRCLSB == 1)
                        CRC = (ushort)(CRC ^ 0xA001);
                }
            }
            CRCHi = (byte)((CRC >> 8) & 0xFF);
            CRCLo = (byte)(CRC & 0xFF);

            //index6 = CRC Lo
            message[message.Length - 2] = CRCLo;
            //index7 = CRC Hi
            message[message.Length - 1] = CRCHi;

            try
            {
                if (serialPort1.IsOpen)
                {
                    serialPort1.Write(message, 0, message.Length);
                    responseFunc3total = 8;
                    responsecollect.Clear();
                }
                else
                {
                    MessageBox.Show(this, "The Port is Closed, Please click Open Port Button");
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(this, err.Message);
            }
        }

        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            //          Thread.Sleep(50);
            if (!serialPort1.IsOpen) return;
            int bytes = serialPort1.BytesToRead;
            byte[] buffer = new byte[bytes];
            serialPort1.Read(buffer, 0, bytes);
            Response(buffer);
        }

        private void Response(byte[] msg)
        {
            Invoke(new EventHandler(delegate
            {
            //Response Collect Data
            for (int i = 0; i < msg.Length; i++)
                responsecollect.Add(msg[i]);


            //Function 3 response
            if (responsecollect.Count == responseFunc3total)
            {
                byte[] responseFunc3 = responsecollect.ToArray();
                //Function Code Check
                if (responseFunc3[1] == 3)
                {
                    //CRC Error Check
                    if (CRCResponseCheck(responseFunc3))
                    {
                        //Byte Count in index 3 = responseFunc3[2]
                        //Number of Registers = byte count / 2 = responseFunc3[2] / 2
                        byte registers = (byte)(responseFunc3[2] / 2);
                        UInt16[] values = new UInt16[registers];

                        for (int i = 0; i < registers; i++)
                        {
                            //Data Hi and Registers1 from Index3
                            values[i] = responseFunc3[2 * i + 3];
                            //Move to Hi
                            values[i] <<= 8;
                            //Data Lo and Registers1 from Index4
                            values[i] += responseFunc3[2 * i + 4];
                            //Data Show
                            int r = i + 1;
                            //                           ResponseDisplayFunc3.Text += "Registers" + r + " = " + values[i] + "\n";

                        }
                        //                       micros = values[0] + values[1] << 16;
                        //                        ResponseDisplayFunc3.Text += "Micros = " + micros + "\n";

                    }
                }
            }

            //Function 4 response
            if (responsecollect.Count == responseFunc4total)
            {
                byte[] responseFunc4 = responsecollect.ToArray();
                //Function Code Check
                if (responseFunc4[1] == 4)
                {
                    //CRC Error Check
                    if (CRCResponseCheck(responseFunc4))
                    {
                        //Byte Count in index 3 = responseFunc3[2]
                        //Number of Registers = byte count / 2 = responseFunc3[2] / 2
                        byte registers = (byte)(responseFunc4[2] / 2);
                        UInt16[] values = new UInt16[registers];

                        for (int i = 0; i < registers; i++)
                        {
                            //Data Hi and Registers1 from Index3
                            values[i] = responseFunc4[2 * i + 3];
                            //Move to Hi
                            values[i] <<= 8;
                            //Data Lo and Registers1 from Index4
                            values[i] += responseFunc4[2 * i + 4];
                            //Data Show
                            int r = i + 1;
                            //                            ResponseDisplayFunc3.Text += "Registers" + r + " = " + values[i] + "\n";
                        }
                        if (!StartEnable)
                        {
                            //                        Pres_M.Text = values[0].ToString();
                            //                        Temp_M.Text = values[1].ToString();
                            //                        Pres_T.Text = values[10].ToString();
                            //                        Temp_T.Text = values[11].ToString();
                        }
                        else
                        {
                            MediaPresM = (MediaPresM * numAmostras + values[0]) / (numAmostras + 1);
                            MediaTempM = (MediaTempM * numAmostras + values[1]) / (numAmostras + 1); // Estava values[0]
                            MediaPresT = (MediaPresT * numAmostras + values[10]) / (numAmostras + 1);
                            MediaTempT = (MediaTempT * numAmostras + values[11]) / (numAmostras + 1);
                            // MediaVazaoM = (MediaVazaoM * numAmostras + Single.Parse(Vazao_M.Text)) / (numAmostras + 1);
                            numAmostras++;
                            Pres_M.Text = MediaPresM.ToString();
                            Temp_M.Text = MediaTempM.ToString();
                            Pres_T.Text = MediaPresT.ToString();
                            Temp_T.Text = MediaTempT.ToString();
                        }
                        Pulso_Min_M.Text = (values[4] * 60).ToString();
                        long esq = values[7];
                        long dir = values[8];
                        long total = esq + dir * 65536;
                        Pulso_Tot_M.Text = ((long)values[17] + (long)(values[18]) * 65536).ToString();
                        Pulso_Min_T.Text = (values[14] * 60).ToString();
                        Pulso_Tot_T.Text = ((long)values[7] + (long)(values[8]) * 65536).ToString();

                        try
                        {
                            Vazao_M.Text = ((values[4] / Convert.ToDouble(Fator_M.Text)) * 3600).ToString();
                            Vol_Tot_M.Text = (((long)values[17] + (long)(values[18]) * 65536) / Convert.ToSingle(Fator_M.Text)).ToString();
                            //MessageBox.Show(((long)values[17]).ToString(), ((long)values[18]).ToString());
                            // textBox1.Text = Vazao_M.Text;




                            // implementado 15/06


                            Pres_M.Text = MediaPresM.ToString();

                            if (Convert.ToSingle(Fator_M.Text) < 0.00000001)
                            {
                                Vazao_M.Text = "Erro";
                                Vol_Tot_M.Text = "Erro";
                            }
                        }
                        catch (Exception err)
                        {
                            Vazao_M.Text = "Erro";
                            Vol_Tot_M.Text = "Erro";
                        }
                        try
                        {
                            Vazao_T.Text = ((values[14] / Convert.ToSingle(Fator_T.Text)) * 3600).ToString();
                            Vol_Tot_T.Text = (((long)values[7] + (long)(values[8]) * 65536) / Convert.ToSingle(Fator_T.Text)).ToString();
                            if (Convert.ToSingle(Fator_T.Text) < 0.00000001)
                            {
                                Vazao_T.Text = "Erro";
                                Vol_Tot_T.Text = "Erro";
                            }
                        }
                        catch (Exception err)
                        {
                            Vazao_T.Text = "Erro";
                            Vol_Tot_T.Text = "Erro";
                        }




                        //////////////////////////////////////////////////////////////////////


                        if (Vazao_M.Text != "Erro" && Vazao_T.Text != "Erro")
                        {


                            ErrorR.Text = (((Convert.ToSingle(Vazao_T.Text) - Convert.ToSingle(Vazao_M.Text)) / Convert.ToSingle(Vazao_M.Text)) * 100).ToString();





                            if (numAmostras2 > 20)
                            {
                                MediaVazaoM += Convert.ToSingle(Vazao_M.Text);
                                MediaError += Convert.ToSingle(ErrorR.Text);


                                    /*this.ErroRep = new double[5];

                                    VazaoRep[0] = 0;
                                    VazaoRep[1] = 0;
                                    VazaoRep[2] = 0;
                                    VazaoRep[3] = 0;
                                    VazaoRep[4] = 0;

                                    ErroRep[0] = 0;
                                    ErroRep[1] = 0;
                                    ErroRep[2] = 0;
                                    ErroRep[3] = 0;
                                    ErroRep[4] = 0;

                                    Soma_Erros = 0;

                                    for (int i = 0; i <= 5; i++)
                                    {
                                        //Calc_Volume_Real
                                        //VazaoRep(i) = VT_Real
                                        //Calculo_do_Erro
                                        ErroRep[i] = Convert.ToSingle(ErrorR.Text);
                                        //  Convert.ToDouble(ErrorR.Text);
                                        Soma_Erros = Soma_Erros + ErroRep[i];


                                    }
                                    double MediaError2 = Soma_Erros / 5;
                                    //RepetibilidadeErro();
                                    */


                                    //MediaVazaoM = (MediaVazaoM * numAmostras3 + Convert.ToSingle(Vazao_M.Text)) / (numAmostras3 + 1);
                                    if (conte >= 1)
                                    {
                                        double l = 0, s = 0, k = 0, j;
                                        //if (Convert.ToUInt16(Nvezes.Text) == 22)
                                        l = (Math.Pow((Convert.ToSingle(ErrorR.Text) - MediaError2), 2));
                                        //if (Convert.ToUInt16(Nvezes.Text) == 23)
                                        s = (Math.Pow((Convert.ToSingle(ErrorR.Text) - MediaError2), 2));
                                        //if (Convert.ToUInt16(Nvezes.Text) == 24)
                                        k = (Math.Pow((Convert.ToSingle(ErrorR.Text) - MediaError2), 2));// 15/06

                                        j = Math.Sqrt((l + s + k) / 3);

                                        Mediadp += j;

                                        // Dp.Text = j.ToString();
                                  
                                        //txtt95.Text = (Convert.ToSingle(Dp.Text) * 2.776).ToString();
                                        textBox3.Text = MediaError2.ToString();

                                    } //implementado 15/06

                                }

                                /*
                                // Função do calculo do  erro. Definir como vai ser aplicado e onde.
                                 
                                Public Sub Calculo_do_Erro()

                                If VM_Real = 0 Then
                                Else

                                Erro = ((VT_Real - VM_Real) / VM_Real) * 100
                                Erro = 100000 * Erro
                                Erro = Val(Erro)
                                Erro = Erro / 100000
                                End If
                                End Sub
                                */

                                /* 
                                //Função teste de repitibilidade do erro e da vazão .Definir como vai ser aplicado e onde.
                                
                               Public void Repetibilidade(){
                               
                               int i;
                               double Soma_Erros;

                                ErroRep
                                VazaoRep

                               /* 
                                VazaoRep[0] = 0
                                VazaoRep[1] = 0
                                VazaoRep[2] = 0
                                VazaoRep[3] = 0
                                VazaoRep[4] = 0 

                                ErroRep[0] = 0
                                ErroRep[1] = 0
                                ErroRep[2] = 0
                                ErroRep[3] = 0
                                ErroRep[4] = 0

                                Soma_Erros = 0

                                For ( i = 0; i <= 5; i++ )
                                  //Calc_Volume_Real
                                  VazaoRep(i) = VT_Real
                                  Calculo_do_Erro
                                  ErroRep(i) = Erro
                                  Soma_Erros = Soma_Erros + ErroRep(i)
                                Next i

                                Media_Erros = Soma_Erros / 5

                                }

                                */

                                /*
                                Função Desvio padrão . Definir onde e quando serar executado.
                                Sub Desvio_Padrao()

                                Dim i As Integer

                                Dim Def_Erros, Pot_Dif_Erros, SomaPDE As Double
                                Const t95 As Double = 2.775

                                For i = 1 To 5

                                Def_Erros = MediaCorridaErro(i) - MediaAcumuladaErro
                                Pot_Dif_Erros = Def_Erros ^ 2
                                SomaPDE = SomaPDE + Pot_Dif_Erros
                                Next i

                                SomaPDE = SomaPDE / 4
                                SomaPDE = Sqr(SomaPDE)
                                R = t95 * SomaPDE

                                End Sub
                                */

                              
                            }





                            // implementado 15/06

                            Nvezes.Text = numAmostras2.ToString(); // talvez saia 

                            //textBox2.Text = MediaError2.ToString();

                            // textBox1.Text = MediaVazaoM.ToString();
                            numAmostras2++;

                            if (Convert.ToSingle(Vol_Tot_M.Text) >= VolumeParada)
                            {
                                StartEnable = false;
                                PollingEnable = false;
                                timer_parada.Enabled = true;
                                if (numAmostras2 > 3)
                                {
                                    double media = 0, error = 0, dp = 0, t95 = 0;
                                    media = MediaVazaoM / (Convert.ToSingle(Nvezes.Text) - 20);
                                    error = MediaError / (Convert.ToSingle(Nvezes.Text) - 20);
                                    MediaError2 = error;
                                    dp = Mediadp / (Convert.ToSingle(Nvezes.Text) - 20);
                                    t95 = dp * 2.776;

                                    textBox1.Text = media.ToString();
                                    textBox2.Text = error.ToString();
                                    this.error = error;
                                    Dp.Text = dp.ToString();
                                    txtt95.Text = t95.ToString();

                                    if (chart1.Series[0].Points.Count > 15) // 15/06
                                    {
                                        chart1.Series[0].Points.RemoveAt(0); // 15/06
                                        chart1.Update(); // 15/06

                                    }

                                    // chart1.Series[0].Points.AddY(Convert.ToSingle(ErrorR.Text));// 15/06
                                    chart1.Series[0].Points.AddY(Convert.ToSingle(error));

                                    numAmostras3 = 0;
                                    numAmostras2 = 0;
                                    MediaVazaoM = 0;
                                    MediaError = 0;
                                    Mediadp = 0;
                                    Mediat95 = 0;
                                    conte++;
                                }

                                /*    if (Convert.ToUInt16(Nvezes.Text) > 10)
                                    {

                                        MediaVazaoM = MediaVazaoM + Convert.ToDouble(Vazao_M.Text);

                                        if ( x == 2)
                                        {
                                            MediaVazaoM = MediaVazaoM / 3;
                                            textBox3.Text = MediaVazaoM.ToString();
                                        }

                                        numAmostras2 = 0;
                                        x++;
                                    }*/
                            }



                            ///////////////////////////////////////////////////////////////////////


                            /*if (numAmostras3 == 1)  // 15/06
                            {
                                conte1 = (double.Parse(ErrorR.Text)).ToString(); // 15/06

                            } else if (numAmostras3 == 2) // 15/06

                            {
                                conte2 = (double.Parse(ErrorR.Text)).ToString(); // 15/06
                            }
                            else  if ( numAmostras3 == 3 ) // 15/06
                            {
                                conte3 = (double.Parse(ErrorR.Text)).ToString();
                                
                                Dp.Text = Math.Sqrt((Math.Pow((double.Parse(conte1) - MediaError), 2)) + (Math.Pow((double.Parse(conte2) - MediaError), 2)) + (Math.Pow((double.Parse(conte3) - MediaError), 2)) / numAmostras3 - 1).ToString(); // 15/06
                            }
                            else
                            {
                                conte1 = null;
                                conte2 = null;
                                conte3 = null;
                                numAmostras3 = 0;
                            }*/

                            /*                           txtt95.Text = Math.Abs(2.776 * Math.Sqrt((Math.Pow((double.Parse(conte1) - MediaError), 2)) + (Math.Pow((double.Parse(conte2) - MediaError), 2)) + (Math.Pow((double.Parse(conte3) - MediaError), 2)) / numAmostras3 - 1) // 15/06
                           ).ToString();
                                                       //txtt95.Text = (distT).ToString();



                                                       /////////////////////////////////////////////////////////////////////


                                                           //                            Single vol = Convert.ToSingle(Vol_Tot_M.Text);


                                                       /*

                                                                               Temp_M.Text = values[3].ToString();
                                                                               Pres_M.Text = values[4].ToString();
                                                                               Temp_T.Text = values[5].ToString();
                                                                               Pres_T.Text = values[6].ToString();

                                                                               Pulso_Tot_M.Text = values[13].ToString();
                                                                               Pulso_Min_M.Text = (values[14] * 60).ToString();
                                                                               Pulso_Tot_T.Text = values[23].ToString();
                                                                               Pulso_Min_T.Text = (values[24] * 60).ToString();

                                                                               Vazao_M.Text = ((values[14] / Convert.ToSingle(Fator_M.Text)) * 3600).ToString();
                                                                               Vazao_T.Text = ((values[24] / Convert.ToSingle(Fator_T.Text)) * 3600).ToString();

                                                                               Single vol = Convert.ToSingle(Vol_Tot_M.Text);
                                                                               Vol_Tot_M.Text = (values[13] / Convert.ToSingle(Fator_M.Text)).ToString();

                                                       */

                            //                           micros = values[0] + values[1] << 16;
                            //                           ResponseDisplayFunc3.Text += "Micros = " + micros + "\n";
                            /*
                                                        if (StartEnable && radioVolume.Checked)
                                                        {
                                                            if (Convert.ToSingle(Vol_Tot_M.Text) >= VolumeParada)
                                                            {
                                                                StartEnable = false;
                                                                PollingEnable = false;
                                                                timer_parada.Enabled = false;

                                                            }
                                                        }

                          for (int i = 0; i < 6;  i++) ver depois luan
                                {
                                    if (i == 5)
                                    {
                                        MediaVazaoM = MediaVazaoM + Convert.ToSingle(Vazao_M.Text);
                                        textBox3.Text = MediaVazaoM.ToString();                                             // talvez saia 

                                        Nvezes.Text = numAmostras2.ToString();
                                    }
                                    i++;
                                }
                                numAmostras2++;
                                if ( numAmostras2 == 4.0 )
                                {
                                    MediaVazaoM = MediaVazaoM /3;
                                    TxtVazaoM.Text = MediaVazaoM.ToString();
                                    MediaVazaoM = 0;
                                }

                            */

                        }
                    }
                }

                //Function 5 response
                if (responsecollect.Count == responseFunc5total)
                {
                    byte[] responseFunc5 = responsecollect.ToArray();
                    //Function Code Check
                    if (responseFunc5[1] == 5)
                    {
                        //CRC Check
                        //                        CRCcheck.Text = CRCResponseCheck(responseFunc5).ToString();
                    }
                }

                //Function 6 response
                if (responsecollect.Count == responseFunc16total)
                {
                    byte[] responseFunc6 = responsecollect.ToArray();
                    //Function Code Check
                    if (responseFunc6[1] == 6)
                    {
                        //CRC Check
                        //                        CRCcheck.Text = CRCResponseCheck(responseFunc16).ToString();
                    }
                }

                //Function 16 response
                if (responsecollect.Count == responseFunc16total)
                {
                    byte[] responseFunc16 = responsecollect.ToArray();
                    //Function Code Check
                    if (responseFunc16[1] == 16)
                    {
                        //CRC Check
                        //                        CRCcheck.Text = CRCResponseCheck(responseFunc16).ToString();
                    }
                }

            }));
        }

        private bool CRCResponseCheck(byte[] message)
        {

            //CRC Response Check:
            byte[] CRC = new byte[2];
            ushort CRCFull = 0xFFFF;
            byte CRCHigh = 0xFF, CRCLow = 0xFF;
            ushort CRCLSB;

            for (int i = 0; i < (message.Length) - 2; i++)
            {
                CRCFull = (ushort)(CRCFull ^ message[i]);

                for (int j = 0; j < 8; j++)
                {
                    CRCLSB = (ushort)(CRCFull & 0x0001);
                    CRCFull = (ushort)((CRCFull >> 1) & 0x7FFF);

                    if (CRCLSB == 1)
                        CRCFull = (ushort)(CRCFull ^ 0xA001);
                }
            }
            CRCHigh = (byte)((CRCFull >> 8) & 0xFF);
            CRCLow = (byte)(CRCFull & 0xFF);

            if (CRCLow == message[message.Length - 2] && CRCHigh == message[message.Length - 1])
                return true;
            else
                return false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen && PollingEnable) requestFunc4_Click(sender, e);
        }

        private void SendPulsosParada2() // _Click(object sender, EventArgs e)
        {
            //FUCTION 16
            byte Slave_Address = 1;
            byte Function = 16;
            ushort Starting_Address = 0;
            ushort NumberofRegisters = 1;
            byte Byte_Count;
            Byte_Count = (byte)(NumberofRegisters * 2);
            short[] values = new short[NumberofRegisters];
            //Fill Data1 and Data2
            short data1;
            //            if (!short.TryParse(this.Data1.Text, out data1)) data1 = 0;
            //            if (!short.TryParse(this.Data2.Text, out data2)) data2 = 0;
            data1 = (short)(Convert.ToSingle(Volume.Text) * Convert.ToSingle(Fator_M.Text));
            values[0] = data1;
            //            values[1] = data2;
            byte[] message = new byte[9 + 2 * NumberofRegisters];

            //index0 = Slave Address
            message[0] = Slave_Address;
            //index1 = Function
            message[1] = Function;
            //index2 = Starting Address Hi
            message[2] = (byte)(Starting_Address >> 8);
            //index3 = Starting Address Lo
            message[3] = (byte)Starting_Address;
            //index4 = Number of Registers Hi
            message[4] = (byte)(NumberofRegisters >> 8);
            //index5 = Number of Registers Lo
            message[5] = (byte)NumberofRegisters;
            //index6 = Byte Count
            message[6] = Byte_Count;
            for (int i = 0; i < NumberofRegisters; i++)
            {
                //Data Hi, index7 and index9
                message[7 + 2 * i] = (byte)(values[i] >> 8);
                //Data Lo, index8 and index10
                message[8 + 2 * i] = (byte)(values[i]);
            }

            // CRC (Cyclical Redundancy Check) Calculation
            ushort CRC = 0xFFFF;
            byte CRCHi = 0xFF;
            byte CRCLo = 0xFF;
            ushort CRCLSB;

            for (int i = 0; i < (message.Length) - 2; i++)
            {
                CRC = (ushort)(CRC ^ message[i]);

                for (int j = 0; j < 8; j++)
                {
                    CRCLSB = (ushort)(CRC & 0x0001);
                    CRC = (ushort)((CRC >> 1) & 0x7FFF);

                    if (CRCLSB == 1)
                        CRC = (ushort)(CRC ^ 0xA001);
                }
            }
            CRCHi = (byte)((CRC >> 8) & 0xFF);
            CRCLo = (byte)(CRC & 0xFF);

            //index11= CRC Lo
            message[message.Length - 2] = CRCLo;
            //index12 = CRC Hi
            message[message.Length - 1] = CRCHi;

            try
            {
                serialPort1.Write(message, 0, message.Length);
                responseFunc16total = 8;
                responsecollect.Clear();
                //                CRCcheck.Text = "";
            }
            catch (Exception err)
            {
                MessageBox.Show(this, err.Message);
            }
        }

        private void SendPulsosParada()
        {
            //FUCTION 16
            byte Slave_Address = 1;
            byte Function = 6;
            ushort Starting_Address = 0;
            short value;
            //Fill Data1 and Data2
            short data1;
            data1 = (short)(Convert.ToSingle(Volume.Text) * Convert.ToSingle(Fator_T.Text));

            //            if (!short.TryParse(this.Data1.Text, out data1)) data1 = 0;
            //            if (!short.TryParse(this.Data2.Text, out data2)) data2 = 0;
            value = data1;
            byte[] message = new byte[8];

            //index0 = Slave Address
            message[0] = Slave_Address;
            //index1 = Function
            message[1] = Function;
            //index2 = Starting Address Hi
            message[2] = (byte)(Starting_Address >> 8);
            //index3 = Starting Address Lo
            message[3] = (byte)Starting_Address;
            //Data Hi, index7 and index9
            message[4] = (byte)(value >> 8);
            //Data Lo, index8 and index10
            message[5] = (byte)(value);

            // CRC (Cyclical Redundancy Check) Calculation
            ushort CRC = 0xFFFF;
            byte CRCHi = 0xFF;
            byte CRCLo = 0xFF;
            ushort CRCLSB;

            for (int i = 0; i < (message.Length) - 2; i++)
            {
                CRC = (ushort)(CRC ^ message[i]);

                for (int j = 0; j < 8; j++)
                {
                    CRCLSB = (ushort)(CRC & 0x0001);
                    CRC = (ushort)((CRC >> 1) & 0x7FFF);

                    if (CRCLSB == 1)
                        CRC = (ushort)(CRC ^ 0xA001);
                }
            }
            CRCHi = (byte)((CRC >> 8) & 0xFF);
            CRCLo = (byte)(CRC & 0xFF);

            //index11= CRC Lo
            message[message.Length - 2] = CRCLo;
            //index12 = CRC Hi
            message[message.Length - 1] = CRCHi;

            try
            {
                serialPort1.Write(message, 0, message.Length);
                responseFunc6total = 8;
                responsecollect.Clear();
                //               CRCcheck.Text = "";
            }
            catch (Exception err)
            {
                MessageBox.Show(this, err.Message);
            }
        }


        private void ResetBtn_Click(object sender, EventArgs e)
        {
            //Function Code 03 / Read Holding Registers
            //           ResponseDisplayFunc3.Text = "";

            //Function 3 request is always 8 bytes
            byte[] message = new byte[8];
            byte Slave_Address = 1;
            byte Function = 5;
            ushort Starting_Address = 0;
            //            ushort Number_of_Points = 5;

            //index0 = Slave Address
            message[0] = Slave_Address;
            //index1 = Function
            message[1] = Function;

            //            if (!ushort.TryParse(this.Addr.Text, out Starting_Address))
            Starting_Address = 0;
            //index2 = Starting Address Hi
            message[2] = (byte)(Starting_Address >> 8);
            //index3 = Starting Address Lo
            message[3] = (byte)Starting_Address;
            //index4 = The status to write
            message[4] = (byte)0x0;
            //           if (Coil.Checked )  message[4] = (byte)0xFF;
            //index5 = The status to write
            message[5] = (byte)0x00;

            // CRC (Cyclical Redundancy Check) Calculation
            ushort CRC = 0xFFFF;
            byte CRCHi = 0xFF;
            byte CRCLo = 0xFF;
            ushort CRCLSB;

            for (int i = 0; i < (message.Length) - 2; i++)
            {
                CRC = (ushort)(CRC ^ message[i]);

                for (int j = 0; j < 8; j++)
                {
                    CRCLSB = (ushort)(CRC & 0x0001);
                    CRC = (ushort)((CRC >> 1) & 0x7FFF);

                    if (CRCLSB == 1)
                        CRC = (ushort)(CRC ^ 0xA001);
                }
            }
            CRCHi = (byte)((CRC >> 8) & 0xFF);
            CRCLo = (byte)(CRC & 0xFF);

            //index6 = CRC Lo
            message[message.Length - 2] = CRCLo;
            //index7 = CRC Hi
            message[message.Length - 1] = CRCHi;

            try
            {
                if (serialPort1.IsOpen)
                {
                    serialPort1.Write(message, 0, message.Length);
                    responseFunc5total = 8;
                    responsecollect.Clear();
                }
                else
                {
                    MessageBox.Show(this, "The Port is Closed, Please click Open Port Button");
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(this, err.Message);
            }

        }

        private void SendReset()
        {
            //Function Code 03 / Read Holding Registers
            //           ResponseDisplayFunc3.Text = "";

            //Function 3 request is always 8 bytes
            byte[] message = new byte[8];
            byte Slave_Address = 1;
            byte Function = 5;
            ushort Starting_Address = 0;
            //            ushort Number_of_Points = 5;

            //index0 = Slave Address
            message[0] = Slave_Address;
            //index1 = Function
            message[1] = Function;

            //            if (!ushort.TryParse(this.Addr.Text, out Starting_Address))
            Starting_Address = 0;
            //index2 = Starting Address Hi
            message[2] = (byte)(Starting_Address >> 8);
            //index3 = Starting Address Lo
            message[3] = (byte)Starting_Address;
            //index4 = The status to write
            message[4] = (byte)0xFF;
            //index5 = The status to write
            message[5] = (byte)0x00;

            // CRC (Cyclical Redundancy Check) Calculation
            ushort CRC = 0xFFFF;
            byte CRCHi = 0xFF;
            byte CRCLo = 0xFF;
            ushort CRCLSB;

            for (int i = 0; i < (message.Length) - 2; i++)
            {
                CRC = (ushort)(CRC ^ message[i]);

                for (int j = 0; j < 8; j++)
                {
                    CRCLSB = (ushort)(CRC & 0x0001);
                    CRC = (ushort)((CRC >> 1) & 0x7FFF);

                    if (CRCLSB == 1)
                        CRC = (ushort)(CRC ^ 0xA001);
                }
            }
            CRCHi = (byte)((CRC >> 8) & 0xFF);
            CRCLo = (byte)(CRC & 0xFF);

            //index6 = CRC Lo
            message[message.Length - 2] = CRCLo;
            //index7 = CRC Hi
            message[message.Length - 1] = CRCHi;

            try
            {
                if (serialPort1.IsOpen)
                {
                    serialPort1.Write(message, 0, message.Length);
                    responseFunc5total = 8;
                    responsecollect.Clear();
                }
                else
                {
                    MessageBox.Show(this, "The Port is Closed, Please click Open Port Button");
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(this, err.Message);
            }

        }


        private void SendModo()
        {
            //Function Code 03 / Read Holding Registers
            //           ResponseDisplayFunc3.Text = "";

            //Function 3 request is always 8 bytes
            byte[] message = new byte[8];
            byte Slave_Address = 1;
            byte Function = 5;
            ushort Starting_Address = 1;
            //            ushort Number_of_Points = 5;

            //index0 = Slave Address
            message[0] = Slave_Address;
            //index1 = Function
            message[1] = Function;

            //            if (!ushort.TryParse(this.Addr.Text, out Starting_Address))
            Starting_Address = 1;
            //index2 = Starting Address Hi
            message[2] = (byte)(Starting_Address >> 8);
            //index3 = Starting Address Lo
            message[3] = (byte)Starting_Address;
            //index4 = The status to write
            message[4] = (byte)0xFF;
            //index5 = The status to write
            message[5] = (byte)0x00;

            // CRC (Cyclical Redundancy Check) Calculation
            ushort CRC = 0xFFFF;
            byte CRCHi = 0xFF;
            byte CRCLo = 0xFF;
            ushort CRCLSB;

            for (int i = 0; i < (message.Length) - 2; i++)
            {
                CRC = (ushort)(CRC ^ message[i]);

                for (int j = 0; j < 8; j++)
                {
                    CRCLSB = (ushort)(CRC & 0x0001);
                    CRC = (ushort)((CRC >> 1) & 0x7FFF);

                    if (CRCLSB == 1)
                        CRC = (ushort)(CRC ^ 0xA001);
                }
            }
            CRCHi = (byte)((CRC >> 8) & 0xFF);
            CRCLo = (byte)(CRC & 0xFF);

            //index6 = CRC Lo
            message[message.Length - 2] = CRCLo;
            //index7 = CRC Hi
            message[message.Length - 1] = CRCHi;

            try
            {
                if (serialPort1.IsOpen)
                {
                    serialPort1.Write(message, 0, message.Length);
                    responseFunc5total = 8;
                    responsecollect.Clear();
                }
                else
                {
                    MessageBox.Show(this, "The Port is Closed, Please click Open Port Button");
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(this, err.Message);
            }

        }

        private void SendStop()
        {
            //Function Code 03 / Read Holding Registers
            //           ResponseDisplayFunc3.Text = "";

            //Function 3 request is always 8 bytes
            byte[] message = new byte[8];
            byte Slave_Address = 1;
            byte Function = 5;
            ushort Starting_Address = 0;
            //            ushort Number_of_Points = 5;

            //index0 = Slave Address
            message[0] = Slave_Address;
            //index1 = Function
            message[1] = Function;

            //            if (!ushort.TryParse(this.Addr.Text, out Starting_Address))
            Starting_Address = 0;
            //index2 = Starting Address Hi
            message[2] = (byte)(Starting_Address >> 8);
            //index3 = Starting Address Lo
            message[3] = (byte)Starting_Address;
            //index4 = The status to write
            message[4] = (byte)0x00;
            //index5 = The status to write
            message[5] = (byte)0x00;

            // CRC (Cyclical Redundancy Check) Calculation
            ushort CRC = 0xFFFF;
            byte CRCHi = 0xFF;
            byte CRCLo = 0xFF;
            ushort CRCLSB;

            for (int i = 0; i < (message.Length) - 2; i++)
            {
                CRC = (ushort)(CRC ^ message[i]);

                for (int j = 0; j < 8; j++)
                {
                    CRCLSB = (ushort)(CRC & 0x0001);
                    CRC = (ushort)((CRC >> 1) & 0x7FFF);

                    if (CRCLSB == 1)
                        CRC = (ushort)(CRC ^ 0xA001);
                }
            }
            CRCHi = (byte)((CRC >> 8) & 0xFF);
            CRCLo = (byte)(CRC & 0xFF);

            //index6 = CRC Lo
            message[message.Length - 2] = CRCLo;
            //index7 = CRC Hi
            message[message.Length - 1] = CRCHi;

            try
            {
                if (serialPort1.IsOpen)
                {
                    serialPort1.Write(message, 0, message.Length);
                    responseFunc5total = 8;
                    responsecollect.Clear();
                }
                else
                {
                    MessageBox.Show(this, "The Port is Closed, Please click Open Port Button");
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(this, err.Message);
            }

        }

        private void SendModo2()
        {
            //Function Code 03 / Read Holding Registers
            //           ResponseDisplayFunc3.Text = "";

            //Function 3 request is always 8 bytes
            byte[] message = new byte[8];
            byte Slave_Address = 1;
            byte Function = 5;
            ushort Starting_Address = 1;
            //            ushort Number_of_Points = 5;

            //index0 = Slave Address
            message[0] = Slave_Address;
            //index1 = Function
            message[1] = Function;

            //            if (!ushort.TryParse(this.Addr.Text, out Starting_Address))
            Starting_Address = 0;
            //index2 = Starting Address Hi
            message[2] = (byte)(Starting_Address >> 8);
            //index3 = Starting Address Lo
            message[3] = (byte)Starting_Address;
            //index4 = The status to write
            //            message[4] = (byte)0x00;
            //            if ( radioVolume.Checked )
            message[4] = (byte)0xFF;
            //index5 = The status to write
            message[5] = (byte)0x00;

            // CRC (Cyclical Redundancy Check) Calculation
            ushort CRC = 0xFFFF;
            byte CRCHi = 0xFF;
            byte CRCLo = 0xFF;
            ushort CRCLSB;

            for (int i = 0; i < (message.Length) - 2; i++)
            {
                CRC = (ushort)(CRC ^ message[i]);

                for (int j = 0; j < 8; j++)
                {
                    CRCLSB = (ushort)(CRC & 0x0001);
                    CRC = (ushort)((CRC >> 1) & 0x7FFF);

                    if (CRCLSB == 1)
                        CRC = (ushort)(CRC ^ 0xA001);
                }
            }
            CRCHi = (byte)((CRC >> 8) & 0xFF);
            CRCLo = (byte)(CRC & 0xFF);

            //index6 = CRC Lo
            message[message.Length - 2] = CRCLo;
            //index7 = CRC Hi
            message[message.Length - 1] = CRCHi;

            try
            {
                if (serialPort1.IsOpen)
                {
                    serialPort1.Write(message, 0, message.Length);
                    responseFunc5total = 8;
                    responsecollect.Clear();
                }
                else
                {
                    MessageBox.Show(this, "The Port is Closed, Please click Open Port Button");
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(this, err.Message);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        { }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            // por a opção de faixa de medição aqui.




            String perc;

            perc = Percentual.SelectedItem.ToString();
            if (faixaM.Text == "1:10")
            {
                if (perc == "25 %") perc = "20 %";
                if (perc == "40 %") perc = "30 %";
                if (perc == "70 %") perc = "50 %";
                if (perc == "100 %") perc = "70 %";
            }

            if (faixaM.Text == "1:20")
            {
                if (perc == "5 %") perc = "10 %";
                if (perc == "25 %") perc = "20 %";
                if (perc == "40 %") perc = "30 %";
                if (perc == "70 %") perc = "50 %";
                if (perc == "100 %") perc = "70 %";
            }

            if (faixaM.Text == "1:30")
            {
                if (perc == "3 %") perc = "10 %";
                if (perc == "25 %") perc = "20 %";
                if (perc == "40 %") perc = "30 %";
                if (perc == "70 %") perc = "50 %";
                if (perc == "100 %") perc = "70 %";
            }

            if (faixaM.Text == "1:50")
            {
                if (perc == "2 %") perc = "10 %";
                if (perc == "5 %") perc = "20 %";
                if (perc == "15 %") perc = "30 %";
                if (perc == "25 %") perc = "50 %";
                if (perc == "70 %") perc = "70 %";

            }

            string[] words = perc.Split(' ');
            //MessageBox.Show("Percentual=" + words[0]);
            GroupMaster.Controls["Fator_M" + words[0]].Text = Fator_M.Text;
            GroupMaster.Controls["Pulso_Min_M" + words[0]].Text = Pulso_Min_M.Text;
            GroupMaster.Controls["Vol_Tot_M" + words[0]].Text = Vol_Tot_M.Text;
            GroupMaster.Controls["Pulso_Tot_M" + words[0]].Text = Pulso_Tot_M.Text;
            GroupMaster.Controls["Temp_M" + words[0]].Text = Temp_M.Text;
            GroupMaster.Controls["Pres_M" + words[0]].Text = Pres_M.Text;
            GroupMaster.Controls["Vazao_M" + words[0]].Text = Vazao_M.Text;
            GroupMaster.Controls["Erro_" + words[0]].Text = textBox2.Text;
           


            GroupTeste.Controls["Fator_T" + words[0]].Text = Fator_T.Text;
            GroupTeste.Controls["Pulso_Min_T" + words[0]].Text = Pulso_Min_T.Text;
            GroupTeste.Controls["Vol_Tot_T" + words[0]].Text = Vol_Tot_T.Text;
            GroupTeste.Controls["Pulso_Tot_T" + words[0]].Text = Pulso_Tot_T.Text;
            GroupTeste.Controls["Temp_T" + words[0]].Text = Temp_T.Text;
            GroupTeste.Controls["Pres_T" + words[0]].Text = Pres_T.Text;
            GroupTeste.Controls["Vazao_T" + words[0]].Text = Vazao_T.Text;


            /*
                        if (radioVolume.Checked)
                        {
                            if ( Convert.ToUInt32( Vol_Tot_M.Text) >= VolumeParada )
                            {
                                StartEnable = false;
                                PollingEnable = false;
                                timer_parada.Enabled = false;

                            }
                        }
            */
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            MediaPresM = 0;
            MediaTempM = 0;
            MediaPresT = 0;
            MediaTempT = 0;
            /*           if ( radioTempo.Checked ) 
                        {
                            string YourString = Tempo.Text;

                            var hours = Int32.Parse(YourString.Split(':')[0]);numAmostras
                            var minutes = Int32.Parse(YourString.Split(':')[1]);

                            TempoRestante = hours * 3600 + minutes * 60;
                            timer_parada.Enabled = true;
                        }
            */
            //            if (radioVolume.Checked)
            {
                PollingEnable = false;
                SendPulsosParada();
                Thread.Sleep(500);
                SendModo();
                Thread.Sleep(500);
                VolumeParada = Convert.ToUInt32(Volume.Text);
            }
            Vol_Tot_M.Text = "0";
            StartEnable = true;
            PollingEnable = true;
            SendReset();
            Thread.Sleep(500);
            StatusLabel.Text = "Rodando";
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            StartEnable = false;
            PollingEnable = true;
            Thread.Sleep(500);
            SendStop();
            Thread.Sleep(500);
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void timer_parada_Tick(object sender, EventArgs e)
        {
            TempoRestante--;
            Restante.Text = TempoRestante.ToString();
            if (TempoRestante <= 0)
            {
                StartEnable = false;
                PollingEnable = false;
                timer_parada.Enabled = false;

                // ve se vai parar e mostrar o erro relativo

            }

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            //            Tempo.Enabled = true;
            Volume.Enabled = false;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            //           Tempo.Enabled = false;
            Volume.Enabled = true;
        }
        /*
                public static bool IsValidTime(this TextBox textBox)
                {
                    string text = textBox.Text;
                    string[] textParts = GetParts(text);
                    if (textParts.Length != 2) return false;
                    string hourString = textParts[0];
                    string minuteString = textParts[1];

                    int hour, minute;
                    if (int.TryParse(hourString, out hour))
                    {
                        if (int.TryParse(minuteString, out minute))
                        {
                            if (isMinute(minute) && IsHour(hour)) return true;
                            else return false;
                        }
                        else return false;
                    }
                    else return false;
                }

                private static bool isMinute(int minute)
                {
                    return ((minute >= 0) && (minute< 60));
                }

                private static bool IsHour(int hour)
                {
                    return ((hour >= 0) && (hour< 24));
                }

                private static string[] GetParts(string text)
                {
                    return text.Split(':');
                }
        */
        private void Tempo_Validating(object sender, CancelEventArgs e)
        {
            TextBox box = sender as TextBox;
            string pattern = "\\d{1,2}:\\d{2}";
            if (box != null)
            {
                if (!Regex.IsMatch(box.Text, pattern, RegexOptions.CultureInvariant))
                {
                    MessageBox.Show("Formato de hora inválida ('hh:mm').");
                    e.Cancel = true;
                    box.Select(0, box.Text.Length);
                }
            }

        }

        private void Fator_M_Validating(object sender, CancelEventArgs e)
        {
            float temp;
            TextBox box = sender as TextBox;
            if (float.TryParse(box.Text.ToString(), out temp))// get initial temp (converts string representation of number to float)
            {
                if (temp <= 0)
                {
                    e.Cancel = true;
                    box.Select(0, box.Text.Length);
                    MessageBox.Show("Fator K deve ser maior que zero.");

                }
            }
            else //if something other than a number entered
            {
                e.Cancel = true;
                box.Select(0, box.Text.Length);
                MessageBox.Show("Valor inválido. Deve ser inteiro ou float maior que zero.");
            }

        }

        private void Fator_T_Validating(object sender, CancelEventArgs e)
        {

            float temp;
            TextBox box = sender as TextBox;
            if (float.TryParse(box.Text.ToString(), out temp))// get initial temp (converts string representation of number to float)
            {
                if (temp <= 0)
                {
                    e.Cancel = true;
                    box.Select(0, box.Text.Length);
                    MessageBox.Show("Fator K deve ser maior que zero.");

                }
            }
            else //if something other than a number entered
            {
                e.Cancel = true;
                box.Select(0, box.Text.Length);
                MessageBox.Show("Valor inválido. Deve ser inteiro ou float maior que zero.");
            }

        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            SendPulsosParada();
        }

        private void button2_Click_2(object sender, EventArgs e)
        {
            SendModo();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label32_Click(object sender, EventArgs e)
        {

        }

        private void timer_corrida_Tick(object sender, EventArgs e)
        {
            String segundo, minuto, hora;
            TempoCorrida++;
            segundo = String.Format("{0:D2}", TempoCorrida % 60);
            minuto = String.Format("{0:D2}", (TempoCorrida / 60) % 60);
            hora = (TempoCorrida / 3600).ToString();
            TempoLabel.Text = "Tempo corrido: " + hora + ":" + minuto + ":" + segundo;
        }

        private void fichaTécnicaToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Ficha f = new Ficha();

            f.ShowDialog(this);

            Cliente = f.txtcliente.Text; Operador = f.txtoperador.Text; endereco = f.txtendere.Text; data = f.txtdata.Text;
            tipoM = f.txttipoM.Text; desigM = f.txtdesigM.Text; fabriM = f.txtfabriM.Text;
            fabriT = f.txtfabriT.Text; modeloM = f.txtmodeloM.Text; modeloT = f.txtmodeloT.Text; diameM = f.txtdiamM.Text; diameT = f.txtdiamT.Text;
            nserieM = f.txtnserieM.Text; nserieT = f.txtnserieT.Text; txtpadrao1 = f.txtpadrao1.Text; txtpadrao2 = f.txtpadrao2.Text;
            txtpadrao3 = f.txtpadrao3.Text; instrucao = f.txtinstru.Text; descriçao = f.txtdescri.Text; umi = f.txtumi.Text; temp = f.txttemp.Text;
            press = f.txtpress.Text; fluido = f.txtfuido.Text; anodefrabicao = f.txtanodefrabri.Text; padrao4 = f.txtpadrao4.Text;

        }

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {

            AboutBox1 a = new AboutBox1();
            a.Show();
        }

        private void comunicaçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CommConfig a = new CommConfig();
            a.Show();

        }

        private void aferiçaçãoDeVazãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Regula a = new Regula();
            a.Show();

        }

        private void label25_Click(object sender, EventArgs e)
        {

        }

        private void Volume_TextChanged(object sender, EventArgs e)
        {

        }

        private void Vol_Tot_T_TextChanged(object sender, EventArgs e)
        {

        }

        private void Vol_Tot_M_TextChanged(object sender, EventArgs e)
        {

        }

        private void Fator_M_TextChanged(object sender, EventArgs e)
        {

        }

        private void Percentual_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void faixaM_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (faixaM.Text == "1:10")
            {
                label25.Text = "10%";   label33.Text = "Erro 10%";
                label24.Text = "25%";   label34.Text = "Erro 25%";
                label23.Text = "40%";   label35.Text = "Erro 40%";
                label22.Text = "70%";   label36.Text = "Erro 70%";
                label21.Text = "100%";  label37.Text = "Erro 100%";
                label20.Text = "";      label38.Text = "";
                label19.Text = "10%";
                label18.Text = "25%";
                label14.Text = "40%";
                label13.Text = "70%";
                label12.Text = "100%";
                label11.Text = "";


                Percentual.Items.Clear();
                Percentual.Items.Add("10 %");
                Percentual.Items.Add("25 %");
                Percentual.Items.Add("40 %");
                Percentual.Items.Add("70 %");
                Percentual.Items.Add("100 %");


            }
            if (faixaM.Text == "1:20")
            {
                label25.Text = "5%";   label33.Text = "Erro 5%";
                label24.Text = "25%";  label34.Text = "Erro 25%";
                label23.Text = "40%";  label35.Text = "Erro 40%";
                label22.Text = "70%";  label36.Text = "Erro 70%";
                label21.Text = "100%"; label37.Text = "Erro 100%";
                label20.Text = "";     label38.Text = "";
                label19.Text = "5%";
                label18.Text = "25%";
                label14.Text = "40%";
                label13.Text = "70%";
                label12.Text = "100%";
                label11.Text = "";

                Percentual.Items.Clear();
                Percentual.Items.Add("5 %");
                Percentual.Items.Add("25 %");
                Percentual.Items.Add("40 %");
                Percentual.Items.Add("70 %");
                Percentual.Items.Add("100 %");
            }
            if (faixaM.Text == "1:30")
            {
                label25.Text = "3 %";    label33.Text = "Erro 3 %";
                label24.Text = "25 %";   label34.Text = "Erro 25 %";
                label23.Text = "40 %";   label35.Text = "Erro 40 %";
                label22.Text = "70 %";   label36.Text = "Erro 70 %";
                label21.Text = "100 %";  label37.Text = "Erro 100 %";
                label20.Text = "";       label38.Text = "";
                label19.Text = "3 %";
                label18.Text = "25 %";
                label14.Text = "40 %";
                label13.Text = "70 %";
                label12.Text = "100 %";
                label11.Text = "";

                Percentual.Items.Clear();
                Percentual.Items.Add("3 %");
                Percentual.Items.Add("25 %");
                Percentual.Items.Add("40 %");
                Percentual.Items.Add("70 %");
                Percentual.Items.Add("100 %");
            }
            if (faixaM.Text == "1:50")
            {
                label25.Text = "2%";    label33.Text = "Erro 2%";
                label24.Text = "5%";    label34.Text = "Erro 5%";
                label23.Text = "15%";   label35.Text = "Erro 15%";
                label22.Text = "25%";   label36.Text = "Erro 25%";
                label21.Text = "70%";   label37.Text = "Erro 70%";
                label20.Text = "100%";  label38.Text = "Erro 100%";
                label19.Text = "2%";
                label18.Text = "5%";
                label14.Text = "15%";
                label13.Text = "25%";
                label12.Text = "70%";
                label11.Text = "100";
                Percentual.Items.Clear();
                Percentual.Items.Add("2 %");
                Percentual.Items.Add("5 %");
                Percentual.Items.Add("15 %");
                Percentual.Items.Add("25 %");
                Percentual.Items.Add("70 %");
                Percentual.Items.Add("100 %");


            }


        }

        private void textBox39_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click_3(object sender, EventArgs e)
        {
            double q = 0.0;
            double w = 0.0;
            double j = 0.0;


            q = double.Parse(Qmax.Text);

            if (faixaM.Text == "1:10") w = (0.1);
            else
            if (faixaM.Text == "1:20") w = (0.05);
            else
            if (faixaM.Text == "1:30") w = (0.03);
            else
            if (faixaM.Text == "1:50") w = (0.02);

            j = (q * w);

            Qmin.Text = (j).ToString();

            if (faixaM.Text == "1:10" || faixaM.Text == "1:20")
                Qt.Text = ((double)q * 0.2).ToString();

            if (faixaM.Text == "1:30" || faixaM.Text == "1:50")
                Qt.Text = ((double)q * 0.15).ToString();


        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            /*double k = 0.0;
            for( int i = 1; i <= 3; i++)
            {
                StartEnable = true;
                
                SendPulsosParada();

                k += Convert.ToDouble(Vazao_M.Text);

                StartEnable = false;
               
            }
                        
            k = (k / 3);
            TxtVazaoM.Text = Convert.ToString(k);
            SendStop(); */

            TxtVazaoM.Text = MediaVazaoM.ToString();

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ErrorR_TextChanged(object sender, EventArgs e)
        {
        }

        private void button1_Click_3(object sender, EventArgs e)
        {
            Relatorio imprimirDadosRelatorio = new Relatorio(Qmin.Text, Qmax.Text,txtpadrao2,txtpadrao3,Cliente,endereco,data,dataemissao,tipoM,diameM, anodefrabicao, instrucao
                ,desigM, descriçao,fluido,temp,press,umi,txtpadrao1,modeloM,fabriM,nserieM,padrao4,modeloT,fabriT,nserieT,Operador,Fator_M.Text, label20.Text, label21.Text
                , label22.Text, label23.Text, label24.Text, label25.Text, Vazao_M100.Text, Vazao_M70.Text, Vazao_M50.Text, Vazao_M30.Text, Vazao_M20.Text, Vazao_M10.Text
                , Vazao_T100.Text, Vazao_T70.Text, Vazao_T50.Text, Vazao_T30.Text, Vazao_T20.Text, Vazao_T10.Text, Vol_Tot_M100.Text, Vol_Tot_M70.Text, Vol_Tot_M50.Text
                , Vol_Tot_M30.Text, Vol_Tot_M20.Text, Vol_Tot_M10.Text, Vol_Tot_T100.Text, Vol_Tot_T70.Text, Vol_Tot_T50.Text, Vol_Tot_T30.Text, Vol_Tot_T20.Text, Vol_Tot_T10.Text
                , Erro_100.Text, Erro_70.Text, Erro_50.Text, Erro_30.Text, Erro_20.Text, Erro_10.Text);

                        
            imprimirDadosRelatorio.Show();
            chart1.Printing.PrintPreview();
           

            /*label20.Text, label21.Text
                , label22.Text, label23.Text, label24.Text, label25.Text, Vazao_M100.Text, Vazao_M70.Text, Vazao_M50.Text, Vazao_M30.Text, Vazao_M20.Text, Vazao_M10.Text
                , Vazao_T100.Text, Vazao_T70.Text, Vazao_T50.Text, Vazao_T30.Text, Vazao_T20.Text, Vazao_T10.Text, Vol_Tot_M100.Text, Vol_Tot_M70.Text, Vol_Tot_M50.Text
                , Vol_Tot_M30.Text, Vol_Tot_M20.Text, Vol_Tot_M10.Text, Vol_Tot_T100.Text, Vol_Tot_T70.Text, Vol_Tot_T50.Text, Vol_Tot_T30.Text, Vol_Tot_T20.Text, Vol_Tot_T10.Text
                , Erro_100.Text, Erro_70.Text, Erro_50.Text, Erro_30.Text, Erro_20.Text, Erro_10.Text*/

            /*Cliente = f.txtcliente.Text; Operador = f.txtoperador.Text; endereco = f.txtendere.Text; data = f.txtdata.Text;
            tipoM = f.txttipoM.Text; tipoT = f.txttipoT.Text; desigM = f.txtdesigM.Text; desigT = f.txtdesigT.Text; fabriM = f.txtfabriM.Text;
            fabriT = f.txtfabriT.Text; modeloM = f.txtmodeloM.Text; modeloT = f.txtmodeloT.Text; diameM = f.txtdiamM.Text; diameT = f.txtdiamT.Text;
            nserieM = f.txtnserieM.Text; nserieT = f.txtnserieT.Text; txtpadrao1 = f.txtpadrao1.Text; txtpadrao2 = f.txtpadrao2.Text;
            txtpadrao3 = f.txtpadrao3.Text; instrucao = f.txtinstru.Text; descriçao = f.txtdescri.Text; umi = f.txtumi.Text; temp = f.txttemp.Text;
            press = f.txtpress.Text; fluido = f.txtfuido.Text;*/

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }


        // funçao de repitibilidade teste
        /* public void RepetibilidadeErro()
          {

           double Soma_Erros;
              this.ErroRep = new double[5];

              /*VazaoRep[0] = 0;
              VazaoRep[1] = 0;
              VazaoRep[2] = 0;
              VazaoRep[3] = 0;
              VazaoRep[4] = 0;

              ErroRep[0] = 0;
              ErroRep[1] = 0;
              ErroRep[2] = 0;
              ErroRep[3] = 0;
              ErroRep[4] = 0;

              Soma_Erros = 0;

              for (int i = 0; i <= 5; i++ ){
                  //Calc_Volume_Real
                  //VazaoRep(i) = VT_Real
                  //Calculo_do_Erro
                  ErroRep[i] = (((Convert.ToSingle(Vazao_T.Text) - Convert.ToSingle(Vazao_M.Text)) / Convert.ToSingle(Vazao_M.Text)) * 100);
                  //  Convert.ToDouble(ErrorR.Text);
                  Soma_Erros = Soma_Erros + ErroRep[i];
                  if (i == 5) MessageBox.Show(i.ToString());

              }
              double MediaError2 = Soma_Erros / 5;

                                  }
  */
    }
}


