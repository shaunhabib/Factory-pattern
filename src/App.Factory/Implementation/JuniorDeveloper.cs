using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using App.Factory.Interface;

namespace App.Factory.Implementation
{
    public class JuniorDeveloper : ICalculateSalary
    {
        public void GetSalary()
        {
           System.Console.WriteLine("The salary of the JuniorDeveloper is 15000 taka");
        }
    }
}