using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCor.Domain
{
    public class Staff:Passenger
    {
        public DateTime EmployementDate { get; set; }
        public string Function { get; set; }

        [DataType(DataType.Currency)]
        public float Salary { get; set; }

        public override string ToString()
        {
            return base.ToString() +
                "EmployementDate: " + EmployementDate +
                ", Function: " + Function +
                ", Salary: " + Salary;
        }
        public override void PassengerType()
        {
            base.PassengerType();
            Console.WriteLine("and I am a staff Member");
        }
    }
}
