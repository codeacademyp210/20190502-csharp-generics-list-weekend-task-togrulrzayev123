using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork.Classes
{
    class Employee:User
    {
        public static int num;

        public int GetId()
        {
            num++;
            return num;
        }
        public int ID { get; set; }

        public string Position { get; set; }

        public double Salary { get; set; }
    }
}
