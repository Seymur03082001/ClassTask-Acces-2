using ClassTask_Acces.Models;

namespace ClassTask_Acces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee("Seymur",true,450m);
            Assistant assistant = new Assistant();
            Manager manager = new Manager();

            assistant.GetFeedBack(employee);
        }
    }
}