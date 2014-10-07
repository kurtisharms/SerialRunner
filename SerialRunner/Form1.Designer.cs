namespace SerialRunner
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.serialPort = new System.IO.Ports.SerialPort(this.components);
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.readDataTimer = new System.Windows.Forms.Timer(this.components);
            this.dataReceivedListBox = new System.Windows.Forms.ListBox();
            this.connectionButton = new System.Windows.Forms.Button();
            this.portSelectionComboBox = new System.Windows.Forms.ComboBox();
            this.saveDataFileButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // serialPort
            // 
            this.serialPort.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort_DataReceived);
            // 
            // readDataTimer
            // 
            this.readDataTimer.Tick += new System.EventHandler(this.readDataTimer_Tick);
            // 
            // dataReceivedListBox
            // 
            this.dataReceivedListBox.AccessibleName = "";
            this.dataReceivedListBox.FormattingEnabled = true;
            this.dataReceivedListBox.ItemHeight = 16;
            this.dataReceivedListBox.Location = new System.Drawing.Point(28, 76);
            this.dataReceivedListBox.Name = "dataReceivedListBox";
            this.dataReceivedListBox.Size = new System.Drawing.Size(225, 116);
            this.dataReceivedListBox.TabIndex = 0;
            // 
            // connectionButton
            // 
            this.connectionButton.Location = new System.Drawing.Point(178, 31);
            this.connectionButton.Name = "connectionButton";
            this.connectionButton.Size = new System.Drawing.Size(75, 23);
            this.connectionButton.TabIndex = 1;
            this.connectionButton.Text = "Connect";
            this.connectionButton.UseVisualStyleBackColor = true;
            this.connectionButton.Click += new System.EventHandler(this.connectionButton_Click);
            // 
            // portSelectionComboBox
            // 
            this.portSelectionComboBox.FormattingEnabled = true;
            this.portSelectionComboBox.Location = new System.Drawing.Point(28, 30);
            this.portSelectionComboBox.Name = "portSelectionComboBox";
            this.portSelectionComboBox.Size = new System.Drawing.Size(121, 24);
            this.portSelectionComboBox.TabIndex = 2;
            // 
            // saveDataFileButton
            // 
            this.saveDataFileButton.Location = new System.Drawing.Point(73, 218);
            this.saveDataFileButton.Name = "saveDataFileButton";
            this.saveDataFileButton.Size = new System.Drawing.Size(75, 23);
            this.saveDataFileButton.TabIndex = 3;
            this.saveDataFileButton.Text = "Save to File";
            this.saveDataFileButton.UseVisualStyleBackColor = true;
            this.saveDataFileButton.Click += new System.EventHandler(this.saveDataFileButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 253);
            this.Controls.Add(this.saveDataFileButton);
            this.Controls.Add(this.portSelectionComboBox);
            this.Controls.Add(this.connectionButton);
            this.Controls.Add(this.dataReceivedListBox);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.IO.Ports.SerialPort serialPort;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Timer readDataTimer;
        private System.Windows.Forms.ListBox dataReceivedListBox;
        private System.Windows.Forms.Button connectionButton;
        private System.Windows.Forms.ComboBox portSelectionComboBox;
        private System.Windows.Forms.Button saveDataFileButton;
    }
}

