using System;
using System.IO.Ports;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArduinoGUI
{
    public partial class Form1 : Form
    {
        private SerialPort serialPort; // Serial port for communication with Arduino
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBoxCOMPort.Items.AddRange(SerialPort.GetPortNames()); // Populate COM port dropdown

            if (comboBoxCOMPort.Items.Count > 0)
            {
                comboBoxCOMPort.SelectedIndex = 0; // Ensure at least one item is selected
            }
        }

        private void buttonConnect_Click(object sender, EventArgs e) //This is the method called when the Connect button is clicked
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
        
        private void buttonSend_Click(object sender, EventArgs e)
        {
            if (serialPort != null && serialPort.IsOpen)
                            {
                try
                {
                    int delayValue = (int) numericUpDownDelay.Value; // Replace with the actual message you want to send
                    serialPort.WriteLine(delayValue.ToString()); // Send the message to Arduino
                    MessageBox.Show("Delay value set: " + delayValue); // Show a message box indicating successful sending
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error sending message: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Please connect to a COM port first.");
            }
        }
    }
    
}
