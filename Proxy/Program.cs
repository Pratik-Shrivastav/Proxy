using Proxy.Model;
using Proxy.Service;

namespace Proxy
{
    public class Program
    {
        static void Main(string[] args)
        {
            Employee emp1 = new Employee("Anurag", "Anurag123", "Developer");
            SharedProxy folderProxy1 = new SharedProxy(emp1);
            folderProxy1.RWOperations();

            Console.WriteLine();
            Console.WriteLine();
            Employee emp2 = new Employee("Pranaya", "Pranaya123", "Manager");
            SharedProxy folderProxy2 = new SharedProxy(emp2);
            folderProxy2.RWOperations();

            Console.WriteLine();
            Console.WriteLine();
            Employee emp3 = new Employee("Pratik", "Pratik123", "CEO");
            SharedProxy folderProxy3 = new SharedProxy(emp3);
            folderProxy3.RWOperations();
        }
    }
}