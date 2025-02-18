﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlyTickets
{
    public partial class FindPreviousBooking : Form
    {
        string BookingDataFilePath = "D:/programming/projects/fly tickets oop C# .net framework/files/BookingData.txt";

        public FindPreviousBooking()
        {
            InitializeComponent();
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
        private void AssignValuesOfBookingData(stBookingData BookingData)
        {
            LBLCountry.Text = BookingData.Country;
            LBLBookingKind.Text = BookingData.BookingKind;
            LBLFirstName.Text = BookingData.FirstName;
            LBLLastName.Text = BookingData.LastName;
            LBLPhoneNumber.Text = BookingData.PhoneNumber;
            LBLJob.Text = BookingData.Job;
            LBLEmail.Text = BookingData.Email;
            LBLGender.Text = BookingData.Gender;
            LBLBookingNumber.Text = BookingData.BookingNumber;
            LBLbookAHotel.Text = BookingData.BookingHotel;
            LBLNumberOfBag.Text = BookingData.NumberOfBag;
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
                        AssignValuesOfBookingData(BookingData);
                        return true;
                    }
                }
            }
            return false;
        }
        private void BTNCheck_Click(object sender, EventArgs e)
        {
            if (IsPhoneNumberExist())
            {
                LBLIssues.Visible = false;

                LBLCountry.Visible = true;
                LBLBookingKind.Visible = true;
                LBLFirstName.Visible = true;
                LBLLastName.Visible = true;
                LBLPhoneNumber.Visible = true;
                LBLJob.Visible = true;
                LBLEmail.Visible = true;
                LBLGender.Visible = true;
                LBLbookAHotel.Visible = true;
                LBLBookingNumber.Visible = true;
                LBLNumberOfBag.Visible = true;
            }
            else
            {
                LBLIssues.Visible = true;

                LBLCountry.Visible = false;
                LBLBookingKind.Visible = false;
                LBLFirstName.Visible = false;
                LBLLastName.Visible = false;
                LBLPhoneNumber.Visible = false;
                LBLJob.Visible = false;
                LBLEmail.Visible = false;
                LBLGender.Visible = false;
                LBLbookAHotel.Visible = false;
                LBLBookingNumber.Visible = false;
                LBLNumberOfBag.Visible = false;
            }
        }

        private void BTNMainMenue_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
