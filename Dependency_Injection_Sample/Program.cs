using System;

namespace Dependency_Injection_Sample
{
    class Program
    {
        static void Main(string[] args)
        {                                   
            var displayMessage = new DisplayMessage(new WindowsBoxDisplay());

            displayMessage.Show("Hi, you wrote a message by using Dependency Injection!");

            Console.Read();
        }
    }
}
