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
    public partial class Form16Level : Form
    {
        private SerialPort serialPort;
        public Form16Level(SerialPort port)
        {
            InitializeComponent();
            serialPort = port;
        }

        private void Form16Level_Load(object sender, EventArgs e)
        {
            // Populate the profile selector with numbers 0 to 15:
            for (int i = 0; i < 16; i++)
            {
                comboBoxProfileSelect.Items.Add(i);
            }

            // Set the default selected profile to 0
            comboBoxProfileSelect.SelectedIndex = 0;

            // Set up the DataGridView for 16 profiles
            dataGridProfile.ColumnCount = 2;
            dataGridProfile.Columns[0].Name = "Profile";
            dataGridProfile.Columns[1].Name = "Frequency (Hz)";

            for (int i = 0; i < 16; i++)
            {
                dataGridProfile.Rows.Add(i, 10000000 + 10000000 * i);
            }
        }
        private void buttonSend_Click(object sender, EventArgs e)
        {
            if (serialPort != null && serialPort.IsOpen)
            {
                //Build the command:
                List<string> freqs = new List<string>();
                foreach (DataGridViewRow row in dataGridProfile.Rows)
                {
                    if (!row.IsNewRow)
                    {
                        var cellValue = row.Cells[1].Value?.ToString().Trim();
                        if (!string.IsNullOrEmpty(cellValue))
                        {
                            freqs.Add(cellValue);
                        }
                    }
                }
                string command = $"PROFILES16,{string.Join(",", freqs)}";
                //string command = $"PROFILES,{15000000}"; //TEST
                //serialPort.NewLine = "\n";  // Match what Serial Monitor uses
                //serialPort.Write(command + "\n"); // Explicitly send just LF

                serialPort.WriteLine(command);

                labelStatus.Text = "Profiles sent successfully.";
                MessageBox.Show("Frequencies sent: " + command); // Show a message box indicating successful sending

        }
            else
            {
                labelStatus.Text = "Serial port is not open.";
                MessageBox.Show("Please open the serial port before sending profiles.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonActivate_Click(object sender, EventArgs e)
        {
            if (serialPort != null && serialPort.IsOpen)
            {
                // Get the selected profile index
                int selectedProfile = int.Parse(comboBoxProfileSelect.SelectedItem.ToString());
                labelStatus.Text = $"Activated Profile {selectedProfile}";
                string activate = $"ACTIVATE16,{selectedProfile}";
                serialPort.WriteLine(activate);
            }
            else
            {
                labelStatus.Text = "Serial port is not open.";
                MessageBox.Show("Please open the serial port before activating a profile.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void buttonPLL_Click(object sender, EventArgs e)
        {
            if (serialPort != null && serialPort.IsOpen)
            {
                // Send the PLL command
                int pllValue = (int)numericUpDownPLL.Value; // Get the PLL value from the NumericUpDown control
                string pllCommand = "PLL16," + pllValue; // Assuming 1 is the command to enable PLL
                serialPort.WriteLine(pllCommand);
                labelStatus.Text = $"PLL multiplier set: x{pllValue}";
            }
            else
            {
                MessageBox.Show("Please open the serial port before sending PLL command.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonSendMonotone_Click(object sender, EventArgs e)
        {
            if (serialPort != null && serialPort.IsOpen)
            {
                // Build the command for monotone frequency
                int f1 = (int)numericUpDownCH1.Value; // Get the frequency from the NumericUpDown control
                int f2 = (int)numericUpDownCH2.Value; // Get the frequency from the NumericUpDown control
                int f3 = (int)numericUpDownCH3.Value; // Get the frequency from the NumericUpDown control
                string command = $"MONOFREQ16,{f1},{f2},{f3}";
                serialPort.WriteLine(command);
                labelStatus.Text = $"Monotone frequency set to {f1}, {f2}, {f3} Hz.";
            }
            else
            {
                MessageBox.Show("Please open the serial port before sending monotone frequency.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonREFCLK_Click(object sender, EventArgs e)
        {
            if (serialPort != null && serialPort.IsOpen)
            {
                // Send the REFCLK command
                int refclkValue = (int)numericUpDownREFCLK.Value; // Get the REFCLK value from the NumericUpDown control
                labelStatus.Text = $"REFCLK set to {refclkValue} Hz.";
            }
            else
            {
                MessageBox.Show("Please open the serial port before sending REFCLK command.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void numericUpDownPLL_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
