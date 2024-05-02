using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.App.OCPGood
{
    public interface ISalaryCalculate
    {
        decimal Calculate(decimal salary);
    }
    public class LowSalaryCalculator : ISalaryCalculate
    {
        public decimal Calculate(decimal salary)
        {
            return salary * 2;
        }
    }
    public class MiddleSalaryCalculator : ISalaryCalculate
    {
        public decimal Calculate(decimal salary)
        {
            return salary * 4;
        }
    }
    public class HighSalaryCalculator : ISalaryCalculate
    {
        public decimal Calculate(decimal salary)
        {
            return salary * 6;
        }
    }
    public class SuperSalaryCalculator : ISalaryCalculate
    {
        public decimal Calculate(decimal salary)
        {
            return salary * 10;
        }
    }
    public class SalaryCalculator
    {
        public decimal Calculate(decimal salary,ISalaryCalculate salaryCalculate)
        {
           return salaryCalculate.Calculate(salary);
        }
    }

    
}
