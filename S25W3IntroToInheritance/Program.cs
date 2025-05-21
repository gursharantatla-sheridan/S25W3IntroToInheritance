namespace S25W3IntroToInheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //BaseClass objBase = new BaseClass();
            //objBase.myPublicVar = 1;

            //DerivedClass objDerived = new DerivedClass();
            //objDerived.myPublicVar = 2;


            //BaseClass objBase = new BaseClass();
            //DerivedClass objDerived = new DerivedClass();



            CommissionEmployee commEmp = new CommissionEmployee(101, "John", 10000, 0.15);
            Console.WriteLine(commEmp);
            Console.WriteLine($"\nEarnings = {commEmp.Earnings():C}\n\n");

            SalaryPlusCommissionEmployee salCommEmp = new SalaryPlusCommissionEmployee(102, "Anne", 8000, 0.10, 500);
            Console.WriteLine(salCommEmp);
            Console.WriteLine($"\nEarnings = {salCommEmp.Earnings():C}\n\n");
        }
    }
}
