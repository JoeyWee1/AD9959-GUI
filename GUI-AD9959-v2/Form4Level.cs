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
    public partial class Form4Level : Form
    {
        private SerialPort serialPort;
        public Form4Level(SerialPort port)
        {
            InitializeComponent();
            serialPort = port;
        }

        private void Form4Level_Load(object sender, EventArgs e)
        {


            // Set up the DataGridView for 4 profiles
            dataGridProfile0.ColumnCount = 2;
            dataGridProfile0.Columns[0].Name = "Profile";
            dataGridProfile0.Columns[1].Name = "Frequency (Hz)";

            dataGridProfile1.ColumnCount = 2;
            dataGridProfile1.Columns[0].Name = "Profile";
            dataGridProfile1.Columns[1].Name = "Frequency (Hz)";
            //

            for (int i = 0; i < 4; i++)
            {
                dataGridProfile0.Rows.Add(i, 10000000 + 10000000 * i);
                dataGridProfile1.Rows.Add(i, 10000000 + 10000000 * i);
            }
        }

        private void buttonPLL_Click(object sender, EventArgs e)
        {

        }
    }
}
