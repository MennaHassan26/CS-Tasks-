using Day8;
using System.Text.RegularExpressions;

internal class Program
{
    static void Main(string[] args)
    {
        Console.Write("Number of Employees");
        int num = int.Parse(Console.ReadLine());
        Employee[] Employees = new Employee[num];
        
        for (int i = 0; i < num; i++)
        {
            Employees[i] = new Employee();
            Console.WriteLine("Enter ID: ");
            Employees[i].ID = int.Parse(Console.ReadLine());

            bool valid = true;
            do
            {
                Console.WriteLine("Enter Name: ");
                Employees[i].Name = Console.ReadLine();
                if (string.IsNullOrEmpty(Employees[i].Name))
                {
                    Console.WriteLine("Can't leave name empty");
                    continue;
                }
                else if (Employees[i].Name.Contains(' '))
                {
                    Console.WriteLine("Name mustn't include spaces");
                    continue;
                }
                else if (Employees[i].Name.Length > 30)
                {
                    Console.WriteLine("Max length is 30");
                    continue;
                }
                else if (!Regex.IsMatch(Employees[i].Name, @"^[a-zA-Z]+$"))
                {
                    Console.WriteLine("Name must include characters only");
                    continue;
                }
                valid = false;
            } while (valid);

            Console.WriteLine("Enter Level: \n1-Guest,\n2->Developer,\n3->Secretary,\n4->DBA\n");
            Employees[i].Privilage = (Privilage)Enum.Parse(typeof(Privilage), Console.ReadLine()) - 1;

            bool Gendervalid = false;
            Console.WriteLine("Enter gender: \n1-Male\n2-Female");
            do
            {
                int gender = int.Parse(Console.ReadLine());
                if (gender != 1 && gender != 2)
                {
                    Console.WriteLine("Please enter 1 for Male or 2 for Female.");
                }
                else
                {
                    Employees[i].Gender = (Gender)(gender - 1);
                    Gendervalid = true;
                }
            } while (!Gendervalid);

            Console.WriteLine("Enter Salary: ");
            Employees[i].Salary = decimal.Parse(Console.ReadLine());

            var Date = new HireDate();
            Console.WriteLine("HireDate: \nDay: ");
            Date.Day = int.Parse(Console.ReadLine());

            Console.WriteLine("Month: ");
            Date.Month = int.Parse(Console.ReadLine());

            Console.WriteLine("Year: ");
            Date.Year = int.Parse(Console.ReadLine());

            Employees[i].HireDate = Date;
        }

        if (Employees.Length >= 3)
        {
            Employees[2].Privilage = Privilage.securityofficer;
            Console.WriteLine(Employees[2]);
        }

        Array.Sort(Employees);

        Console.WriteLine("Sorted Employees:");
        foreach (var Employee in Employees)
        {
            Console.WriteLine(Employee);
        }

        Console.WriteLine(Counter.C);
    }
}
