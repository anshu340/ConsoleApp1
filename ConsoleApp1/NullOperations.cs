using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class NullOperations
    {
        //Task 2
        public void PerformNullChecks()
        {
            string username = null;
            string result = (username == null) ? "Username is not available" : username;
            Console.WriteLine(result);
            username ??= "Anshu";
            Console.WriteLine($"Updated username: {username}");
        }

        public void CheckWithNullCoalescing()
        {
            string username = null;
            string checkUsername = username ?? "Username is not available";
            Console.WriteLine(checkUsername);
        }
        
    }
}
