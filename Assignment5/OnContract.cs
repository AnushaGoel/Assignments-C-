using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Assignment5
{
    internal class OnContract : Employee
    {
        int duration;
        double charges;
        DateTime contractDate;
        double paymentAmount;

        public OnContract() { }

        public OnContract(int duration, double charges, DateTime contractDate, double paymentAmount, int id, string name, string manager)
            : base(id, name, manager)
        {
            this.duration = duration;
            this.charges = charges;
            this.contractDate = contractDate;
            this.paymentAmount = paymentAmount;

        }

        public void CalculatePayment()
        {
            paymentAmount = charges * duration;
        }
        public void GetDetails()
        {
            base.GetDetails();
            Console.Write("Enter duration");
            duration = Byte.Parse(Console.ReadLine());
            Console.WriteLine("ENter charges");
            charges = Byte.Parse(Console.ReadLine());

        }

        public void DisplayDetails()
        {
            base.DisplayDetails();
            Console.WriteLine("charges are " + charges);
            Console.WriteLine("duration is " + duration);
            Console.WriteLine("Total payment done " + paymentAmount);
        }
    }
}
