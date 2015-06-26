using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MiniDatabase.Classes;
using System.IO;

namespace MiniDatabase
{
    

    
    public partial class Form1 : Form, IDBOperations
    {

        private const string filePath = "C:\\Temp\\Db.csv";

        
        public Form1()
        {
            InitializeComponent();
        }

        public bool saveData(Record record)
        {
            StringBuilder csv = new StringBuilder();
            csv.Append(record.UserName);
            csv.Append(";");
            csv.Append(record.FirstName);
            csv.Append(";");
            csv.Append(record.LastName);
            csv.Append(";");
            csv.Append(record.Department);
            csv.Append(";");
            csv.Append(record.AccountEndDatestr);
            csv.Append(";");
            csv.Append(record.TelephoneNumber);

            File.AppendAllText(filePath, csv.ToString());


            return true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string phone = PhoneCountryCode.Text + " " + PhoneAreaCode.Text + " " + PhoneNumber.Text;
            Record tempRecord = new Record(UserName.Text, FirstName.Text, LastName.Text, Department.Text, AccountEndDate.Value, phone);
            if (saveData(tempRecord))
            {
                MessageBox.Show("Success!!!", "Congratulations");
            }


        }

        private bool FormValidation()
        {
            if (UserName.Text.Length < 10)
            {
                MessageBox.Show("User Name should be less than 10 characters", "Input Error");
                return false;
            }

            if (FirstName.Text.Length > 30)
            {
                MessageBox.Show("First Name should be less than 30 characters", "Input Error");
                return false;
            }

            if (LastName.Text.Length > 30)
            {
                MessageBox.Show("Last Name should be less than 30 characters", "Input Error");
                return false;
            }

            return true;
        }

        
    }
}
