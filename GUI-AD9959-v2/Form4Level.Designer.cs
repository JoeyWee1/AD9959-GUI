namespace GUI_AD9959_16Levels
{
    partial class Form4Level
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
            this.numericUpDownPLL = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownREFCLK = new System.Windows.Forms.NumericUpDown();
            this.buttonPLL = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.buttonREFCLK = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.dataGridProfile0 = new System.Windows.Forms.DataGridView();
            this.Profile = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Frequency = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridProfile1 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonSendMonotone = new System.Windows.Forms.Button();
            this.numericUpDownCH3 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownCH2 = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.labelStatus = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonSend = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPLL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownREFCLK)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridProfile0)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridProfile1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCH3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCH2)).BeginInit();
            this.SuspendLayout();
            // 
            // numericUpDownPLL
            // 
            this.numericUpDownPLL.Location = new System.Drawing.Point(226, 91);
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
            this.numericUpDownPLL.TabIndex = 58;
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
            this.numericUpDownREFCLK.Location = new System.Drawing.Point(226, 47);
            this.numericUpDownREFCLK.Maximum = new decimal(new int[] {
            500000000,
            0,
            0,
            0});
            this.numericUpDownREFCLK.Name = "numericUpDownREFCLK";
            this.numericUpDownREFCLK.Size = new System.Drawing.Size(120, 22);
            this.numericUpDownREFCLK.TabIndex = 57;
            this.numericUpDownREFCLK.ThousandsSeparator = true;
            this.numericUpDownREFCLK.Value = new decimal(new int[] {
            25000000,
            0,
            0,
            0});
            // 
            // buttonPLL
            // 
            this.buttonPLL.Location = new System.Drawing.Point(564, 84);
            this.buttonPLL.Name = "buttonPLL";
            this.buttonPLL.Size = new System.Drawing.Size(83, 23);
            this.buttonPLL.TabIndex = 56;
            this.buttonPLL.Text = "Set PLL";
            this.buttonPLL.UseVisualStyleBackColor = true;
            this.buttonPLL.Click += new System.EventHandler(this.buttonPLL_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(79, 91);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(89, 16);
            this.label13.TabIndex = 55;
            this.label13.Text = "PLL Multiplier:";
            // 
            // buttonREFCLK
            // 
            this.buttonREFCLK.Location = new System.Drawing.Point(564, 40);
            this.buttonREFCLK.Name = "buttonREFCLK";
            this.buttonREFCLK.Size = new System.Drawing.Size(83, 23);
            this.buttonREFCLK.TabIndex = 54;
            this.buttonREFCLK.Text = "Set CLK";
            this.buttonREFCLK.UseVisualStyleBackColor = true;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(79, 47);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(110, 16);
            this.label14.TabIndex = 53;
            this.label14.Text = "Reference Clock:";
            // 
            // dataGridProfile0
            // 
            this.dataGridProfile0.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridProfile0.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Profile,
            this.Frequency});
            this.dataGridProfile0.Location = new System.Drawing.Point(82, 167);
            this.dataGridProfile0.Name = "dataGridProfile0";
            this.dataGridProfile0.RowHeadersWidth = 51;
            this.dataGridProfile0.RowTemplate.Height = 24;
            this.dataGridProfile0.Size = new System.Drawing.Size(421, 149);
            this.dataGridProfile0.TabIndex = 59;
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
            // dataGridProfile1
            // 
            this.dataGridProfile1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridProfile1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.dataGridProfile1.Location = new System.Drawing.Point(82, 376);
            this.dataGridProfile1.Name = "dataGridProfile1";
            this.dataGridProfile1.RowHeadersWidth = 51;
            this.dataGridProfile1.RowTemplate.Height = 24;
            this.dataGridProfile1.Size = new System.Drawing.Size(421, 149);
            this.dataGridProfile1.TabIndex = 60;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Profile";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Frequency (Hz)";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // buttonSendMonotone
            // 
            this.buttonSendMonotone.Location = new System.Drawing.Point(564, 573);
            this.buttonSendMonotone.Name = "buttonSendMonotone";
            this.buttonSendMonotone.Size = new System.Drawing.Size(75, 23);
            this.buttonSendMonotone.TabIndex = 65;
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
            this.numericUpDownCH3.Location = new System.Drawing.Point(226, 573);
            this.numericUpDownCH3.Maximum = new decimal(new int[] {
            200000000,
            0,
            0,
            0});
            this.numericUpDownCH3.Name = "numericUpDownCH3";
            this.numericUpDownCH3.Size = new System.Drawing.Size(120, 22);
            this.numericUpDownCH3.TabIndex = 64;
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
            this.numericUpDownCH2.Location = new System.Drawing.Point(226, 545);
            this.numericUpDownCH2.Maximum = new decimal(new int[] {
            200000000,
            0,
            0,
            0});
            this.numericUpDownCH2.Name = "numericUpDownCH2";
            this.numericUpDownCH2.Size = new System.Drawing.Size(120, 22);
            this.numericUpDownCH2.TabIndex = 63;
            this.numericUpDownCH2.ThousandsSeparator = true;
            this.numericUpDownCH2.Value = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(79, 579);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 16);
            this.label7.TabIndex = 62;
            this.label7.Text = "Ch3 Frequency:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(79, 547);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 16);
            this.label6.TabIndex = 61;
            this.label6.Text = "Ch2 Frequency:";
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Location = new System.Drawing.Point(79, 613);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(133, 16);
            this.labelStatus.TabIndex = 66;
            this.labelStatus.Text = "Status: Disconnected";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(79, 132);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 16);
            this.label1.TabIndex = 67;
            this.label1.Text = "Ch0 Profile Frequencies:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(79, 345);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 16);
            this.label2.TabIndex = 68;
            this.label2.Text = "Ch1 Profile Frequencies:";
            // 
            // buttonSend
            // 
            this.buttonSend.Location = new System.Drawing.Point(564, 293);
            this.buttonSend.Name = "buttonSend";
            this.buttonSend.Size = new System.Drawing.Size(75, 23);
            this.buttonSend.TabIndex = 69;
            this.buttonSend.Text = "Send";
            this.buttonSend.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(564, 502);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 70;
            this.button1.Text = "Send";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Form4Level
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(866, 689);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonSend);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelStatus);
            this.Controls.Add(this.buttonSendMonotone);
            this.Controls.Add(this.numericUpDownCH3);
            this.Controls.Add(this.numericUpDownCH2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dataGridProfile1);
            this.Controls.Add(this.dataGridProfile0);
            this.Controls.Add(this.numericUpDownPLL);
            this.Controls.Add(this.numericUpDownREFCLK);
            this.Controls.Add(this.buttonPLL);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.buttonREFCLK);
            this.Controls.Add(this.label14);
            this.Name = "Form4Level";
            this.Text = "Form4Level";
            this.Load += new System.EventHandler(this.Form4Level_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPLL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownREFCLK)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridProfile0)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridProfile1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCH3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCH2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numericUpDownPLL;
        private System.Windows.Forms.NumericUpDown numericUpDownREFCLK;
        private System.Windows.Forms.Button buttonPLL;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button buttonREFCLK;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DataGridView dataGridProfile0;
        private System.Windows.Forms.DataGridViewTextBoxColumn Profile;
        private System.Windows.Forms.DataGridViewTextBoxColumn Frequency;
        private System.Windows.Forms.DataGridView dataGridProfile1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.Button buttonSendMonotone;
        private System.Windows.Forms.NumericUpDown numericUpDownCH3;
        private System.Windows.Forms.NumericUpDown numericUpDownCH2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonSend;
        private System.Windows.Forms.Button button1;
    }
}