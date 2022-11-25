using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassTask_Acces.Models
{
    internal class Assistant: Manager
    {
        public void GetFeedBack(Employee employee)
        {
            if(employee.IsSuccessfull)
            {
                employee=GetPromotion(employee);
                Console.WriteLine(employee.Salary + "new salary");
            }
            else
            {
                Console.WriteLine("Wrong Input");
            }
        }
    }
}
