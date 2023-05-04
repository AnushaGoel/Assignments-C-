using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Assignment4
{
    //    internal abstract class Employee
    //    {
    //        int id;
    //        string name;
    //        string reportManager;
    //        static public int count;
    //        public Employee() {
    //            count++;
    //        }

    //        public void getDetails()
    //        {
    //            Console.WriteLine("Enter Employee id");
    //            id = Byte.Parse(Console.ReadLine());
    //            Console.WriteLine("Enter Employee name");
    //            name = Console.ReadLine();
    //            Console.WriteLine("Enter Report Manager name");
    //            name = Console.ReadLine();

    //        }
    //        public abstract void salDetails();

    //        public void displayDetails()
    //        {
    //            Console.WriteLine("ID is {0}",id);
    //            Console.WriteLine("Name is {0}", name);
    //            Console.WriteLine("Reporting Manager is {0}", reportManager);
    //        }
    //    }

    //    class OnContractBasis: Employee
    //    {
    //        DateTime contractDate;
    //        int duration;
    //        double charges;

    //        public void getDetails()
    //        {
    //            Console.WriteLine("Enter Employee Contract date");
    //            contractDate = Convert.ToDateTime(Console.ReadLine());
    //            Console.WriteLine("Enter Employee duration");
    //            duration= Int16.Parse(Console.ReadLine());
    //            Console.WriteLine("Enter charges");
    //            charges= Double.Parse(Console.ReadLine());
    //        }

    //        public override void salDetails()
    //        {

    //        }


    //    }
    //    class PayRoll: Employee
    //    {
    //        DateOnly joiningDate;
    //        double exp;
    //        double basicSalary;
    //        double dailyAllow;
    //        double hra, netSalary;
    //    }

    internal class Assgnmnt4
    {
        //pcode, pname, qty_in_stock,discount_allowed
        int pcode;
        string pname;
        int qty_in_stock;
        readonly float discount_allowed;
        static string brand;
        const float specialDiscount = 5;
        int price;
        int total;




        public Assgnmnt4() { }
        public Assgnmnt4(int code, string name, int qty, float discount, int price)
        {
            this.pcode = code;
            this.pname = name;
            this.qty_in_stock = qty;
            this.discount_allowed = discount;
            this.price = price;
        }



        static Assgnmnt4()
        {
            brand = "Levis";
        }



        public void calcTotal()
        {



            int totalDis = (int)this.discount_allowed + (int)specialDiscount;
            int discount = (this.price * totalDis / 100);



            this.total = this.price - discount;
            getBill();
        }



        public void getBill()
        {
            string bill = "";
            bill += "Bill for " + this.pname + " is " + this.total;
            Console.WriteLine(bill);
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter code:");
            int code = Byte.Parse(Console.ReadLine());
            Console.WriteLine("Enter name:");
            string name = Console.ReadLine();
            Console.WriteLine("Enter quantity:");
            int qty = Byte.Parse(Console.ReadLine());
            Console.WriteLine("Enter discount:");
            float discount = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter price:");
            int price = Convert.ToInt32(Console.ReadLine());



            Assgnmnt4 obj = new Assgnmnt4(code, name, qty, discount, price);
            obj.calcTotal();


        }




    }
}
