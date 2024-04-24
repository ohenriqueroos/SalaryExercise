using System.Globalization;

namespace SalaryExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();

            Console.Write("Nome: ");
            employee.Name = Console.ReadLine();
            Console.Write("Salário bruto: ");
            employee.GrossSalary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Imposto: ");
            employee.Tax = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Funcionário: {0}, $ {1}", employee.Name, employee.CalculateNetSalary().ToString("F2", CultureInfo.InvariantCulture));

            Console.Write("Digite a porcentagem para aumentar o salário: ");
            double currentTax = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Dados atualizados: {0}, $ {1}", employee.Name, employee.IncreaseSalary(currentTax).ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}