using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniDatabase.Classes
{
    interface IDBOperations
    {
        //int loadData(string filename);
        //Record[] findByName(string firstName, string LastName);
        //Record[] findByDepartment(string department);
        //Record[] findByTeleophoneNumber(string telephoneNumber);
        //Record[] findByEndDate(DateTime intervalStart, DateTime intervalEnd);

        bool saveData(Record record);


    }

    public class Record
    {
        public string UserName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Department { get; set; }
        public DateTime AccountEndDate { get; set; }
        public string TelephoneNumber { get; set; }
        public string AccountEndDatestr { get; set; }

        public Record(string userName, string firstName, string lastName, string department, DateTime accountEndDate, string telephoneNumber)
        {
            UserName = userName;
            FirstName = firstName;
            LastName = lastName;
            Department = department;
            AccountEndDate = accountEndDate;
            TelephoneNumber = telephoneNumber;
            AccountEndDatestr = String.Format("{0: yyyy-mm-dd}", accountEndDate);

        }
    }
}
