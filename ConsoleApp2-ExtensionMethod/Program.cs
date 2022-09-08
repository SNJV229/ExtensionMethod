using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApp2_ExtensionMethod
{
    class Program
    {
        public static void Main(string[] args)
        {
            string demo = "124";
            try
            {
                string result = demo.toCurrency();
                Console.WriteLine(result);
                Console.ReadLine();
            }
            catch(IOException e)
            {
                Console.WriteLine(e.ToString());
                Console.ReadLine();
            }
        }
    }

    public static class Extension
    {
        public static bool isNUmber(this String str)
        {
            bool isStringInt = str.All(char.IsDigit);
            return isStringInt;
        }
        public static String toCurrency(this String str)
        {
            if (isNUmber(str))
            {
                String currency = "$" + str;
                return currency;
            }
            else
            {
                throw new IOException("String is not number.");
            }
        }
    }
}
