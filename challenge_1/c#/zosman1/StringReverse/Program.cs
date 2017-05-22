using System;

namespace StringReverse
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.White;
			Console.WriteLine("Hello!");
            Console.WriteLine("Please enter a string you would like reversed!");
            string input = Console.ReadLine();
            string output = "";
            foreach(char character in input){
                if (output != null){
                    output = character.ToString() + output;
				}
                else {
                    output = character.ToString();
                }
            }
            Console.WriteLine("Reversed String: " + output);
		}
    }
}
