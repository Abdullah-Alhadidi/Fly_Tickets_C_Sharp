using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace FlyTickets
{
    public partial class EditBooking : Form
    {
        string BookingDataFilePath = "D:/programming/projects/fly tickets oop C# .net framework/files/BookingData.txt";

        public EditBooking()
        {
            InitializeComponent();
        }
        private bool ValidateIsNotEmpty()
        {
            if (TXBFirstName.Text != "" && TXBLastName.Text != "" && CMBGender.Text != "" && CMBBookingKind.Text != "" && TXBJob.Text != "" 
                && TXBEmail.Text != "" && CMBCountries.Text != "")
                return true;
            else
                return false;
        }
        private struct stBookingData
        {
            public string Country, BookingKind, NumberOfBag, FirstName, LastName, PhoneNumber, Job, Email, Gender, BookingHotel, BookingNumber;
        }
        private stBookingData ConvertBookingDataLineToRecord(string Line)
        {
            stBookingData BookingData = new stBookingData();
            List<string> LBookingData = new List<string>();
            string Separator = "#//#";
            string[] Words = Line.Split(new string[] { Separator }, StringSplitOptions.None);
            foreach (string Word in Words)
            {
                LBookingData.Add(Word);
            }

            BookingData.Country = LBookingData[0];
            BookingData.BookingKind = LBookingData[1];
            BookingData.NumberOfBag = LBookingData[2];
            BookingData.FirstName = LBookingData[3];
            BookingData.LastName = LBookingData[4];
            BookingData.PhoneNumber = LBookingData[5];
            BookingData.Job = LBookingData[6];
            BookingData.Email = LBookingData[7];
            BookingData.Gender = LBookingData[8];
            BookingData.BookingHotel = LBookingData[9];
            BookingData.BookingNumber = LBookingData[10];

            return BookingData;
        }
        private string ConvertBookingDataRecordToLine(stBookingData BookingData)
        {
            string Line = BookingData.Country + "#//#" + BookingData.BookingKind + "#//#" + BookingData.NumberOfBag + "#//#" + BookingData.FirstName
                + "#//#" + BookingData.LastName + "#//#" + BookingData.PhoneNumber + "#//#" + BookingData.Job + "#//#" + BookingData.Email + "#//#"
                + BookingData.Gender + "#//#" + BookingData.BookingHotel + "#//#" + BookingData.BookingNumber;

            return Line;
        }
        private bool IsPhoneNumberExist()
        {
            if (File.Exists(BookingDataFilePath))
            {
                string[] Lines = File.ReadAllLines(BookingDataFilePath);

                foreach (string Line in Lines)
                {
                    stBookingData BookingData = ConvertBookingDataLineToRecord(Line);
                    if (TXBPhoneNumber.Text == BookingData.PhoneNumber)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
        private stBookingData GetBookingDataRecordThatNeedsToUpdate()
        {
            stBookingData NullBookingData = new stBookingData();
            if (File.Exists(BookingDataFilePath))
            {
                string[] Lines = File.ReadAllLines(BookingDataFilePath);

                foreach (string Line in Lines)
                {
                    stBookingData BookingData = ConvertBookingDataLineToRecord(Line);
                    if (TXBPhoneNumber.Text == BookingData.PhoneNumber)
                    {
                        return BookingData;
                    }
                }
            }
            return NullBookingData;
        }

        private string CheckBookingHotelYesOrNo()
        {
            if (RADBookAHotelYes.Checked == true)
                return "Yes";
            else
                return "No";
        }
        private string GenerateBookingNumber()
        {
            Random rnd = new Random();
            string NumberOfBooking = "";
            for (int i = 0; i <= 10; i++)
            {
                NumberOfBooking += Convert.ToString(rnd.Next(0, 9));
            }
            return NumberOfBooking;
        }
        private void EditPhoneNumber(stBookingData UpdatedBookingDataRecord)
        {
            List<string> Lines = File.ReadAllLines(BookingDataFilePath).ToList();
            for (int i = 0; i < Lines.Count; i++)
            {
                stBookingData CurrentBookingDataRecord = ConvertBookingDataLineToRecord(Lines[i]);
                if (CurrentBookingDataRecord.PhoneNumber == UpdatedBookingDataRecord.PhoneNumber)
                {
                    CurrentBookingDataRecord.Country = CMBCountries.Text;
                    CurrentBookingDataRecord.BookingKind = CMBBookingKind.Text;
                    CurrentBookingDataRecord.FirstName = TXBFirstName.Text;
                    CurrentBookingDataRecord.LastName = TXBLastName.Text;
                    CurrentBookingDataRecord.Job = TXBJob.Text;
                    CurrentBookingDataRecord.Email = TXBEmail.Text;
                    CurrentBookingDataRecord.Gender = CMBGender.Text;
                    CurrentBookingDataRecord.NumberOfBag = NUMNumberOfBag.Text;
                    CurrentBookingDataRecord.BookingHotel = CheckBookingHotelYesOrNo();
                    CurrentBookingDataRecord.BookingNumber = GenerateBookingNumber();
                    if (RADEidtPhoneNumberYes.Checked)
                        CurrentBookingDataRecord.PhoneNumber = TXBNewPhoneNumber.Text;
                    else
                        CurrentBookingDataRecord.PhoneNumber = TXBPhoneNumber.Text;
                    Lines[i] = ConvertBookingDataRecordToLine(CurrentBookingDataRecord);
                    File.WriteAllLines(BookingDataFilePath, Lines);
                    break;
                }
            }
        }
        private void RADEidtPhoneNumberYes_CheckedChanged(object sender, EventArgs e)
        {
            PANNewNumber.Visible = true;
        }
        private void RADEidtPhoneNumberNo_CheckedChanged(object sender, EventArgs e)
        {
            PANNewNumber.Visible = false;
        }
        private void BTNCheck_Click(object sender, EventArgs e)
        {
            if (IsPhoneNumberExist())
            {
                LBLIssues.Visible = false;
                PANControlls.Visible = true;
                PANNewNumber.Visible = false;
                BTNEdit.Enabled = true;
            }
            else
            {
                LBLIssues.Visible = true;
                LBLIssues.ForeColor = Color.Red;
                PANControlls.Visible = false;
                BTNEdit.Enabled = false;
            }
        }
        private bool CheckEditPhoneNumberOrNot()
        {
            if (RADEidtPhoneNumberYes.Checked)
                return true;
            else
                return false;
        }
        private bool ValidateIsPhoneNumberEmpty()
        {
            if (CheckEditPhoneNumberOrNot())
            {
                if (TXBNewPhoneNumber.Text == "")
                    return true;
            }
            return false;
        }
        private void BTNMainMenue_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void BTNEdit_Click(object sender, EventArgs e)
        {
            if (!ValidateIsPhoneNumberEmpty())
            {
                if (ValidateIsNotEmpty())
                {
                    EditPhoneNumber(GetBookingDataRecordThatNeedsToUpdate());
                    LBLIssues.Text = "Booking Updated Successfully.";
                    LBLIssues.Visible = true;
                    LBLIssues.ForeColor = Color.Lime;
                    BTNEdit.Enabled = false;
                    BTNCheck.Enabled = false;
                }
                else 
                {
                    LBLIssues.Text = "There are some empty feilds.";
                    LBLIssues.Visible = true;
                    LBLIssues.ForeColor = Color.Red;
                }
            }
            else
            {
                LBLIssues.Visible = true;
                LBLIssues.ForeColor = Color.Red;
                LBLIssues.Text = "Enter The New Phone Number.";
            }
        }
    }
}
