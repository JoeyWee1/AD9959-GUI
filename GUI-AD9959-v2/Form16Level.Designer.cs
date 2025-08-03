namespace GUI_AD9959_16Levels
{
    partial class Form16Level
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
            this.buttonSendMonotone = new System.Windows.Forms.Button();
            this.numericUpDownCH3 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownCH2 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownCH1 = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxProfileSelect = new System.Windows.Forms.ComboBox();
            this.buttonActivate = new System.Windows.Forms.Button();
            this.labelStatus = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonSend = new System.Windows.Forms.Button();
            this.dataGridProfile = new System.Windows.Forms.DataGridView();
            this.Profile = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Frequency = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numericUpDownPLL = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownREFCLK = new System.Windows.Forms.NumericUpDown();
            this.buttonPLL = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonREFCLK = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCH3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCH2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCH1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridProfile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPLL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownREFCLK)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonSendMonotone
            // 
            this.buttonSendMonotone.Location = new System.Drawing.Point(609, 453);
            this.buttonSendMonotone.Name = "buttonSendMonotone";
            this.buttonSendMonotone.Size = new System.Drawing.Size(75, 23);
            this.buttonSendMonotone.TabIndex = 40;
            this.buttonSendMonotone.Text = "Send";
            this.buttonSendMonotone.UseVisualStyleBackColor = true;
            this.buttonSendMonotone.Click += new System.EventHandler(this.buttonSendMonotone_Click);
            // 
            // numericUpDownCH3
            // 
            this.numericUpDownCH3.DecimalPlaces = 2;
            this.numericUpDownCH3.Increment = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericUpDownCH3.Location = new System.Drawing.Point(271, 453);
            this.numericUpDownCH3.Maximum = new decimal(new int[] {
            200000000,
            0,
            0,
            0});
            this.numericUpDownCH3.Name = "numericUpDownCH3";
            this.numericUpDownCH3.Size = new System.Drawing.Size(120, 22);
            this.numericUpDownCH3.TabIndex = 39;
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
            this.numericUpDownCH2.Location = new System.Drawing.Point(271, 425);
            this.numericUpDownCH2.Maximum = new decimal(new int[] {
            200000000,
            0,
            0,
            0});
            this.numericUpDownCH2.Name = "numericUpDownCH2";
            this.numericUpDownCH2.Size = new System.Drawing.Size(120, 22);
            this.numericUpDownCH2.TabIndex = 38;
            this.numericUpDownCH2.ThousandsSeparator = true;
            this.numericUpDownCH2.Value = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            // 
            // numericUpDownCH1
            // 
            this.numericUpDownCH1.DecimalPlaces = 2;
            this.numericUpDownCH1.Increment = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericUpDownCH1.Location = new System.Drawing.Point(271, 394);
            this.numericUpDownCH1.Maximum = new decimal(new int[] {
            200000000,
            0,
            0,
            0});
            this.numericUpDownCH1.Name = "numericUpDownCH1";
            this.numericUpDownCH1.Size = new System.Drawing.Size(120, 22);
            this.numericUpDownCH1.TabIndex = 37;
            this.numericUpDownCH1.ThousandsSeparator = true;
            this.numericUpDownCH1.Value = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(124, 459);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 16);
            this.label7.TabIndex = 36;
            this.label7.Text = "Ch3 Frequency:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(124, 427);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 16);
            this.label6.TabIndex = 35;
            this.label6.Text = "Ch2 Frequency:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(124, 394);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 16);
            this.label5.TabIndex = 34;
            this.label5.Text = "Ch1 Frequency:";
            // 
            // comboBoxProfileSelect
            // 
            this.comboBoxProfileSelect.FormattingEnabled = true;
            this.comboBoxProfileSelect.Location = new System.Drawing.Point(271, 340);
            this.comboBoxProfileSelect.Name = "comboBoxProfileSelect";
            this.comboBoxProfileSelect.Size = new System.Drawing.Size(121, 24);
            this.comboBoxProfileSelect.TabIndex = 33;
            // 
            // buttonActivate
            // 
            this.buttonActivate.Location = new System.Drawing.Point(609, 340);
            this.buttonActivate.Name = "buttonActivate";
            this.buttonActivate.Size = new System.Drawing.Size(75, 23);
            this.buttonActivate.TabIndex = 32;
            this.buttonActivate.Text = "Activate ";
            this.buttonActivate.UseVisualStyleBackColor = true;
            this.buttonActivate.Click += new System.EventHandler(this.buttonActivate_Click);
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Location = new System.Drawing.Point(124, 501);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(133, 16);
            this.labelStatus.TabIndex = 31;
            this.labelStatus.Text = "Status: Disconnected";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(124, 347);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 16);
            this.label1.TabIndex = 30;
            this.label1.Text = "Select Profile:";
            // 
            // buttonSend
            // 
            this.buttonSend.Location = new System.Drawing.Point(609, 297);
            this.buttonSend.Name = "buttonSend";
            this.buttonSend.Size = new System.Drawing.Size(75, 23);
            this.buttonSend.TabIndex = 29;
            this.buttonSend.Text = "Send";
            this.buttonSend.UseVisualStyleBackColor = true;
            this.buttonSend.Click += new System.EventHandler(this.buttonSend_Click);
            // 
            // dataGridProfile
            // 
            this.dataGridProfile.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridProfile.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Profile,
            this.Frequency});
            this.dataGridProfile.Location = new System.Drawing.Point(127, 171);
            this.dataGridProfile.Name = "dataGridProfile";
            this.dataGridProfile.RowHeadersWidth = 51;
            this.dataGridProfile.RowTemplate.Height = 24;
            this.dataGridProfile.Size = new System.Drawing.Size(421, 149);
            this.dataGridProfile.TabIndex = 28;
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
            this.numericUpDownPLL.Location = new System.Drawing.Point(271, 109);
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
            this.numericUpDownPLL.TabIndex = 46;
            this.numericUpDownPLL.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numericUpDownPLL.ValueChanged += new System.EventHandler(this.numericUpDownPLL_ValueChanged);
            // 
            // numericUpDownREFCLK
            // 
            this.numericUpDownREFCLK.Increment = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericUpDownREFCLK.Location = new System.Drawing.Point(271, 65);
            this.numericUpDownREFCLK.Maximum = new decimal(new int[] {
            500000000,
            0,
            0,
            0});
            this.numericUpDownREFCLK.Name = "numericUpDownREFCLK";
            this.numericUpDownREFCLK.Size = new System.Drawing.Size(120, 22);
            this.numericUpDownREFCLK.TabIndex = 45;
            this.numericUpDownREFCLK.ThousandsSeparator = true;
            this.numericUpDownREFCLK.Value = new decimal(new int[] {
            25000000,
            0,
            0,
            0});
            // 
            // buttonPLL
            // 
            this.buttonPLL.Location = new System.Drawing.Point(609, 102);
            this.buttonPLL.Name = "buttonPLL";
            this.buttonPLL.Size = new System.Drawing.Size(83, 23);
            this.buttonPLL.TabIndex = 44;
            this.buttonPLL.Text = "Set PLL";
            this.buttonPLL.UseVisualStyleBackColor = true;
            this.buttonPLL.Click += new System.EventHandler(this.buttonPLL_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(124, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 16);
            this.label4.TabIndex = 43;
            this.label4.Text = "PLL Multiplier:";
            // 
            // buttonREFCLK
            // 
            this.buttonREFCLK.Location = new System.Drawing.Point(609, 58);
            this.buttonREFCLK.Name = "buttonREFCLK";
            this.buttonREFCLK.Size = new System.Drawing.Size(83, 23);
            this.buttonREFCLK.TabIndex = 42;
            this.buttonREFCLK.Text = "Set CLK";
            this.buttonREFCLK.UseVisualStyleBackColor = true;
            this.buttonREFCLK.Click += new System.EventHandler(this.buttonREFCLK_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(124, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 16);
            this.label3.TabIndex = 41;
            this.label3.Text = "Reference Clock:";
            // 
            // Form16Level
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(896, 580);
            this.Controls.Add(this.numericUpDownPLL);
            this.Controls.Add(this.numericUpDownREFCLK);
            this.Controls.Add(this.buttonPLL);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.buttonREFCLK);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonSendMonotone);
            this.Controls.Add(this.numericUpDownCH3);
            this.Controls.Add(this.numericUpDownCH2);
            this.Controls.Add(this.numericUpDownCH1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBoxProfileSelect);
            this.Controls.Add(this.buttonActivate);
            this.Controls.Add(this.labelStatus);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonSend);
            this.Controls.Add(this.dataGridProfile);
            this.Name = "Form16Level";
            this.Text = "Form16Level";
            this.Load += new System.EventHandler(this.Form16Level_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCH3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCH2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCH1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridProfile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPLL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownREFCLK)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonSendMonotone;
        private System.Windows.Forms.NumericUpDown numericUpDownCH3;
        private System.Windows.Forms.NumericUpDown numericUpDownCH2;
        private System.Windows.Forms.NumericUpDown numericUpDownCH1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBoxProfileSelect;
        private System.Windows.Forms.Button buttonActivate;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonSend;
        private System.Windows.Forms.DataGridView dataGridProfile;
        private System.Windows.Forms.DataGridViewTextBoxColumn Profile;
        private System.Windows.Forms.DataGridViewTextBoxColumn Frequency;
        private System.Windows.Forms.NumericUpDown numericUpDownPLL;
        private System.Windows.Forms.NumericUpDown numericUpDownREFCLK;
        private System.Windows.Forms.Button buttonPLL;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonREFCLK;
        private System.Windows.Forms.Label label3;
    }
}