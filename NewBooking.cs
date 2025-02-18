using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlyTickets
{
    public partial class NewBooking : Form
    {
        string BookingDataFilePath = "D:/programming/projects/fly tickets oop C# .net framework/files/BookingData.txt";

        public NewBooking()
        {
            InitializeComponent();
        }
        private bool ValidateIsNotEmpty()
        {
            if (CBCountries.Text != "" && CBBookingKind.Text != "" && TXBFirstName.Text != "" && TXBLastName.Text != "" && TXBPhoneNumber.Text != ""
                && TXBJob.Text != "" && TXBEmail.Text != "" && CBGender.Text != "")
                return true;
            else
                return false;
        }
        private string CheckBookingHotelYesOrNo()
        {
            if (RDBBookingHotelYes.Checked == true)
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
        private void BTNSubmit_Click(object sender, EventArgs e)
        {
            if (ValidateIsNotEmpty())
            {
                if (!IsPhoneNumberExist())
                {
                    string Record = (CBCountries.Text + "#//#" + CBBookingKind.Text + "#//#" + NUDNumberOfBooking.Text + "#//#" + TXBFirstName.Text
                        + "#//#" + TXBLastName.Text + "#//#" + TXBPhoneNumber.Text + "#//#" + TXBJob.Text + "#//#" + TXBEmail.Text + "#//#" + 
                        CBGender.Text + "#//#" + CheckBookingHotelYesOrNo() + "#//#" + GenerateBookingNumber() + "\n");

                    File.AppendAllText(BookingDataFilePath, Record);
                    LBLIssues.ForeColor = Color.Lime;
                    LBLIssues.Text = "Booked successfully";
                    LBLIssues.Visible = true;
                    BTNSubmit.Enabled = false;
                }
                else
                {
                    LBLIssues.Text = "Phone number already exist";
                    LBLIssues.Visible = true;
                }
            }
            else
                LBLIssues.Visible = true;
        }
        private void BTNMainMenue_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
