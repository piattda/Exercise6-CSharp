
namespace Exercise6
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
            this.label1 = new System.Windows.Forms.Label();
            this.AccountNumberTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.AccountBalanceTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.AccountHistoryTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.DepositRadioButton = new System.Windows.Forms.RadioButton();
            this.WithdrawalRadioButton = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.TransactionAmountTextbox = new System.Windows.Forms.TextBox();
            this.submit = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.TransactionStatusTextBox = new System.Windows.Forms.TextBox();
            this.getHistory = new System.Windows.Forms.Button();
            this.getStatus = new System.Windows.Forms.Button();
            this.close = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Account Number: ";
            // 
            // AccountNumberTextBox
            // 
            this.AccountNumberTextBox.Location = new System.Drawing.Point(190, 42);
            this.AccountNumberTextBox.Name = "AccountNumberTextBox";
            this.AccountNumberTextBox.ReadOnly = true;
            this.AccountNumberTextBox.Size = new System.Drawing.Size(186, 22);
            this.AccountNumberTextBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(452, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Account Balance: ";
            // 
            // AccountBalanceTextBox
            // 
            this.AccountBalanceTextBox.Location = new System.Drawing.Point(599, 40);
            this.AccountBalanceTextBox.Name = "AccountBalanceTextBox";
            this.AccountBalanceTextBox.ReadOnly = true;
            this.AccountBalanceTextBox.Size = new System.Drawing.Size(186, 22);
            this.AccountBalanceTextBox.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(934, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Account History";
            // 
            // AccountHistoryTextBox
            // 
            this.AccountHistoryTextBox.Location = new System.Drawing.Point(886, 82);
            this.AccountHistoryTextBox.Multiline = true;
            this.AccountHistoryTextBox.Name = "AccountHistoryTextBox";
            this.AccountHistoryTextBox.ReadOnly = true;
            this.AccountHistoryTextBox.Size = new System.Drawing.Size(219, 411);
            this.AccountHistoryTextBox.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Transaction Type:";
            // 
            // DepositRadioButton
            // 
            this.DepositRadioButton.AutoSize = true;
            this.DepositRadioButton.Location = new System.Drawing.Point(44, 155);
            this.DepositRadioButton.Name = "DepositRadioButton";
            this.DepositRadioButton.Size = new System.Drawing.Size(77, 21);
            this.DepositRadioButton.TabIndex = 8;
            this.DepositRadioButton.TabStop = true;
            this.DepositRadioButton.Text = "Deposit";
            this.DepositRadioButton.UseVisualStyleBackColor = true;
            // 
            // WithdrawalRadioButton
            // 
            this.WithdrawalRadioButton.AutoSize = true;
            this.WithdrawalRadioButton.Location = new System.Drawing.Point(44, 213);
            this.WithdrawalRadioButton.Name = "WithdrawalRadioButton";
            this.WithdrawalRadioButton.Size = new System.Drawing.Size(98, 21);
            this.WithdrawalRadioButton.TabIndex = 9;
            this.WithdrawalRadioButton.TabStop = true;
            this.WithdrawalRadioButton.Text = "Withdrawal";
            this.WithdrawalRadioButton.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(41, 279);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(143, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Transaction Amount: ";
            // 
            // TransactionAmountTextbox
            // 
            this.TransactionAmountTextbox.Location = new System.Drawing.Point(190, 279);
            this.TransactionAmountTextbox.Name = "TransactionAmountTextbox";
            this.TransactionAmountTextbox.Size = new System.Drawing.Size(197, 22);
            this.TransactionAmountTextbox.TabIndex = 11;
            this.TransactionAmountTextbox.TextChanged += new System.EventHandler(this.transactionAmountTextbox_TextChanged);
            // 
            // submit
            // 
            this.submit.Location = new System.Drawing.Point(44, 347);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(89, 27);
            this.submit.TabIndex = 12;
            this.submit.Text = "Submit";
            this.submit.UseVisualStyleBackColor = true;
            this.submit.Click += new System.EventHandler(this.submit_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(41, 412);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(131, 17);
            this.label6.TabIndex = 13;
            this.label6.Text = "Transaction Status:";
            // 
            // TransactionStatusTextBox
            // 
            this.TransactionStatusTextBox.Location = new System.Drawing.Point(190, 412);
            this.TransactionStatusTextBox.Name = "TransactionStatusTextBox";
            this.TransactionStatusTextBox.ReadOnly = true;
            this.TransactionStatusTextBox.Size = new System.Drawing.Size(419, 22);
            this.TransactionStatusTextBox.TabIndex = 14;
            // 
            // getHistory
            // 
            this.getHistory.Location = new System.Drawing.Point(44, 525);
            this.getHistory.Name = "getHistory";
            this.getHistory.Size = new System.Drawing.Size(110, 33);
            this.getHistory.TabIndex = 15;
            this.getHistory.Text = "Get History";
            this.getHistory.UseVisualStyleBackColor = true;
            this.getHistory.Click += new System.EventHandler(this.getHistory_Click);
            // 
            // getStatus
            // 
            this.getStatus.Location = new System.Drawing.Point(214, 525);
            this.getStatus.Name = "getStatus";
            this.getStatus.Size = new System.Drawing.Size(133, 33);
            this.getStatus.TabIndex = 16;
            this.getStatus.Text = "Get Status";
            this.getStatus.UseVisualStyleBackColor = true;
            this.getStatus.Click += new System.EventHandler(this.getStatus_Click);
            // 
            // close
            // 
            this.close.Location = new System.Drawing.Point(1017, 535);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(88, 23);
            this.close.TabIndex = 17;
            this.close.Text = "Close";
            this.close.UseVisualStyleBackColor = true;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1141, 637);
            this.Controls.Add(this.close);
            this.Controls.Add(this.getStatus);
            this.Controls.Add(this.getHistory);
            this.Controls.Add(this.TransactionStatusTextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.submit);
            this.Controls.Add(this.TransactionAmountTextbox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.WithdrawalRadioButton);
            this.Controls.Add(this.DepositRadioButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.AccountHistoryTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.AccountBalanceTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.AccountNumberTextBox);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox AccountNumberTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox AccountBalanceTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox AccountHistoryTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton DepositRadioButton;
        private System.Windows.Forms.RadioButton WithdrawalRadioButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TransactionAmountTextbox;
        private System.Windows.Forms.Button submit;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TransactionStatusTextBox;
        private System.Windows.Forms.Button getHistory;
        private System.Windows.Forms.Button getStatus;
        private System.Windows.Forms.Button close;
    }
}

