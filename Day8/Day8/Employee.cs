using Day8;
using System.Globalization;

public struct Employee : IComparable<Employee>
{
    public int ID { get; set; }
    public string Name { get; set; }
    public Privilage Privilage { get; set; }
    public Gender Gender { get; set; }
    public decimal Salary { get; set; }
    public HireDate HireDate { get; set; }

    public Employee(int id, string name, decimal salary, HireDate hireDate, Privilage privilage, Gender gender)
    {
        ID = id;
        Name = name;
        Salary = salary;
        HireDate = hireDate;
        Privilage = privilage;
        Gender = gender;
    }

    public override string ToString()
    {
        return $"{ID}:{Name}:{Gender}:{Salary:C}:{HireDate}:{Privilage} ";
    }
    public int CompareTo(Employee Right)
    {
        Counter.C++;
        return HireDate.CompareTo(Right.HireDate);
    }



}