using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using App.Factory.Enums;
using App.Factory.Implementation;
using App.Factory.Interface;

namespace App.Factory
{
    public class FactoryManager
    {
        public ICalculateSalary GetEmployee(EmployeeType empType)
        {
            switch (empType)
            {
                case EmployeeType.Manager:
                    return new Manager();
                case EmployeeType.AssociateDeveloper:
                    return new AssociateDeveloper();
                case EmployeeType.JuniorDeveloper:
                    return new JuniorDeveloper();
                default:
                    throw new Exception("Invalid type");
            }
        }
    }
}