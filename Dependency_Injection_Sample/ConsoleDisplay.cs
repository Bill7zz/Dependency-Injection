using System;

namespace Dependency_Injection_Sample
{
    public class ConsoleDisplay : IDisplay
    {
        public void Show(string message)
        {
            Console.WriteLine(message);
        }
    }
}
