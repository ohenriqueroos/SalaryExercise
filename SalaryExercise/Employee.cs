using System.Globalization;

namespace SalaryExercise
{
    class Employee
    {
        public string Name = "";
        public double GrossSalary;
        public double Tax;

        public double CalculateNetSalary()
        {
            return GrossSalary - Tax;
        }

        public void IncreaseSalary(double percentage)
        {
            GrossSalary += (GrossSalary * percentage / 100.0);
        }

        public override string ToString()
        {
            return Name
                + ", R$ "
                + CalculateNetSalary().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
