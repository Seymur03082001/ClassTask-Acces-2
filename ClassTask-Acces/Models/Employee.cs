using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassTask_Acces.Models
{
    internal class Employee
    {
        private string _name;
        private bool _isSuccessfull;
        private decimal _salary;
        private bool isSuccessfull;
        private string name;

        public string Name
        {
            get => _name;
            set 
            { 
                value = value.Trim();
                if(value.Length >= 0 && value.Length <= 20)
                {
                    _name = value;
                }
            }
        }

        
        public bool IsSuccessfull
        {
            get => _isSuccessfull;
            set 
            { 
                if(value == true)
                {
                    _isSuccessfull = value;
                }
            }
        }
        
        public decimal Salary
        {
            get => _salary;
            set 
            { 
                if(value > 0)
                {
                    _salary = value;
                }
            }
        }
        public Employee(string name, bool isSuccessfull, decimal salary)
        {
            Name = name;
            IsSuccessfull = isSuccessfull;
            Salary = salary;
            
        }
    }
}
