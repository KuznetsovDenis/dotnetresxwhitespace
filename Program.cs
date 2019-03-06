using System;

namespace dotnetresxwhitespace
{
    class Program
    {
        static void Main(string[] args)
        {
            string whitespaceFromResource = Resource1.ResourceManager.GetString("WhitespaceResource");
            if(whitespaceFromResource == " ")
                Console.WriteLine("The whitespace in resouces is correct");
            else
                Console.WriteLine("The whitespace in resources has been replaced with something else. Probably with the String.Empty");
        }
    }
}
