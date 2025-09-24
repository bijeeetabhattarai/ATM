namespace ATM
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pinPromtLabel = new System.Windows.Forms.Label();
            this.pinTextBox = new System.Windows.Forms.TextBox();
            this.cancelButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.enterButton = new System.Windows.Forms.Button();
            this.cardNumberlabel = new System.Windows.Forms.Label();
            this.cardNumberTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // pinPromtLabel
            // 
            this.pinPromtLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pinPromtLabel.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.pinPromtLabel.Location = new System.Drawing.Point(81, 172);
            this.pinPromtLabel.Name = "pinPromtLabel";
            this.pinPromtLabel.Size = new System.Drawing.Size(566, 58);
            this.pinPromtLabel.TabIndex = 1;
            this.pinPromtLabel.Text = "PLEASE ENTER YOUR PIN ";
            this.pinPromtLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pinTextBox
            // 
            this.pinTextBox.BackColor = System.Drawing.SystemColors.Highlight;
            this.pinTextBox.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.pinTextBox.Location = new System.Drawing.Point(643, 172);
            this.pinTextBox.Name = "pinTextBox";
            this.pinTextBox.PasswordChar = '*';
            this.pinTextBox.Size = new System.Drawing.Size(162, 54);
            this.pinTextBox.TabIndex = 2;
            this.pinTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.pinTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.pinTextBox_KeyDown);
            this.pinTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.pinTextBox_KeyPress);
            // 
            // cancelButton
            // 
            this.cancelButton.BackColor = System.Drawing.SystemColors.ControlDark;
            this.cancelButton.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.cancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelButton.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cancelButton.Location = new System.Drawing.Point(435, 542);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(150, 89);
            this.cancelButton.TabIndex = 3;
            this.cancelButton.Text = "Exit";
            this.cancelButton.UseVisualStyleBackColor = false;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.BackColor = System.Drawing.SystemColors.ControlDark;
            this.clearButton.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.clearButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.clearButton.Location = new System.Drawing.Point(290, 542);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(146, 89);
            this.clearButton.TabIndex = 4;
            this.clearButton.Text = "CLEAR";
            this.clearButton.UseVisualStyleBackColor = false;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // enterButton
            // 
            this.enterButton.BackColor = System.Drawing.SystemColors.ControlDark;
            this.enterButton.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.enterButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.enterButton.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.enterButton.Location = new System.Drawing.Point(143, 542);
            this.enterButton.Name = "enterButton";
            this.enterButton.Size = new System.Drawing.Size(150, 89);
            this.enterButton.TabIndex = 5;
            this.enterButton.Text = "ENTER";
            this.enterButton.UseVisualStyleBackColor = false;
            this.enterButton.Click += new System.EventHandler(this.enterButton_Click);
            // 
            // cardNumberlabel
            // 
            this.cardNumberlabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.cardNumberlabel.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cardNumberlabel.Location = new System.Drawing.Point(81, 119);
            this.cardNumberlabel.Name = "cardNumberlabel";
            this.cardNumberlabel.Size = new System.Drawing.Size(566, 53);
            this.cardNumberlabel.TabIndex = 7;
            this.cardNumberlabel.Text = "PLEASE ENTER YOUR CARD NUMBER";
            this.cardNumberlabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cardNumberTextBox
            // 
            this.cardNumberTextBox.BackColor = System.Drawing.SystemColors.Highlight;
            this.cardNumberTextBox.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cardNumberTextBox.Location = new System.Drawing.Point(643, 119);
            this.cardNumberTextBox.Name = "cardNumberTextBox";
            this.cardNumberTextBox.Size = new System.Drawing.Size(162, 54);
            this.cardNumberTextBox.TabIndex = 1;
            this.cardNumberTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.cardNumberTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cardNumberTextBox_KeyDown);
            this.cardNumberTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cardNumberTextBox_KeyPress);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(887, 695);
            this.Controls.Add(this.cardNumberTextBox);
            this.Controls.Add(this.cardNumberlabel);
            this.Controls.Add(this.enterButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.pinTextBox);
            this.Controls.Add(this.pinPromtLabel);
            this.Name = "Form1";
            this.Text = "ATM Machine";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label pinPromtLabel;
        private TextBox pinTextBox;
        private Button cancelButton;
        private Button clearButton;
        private Button enterButton;
        private Label cardNumberlabel;
        private TextBox cardNumberTextBox;
    }
}