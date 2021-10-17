using System;
using ThirdPartyTools;

namespace FileData
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            try
            {
                FileDetails fileDetails = new FileDetails();
                MyClass myClass = new MyClass();
                string result = myClass.GetOutput(args);
                Console.WriteLine(result);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Program::Main -> {0}", ex.Message);
            }

            Console.ReadKey();
        }
    }
}
