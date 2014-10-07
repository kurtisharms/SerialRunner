using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Collections.Concurrent;

namespace SerialRunner
{
       
    public partial class MainForm : Form
    {
        ConcurrentQueue<int> dataQueue = new ConcurrentQueue<int>();
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }


        private void Form1_Load(object sender, EventArgs e)
        {
            portSelectionComboBox.Items.AddRange(System.IO.Ports.SerialPort.GetPortNames());
            if (portSelectionComboBox.Items.Count > 0)
                portSelectionComboBox.SelectedIndex = 0;

        }






        private void saveDataFileButton_Click(object sender, EventArgs e)
        {
            StreamWriter outputFile;
            saveFileDialog1.InitialDirectory = Application.StartupPath;
            saveFileDialog1.ShowDialog();
            outputFile = new StreamWriter(saveFileDialog1.FileName);
            //outputFile.WriteLine("X,Y,Z");
            for (int i = 0; i < dataReceivedListBox.Items.Count; i++)
            {
                outputFile.WriteLine(dataReceivedListBox.Items[i]);

            }

            outputFile.Close();
        }

        private void serialPort_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            while (serialPort.ReadBufferSize > 0)
            {
                dataQueue.Enqueue(serialPort.ReadByte());
            }
        }

        private void connectionButton_Click(object sender, EventArgs e)
        {
             try
            {
                if (!serialPort.IsOpen)
                {
                    serialPort.PortName = portSelectionComboBox.SelectedItem.ToString();
                    serialPort.Open();
                    //tinyStickSerialPort.DtrEnable = true;
                    connectionButton.Text = "Disconnect";
                    readDataTimer.Enabled = true;
                    //serialPort1.WriteLine("LOG COM1 BESTPOSB ONTIME 1[CR]");
                    serialPort.WriteLine("log com1 loglist");
                }
                else
                {
                    serialPort.Close();
                    dataQueue = new ConcurrentQueue<int>();
                    connectionButton.Text = "Connect";
                    readDataTimer.Enabled = false;
                }
            }
            catch (NullReferenceException)
            {
                // Handles case of trying to connect to an empty COM port
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            readDataTimer.Stop();
            if (serialPort.IsOpen)
                serialPort.Close();
        }

        private void readDataTimer_Tick(object sender, EventArgs e)
        {
            int result;
            if (dataQueue.TryDequeue(out result))
            {
                char c = Convert.ToChar(result);
                string d = c.ToString();
                dataReceivedListBox.Items.Add(d);

            }
        }

        private void sendDataButton_Click(object sender, EventArgs e)
        {
            if (serialPort.IsOpen)
            {
                serialPort.WriteLine(sendDataTextBox.Text);
            }
        }

        private void sendDataButton_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void sendDataButton_KeyDown(object sender, KeyEventArgs e)
        {
             if (e.KeyCode == Keys.Enter && serialPort.IsOpen)
            {
                serialPort.WriteLine(sendDataTextBox.Text);
            }
        }
    }
}
