using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestAppConsole
{
    public class VarTypeArray
    {
        public static void RunCode()
        {
            var contacts = new[]
            {       
                new
                {
                    Name = "Eugene Zabokritski",
                    PhoneNumbers = new[] { "206-555-0108", "425-555-0001" }
                },
                new
                {
                    Name = "Hanying Feng",
                    PhoneNumbers = new[] { "650-555-0199" }
                }
            };
        }
    }
}