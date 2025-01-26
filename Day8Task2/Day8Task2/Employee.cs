using System;

namespace Day8Task2
{
    public enum Gender
    {
        Male = 'M',
        Female = 'F'
    }

    public enum SecurityLevel
    {
        Guest,
        Developer,
        Secretary,
        DBA
    }

    public struct Employee
    {
        #region Data
        private int id;
        private string name;
        private Gender gender;
        private SecurityLevel securityLevel;
        private decimal salary;
        private HiringDate hireDate;
        #endregion

        #region Properties
        public int Id
        {
            get => id;
            set => id = value;
        }

        public string Name
        {
            get => name;
            set => name = value;
        }

        public Gender Gender
        {
            get => gender;
            set => gender = value;
        }

        public SecurityLevel SecurityLevel
        {
            get => securityLevel;
            set => securityLevel = value;
        }

        public decimal Salary
        {
            get => salary;
            set => salary = value;
        }

        public HiringDate HireDate
        {
            get => hireDate;
            set => hireDate = value;
        }
        #endregion

        #region Constructors
        public Employee(int id, string name, Gender gender, SecurityLevel securityLevel, decimal salary, HiringDate hireDate)
        {
            this.id = id;
            this.name = name;
            this.gender = gender;
            this.securityLevel = securityLevel;
            this.salary = salary;
            this.hireDate = hireDate;
        }
        #endregion

        #region Methods
        public override string ToString()
        {
            return $"{id}: {name}, {gender}, {securityLevel}, {salary:C}, Hired on {hireDate}";
        }
        #endregion
    }
}
