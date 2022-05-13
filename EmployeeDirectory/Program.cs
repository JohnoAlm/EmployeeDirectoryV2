using Employee.Helpers;
using System;

namespace EmployeeDirectory
{
    internal class Program
    {
        //Instanseierar en payroll och ett ui
        //Scoopade till hela klassen

        //Programmets startpunkt
        //Får bara finnas EN!
        static void Main(string[] args)
        {
            IPayRoll payRoll = new PayRoll();
            IUI ui = new ConsoleUI();
            var main = new Main(ui, payRoll );
            main.Start();
        }


    }
}
