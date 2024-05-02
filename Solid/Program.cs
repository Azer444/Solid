// See https://aka.ms/new-console-template for more information
//using Solid.App.OCPBad;
//using Solid.App.OCPGood;
using Solid.App.OCPGood2;

Console.WriteLine("Hello, World!");

SalaryCalculator salaryCalculator = new SalaryCalculator();

//Badd
//Console.WriteLine(salaryCalculator.Calculate(1000, SalaryType.Low));
//Console.WriteLine(salaryCalculator.Calculate(1000, SalaryType.Middle));
//Console.WriteLine(salaryCalculator.Calculate(1000, SalaryType.High));


//Good
//Console.WriteLine($"Low Salary : {salaryCalculator.Calculate(1000, new LowSalaryCalculator())}");
//Console.WriteLine($"Middle Salary : {salaryCalculator.Calculate(1000, new MiddleSalaryCalculator())}");
//Console.WriteLine($"High Salary : {salaryCalculator.Calculate(1000, new HighSalaryCalculator())}");
//Console.WriteLine($"Super Salary : {salaryCalculator.Calculate(1000, new SuperSalaryCalculator())}");


//Good2
Console.WriteLine($"Low Salary : {salaryCalculator.Calculate(1000, new LowSalaryCalculator().Calculate)}");
Console.WriteLine($"Middle Salary : {salaryCalculator.Calculate(1000, new MiddleSalaryCalculator().Calculate)}");
Console.WriteLine($"High Salary : {salaryCalculator.Calculate(1000, new HighSalaryCalculator().Calculate)}");
Console.WriteLine($"Super Salary : {salaryCalculator.Calculate(1000, new SuperSalaryCalculator().Calculate)}");