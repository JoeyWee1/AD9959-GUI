namespace ArduinoGUI
{
    partial class Form1
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
            this.buttonConnect = new System.Windows.Forms.Button();
            this.buttonCOMPort = new System.Windows.Forms.Label();
            this.buttonDelay = new System.Windows.Forms.Label();
            this.buttonSend = new System.Windows.Forms.Button();
            this.numericUpDownDelay = new System.Windows.Forms.NumericUpDown();
            this.comboBoxCOMPort = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDelay)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonConnect
            // 
            this.buttonConnect.Location = new System.Drawing.Point(486, 153);
            this.buttonConnect.Name = "buttonConnect";
            this.buttonConnect.Size = new System.Drawing.Size(75, 23);
            this.buttonConnect.TabIndex = 0;
            this.buttonConnect.Text = "Connect";
            this.buttonConnect.UseVisualStyleBackColor = true;
            this.buttonConnect.Click += new System.EventHandler(this.buttonConnect_Click);
            // 
            // buttonCOMPort
            // 
            this.buttonCOMPort.AutoSize = true;
            this.buttonCOMPort.Location = new System.Drawing.Point(197, 160);
            this.buttonCOMPort.Name = "buttonCOMPort";
            this.buttonCOMPort.Size = new System.Drawing.Size(64, 16);
            this.buttonCOMPort.TabIndex = 1;
            this.buttonCOMPort.Text = "COM Port";
            this.buttonCOMPort.Click += new System.EventHandler(this.label1_Click);
            // 
            // buttonDelay
            // 
            this.buttonDelay.AutoSize = true;
            this.buttonDelay.Location = new System.Drawing.Point(197, 271);
            this.buttonDelay.Name = "buttonDelay";
            this.buttonDelay.Size = new System.Drawing.Size(72, 16);
            this.buttonDelay.TabIndex = 2;
            this.buttonDelay.Text = "Delay (ms)";
            // 
            // buttonSend
            // 
            this.buttonSend.Location = new System.Drawing.Point(486, 269);
            this.buttonSend.Name = "buttonSend";
            this.buttonSend.Size = new System.Drawing.Size(75, 23);
            this.buttonSend.TabIndex = 3;
            this.buttonSend.Text = "Send";
            this.buttonSend.UseVisualStyleBackColor = true;
            this.buttonSend.Click += new System.EventHandler(this.buttonSend_Click);
            // 
            // numericUpDownDelay
            // 
            this.numericUpDownDelay.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numericUpDownDelay.Location = new System.Drawing.Point(312, 269);
            this.numericUpDownDelay.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.numericUpDownDelay.Name = "numericUpDownDelay";
            this.numericUpDownDelay.Size = new System.Drawing.Size(120, 22);
            this.numericUpDownDelay.TabIndex = 4;
            // 
            // comboBoxCOMPort
            // 
            this.comboBoxCOMPort.FormattingEnabled = true;
            this.comboBoxCOMPort.Location = new System.Drawing.Point(312, 152);
            this.comboBoxCOMPort.Name = "comboBoxCOMPort";
            this.comboBoxCOMPort.Size = new System.Drawing.Size(121, 24);
            this.comboBoxCOMPort.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 478);
            this.Controls.Add(this.comboBoxCOMPort);
            this.Controls.Add(this.numericUpDownDelay);
            this.Controls.Add(this.buttonSend);
            this.Controls.Add(this.buttonDelay);
            this.Controls.Add(this.buttonCOMPort);
            this.Controls.Add(this.buttonConnect);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDelay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonConnect;
        private System.Windows.Forms.Label buttonCOMPort;
        private System.Windows.Forms.Label buttonDelay;
        private System.Windows.Forms.Button buttonSend;
        private System.Windows.Forms.NumericUpDown numericUpDownDelay;
        private System.Windows.Forms.ComboBox comboBoxCOMPort;
    }
}

