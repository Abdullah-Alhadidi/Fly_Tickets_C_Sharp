namespace FlyTickets
{
    partial class RegisterUsers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterUsers));
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TXBEmail = new System.Windows.Forms.TextBox();
            this.TXBUserName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TXBPassWord = new System.Windows.Forms.TextBox();
            this.BTNConfirm = new System.Windows.Forms.Button();
            this.ERRProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.LBLIssues = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.LBLBackToLogInPage = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ERRProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MintCream;
            this.label1.Location = new System.Drawing.Point(176, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(499, 66);
            this.label1.TabIndex = 1;
            this.label1.Text = "Create An Account";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.MintCream;
            this.label3.Location = new System.Drawing.Point(15, 337);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 31);
            this.label3.TabIndex = 8;
            this.label3.Text = "Email";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.MintCream;
            this.label2.Location = new System.Drawing.Point(21, 182);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 31);
            this.label2.TabIndex = 7;
            this.label2.Text = "UserName";
            // 
            // TXBEmail
            // 
            this.TXBEmail.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Bold);
            this.TXBEmail.Location = new System.Drawing.Point(21, 388);
            this.TXBEmail.Name = "TXBEmail";
            this.TXBEmail.Size = new System.Drawing.Size(781, 53);
            this.TXBEmail.TabIndex = 1;
            // 
            // TXBUserName
            // 
            this.TXBUserName.BackColor = System.Drawing.Color.White;
            this.TXBUserName.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXBUserName.Location = new System.Drawing.Point(21, 228);
            this.TXBUserName.Name = "TXBUserName";
            this.TXBUserName.Size = new System.Drawing.Size(781, 53);
            this.TXBUserName.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.MintCream;
            this.label4.Location = new System.Drawing.Point(15, 494);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(136, 31);
            this.label4.TabIndex = 10;
            this.label4.Text = "PassWord";
            // 
            // TXBPassWord
            // 
            this.TXBPassWord.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Bold);
            this.TXBPassWord.Location = new System.Drawing.Point(21, 545);
            this.TXBPassWord.Name = "TXBPassWord";
            this.TXBPassWord.Size = new System.Drawing.Size(781, 53);
            this.TXBPassWord.TabIndex = 2;
            // 
            // BTNConfirm
            // 
            this.BTNConfirm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTNConfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold);
            this.BTNConfirm.Location = new System.Drawing.Point(268, 712);
            this.BTNConfirm.Name = "BTNConfirm";
            this.BTNConfirm.Size = new System.Drawing.Size(268, 86);
            this.BTNConfirm.TabIndex = 3;
            this.BTNConfirm.Text = "Confirm";
            this.BTNConfirm.UseVisualStyleBackColor = true;
            this.BTNConfirm.Click += new System.EventHandler(this.BTNConfirm_Click);
            this.BTNConfirm.Validating += new System.ComponentModel.CancelEventHandler(this.BTNConfirm_Click);
            // 
            // ERRProvider
            // 
            this.ERRProvider.ContainerControl = this;
            // 
            // LBLIssues
            // 
            this.LBLIssues.BackColor = System.Drawing.Color.Transparent;
            this.LBLIssues.Font = new System.Drawing.Font("Microsoft YaHei UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLIssues.ForeColor = System.Drawing.Color.Lime;
            this.LBLIssues.Location = new System.Drawing.Point(12, 102);
            this.LBLIssues.Name = "LBLIssues";
            this.LBLIssues.Size = new System.Drawing.Size(812, 38);
            this.LBLIssues.TabIndex = 12;
            this.LBLIssues.Text = "Account Created Successfully";
            this.LBLIssues.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LBLIssues.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label5.Location = new System.Drawing.Point(15, 295);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(502, 31);
            this.label5.TabIndex = 13;
            this.label5.Text = "Email Can\'t Change After Press Confirm.";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LBLBackToLogInPage
            // 
            this.LBLBackToLogInPage.AutoSize = true;
            this.LBLBackToLogInPage.BackColor = System.Drawing.Color.Transparent;
            this.LBLBackToLogInPage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LBLBackToLogInPage.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLBackToLogInPage.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.LBLBackToLogInPage.Location = new System.Drawing.Point(276, 621);
            this.LBLBackToLogInPage.Name = "LBLBackToLogInPage";
            this.LBLBackToLogInPage.Size = new System.Drawing.Size(251, 31);
            this.LBLBackToLogInPage.TabIndex = 14;
            this.LBLBackToLogInPage.Text = "Back To LogIn Page";
            this.LBLBackToLogInPage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LBLBackToLogInPage.Click += new System.EventHandler(this.LBLBackToLogInPage_Click);
            // 
            // RegisterUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(60)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(836, 826);
            this.Controls.Add(this.LBLBackToLogInPage);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.LBLIssues);
            this.Controls.Add(this.BTNConfirm);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TXBPassWord);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TXBEmail);
            this.Controls.Add(this.TXBUserName);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RegisterUsers";
            this.Text = "RegisterUsers";
            this.Load += new System.EventHandler(this.RegisterUsers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ERRProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TXBEmail;
        private System.Windows.Forms.TextBox TXBUserName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TXBPassWord;
        private System.Windows.Forms.Button BTNConfirm;
        private System.Windows.Forms.ErrorProvider ERRProvider;
        private System.Windows.Forms.Label LBLIssues;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label LBLBackToLogInPage;
    }
}