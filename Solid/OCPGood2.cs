using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.App.OCPGood2
{

    public class LowSalaryCalculator
    {
        public decimal Calculate(decimal salary)
        {
            return salary * 2;
        }
    }
    public class MiddleSalaryCalculator
    {
        public decimal Calculate(decimal salary)
        {
            return salary * 4;
        }
    }
    public class HighSalaryCalculator
    {
        public decimal Calculate(decimal salary)
        {
            return salary * 6;
        }
    }
    public class SuperSalaryCalculator 
    {
        public decimal Calculate(decimal salary)
        {
            return salary * 10;
        }
    }
    public class SalaryCalculator
    {
        // Action => void
        // Predicate // bool
        // Fuunction
        public decimal Calculate(decimal salary,Func<decimal,decimal> calculateDelegate)
        {
           return calculateDelegate(salary);
        }
    }

    
}
