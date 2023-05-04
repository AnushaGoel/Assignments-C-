using Assignment5;

internal class Program
{
    static void Main()
    {


        PayRoll pemp = new PayRoll();
        pemp.GetDetails();
        pemp.DisplayDetails();


        OnContract cemp = new OnContract();
        cemp.GetDetails();
        cemp.DisplayDetails();

    }
}