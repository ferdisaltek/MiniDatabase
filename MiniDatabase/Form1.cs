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
            csv.Append("\n");
          

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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            

             if (comboBox1.Items[comboBox1.SelectedIndex].ToString() == "Multiple")
            {
                panelSearchByDate.Visible = true;
                panelSearchByName.Visible = true;
                panelSearchByPhone.Visible = true;
                panelSearchByDepartment.Visible = true;
            }
            else if (comboBox1.Items[comboBox1.SelectedIndex].ToString() == "By Account End Date")
            {
                panelSearchByDate.Visible = true;
                panelSearchByName.Visible = false;
                panelSearchByPhone.Visible = false;
                panelSearchByDepartment.Visible = false;

            }
            else if (comboBox1.Items[comboBox1.SelectedIndex].ToString() == "By Name")
            {
                panelSearchByDate.Visible = false;
                panelSearchByName.Visible = true;
                panelSearchByPhone.Visible = false;
                panelSearchByDepartment.Visible = false;

            }

            else if (comboBox1.Items[comboBox1.SelectedIndex].ToString() == "By Telephone Number")
            {
                panelSearchByDate.Visible = false;
                panelSearchByName.Visible = false;
                panelSearchByPhone.Visible = true;
                panelSearchByDepartment.Visible = false;

            }

            else if (comboBox1.Items[comboBox1.SelectedIndex].ToString() == "By Department")
            {
                panelSearchByDate.Visible = false;
                panelSearchByName.Visible = false;
                panelSearchByPhone.Visible = false;
                panelSearchByDepartment.Visible = true;

            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            List<Record> results = new List<Record>();
           if (comboBox1.Items[comboBox1.SelectedIndex].ToString() == "Multiple")
            {
               
            }
            else if (comboBox1.Items[comboBox1.SelectedIndex].ToString() == "By Account End Date")
            {
                                
            }
            else if (comboBox1.Items[comboBox1.SelectedIndex].ToString() == "By Name")
            {
                results = findByName(SearchBoxFirstName.Text, searchBoxLastName.Text);
            }

            else if (comboBox1.Items[comboBox1.SelectedIndex].ToString() == "By Telephone Number")
            {
                results = findByTelephoneNumber(searchBoxPhoneNumber.Text);
            }

           else if (comboBox1.Items[comboBox1.SelectedIndex].ToString() == "By Department")
            {
               results = findByDepartment(SearchBoxDepartment.Text);
            }

           grd.Rows.Clear();

            foreach(Record tempRecord in results)
            {
                grd.Rows.Add();
                int currentIndex = grd.Rows.Count - 1;

                grd.Rows[currentIndex].Cells[0].Value = tempRecord.UserName;
                grd.Rows[currentIndex].Cells[1].Value = tempRecord.FirstName;
                grd.Rows[currentIndex].Cells[2].Value = tempRecord.LastName;
                grd.Rows[currentIndex].Cells[3].Value = tempRecord.Department;
                grd.Rows[currentIndex].Cells[4].Value = tempRecord.AccountEndDatestr;
                grd.Rows[currentIndex].Cells[5].Value = tempRecord.TelephoneNumber;
            }
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        public List<Record> findByName(string firstName, string LastName)
        {
            StreamReader reader = File.OpenText(filePath);
            string tempLine = reader.ReadLine();
            string[] sep = {";"};
            List<Record> resultSet = new List<Record>();
            
            while (!String.IsNullOrEmpty(tempLine))
            {
                String[] valueArr = tempLine.Split(sep, StringSplitOptions.None);
                Record tempRecord = new Record(valueArr[0], valueArr[1], valueArr[2], valueArr[3], DateTime.Parse(valueArr[4]), valueArr[5]);
                if ((tempRecord.FirstName == firstName) && (tempRecord.LastName == LastName))
                {
                    resultSet.Add(new Record(tempRecord.UserName, tempRecord.FirstName, tempRecord.LastName, tempRecord.Department, tempRecord.AccountEndDate, tempRecord.TelephoneNumber));
                }
                tempLine = reader.ReadLine();
            }
            
            return resultSet;
        }

        public List<Record> findByDepartment(string department)
        {
            StreamReader reader = File.OpenText(filePath);
            string tempLine = reader.ReadLine();
            string[] sep = { ";" };
            List<Record> resultSet = new List<Record>();

            while (!String.IsNullOrEmpty(tempLine))
            {
                String[] valueArr = tempLine.Split(sep, StringSplitOptions.None);
                Record tempRecord = new Record(valueArr[0], valueArr[1], valueArr[2], valueArr[3], DateTime.Parse(valueArr[4]), valueArr[5]);
                if (tempRecord.Department == department)
                {
                    resultSet.Add(new Record(tempRecord.UserName, tempRecord.FirstName, tempRecord.LastName, tempRecord.Department, tempRecord.AccountEndDate, tempRecord.TelephoneNumber));
                }
                tempLine = reader.ReadLine();
            }

            return resultSet;
        }

        public List<Record> findByTelephoneNumber(string telephoneNumber)
        {
            StreamReader reader = File.OpenText(filePath);
            string tempLine = reader.ReadLine();
            string[] sep = { ";" };
            List<Record> resultSet = new List<Record>();

            while (!String.IsNullOrEmpty(tempLine))
            {
                String[] valueArr = tempLine.Split(sep, StringSplitOptions.None);
                Record tempRecord = new Record(valueArr[0], valueArr[1], valueArr[2], valueArr[3], DateTime.Parse(valueArr[4]), valueArr[5]);
                if (tempRecord.TelephoneNumber == telephoneNumber)
                {
                    resultSet.Add(new Record(tempRecord.UserName, tempRecord.FirstName, tempRecord.LastName, tempRecord.Department, tempRecord.AccountEndDate, tempRecord.TelephoneNumber));
                }
                tempLine = reader.ReadLine();
            }

            return resultSet;
        }

        public List<Record> findByEndDate(DateTime intervalStart, DateTime intervalEnd)
        {
            return null;
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        
    }
}
