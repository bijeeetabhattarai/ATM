namespace ATM
{
    partial class CashWithdrawal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CashWithdrawal));
            this.bankSecondLabel = new System.Windows.Forms.Label();
            this.bankNameLabel = new System.Windows.Forms.Label();
            this.cashWPromptLabel = new System.Windows.Forms.Label();
            this.cashWBackToMainButton = new System.Windows.Forms.Button();
            this.cashWlSavingAccountButton = new System.Windows.Forms.Button();
            this.CashWCheckingAccountButton = new System.Windows.Forms.Button();
            this.cashWithdrawalLabel = new System.Windows.Forms.Label();
            this.cashWExitMyAccountButton = new System.Windows.Forms.Button();
            this.cashWTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // bankSecondLabel
            // 
            this.bankSecondLabel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.bankSecondLabel.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bankSecondLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.bankSecondLabel.Location = new System.Drawing.Point(638, 33);
            this.bankSecondLabel.Name = "bankSecondLabel";
            this.bankSecondLabel.Size = new System.Drawing.Size(148, 33);
            this.bankSecondLabel.TabIndex = 19;
            this.bankSecondLabel.Text = "CREDIT UNION";
            this.bankSecondLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bankNameLabel
            // 
            this.bankNameLabel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.bankNameLabel.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bankNameLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.bankNameLabel.Location = new System.Drawing.Point(522, 0);
            this.bankNameLabel.Name = "bankNameLabel";
            this.bankNameLabel.Size = new System.Drawing.Size(264, 44);
            this.bankNameLabel.TabIndex = 18;
            this.bankNameLabel.Text = "AFFINITY PLUS";
            this.bankNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cashWPromptLabel
            // 
            this.cashWPromptLabel.BackColor = System.Drawing.SystemColors.ControlText;
            this.cashWPromptLabel.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cashWPromptLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.cashWPromptLabel.Location = new System.Drawing.Point(135, 174);
            this.cashWPromptLabel.Name = "cashWPromptLabel";
            this.cashWPromptLabel.Size = new System.Drawing.Size(242, 76);
            this.cashWPromptLabel.TabIndex = 17;
            this.cashWPromptLabel.Text = "Enter The Amount To Withdraw";
            this.cashWPromptLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cashWBackToMainButton
            // 
            this.cashWBackToMainButton.BackColor = System.Drawing.SystemColors.Desktop;
            this.cashWBackToMainButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.cashWBackToMainButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cashWBackToMainButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cashWBackToMainButton.Location = new System.Drawing.Point(135, 394);
            this.cashWBackToMainButton.Name = "cashWBackToMainButton";
            this.cashWBackToMainButton.Size = new System.Drawing.Size(242, 76);
            this.cashWBackToMainButton.TabIndex = 15;
            this.cashWBackToMainButton.Text = "Back to Transaction Menu";
            this.cashWBackToMainButton.UseVisualStyleBackColor = false;
            this.cashWBackToMainButton.Click += new System.EventHandler(this.cashWBackToMainButton_Click);
            // 
            // cashWlSavingAccountButton
            // 
            this.cashWlSavingAccountButton.BackColor = System.Drawing.SystemColors.Desktop;
            this.cashWlSavingAccountButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.cashWlSavingAccountButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cashWlSavingAccountButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cashWlSavingAccountButton.Location = new System.Drawing.Point(423, 299);
            this.cashWlSavingAccountButton.Name = "cashWlSavingAccountButton";
            this.cashWlSavingAccountButton.Size = new System.Drawing.Size(266, 76);
            this.cashWlSavingAccountButton.TabIndex = 14;
            this.cashWlSavingAccountButton.Text = "Saving Account";
            this.cashWlSavingAccountButton.UseVisualStyleBackColor = false;
            this.cashWlSavingAccountButton.Click += new System.EventHandler(this.cashWlSavingAccountButton_Click);
            // 
            // CashWCheckingAccountButton
            // 
            this.CashWCheckingAccountButton.BackColor = System.Drawing.SystemColors.Desktop;
            this.CashWCheckingAccountButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.CashWCheckingAccountButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CashWCheckingAccountButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.CashWCheckingAccountButton.Location = new System.Drawing.Point(135, 299);
            this.CashWCheckingAccountButton.Name = "CashWCheckingAccountButton";
            this.CashWCheckingAccountButton.Size = new System.Drawing.Size(242, 76);
            this.CashWCheckingAccountButton.TabIndex = 13;
            this.CashWCheckingAccountButton.Text = "Checking Account";
            this.CashWCheckingAccountButton.UseVisualStyleBackColor = false;
            this.CashWCheckingAccountButton.Click += new System.EventHandler(this.CashWCheckingAccountButton_Click);
            // 
            // cashWithdrawalLabel
            // 
            this.cashWithdrawalLabel.BackColor = System.Drawing.SystemColors.ControlText;
            this.cashWithdrawalLabel.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cashWithdrawalLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.cashWithdrawalLabel.Location = new System.Drawing.Point(135, 87);
            this.cashWithdrawalLabel.Name = "cashWithdrawalLabel";
            this.cashWithdrawalLabel.Size = new System.Drawing.Size(554, 66);
            this.cashWithdrawalLabel.TabIndex = 12;
            this.cashWithdrawalLabel.Text = "Cash Withdrawal";
            this.cashWithdrawalLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cashWExitMyAccountButton
            // 
            this.cashWExitMyAccountButton.BackColor = System.Drawing.SystemColors.Desktop;
            this.cashWExitMyAccountButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.cashWExitMyAccountButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cashWExitMyAccountButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cashWExitMyAccountButton.Location = new System.Drawing.Point(423, 394);
            this.cashWExitMyAccountButton.Name = "cashWExitMyAccountButton";
            this.cashWExitMyAccountButton.Size = new System.Drawing.Size(266, 76);
            this.cashWExitMyAccountButton.TabIndex = 21;
            this.cashWExitMyAccountButton.Text = "Exit My Account";
            this.cashWExitMyAccountButton.UseVisualStyleBackColor = false;
            this.cashWExitMyAccountButton.Click += new System.EventHandler(this.cashWExitMyAccountButton_Click);
            // 
            // cashWTextBox
            // 
            this.cashWTextBox.Location = new System.Drawing.Point(423, 190);
            this.cashWTextBox.Name = "cashWTextBox";
            this.cashWTextBox.Size = new System.Drawing.Size(266, 23);
            this.cashWTextBox.TabIndex = 22;
            this.cashWTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // CashWithdrawal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(841, 536);
            this.Controls.Add(this.cashWTextBox);
            this.Controls.Add(this.cashWExitMyAccountButton);
            this.Controls.Add(this.bankSecondLabel);
            this.Controls.Add(this.bankNameLabel);
            this.Controls.Add(this.cashWPromptLabel);
            this.Controls.Add(this.cashWBackToMainButton);
            this.Controls.Add(this.cashWlSavingAccountButton);
            this.Controls.Add(this.CashWCheckingAccountButton);
            this.Controls.Add(this.cashWithdrawalLabel);
            this.Name = "CashWithdrawal";
            this.Text = "Form4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label bankSecondLabel;
        private Label bankNameLabel;
        private Label cashWPromptLabel;
        private Button cashWBackToMainButton;
        private Button cashWlSavingAccountButton;
        private Button CashWCheckingAccountButton;
        private Label cashWithdrawalLabel;
        private Button cashWExitMyAccountButton;
        private TextBox cashWTextBox;
    }
}