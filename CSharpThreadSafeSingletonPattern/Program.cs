using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpThreadSafeSingletonPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("****** Using Thread Safe Singleton design pattern *****");

            PrintEmployeeDetails();
            PrintStudentDetails();

            Console.ReadKey();
        }

        private static void PrintEmployeeDetails()
        {
            Singleton _singleton = Singleton.GetInstance();

            _singleton.PrintDetails("Employee Name: Brock Allen");
        }

        private static void PrintStudentDetails()
        {
            Singleton _singleton = Singleton.GetInstance();
            _singleton.PrintDetails("Student Name: Jeremy Foster");
        }
    }
}
