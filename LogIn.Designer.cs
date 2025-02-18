namespace FlyTickets
{
    partial class LogIn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogIn));
            this.label1 = new System.Windows.Forms.Label();
            this.TXBUserNameEmail = new System.Windows.Forms.TextBox();
            this.TXBPassWord = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.BTNSignIn = new System.Windows.Forms.Button();
            this.ERRProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.LBLCreateAccount = new System.Windows.Forms.Label();
            this.LBLIssues = new System.Windows.Forms.Label();
            this.LBLResetUserName = new System.Windows.Forms.Label();
            this.LBLResetPassWord = new System.Windows.Forms.Label();
            this.BTNExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ERRProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MintCream;
            this.label1.Location = new System.Drawing.Point(245, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(266, 96);
            this.label1.TabIndex = 0;
            this.label1.Text = "Log In";
            // 
            // TXBUserNameEmail
            // 
            this.TXBUserNameEmail.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXBUserNameEmail.Location = new System.Drawing.Point(12, 252);
            this.TXBUserNameEmail.Name = "TXBUserNameEmail";
            this.TXBUserNameEmail.Size = new System.Drawing.Size(715, 53);
            this.TXBUserNameEmail.TabIndex = 0;
            // 
            // TXBPassWord
            // 
            this.TXBPassWord.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXBPassWord.Location = new System.Drawing.Point(12, 388);
            this.TXBPassWord.Name = "TXBPassWord";
            this.TXBPassWord.Size = new System.Drawing.Size(715, 53);
            this.TXBPassWord.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.MintCream;
            this.label2.Location = new System.Drawing.Point(12, 206);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(218, 31);
            this.label2.TabIndex = 3;
            this.label2.Text = "UserName/Email";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.MintCream;
            this.label3.Location = new System.Drawing.Point(6, 337);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 31);
            this.label3.TabIndex = 4;
            this.label3.Text = "PassWord";
            // 
            // BTNSignIn
            // 
            this.BTNSignIn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTNSignIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNSignIn.Location = new System.Drawing.Point(414, 671);
            this.BTNSignIn.Name = "BTNSignIn";
            this.BTNSignIn.Size = new System.Drawing.Size(243, 86);
            this.BTNSignIn.TabIndex = 2;
            this.BTNSignIn.Text = "Sign IN";
            this.BTNSignIn.UseVisualStyleBackColor = true;
            this.BTNSignIn.Click += new System.EventHandler(this.BTNSignIn_Click);
            // 
            // ERRProvider
            // 
            this.ERRProvider.ContainerControl = this;
            // 
            // LBLCreateAccount
            // 
            this.LBLCreateAccount.AutoSize = true;
            this.LBLCreateAccount.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LBLCreateAccount.Font = new System.Drawing.Font("MS Reference Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLCreateAccount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.LBLCreateAccount.Location = new System.Drawing.Point(23, 476);
            this.LBLCreateAccount.Name = "LBLCreateAccount";
            this.LBLCreateAccount.Size = new System.Drawing.Size(717, 38);
            this.LBLCreateAccount.TabIndex = 6;
            this.LBLCreateAccount.Text = "You don\'t have an account creat a new one";
            this.LBLCreateAccount.Click += new System.EventHandler(this.LBLCreateAccount_Click);
            // 
            // LBLIssues
            // 
            this.LBLIssues.BackColor = System.Drawing.Color.Transparent;
            this.LBLIssues.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLIssues.ForeColor = System.Drawing.Color.Red;
            this.LBLIssues.Location = new System.Drawing.Point(12, 122);
            this.LBLIssues.Name = "LBLIssues";
            this.LBLIssues.Size = new System.Drawing.Size(743, 49);
            this.LBLIssues.TabIndex = 7;
            this.LBLIssues.Text = "BookingKind/PassWord Shouldn\'t Be Empty.";
            this.LBLIssues.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LBLIssues.Visible = false;
            // 
            // LBLResetUserName
            // 
            this.LBLResetUserName.AutoSize = true;
            this.LBLResetUserName.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LBLResetUserName.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLResetUserName.ForeColor = System.Drawing.Color.Lime;
            this.LBLResetUserName.Location = new System.Drawing.Point(223, 524);
            this.LBLResetUserName.Name = "LBLResetUserName";
            this.LBLResetUserName.Size = new System.Drawing.Size(321, 29);
            this.LBLResetUserName.TabIndex = 9;
            this.LBLResetUserName.Text = "Forget/Reset UserName";
            this.LBLResetUserName.Click += new System.EventHandler(this.LBLResetUserName_Click);
            // 
            // LBLResetPassWord
            // 
            this.LBLResetPassWord.AutoSize = true;
            this.LBLResetPassWord.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LBLResetPassWord.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLResetPassWord.ForeColor = System.Drawing.Color.Lime;
            this.LBLResetPassWord.Location = new System.Drawing.Point(224, 563);
            this.LBLResetPassWord.Name = "LBLResetPassWord";
            this.LBLResetPassWord.Size = new System.Drawing.Size(315, 29);
            this.LBLResetPassWord.TabIndex = 10;
            this.LBLResetPassWord.Text = "Forget/Reset PassWord";
            this.LBLResetPassWord.Click += new System.EventHandler(this.LBLResetPassWord_Click);
            // 
            // BTNExit
            // 
            this.BTNExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTNExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNExit.Location = new System.Drawing.Point(120, 671);
            this.BTNExit.Name = "BTNExit";
            this.BTNExit.Size = new System.Drawing.Size(243, 86);
            this.BTNExit.TabIndex = 3;
            this.BTNExit.Text = "Exit";
            this.BTNExit.UseVisualStyleBackColor = true;
            this.BTNExit.Click += new System.EventHandler(this.BTNExit_Click);
            // 
            // LogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(767, 800);
            this.Controls.Add(this.BTNExit);
            this.Controls.Add(this.LBLResetPassWord);
            this.Controls.Add(this.LBLResetUserName);
            this.Controls.Add(this.LBLIssues);
            this.Controls.Add(this.LBLCreateAccount);
            this.Controls.Add(this.BTNSignIn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TXBPassWord);
            this.Controls.Add(this.TXBUserNameEmail);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LogIn";
            this.Text = "Log In";
            this.Load += new System.EventHandler(this.LogIn_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ERRProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TXBUserNameEmail;
        private System.Windows.Forms.TextBox TXBPassWord;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BTNSignIn;
        private System.Windows.Forms.ErrorProvider ERRProvider;
        private System.Windows.Forms.Label LBLCreateAccount;
        private System.Windows.Forms.Label LBLIssues;
        private System.Windows.Forms.Label LBLResetUserName;
        private System.Windows.Forms.Label LBLResetPassWord;
        private System.Windows.Forms.Button BTNExit;
    }
}