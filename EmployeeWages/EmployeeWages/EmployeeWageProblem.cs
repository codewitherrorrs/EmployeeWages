using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWages
{
    public class EmployeeWageProblem
    {
        public static void Employee()
        {
            Random random = new Random();
            int check = random.Next(2);
            int fulltime = 1;

            if(check == fulltime)
            {
                Console.WriteLine("Employee is Present");
            }
            else
            {
                Console.WriteLine("Employee is Absent");
            }
        }
    }
}
