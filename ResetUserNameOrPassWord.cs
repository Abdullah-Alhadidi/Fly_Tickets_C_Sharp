using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.LinkLabel;

namespace FlyTickets
{
    public partial class ResetUserNameOrPassWord : Form
    {
        public static Label StaticLBLUserNameOrPassWord;
        string LogInInfoFilePath = "D:/programming/projects/fly tickets oop C# .net framework/files/UsersRegistration.txt";
        public ResetUserNameOrPassWord()
        {
            InitializeComponent();
            StaticLBLUserNameOrPassWord = LBLNewUserNameOrPassWord;
        }
        private void ResetUserNameOrPassWord_Load(object sender, EventArgs e)
        {
            TXBEmail.Focus();
            TXBUserNameAndPassWord.Text = " ";
        }
        private void LBLBackToLogInPage_Click(object sender, EventArgs e)
        {
            this.Close();
            Form frm = new LogIn();
            frm.Show();
        }
        private void TXBEmail_Validating()
        {
            if (string.IsNullOrEmpty(TXBEmail.Text))
                ERRProvider.SetError(TXBEmail, "Email Should Have A Value!");
        }
        private void TXBUserNameOrPassWord_Validating()
        {
            if (string.IsNullOrEmpty(TXBUserNameAndPassWord.Text))
                ERRProvider.SetError(TXBUserNameAndPassWord, "UserName/PassWord Should Have A Value!");
        }
        private bool ValidateIsNotTextBoxEmpty()
        {
            TXBEmail_Validating();
            TXBUserNameOrPassWord_Validating();

            if (TXBEmail.Text != "" && TXBUserNameAndPassWord.Text != "")
                return true;
            else
                return false;
        }

        static public string SetGetLabelUserNameOrPassWord
        {
            set { StaticLBLUserNameOrPassWord.Text = value; }
            get { return StaticLBLUserNameOrPassWord.Text; }
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
                    if (TXBEmail.Text.ToLower() == LogInInfo.Email)
                    {
                        return true;
                    }
                }
            }

            return false;
        }
        private string ConvertRecordLogInInfoToLine(List<stLogInInfo> LLogInInfo)
        {
            string Separator = ",";
            string LogInInfoRecord = "";
            foreach (stLogInInfo LogInInfo in LLogInInfo)
            {
                LogInInfoRecord += LogInInfo.UserName + Separator;
                LogInInfoRecord += LogInInfo.Email + Separator;
                LogInInfoRecord += LogInInfo.PassWord + "\n";
            }

            return LogInInfoRecord;
        }
        private void SaveLogInInfoToFile(List<stLogInInfo> LLogInInfo)
        {
            string DataLine = ConvertRecordLogInInfoToLine(LLogInInfo);
            File.WriteAllText(LogInInfoFilePath, DataLine.ToLower());
        }
        private void UpdateLogInInfo(string UserNameOrPassWordUpdate)
        {
            List<stLogInInfo> LLogInInfo = new List<stLogInInfo>();

            if (File.Exists(LogInInfoFilePath))
            {
                string[] Lines = File.ReadAllLines(LogInInfoFilePath);

                foreach (string Line in Lines)
                {
                    stLogInInfo LogInInfo = ConvertLogInDataLineToRecord(Line);
                    if (TXBEmail.Text == LogInInfo.Email)
                    {
                        if (LBLNewUserNameOrPassWord.Text == "New UserName")
                            LogInInfo.UserName = UserNameOrPassWordUpdate;
                        else
                            LogInInfo.PassWord = UserNameOrPassWordUpdate;
                    }
                    LLogInInfo.Add(LogInInfo);
                }
                SaveLogInInfoToFile(LLogInInfo);
            }
        }
        private void ShowLBLIssuesErrors(string Text)
        {
            LBLIssues.Text = Text;
            LBLIssues.ForeColor = Color.Red;
            LBLIssues.Visible = true;
        }
        private void LBLCheckEmail_Click(object sender, EventArgs e)
        {
            if (ValidateIsNotTextBoxEmpty())
            {
                if (IsEmailExist())
                {
                    LBLIssues.Visible = false;
                    TXBUserNameAndPassWord.Enabled = true;
                    TXBEmail.Text = TXBEmail.Text;
                    TXBUserNameAndPassWord.Text = "";
                    TXBUserNameAndPassWord.BackColor = Color.White;
                    BTNReset.Enabled = true;
                }
                else
                {
                    TXBUserNameAndPassWord.Enabled = false;
                    TXBUserNameAndPassWord.Text = " ";
                    TXBUserNameAndPassWord.BackColor = Color.Silver;
                    BTNReset.Enabled = false;
                    ShowLBLIssuesErrors("Email Is Not Found");
                }
            }
            else
            {
                if (LBLNewUserNameOrPassWord.Text == "New UserName")
                    ShowLBLIssuesErrors("UserName Shouldn't Be Empty.");
                else
                    ShowLBLIssuesErrors("PassWord Shouldn't Be Empty.");
            }
        }
        private void BTNReset_Click(object sender, EventArgs e)
        {
            if (ValidateIsNotTextBoxEmpty())
            {
                UpdateLogInInfo(TXBUserNameAndPassWord.Text);
                LBLIssues.Text = "Updated Successfully";
                LBLIssues.ForeColor = Color.Lime;
                LBLIssues.Visible = true;
                BTNReset.Enabled = false;
            }
            else
            {
                if (LBLNewUserNameOrPassWord.Text == "New UserName")
                    ShowLBLIssuesErrors("UserName Shouldn't Be Empty.");
                else
                    ShowLBLIssuesErrors("PassWord Shouldn't Be Empty.");
            }
        }

    }
}
