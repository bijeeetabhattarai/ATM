namespace ATM
{
    partial class TransferForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TransferForm));
            this.depositTransferAmountTextBox = new System.Windows.Forms.TextBox();
            this.transferpictureBox = new System.Windows.Forms.PictureBox();
            this.transferExitMyAccountButton = new System.Windows.Forms.Button();
            this.bankSecondLabel = new System.Windows.Forms.Label();
            this.bankNameLabel = new System.Windows.Forms.Label();
            this.selectAcToTransferFrompromptLabel = new System.Windows.Forms.Label();
            this.transferBackToMainButton = new System.Windows.Forms.Button();
            this.transferLabel = new System.Windows.Forms.Label();
            this.amountToTransferPromptLabel = new System.Windows.Forms.Label();
            this.transferFromComboBox = new System.Windows.Forms.ComboBox();
            this.transferButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.transferpictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // depositTransferAmountTextBox
            // 
            this.depositTransferAmountTextBox.Location = new System.Drawing.Point(505, 306);
            this.depositTransferAmountTextBox.Name = "depositTransferAmountTextBox";
            this.depositTransferAmountTextBox.Size = new System.Drawing.Size(346, 23);
            this.depositTransferAmountTextBox.TabIndex = 42;
            this.depositTransferAmountTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // transferpictureBox
            // 
            this.transferpictureBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("transferpictureBox.BackgroundImage")));
            this.transferpictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.transferpictureBox.Location = new System.Drawing.Point(475, 88);
            this.transferpictureBox.Name = "transferpictureBox";
            this.transferpictureBox.Size = new System.Drawing.Size(116, 66);
            this.transferpictureBox.TabIndex = 41;
            this.transferpictureBox.TabStop = false;
            // 
            // transferExitMyAccountButton
            // 
            this.transferExitMyAccountButton.BackColor = System.Drawing.SystemColors.Desktop;
            this.transferExitMyAccountButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.transferExitMyAccountButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.transferExitMyAccountButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.transferExitMyAccountButton.Location = new System.Drawing.Point(635, 408);
            this.transferExitMyAccountButton.Name = "transferExitMyAccountButton";
            this.transferExitMyAccountButton.Size = new System.Drawing.Size(225, 76);
            this.transferExitMyAccountButton.TabIndex = 40;
            this.transferExitMyAccountButton.Text = "Exit My Account";
            this.transferExitMyAccountButton.UseVisualStyleBackColor = false;
            this.transferExitMyAccountButton.Click += new System.EventHandler(this.transferExitMyAccountButton_Click);
            // 
            // bankSecondLabel
            // 
            this.bankSecondLabel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.bankSecondLabel.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bankSecondLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.bankSecondLabel.Location = new System.Drawing.Point(734, 41);
            this.bankSecondLabel.Name = "bankSecondLabel";
            this.bankSecondLabel.Size = new System.Drawing.Size(148, 33);
            this.bankSecondLabel.TabIndex = 39;
            this.bankSecondLabel.Text = "CREDIT UNION";
            this.bankSecondLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bankNameLabel
            // 
            this.bankNameLabel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.bankNameLabel.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bankNameLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.bankNameLabel.Location = new System.Drawing.Point(648, 9);
            this.bankNameLabel.Name = "bankNameLabel";
            this.bankNameLabel.Size = new System.Drawing.Size(264, 44);
            this.bankNameLabel.TabIndex = 38;
            this.bankNameLabel.Text = "AFFINITY PLUS";
            this.bankNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // selectAcToTransferFrompromptLabel
            // 
            this.selectAcToTransferFrompromptLabel.BackColor = System.Drawing.SystemColors.ControlText;
            this.selectAcToTransferFrompromptLabel.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.selectAcToTransferFrompromptLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.selectAcToTransferFrompromptLabel.Location = new System.Drawing.Point(71, 174);
            this.selectAcToTransferFrompromptLabel.Name = "selectAcToTransferFrompromptLabel";
            this.selectAcToTransferFrompromptLabel.Size = new System.Drawing.Size(394, 76);
            this.selectAcToTransferFrompromptLabel.TabIndex = 37;
            this.selectAcToTransferFrompromptLabel.Text = "Select Transfer Type";
            this.selectAcToTransferFrompromptLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // transferBackToMainButton
            // 
            this.transferBackToMainButton.BackColor = System.Drawing.SystemColors.Desktop;
            this.transferBackToMainButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.transferBackToMainButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.transferBackToMainButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.transferBackToMainButton.Location = new System.Drawing.Point(369, 408);
            this.transferBackToMainButton.Name = "transferBackToMainButton";
            this.transferBackToMainButton.Size = new System.Drawing.Size(242, 76);
            this.transferBackToMainButton.TabIndex = 36;
            this.transferBackToMainButton.Text = "Back to Transaction Menu";
            this.transferBackToMainButton.UseVisualStyleBackColor = false;
            this.transferBackToMainButton.Click += new System.EventHandler(this.transferBackToMainButton_Click);
            // 
            // transferLabel
            // 
            this.transferLabel.BackColor = System.Drawing.SystemColors.ControlText;
            this.transferLabel.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.transferLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.transferLabel.Location = new System.Drawing.Point(102, 88);
            this.transferLabel.Name = "transferLabel";
            this.transferLabel.Size = new System.Drawing.Size(554, 66);
            this.transferLabel.TabIndex = 33;
            this.transferLabel.Text = "Transfer";
            this.transferLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // amountToTransferPromptLabel
            // 
            this.amountToTransferPromptLabel.BackColor = System.Drawing.SystemColors.ControlText;
            this.amountToTransferPromptLabel.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.amountToTransferPromptLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.amountToTransferPromptLabel.Location = new System.Drawing.Point(71, 297);
            this.amountToTransferPromptLabel.Name = "amountToTransferPromptLabel";
            this.amountToTransferPromptLabel.Size = new System.Drawing.Size(394, 76);
            this.amountToTransferPromptLabel.TabIndex = 44;
            this.amountToTransferPromptLabel.Text = "Amount To Transfer";
            this.amountToTransferPromptLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // transferFromComboBox
            // 
            this.transferFromComboBox.FormattingEnabled = true;
            this.transferFromComboBox.Items.AddRange(new object[] {
            "-Select Transfer Type-",
            "Checking Account To Saving Account",
            "Saving Account To Checking Account"});
            this.transferFromComboBox.Location = new System.Drawing.Point(505, 190);
            this.transferFromComboBox.Name = "transferFromComboBox";
            this.transferFromComboBox.Size = new System.Drawing.Size(346, 23);
            this.transferFromComboBox.TabIndex = 45;
            // 
            // transferButton
            // 
            this.transferButton.BackColor = System.Drawing.SystemColors.Desktop;
            this.transferButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.transferButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.transferButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.transferButton.Location = new System.Drawing.Point(77, 408);
            this.transferButton.Name = "transferButton";
            this.transferButton.Size = new System.Drawing.Size(266, 76);
            this.transferButton.TabIndex = 47;
            this.transferButton.Text = "Transfer";
            this.transferButton.UseVisualStyleBackColor = false;
            this.transferButton.Click += new System.EventHandler(this.transferButton_Click);
            // 
            // TransferForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(924, 526);
            this.Controls.Add(this.transferButton);
            this.Controls.Add(this.transferFromComboBox);
            this.Controls.Add(this.amountToTransferPromptLabel);
            this.Controls.Add(this.depositTransferAmountTextBox);
            this.Controls.Add(this.transferpictureBox);
            this.Controls.Add(this.transferExitMyAccountButton);
            this.Controls.Add(this.bankSecondLabel);
            this.Controls.Add(this.bankNameLabel);
            this.Controls.Add(this.selectAcToTransferFrompromptLabel);
            this.Controls.Add(this.transferBackToMainButton);
            this.Controls.Add(this.transferLabel);
            this.Name = "TransferForm";
            this.Text = "Transfer Form";
            ((System.ComponentModel.ISupportInitialize)(this.transferpictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox depositTransferAmountTextBox;
        private PictureBox transferpictureBox;
        private Button transferExitMyAccountButton;
        private Label bankSecondLabel;
        private Label bankNameLabel;
        private Label selectAcToTransferFrompromptLabel;
        private Button transferBackToMainButton;
        private Label transferLabel;
        private Label amountToTransferPromptLabel;
        private ComboBox transferFromComboBox;
        private Button transferButton;
    }
}