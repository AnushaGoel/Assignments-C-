
    internal class Assgnmnt3
    {
        byte id;
        string name;
        public string dept;
        public double salary;
        public void GetDetails()
        {
            Console.Write("Enter ID");
            //id = Byte.Parse(Console.ReadLine());
            Byte.TryParse(Console.ReadLine(), out id);
            Console.WriteLine("ENter NAme");
            name = Console.ReadLine();
            Console.WriteLine("ENter Dept");
            dept = Console.ReadLine();
            Console.WriteLine("ENter Salary");
            salary = Convert.ToDouble(Console.ReadLine());



        }
        //default constructor
        public Assgnmnt3() {

            }

    public Assgnmnt3(byte id, string name, string dept, double salary)
    {
        this.id = id;
        this.name = name;
        this.dept = dept;
        this.salary = salary;
    }

}
    

