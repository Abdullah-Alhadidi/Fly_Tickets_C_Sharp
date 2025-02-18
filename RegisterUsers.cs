using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Security.Cryptography;
using System.Reflection;

namespace FlyTickets
{
    public partial class RegisterUsers : Form
    {
        string LogInInfoFilePath = "D:/programming/projects/fly tickets oop C# .net framework/files/UsersRegistration.txt";

        public RegisterUsers()
        {
            InitializeComponent();
        }
        private void RegisterUsers_Load(object sender, EventArgs e)
        {
            TXBUserName.Focus();
        }
        private void TXBUserName_Validating()
        {
            if (string.IsNullOrEmpty(TXBUserName.Text))
                ERRProvider.SetError(TXBUserName, "User Name Should Have A Value!");
        }
        private void TXBEmail_Validating()
        {
            if (string.IsNullOrEmpty(TXBEmail.Text))
                ERRProvider.SetError(TXBEmail, "Email Should Have A Value!");
        }
        private void TXBPassWord_Validating()
        {
            if (string.IsNullOrEmpty(TXBPassWord.Text))
                ERRProvider.SetError(TXBPassWord, "PassWord Should Have A Value!");
        }
        private bool ValidateIsNotTextBoxEmpty()
        {
            TXBUserName_Validating();
            TXBEmail_Validating();
            TXBPassWord_Validating();

            if (TXBUserName.Text != "" && TXBEmail.Text != "" && TXBPassWord.Text != "")
                return true;
            else
                return false;
        }
        private bool CheckIsContainCommaSymbol(string Text)
        {
            for (int i = 0; i < Text.Length; i++) 
            {
                if (Text[i] == ',') 
                    return true;
            }
            return false;
        }
        private void LBLBackToLogInPage_Click(object sender, EventArgs e)
        {
            this.Close();
            Form frm = new LogIn();
            frm.Show();
        }
        private void CommaSymbolMessage()
        {
            LBLIssues.Text = "Email/UserName/PassWord Shouldn't Contain Comma Symbol (,)";
            LBLIssues.Visible = true;
            LBLIssues.ForeColor = Color.Red;
        }
        private void PerformCreatedAccountChanges() 
        {

            LBLIssues.ForeColor = Color.Lime;
            LBLIssues.Text = "Account Created Successfully";
            LBLIssues.Visible = true;

            TXBUserName.BackColor = Color.White;
            TXBEmail.BackColor = Color.White;
            TXBPassWord.BackColor = Color.White;

            TXBUserName.Enabled = false;
            TXBEmail.Enabled = false;
            TXBPassWord.Enabled = false;

            BTNConfirm.Enabled = false;
        }

        private void PerformConfirmBTN()
        {
            if (!CheckIsContainCommaSymbol(TXBUserName.Text))
            {
                if (!CheckIsContainCommaSymbol(TXBEmail.Text))
                {
                    if (!CheckIsContainCommaSymbol(TXBPassWord.Text))
                    {
                        string Record = TXBUserName.Text.ToLower() + "," + TXBEmail.Text.ToLower() + "," + TXBPassWord.Text + "\n";
                        File.AppendAllText(LogInInfoFilePath, Record);
                        TXBUserName.Text = "";
                        TXBEmail.Text = "";
                        TXBPassWord.Text = "";

                        PerformCreatedAccountChanges();
                    }
                    else
                    {
                        CommaSymbolMessage();
                        TXBPassWord.BackColor = Color.RosyBrown;
                    }
                }
                else
                {
                    CommaSymbolMessage();
                    TXBEmail.BackColor = Color.RosyBrown;
                }
            }
            else
            {
                CommaSymbolMessage();
                TXBUserName.BackColor = Color.RosyBrown;
            }
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
        private bool IsEmailExist()
        {
            if (File.Exists(LogInInfoFilePath))
            {
                string[] Lines = File.ReadAllLines(LogInInfoFilePath);

                foreach (string Line in Lines)
                {
                    stLogInInfo LogInInfo = ConvertLogInDataLineToRecord(Line);
                    if (LogInInfo.Email == TXBEmail.Text.ToLower())
                    return true;
                }
            }
            return false;
        }
        private void BTNConfirm_Click(object sender, EventArgs e)
        {
            if (ValidateIsNotTextBoxEmpty())
            {
                if (!IsEmailExist()) 
                    PerformConfirmBTN();
                else
                {
                    LBLIssues.Text = "Email Is Already Used, Tray Another One.";
                    LBLIssues.Visible = true;
                    LBLIssues.ForeColor = Color.Red;
                }
            }
            else
            {
                LBLIssues.Text = "Email/UserName/PassWord Shouldn't Be Empty.";
                LBLIssues.Visible = true;
                LBLIssues.ForeColor = Color.Red;
            }
        }


    }
}
