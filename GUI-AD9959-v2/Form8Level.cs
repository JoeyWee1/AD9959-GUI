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
    public partial class Form8Level : Form
    {
        private SerialPort serialPort;
        public Form8Level(SerialPort port)
        {
            serialPort = port;
            InitializeComponent();
        }

        private void Form8Level_Load(object sender, EventArgs e)
        {

            // Set up the DataGridView for 4 profiles
            dataGridProfile.ColumnCount = 2;
            dataGridProfile.Columns[0].Name = "Profile";
            dataGridProfile.Columns[1].Name = "Frequency (Hz)";


            //

            for (int i = 0; i < 8; i++)
            {
                dataGridProfile.Rows.Add(i, 10000000 + 10000000 * i);
                dataGridProfile.Rows.Add(i, 10000000 + 10000000 * i);
            }
        }
    }
}
