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
            this.sendDataTextBox = new System.Windows.Forms.TextBox();
            this.sendDataButton = new System.Windows.Forms.Button();
            this.separatorLabel = new System.Windows.Forms.Label();
            this.separatorTextBox = new System.Windows.Forms.TextBox();
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
            this.dataReceivedListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataReceivedListBox.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataReceivedListBox.FormattingEnabled = true;
            this.dataReceivedListBox.HorizontalScrollbar = true;
            this.dataReceivedListBox.ItemHeight = 24;
            this.dataReceivedListBox.Location = new System.Drawing.Point(28, 119);
            this.dataReceivedListBox.Name = "dataReceivedListBox";
            this.dataReceivedListBox.Size = new System.Drawing.Size(623, 244);
            this.dataReceivedListBox.TabIndex = 0;
            // 
            // connectionButton
            // 
            this.connectionButton.Location = new System.Drawing.Point(155, 31);
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
            this.saveDataFileButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.saveDataFileButton.Location = new System.Drawing.Point(294, 403);
            this.saveDataFileButton.Name = "saveDataFileButton";
            this.saveDataFileButton.Size = new System.Drawing.Size(134, 23);
            this.saveDataFileButton.TabIndex = 3;
            this.saveDataFileButton.Text = "Save to File";
            this.saveDataFileButton.UseVisualStyleBackColor = true;
            this.saveDataFileButton.Click += new System.EventHandler(this.saveDataFileButton_Click);
            // 
            // sendDataTextBox
            // 
            this.sendDataTextBox.Location = new System.Drawing.Point(28, 77);
            this.sendDataTextBox.Name = "sendDataTextBox";
            this.sendDataTextBox.Size = new System.Drawing.Size(282, 22);
            this.sendDataTextBox.TabIndex = 4;
            // 
            // sendDataButton
            // 
            this.sendDataButton.Location = new System.Drawing.Point(329, 77);
            this.sendDataButton.Name = "sendDataButton";
            this.sendDataButton.Size = new System.Drawing.Size(116, 23);
            this.sendDataButton.TabIndex = 5;
            this.sendDataButton.Text = "Send Data";
            this.sendDataButton.UseVisualStyleBackColor = true;
            this.sendDataButton.Click += new System.EventHandler(this.sendDataButton_Click);
            this.sendDataButton.KeyDown += new System.Windows.Forms.KeyEventHandler(this.sendDataButton_KeyDown);
            this.sendDataButton.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.sendDataButton_KeyPress);
            // 
            // separatorLabel
            // 
            this.separatorLabel.AutoSize = true;
            this.separatorLabel.Location = new System.Drawing.Point(460, 82);
            this.separatorLabel.Name = "separatorLabel";
            this.separatorLabel.Size = new System.Drawing.Size(71, 17);
            this.separatorLabel.TabIndex = 6;
            this.separatorLabel.Text = "Separator";
            // 
            // separatorTextBox
            // 
            this.separatorTextBox.Location = new System.Drawing.Point(538, 76);
            this.separatorTextBox.Name = "separatorTextBox";
            this.separatorTextBox.Size = new System.Drawing.Size(100, 22);
            this.separatorTextBox.TabIndex = 7;
            this.separatorTextBox.Text = "#";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(677, 438);
            this.Controls.Add(this.separatorTextBox);
            this.Controls.Add(this.separatorLabel);
            this.Controls.Add(this.sendDataButton);
            this.Controls.Add(this.sendDataTextBox);
            this.Controls.Add(this.saveDataFileButton);
            this.Controls.Add(this.portSelectionComboBox);
            this.Controls.Add(this.connectionButton);
            this.Controls.Add(this.dataReceivedListBox);
            this.Name = "MainForm";
            this.Text = "SerialRunner";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.IO.Ports.SerialPort serialPort;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Timer readDataTimer;
        private System.Windows.Forms.ListBox dataReceivedListBox;
        private System.Windows.Forms.Button connectionButton;
        private System.Windows.Forms.ComboBox portSelectionComboBox;
        private System.Windows.Forms.Button saveDataFileButton;
        private System.Windows.Forms.TextBox sendDataTextBox;
        private System.Windows.Forms.Button sendDataButton;
        private System.Windows.Forms.Label separatorLabel;
        private System.Windows.Forms.TextBox separatorTextBox;
    }
}

