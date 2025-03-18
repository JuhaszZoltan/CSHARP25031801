using CSHARP25031801;
using System.Security.Cryptography;
using System.Text;

const string PATH = "D:\\PROJECTS\\CSHARP25031801\\src\\berek2020.txt";

List<Employee> employees = [];

using StreamReader sr = new(PATH, Encoding.UTF8);
_ = sr.ReadLine();
while (!sr.EndOfStream) employees.Add(new(sr.ReadLine()));

Console.WriteLine($"t3: number of employees: {employees.Count}");

double avgPayment = employees.Average(e => e.Payment);
Console.WriteLine($"t4: average payment: {avgPayment / 1000:0.0} tHUF");

Console.Write("t5: enter the name of a department: ");
string depName = Console.ReadLine();

Console.Write("t6: ");
Employee hPaidEmp = employees
    .Where(e => e.Department == depName)
    .MaxBy(e => e.Payment);
if (hPaidEmp is null) Console.WriteLine(
    "the department entered does not exist at the company");
else Console.WriteLine(
    $"the highest-earning employee in the department:" +
    $"\n{hPaidEmp}");

Console.WriteLine("t7: statistics:");
var deps = employees.GroupBy(e => e.Department);
foreach (var dep in deps)
    Console.WriteLine($"\t{dep.Key, -15} - {dep.Count()} ppl.");

