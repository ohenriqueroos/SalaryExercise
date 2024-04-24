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

        public double IncreaseSalary(double percentage)
        {
            return (GrossSalary * (percentage / 100.00) + GrossSalary) - Tax;
        }
    }
}
