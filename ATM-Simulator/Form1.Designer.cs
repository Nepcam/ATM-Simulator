namespace ATM_Simulator
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
            this.labelEnterAmount = new System.Windows.Forms.Label();
            this.textBoxEnterAmount = new System.Windows.Forms.TextBox();
            this.textBoxDisplayAmount = new System.Windows.Forms.TextBox();
            this.labelBalance = new System.Windows.Forms.Label();
            this.buttonDeposit = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelEnterAmount
            // 
            this.labelEnterAmount.AutoSize = true;
            this.labelEnterAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEnterAmount.Location = new System.Drawing.Point(48, 22);
            this.labelEnterAmount.Name = "labelEnterAmount";
            this.labelEnterAmount.Size = new System.Drawing.Size(107, 16);
            this.labelEnterAmount.TabIndex = 0;
            this.labelEnterAmount.Text = "Enter amount ($);";
            // 
            // textBoxEnterAmount
            // 
            this.textBoxEnterAmount.Location = new System.Drawing.Point(224, 21);
            this.textBoxEnterAmount.Name = "textBoxEnterAmount";
            this.textBoxEnterAmount.Size = new System.Drawing.Size(100, 20);
            this.textBoxEnterAmount.TabIndex = 1;
            // 
            // textBoxDisplayAmount
            // 
            this.textBoxDisplayAmount.Location = new System.Drawing.Point(224, 59);
            this.textBoxDisplayAmount.Name = "textBoxDisplayAmount";
            this.textBoxDisplayAmount.ReadOnly = true;
            this.textBoxDisplayAmount.Size = new System.Drawing.Size(100, 20);
            this.textBoxDisplayAmount.TabIndex = 2;
            // 
            // labelBalance
            // 
            this.labelBalance.AutoSize = true;
            this.labelBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBalance.Location = new System.Drawing.Point(48, 59);
            this.labelBalance.Name = "labelBalance";
            this.labelBalance.Size = new System.Drawing.Size(61, 16);
            this.labelBalance.TabIndex = 3;
            this.labelBalance.Text = "Balance:";
            // 
            // buttonDeposit
            // 
            this.buttonDeposit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDeposit.Location = new System.Drawing.Point(51, 126);
            this.buttonDeposit.Name = "buttonDeposit";
            this.buttonDeposit.Size = new System.Drawing.Size(75, 23);
            this.buttonDeposit.TabIndex = 4;
            this.buttonDeposit.Text = "Deposit";
            this.buttonDeposit.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(162, 126);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Withdraw";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // buttonExit
            // 
            this.buttonExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExit.Location = new System.Drawing.Point(266, 126);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(75, 23);
            this.buttonExit.TabIndex = 6;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.buttonDeposit);
            this.Controls.Add(this.labelBalance);
            this.Controls.Add(this.textBoxDisplayAmount);
            this.Controls.Add(this.textBoxEnterAmount);
            this.Controls.Add(this.labelEnterAmount);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelEnterAmount;
        private System.Windows.Forms.TextBox textBoxEnterAmount;
        private System.Windows.Forms.TextBox textBoxDisplayAmount;
        private System.Windows.Forms.Label labelBalance;
        private System.Windows.Forms.Button buttonDeposit;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button buttonExit;
    }
}

