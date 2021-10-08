using System;

namespace UC6AnagramDetection
{
    class UC7Program
    {
        static void Main(string[] args)
        {
            string str1 = "abcd";
            string str2 = "bcda";

            char[] ch1 = str1.ToLower().ToCharArray();
            char[] ch2 = str2.ToLower().ToCharArray();
            Array.Sort(ch1);
            Array.Sort(ch2);

            string va1 = new string(ch1);
            string va2 = new string(ch2);

            if (va1 == va2)
            {
                Console.WriteLine("String is Equal");
            }
            else
            {
                Console.WriteLine("String is not Equal");
            }
        }
    }
}
