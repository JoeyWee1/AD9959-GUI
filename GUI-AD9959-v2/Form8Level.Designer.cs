namespace GUI_AD9959_16Levels
{
    partial class Form8Level
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
            this.buttonSend = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridProfile = new System.Windows.Forms.DataGridView();
            this.Profile = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Frequency = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numericUpDownPLL = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownREFCLK = new System.Windows.Forms.NumericUpDown();
            this.buttonPLL = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.buttonREFCLK = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.buttonSendMonotone = new System.Windows.Forms.Button();
            this.numericUpDownCH3 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownCH2 = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.labelStatus = new System.Windows.Forms.Label();
            this.numericUpDownCH1 = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridProfile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPLL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownREFCLK)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCH3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCH2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCH1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonSend
            // 
            this.buttonSend.Location = new System.Drawing.Point(529, 273);
            this.buttonSend.Name = "buttonSend";
            this.buttonSend.Size = new System.Drawing.Size(75, 23);
            this.buttonSend.TabIndex = 79;
            this.buttonSend.Text = "Send";
            this.buttonSend.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 16);
            this.label1.TabIndex = 77;
            this.label1.Text = "Ch0 Profile Frequencies:";
            // 
            // dataGridProfile
            // 
            this.dataGridProfile.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridProfile.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Profile,
            this.Frequency});
            this.dataGridProfile.Location = new System.Drawing.Point(47, 147);
            this.dataGridProfile.Name = "dataGridProfile";
            this.dataGridProfile.RowHeadersWidth = 51;
            this.dataGridProfile.RowTemplate.Height = 24;
            this.dataGridProfile.Size = new System.Drawing.Size(421, 149);
            this.dataGridProfile.TabIndex = 76;
            // 
            // Profile
            // 
            this.Profile.HeaderText = "Profile";
            this.Profile.MinimumWidth = 6;
            this.Profile.Name = "Profile";
            this.Profile.ReadOnly = true;
            this.Profile.Width = 125;
            // 
            // Frequency
            // 
            this.Frequency.HeaderText = "Frequency (Hz)";
            this.Frequency.MinimumWidth = 6;
            this.Frequency.Name = "Frequency";
            this.Frequency.Width = 125;
            // 
            // numericUpDownPLL
            // 
            this.numericUpDownPLL.Location = new System.Drawing.Point(191, 71);
            this.numericUpDownPLL.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numericUpDownPLL.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownPLL.Name = "numericUpDownPLL";
            this.numericUpDownPLL.Size = new System.Drawing.Size(120, 22);
            this.numericUpDownPLL.TabIndex = 75;
            this.numericUpDownPLL.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // numericUpDownREFCLK
            // 
            this.numericUpDownREFCLK.Increment = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericUpDownREFCLK.Location = new System.Drawing.Point(191, 27);
            this.numericUpDownREFCLK.Maximum = new decimal(new int[] {
            500000000,
            0,
            0,
            0});
            this.numericUpDownREFCLK.Name = "numericUpDownREFCLK";
            this.numericUpDownREFCLK.Size = new System.Drawing.Size(120, 22);
            this.numericUpDownREFCLK.TabIndex = 74;
            this.numericUpDownREFCLK.ThousandsSeparator = true;
            this.numericUpDownREFCLK.Value = new decimal(new int[] {
            25000000,
            0,
            0,
            0});
            // 
            // buttonPLL
            // 
            this.buttonPLL.Location = new System.Drawing.Point(529, 64);
            this.buttonPLL.Name = "buttonPLL";
            this.buttonPLL.Size = new System.Drawing.Size(83, 23);
            this.buttonPLL.TabIndex = 73;
            this.buttonPLL.Text = "Set PLL";
            this.buttonPLL.UseVisualStyleBackColor = true;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(44, 71);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(89, 16);
            this.label13.TabIndex = 72;
            this.label13.Text = "PLL Multiplier:";
            // 
            // buttonREFCLK
            // 
            this.buttonREFCLK.Location = new System.Drawing.Point(529, 20);
            this.buttonREFCLK.Name = "buttonREFCLK";
            this.buttonREFCLK.Size = new System.Drawing.Size(83, 23);
            this.buttonREFCLK.TabIndex = 71;
            this.buttonREFCLK.Text = "Set CLK";
            this.buttonREFCLK.UseVisualStyleBackColor = true;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(44, 27);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(110, 16);
            this.label14.TabIndex = 70;
            this.label14.Text = "Reference Clock:";
            // 
            // buttonSendMonotone
            // 
            this.buttonSendMonotone.Location = new System.Drawing.Point(529, 397);
            this.buttonSendMonotone.Name = "buttonSendMonotone";
            this.buttonSendMonotone.Size = new System.Drawing.Size(75, 23);
            this.buttonSendMonotone.TabIndex = 90;
            this.buttonSendMonotone.Text = "Send";
            this.buttonSendMonotone.UseVisualStyleBackColor = true;
            // 
            // numericUpDownCH3
            // 
            this.numericUpDownCH3.DecimalPlaces = 2;
            this.numericUpDownCH3.Increment = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericUpDownCH3.Location = new System.Drawing.Point(202, 394);
            this.numericUpDownCH3.Maximum = new decimal(new int[] {
            200000000,
            0,
            0,
            0});
            this.numericUpDownCH3.Name = "numericUpDownCH3";
            this.numericUpDownCH3.Size = new System.Drawing.Size(120, 22);
            this.numericUpDownCH3.TabIndex = 89;
            this.numericUpDownCH3.ThousandsSeparator = true;
            this.numericUpDownCH3.Value = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            // 
            // numericUpDownCH2
            // 
            this.numericUpDownCH2.DecimalPlaces = 2;
            this.numericUpDownCH2.Increment = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericUpDownCH2.Location = new System.Drawing.Point(202, 366);
            this.numericUpDownCH2.Maximum = new decimal(new int[] {
            200000000,
            0,
            0,
            0});
            this.numericUpDownCH2.Name = "numericUpDownCH2";
            this.numericUpDownCH2.Size = new System.Drawing.Size(120, 22);
            this.numericUpDownCH2.TabIndex = 88;
            this.numericUpDownCH2.ThousandsSeparator = true;
            this.numericUpDownCH2.Value = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 400);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 16);
            this.label2.TabIndex = 87;
            this.label2.Text = "Ch3 Frequency:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(55, 368);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 16);
            this.label6.TabIndex = 86;
            this.label6.Text = "Ch2 Frequency:";
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Location = new System.Drawing.Point(55, 442);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(133, 16);
            this.labelStatus.TabIndex = 85;
            this.labelStatus.Text = "Status: Disconnected";
            // 
            // numericUpDownCH1
            // 
            this.numericUpDownCH1.DecimalPlaces = 2;
            this.numericUpDownCH1.Increment = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericUpDownCH1.Location = new System.Drawing.Point(202, 338);
            this.numericUpDownCH1.Maximum = new decimal(new int[] {
            200000000,
            0,
            0,
            0});
            this.numericUpDownCH1.Name = "numericUpDownCH1";
            this.numericUpDownCH1.Size = new System.Drawing.Size(120, 22);
            this.numericUpDownCH1.TabIndex = 92;
            this.numericUpDownCH1.ThousandsSeparator = true;
            this.numericUpDownCH1.Value = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(55, 338);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 16);
            this.label5.TabIndex = 91;
            this.label5.Text = "Ch1 Frequency:";
            // 
            // Form8Level
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(786, 555);
            this.Controls.Add(this.numericUpDownCH1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.buttonSendMonotone);
            this.Controls.Add(this.numericUpDownCH3);
            this.Controls.Add(this.numericUpDownCH2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.labelStatus);
            this.Controls.Add(this.buttonSend);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridProfile);
            this.Controls.Add(this.numericUpDownPLL);
            this.Controls.Add(this.numericUpDownREFCLK);
            this.Controls.Add(this.buttonPLL);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.buttonREFCLK);
            this.Controls.Add(this.label14);
            this.Name = "Form8Level";
            this.Text = "Form8Level";
            this.Load += new System.EventHandler(this.Form8Level_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridProfile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPLL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownREFCLK)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCH3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCH2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCH1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonSend;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridProfile;
        private System.Windows.Forms.DataGridViewTextBoxColumn Profile;
        private System.Windows.Forms.DataGridViewTextBoxColumn Frequency;
        private System.Windows.Forms.NumericUpDown numericUpDownPLL;
        private System.Windows.Forms.NumericUpDown numericUpDownREFCLK;
        private System.Windows.Forms.Button buttonPLL;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button buttonREFCLK;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button buttonSendMonotone;
        private System.Windows.Forms.NumericUpDown numericUpDownCH3;
        private System.Windows.Forms.NumericUpDown numericUpDownCH2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.NumericUpDown numericUpDownCH1;
        private System.Windows.Forms.Label label5;
    }
}