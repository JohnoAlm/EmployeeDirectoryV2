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
            IUI ui2 = new MockUI();

            //var sum = ui.Add(5, 7);
            //var sum2 = ui2.Add(5, 7);

            //var listt = new List<IUI>() { ui, ui2 };

            //foreach (IUI item in listt)
            //{
            //    var s = item.GetInput();
            //}
            //ui.ToString();

            var main = new Main(ui, payRoll);
            main.Start();
        }

    }
}
