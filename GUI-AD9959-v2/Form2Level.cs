using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_AD9959_16Levels
{
    public partial class Form2Level : Form
    {
        private SerialPort serialPort;
        public Form2Level(SerialPort port)
        {
            InitializeComponent();
            serialPort = port;
        }

        private void Form2Level_Load(object sender, EventArgs e)
        {

        }
    }
}
