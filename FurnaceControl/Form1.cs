using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.Globalization;


namespace FurnaceControl
{
    public partial class Form1 : Form
    {

        SerialPort port;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void onButton_Click(object sender, EventArgs e)
        {
            port.Open();
            // \x0201010WWRD0121,01,0001\x03
            port.Write(Int32.Parse("02", NumberStyles.HexNumber) + "01010WWRD0121,01,0001" + Int32.Parse("02", NumberStyles.HexNumber) +Int32.Parse("0D", NumberStyles.HexNumber) ) ;
            port.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            port = new SerialPort("COM1", 9600, Parity.Even, 8, StopBits.One);
        }

        private void offButton_Click(object sender, EventArgs e)
        {
            port.Open();
            // \x0201010WWRD0121,01,0000\x03

            port.Write(Int32.Parse("02", NumberStyles.HexNumber) + "01010WWRD0121,01,0000" + Int32.Parse("02", NumberStyles.HexNumber) +Int32.Parse("0D", NumberStyles.HexNumber) ) ;
            port.Close();
        }
    }
}
