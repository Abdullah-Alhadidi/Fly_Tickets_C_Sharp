namespace FlyTickets
{
    partial class LogOut
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogOut));
            this.BTNMainMenu = new System.Windows.Forms.Button();
            this.BTNSignOut = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BTNMainMenu
            // 
            this.BTNMainMenu.BackColor = System.Drawing.Color.RoyalBlue;
            this.BTNMainMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTNMainMenu.FlatAppearance.BorderSize = 4;
            this.BTNMainMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNMainMenu.ForeColor = System.Drawing.Color.White;
            this.BTNMainMenu.Location = new System.Drawing.Point(179, 257);
            this.BTNMainMenu.Name = "BTNMainMenu";
            this.BTNMainMenu.Size = new System.Drawing.Size(294, 69);
            this.BTNMainMenu.TabIndex = 83;
            this.BTNMainMenu.Text = "Main Menu";
            this.BTNMainMenu.UseVisualStyleBackColor = false;
            this.BTNMainMenu.Click += new System.EventHandler(this.BTNMainMenu_Click);
            // 
            // BTNSignOut
            // 
            this.BTNSignOut.BackColor = System.Drawing.Color.RoyalBlue;
            this.BTNSignOut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTNSignOut.FlatAppearance.BorderSize = 4;
            this.BTNSignOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNSignOut.ForeColor = System.Drawing.Color.White;
            this.BTNSignOut.Location = new System.Drawing.Point(179, 354);
            this.BTNSignOut.Name = "BTNSignOut";
            this.BTNSignOut.Size = new System.Drawing.Size(294, 69);
            this.BTNSignOut.TabIndex = 82;
            this.BTNSignOut.Text = "Sign Out";
            this.BTNSignOut.UseVisualStyleBackColor = false;
            this.BTNSignOut.Click += new System.EventHandler(this.BTNSignOut_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label10.Font = new System.Drawing.Font("Tahoma", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label10.Location = new System.Drawing.Point(210, 13);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(225, 62);
            this.label10.TabIndex = 84;
            this.label10.Text = "Log Out";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label13.Location = new System.Drawing.Point(44, 164);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(552, 39);
            this.label13.TabIndex = 85;
            this.label13.Text = "Are you sure you want to sign out";
            // 
            // LogOut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(633, 450);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.BTNMainMenu);
            this.Controls.Add(this.BTNSignOut);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LogOut";
            this.Text = "LogOut";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTNMainMenu;
        private System.Windows.Forms.Button BTNSignOut;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label13;
    }
}