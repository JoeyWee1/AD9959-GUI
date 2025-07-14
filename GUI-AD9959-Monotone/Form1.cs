using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_AD9959_Monotone
{
    public partial class Form1 : Form
    {
        private SerialPort serialPort; // Serial port for communication with Arduino
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBoxCOMPort.Items.AddRange(SerialPort.GetPortNames()); // Populate COM port dropdown

            if (comboBoxCOMPort.Items.Count > 0)
            {
                comboBoxCOMPort.SelectedIndex = 0; // Ensure at least one item is selected
            }
        }

        private void buttonConnect_Click(object sender, EventArgs e)
        {
            {
                if (serialPort != null && serialPort.IsOpen)
                {
                    serialPort.Close(); // Close the port if it's already open
                    buttonConnect.Text = "Connect"; // Change button text back to "Connect"
                }
                else
                {
                    try //Protects code from crashing if an error occurs 
                    {
                        serialPort = new SerialPort(comboBoxCOMPort.SelectedItem.ToString(), 9600); // Create a new SerialPort instance with the selected COM port and baud rate
                        serialPort.Open(); // Open the selected COM port
                        buttonConnect.Text = "Disconnect"; // Change button text to "Disconnect"
                        MessageBox.Show("Connected to " + comboBoxCOMPort.SelectedItem.ToString()); // Show a message box indicating successful connection
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error connecting to COM port: " + ex.Message);
                    }
                }
            }


        }

        private void buttonCOMPort_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxCOMPort_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void buttonSend_Click(object sender, EventArgs e)
        {
            if (serialPort != null && serialPort.IsOpen) //Check that the serial port is open and connected
            {
                //Read frequency values from NumericUpDown controls:
                long frequency0 = (long)numericUpDownCH0.Value;
                long frequency1 = (long)numericUpDownCH1.Value;
                long frequency2 = (long)numericUpDownCH2.Value;
                long frequency3 = (long)numericUpDownCH3.Value;

                //Create a formatted string to send the frequencies:
                string command = $"FREQ,{frequency0},{frequency1},{frequency2},{frequency3}\n";

                // Send the command to the Arduino:
                serialPort.WriteLine(command);

                MessageBox.Show("Frequencies sent: " + command); // Show a message box indicating successful sending
            }
            else
            {
                MessageBox.Show("Serial port is not open. Please connect to a COM port first.");

            }
        }
    }
}
