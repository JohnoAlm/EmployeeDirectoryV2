using Employee.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeDirectory
{
    internal class Main
    {
        private IUI ui;
        private IPayRoll payRoll;

        public Main(IUI ui, IPayRoll payRoll)
        {
            this.ui = ui;
            this.payRoll = payRoll;
        }

        public void Start()
        {
            SeedData();

            do
            {
                ShowMainMeny();
                UserInput();

            } while (true);
        }

        private void UserInput()
        {
            string input = ui.GetInput();

            switch (input)
            {
                case MenyHelper.Add:
                    AddEmployee();
                    break;
                case MenyHelper.Show:
                    PrintEmployees();
                    break;
                case MenyHelper.Quit:
                    Environment.Exit(0);
                    break;
                default:
                    break;
            }
        }

        private  void AddEmployee()
        {
            ui.Print("Add an employee");

            string name = Util.AskForString("Name", ui);
            uint salary = Util.AskForUInt("Salary", ui);

            var emp = new Employee(name, salary);

            payRoll.AddEmployee(emp);


        }

        private  void PrintEmployees()
        {
            List<Employee> employees = payRoll.GetEmployees();

            foreach (var employee in employees)
            {
                //Console.WriteLine($"Name: {employee.Name} Salary: {employee.Salary}");
                ui.Print(employee.ToString());
            }
        }

        private  void ShowMainMeny()
        {
            ui.Print($"{MenyHelper.Add}: add Employee");
            ui.Print($"{MenyHelper.Show}: print Employee");
            ui.Print($"{MenyHelper.Quit}: quit");
        }

        private  void SeedData()
        {
            payRoll.AddEmployee("Nisse", 10000);
            payRoll.AddEmployee("Kalle", 20000);
            payRoll.AddEmployee("Anna", 30000);
            payRoll.AddEmployee("Pelle", 40000);
            payRoll.AddEmployee(new Employee("Owe", 50000));
        }
    }
}
