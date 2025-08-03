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
using System.Linq.Expressions;

namespace GUI_AD9959_16Levels
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SerialPort serialPort;
        private void dataGridProfile_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Populate the serial port combo box with available ports:
            comboBoxPorts.Items.AddRange(SerialPort.GetPortNames());
            if (comboBoxPorts.Items.Count > 0)
            {
                comboBoxPorts.SelectedIndex = 0; // Select the first available port by default
            }

            else
            {
                MessageBox.Show("No serial ports found. Please connect a device.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


       
        }



        
    

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

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
                    serialPort = new SerialPort(comboBoxPorts.SelectedItem.ToString(), 9600); // Create a new SerialPort instance with the selected COM port and baud rate
                    serialPort.ReadTimeout = 5000; // Set read timeout to 5000 milliseconds
                    serialPort.Open(); // Open the selected COM port

                    System.Threading.Thread.Sleep(3000); // Wait for 2 seconds to ensure the connection is established


                    serialPort.DiscardInBuffer(); // Clear any incoming data in the buffer

                    //string readyMessage = serialPort.ReadLine().Trim(); // Read the "Ready" message from the Arduino

                    //if (readyMessage == "READY") // Check if the message is "Ready"
                    //{
                    //    MessageBox.Show("Arduino is ready for communication.");
                    //}
                    //else
                    //{
                    //    MessageBox.Show("Unexpected response from Arduino: " + readyMessage);
                    //}

                    MessageBox.Show("Connected to " + comboBoxPorts.SelectedItem.ToString()); // Show a message box indicating successful connection
                    buttonConnect.Text = "Disconnect"; // Change button text to "Disconnect"

                }
                catch (TimeoutException)
                {
                    MessageBox.Show("Connection timed out. Please check the COM port and try again.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error connecting to COM port: " + ex.Message);
                }
            }
        }


        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string selected = comboModeSelect.SelectedItem.ToString();
            if (selected.Contains("16-Level"))
            {
                Form16Level f16 = new Form16Level(serialPort); // Pass serial port
                f16.ShowDialog();
            }
            else if (selected.Contains("2-Level"))
            {
                Form2Level f2 = new Form2Level(serialPort); //Pass serial port
                f2.ShowDialog();
            }
            else if (selected.Contains("4-Level"))
            {
                Form4Level f4 = new Form4Level(serialPort); //Pass serial port
                f4.ShowDialog();
            }
            else if (selected.Contains("8-Level"))
            {
                Form8Level f8 = new Form8Level(serialPort); //Pass serial port
                f8.ShowDialog();
            }

        }


        private void comboModeSelect_SelectedIndexChanged(object sender, EventArgs e)
        {

            
        }
    }
}
