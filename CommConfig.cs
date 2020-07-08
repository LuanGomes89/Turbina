using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO.Ports;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleModBusforPLC
{
    public partial class CommConfig : Form
    {

        public string RegisterQty = "8";
        public string SampleRate = "1000";
        public string SlaveID = "1";
        public string StartAddr = "0";
        public string Porta = "";
        public string Baudrate = "9600";
        public string DataType = "9600";
        public int numPorts = 0;

        public CommConfig()
        {
            InitializeComponent();
        }


        public string _txtStartAddr()
        {
            return txtStartAddr.Text;
        }

        #region Load Listboxes
        public void LoadListboxes()
        {
            //Three to load - ports, baudrates, datetype.  Also set default textbox values:
            //1) Available Ports:
            string[] ports = SerialPort.GetPortNames();

            numPorts = ports.Length;
            if (ports.Length == 0) return;
            foreach (string port in ports)
            {
                lstPorts.Items.Add(port);
            }

            lstPorts.SelectedIndex = 0;
            Porta = lstPorts.SelectedItem.ToString();

            //2) Baudrates:
            string[] baudrates = { "230400", "115200", "57600", "38400", "19200", "9600" };

            foreach (string baudrate in baudrates)
            {
                lstBaudrate.Items.Add(baudrate);
            }

            lstBaudrate.SelectedIndex = 5;

            //3) Datatype:
            string[] dataTypes = { "Decimal", "Hexadecimal", "Float", "Reverse" };

            foreach (string dataType in dataTypes)
            {
                lstDataType.Items.Add(dataType);
            }

            lstDataType.SelectedIndex = 0;

            //Textbox defaults:
            txtRegisterQty.Text = "8";
            txtSampleRate.Text = "500";
            txtSlaveID.Text = "1";
            txtStartAddr.Text = "0";
            RegisterQty = "8";
            SampleRate = "500";
            SlaveID = "1";
            StartAddr = "0";
            Porta = lstPorts.SelectedItem.ToString();
            Baudrate = "9600";
            DataType = lstDataType.SelectedItem.ToString();

        }
    #endregion

    private void CommConfig_Load(object sender, EventArgs e)
        {
            LoadListboxes();
        }

        private void LstPorts_SelectedIndexChanged(object sender, EventArgs e)
        {
            Porta = lstPorts.SelectedItem.ToString();
        }

        private void LstBaudrate_SelectedIndexChanged(object sender, EventArgs e)
        {
            Baudrate = lstBaudrate.SelectedItem.ToString();
        }

        private void LstDataType_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataType = lstDataType.SelectedItem.ToString();
        }

        private void TxtSampleRate_TextChanged(object sender, EventArgs e)
        {
            SampleRate = txtSampleRate.Text;
        }
    }
}
