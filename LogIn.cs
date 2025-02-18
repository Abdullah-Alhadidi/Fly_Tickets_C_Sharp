using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Collections.Specialized;
using static System.Resources.ResXFileRef;
using System.Runtime.InteropServices.ComTypes;
using static System.Windows.Forms.LinkLabel;

namespace FlyTickets
{
    public partial class LogIn : Form
    {
        string LogInInfoFilePath = "D:/programming/projects/fly tickets oop C# .net framework/files/UsersRegistration.txt";

        public LogIn()
        {
            InitializeComponent();
        }
        private void LogIn_Load(object sender, EventArgs e)
        {
            TXBUserNameEmail.Focus();   
        }
        private void TXBEmail_Validating()
        {
            if (string.IsNullOrEmpty(TXBUserNameEmail.Text))
                ERRProvider.SetError(TXBUserNameEmail, "Email/UserName Should Have A Value!");
        }
        private void TXBPassWord_Validating()
        {
            if (string.IsNullOrEmpty(TXBPassWord.Text))
                ERRProvider.SetError(TXBPassWord, "PassWord Should Have A Value!");
        }
        private bool ValidateIsNotTextBoxEmpty()
        {
            TXBEmail_Validating();
            TXBPassWord_Validating();
            if (TXBUserNameEmail.Text != "" && TXBPassWord.Text != "")
                return true;
            else
                return false;
        }
        private void LBLCreateAccount_Click(object sender, EventArgs e)
        {
            Form FRM = new RegisterUsers();
            FRM.Show();
            this.Hide();
        }
        private void LBLResetUserName_Click(object sender, EventArgs e)
        {
            Form FRM = new ResetUserNameOrPassWord();
            FRM.Show();
            ResetUserNameOrPassWord.SetGetLabelUserNameOrPassWord = "New UserName";
            this.Hide();
        }
        private void LBLResetPassWord_Click(object sender, EventArgs e)
        {
            Form FRM = new ResetUserNameOrPassWord();
            FRM.Show();
            ResetUserNameOrPassWord.SetGetLabelUserNameOrPassWord = "New PassWord";
            this.Hide();
        }
        private struct stLogInInfo
        {
            public string UserName;
            public string Email;
            public string PassWord;
        }
        private stLogInInfo ConvertLogInDataLineToRecord(string Line)
        {
            stLogInInfo LogInInfo = new stLogInInfo();
            List<string> LLogInInfo = new List<string>();
            string[] Words = Line.Split(',');
            foreach (string Word in Words)
            {
                LLogInInfo.Add(Word);
            }
            if (LLogInInfo.Count >= 3)
            {
                LogInInfo.UserName = LLogInInfo[0];
                LogInInfo.Email = LLogInInfo[1];
                LogInInfo.PassWord = LLogInInfo[2];
            }

            return LogInInfo;
        }
        private bool IsEmailExist(stLogInInfo LogInInfo)
        {
            if (LogInInfo.Email == TXBUserNameEmail.Text.ToLower())
                return true;
            else
                return false;
        }
        private bool IsUserNameExist(stLogInInfo LogInInfo)
        {
            if (LogInInfo.UserName == TXBUserNameEmail.Text.ToLower())
                return true;
            else
                return false;
        }
        private bool IsPassWordExist(stLogInInfo LogInInfo)
        {
            if (LogInInfo.PassWord == TXBPassWord.Text.ToLower())
                return true;
            else
                return false;
        }
        private bool CheckInputs()
        {
            if (File.Exists(LogInInfoFilePath))
            {
                string[] Lines = File.ReadAllLines(LogInInfoFilePath);

                foreach (string Line in Lines)
                {

                    stLogInInfo LogInInfo = ConvertLogInDataLineToRecord(Line);
                    if ((IsEmailExist(LogInInfo) || IsUserNameExist(LogInInfo)) && IsPassWordExist(LogInInfo))
                    {
                        return true;
                    }
                }
            }
            return false;
        }
        private void ShowLBLIssuesErrors(string Text)
        {
            LBLIssues.Text = Text;
            LBLIssues.Visible = true;
            LBLIssues.ForeColor = Color.Red;
        }
        private void PerformSignInBTN()
        {
            if (CheckInputs())
            {
                this.Hide();
                Form frm = new MainMenu();
                frm.Show();
            }
            else
            {
                ShowLBLIssuesErrors("Email/UserName Or PassWord Is Incorrect.");
            }

        }
        private void BTNSignIn_Click(object sender, EventArgs e)
        {

            if (ValidateIsNotTextBoxEmpty())
                PerformSignInBTN();
            else
            {
                ShowLBLIssuesErrors("Email/UserName Or PassWord Shouldn't Be Empty.");
            }
        }

        private void BTNExit_Click(object sender, EventArgs e)
        {
            //Application.Exit();
            Environment.Exit(0);
        }
    }
}
