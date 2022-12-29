using App.Factory;
using App.Factory.Enums;


var factory = new FactoryManager();

var emp = factory.GetEmployee(EmployeeType.Manager);
emp.GetSalary();

var emp2 = factory.GetEmployee(EmployeeType.AssociateDeveloper);
emp2.GetSalary();

var emp3 = factory.GetEmployee(EmployeeType.JuniorDeveloper);
emp3.GetSalary();
Console.ReadKey();