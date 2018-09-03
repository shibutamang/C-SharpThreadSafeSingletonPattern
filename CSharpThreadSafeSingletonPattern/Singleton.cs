using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpThreadSafeSingletonPattern
{
    public sealed class Singleton
    {
        private static readonly object obj = new object();
        
        //A private constructor
        private Singleton()
        {
        }
        //creating default null instanciate
        private static Singleton _instance = null;

        public static Singleton GetInstance()
        {
            if (_instance == null)
            {
                lock (obj)
                {
                    if (_instance == null)
                    {
                        _instance = new Singleton();
                    }
                }
            }
            return _instance;
        }

        //public method which can be accessed with the single instance
        public void PrintDetails(string message)
        {
            Console.WriteLine(message);
        }
    }
}
