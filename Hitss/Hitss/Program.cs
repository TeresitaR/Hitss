
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hitss
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new BaseHitss())
            {
                Console.Write("Please write the name of the client:");
                var ClientName = Console.ReadLine();
                Console.Write("Please write the client's description:");
                var ClientDescription = Console.ReadLine();




                var client = new Client { Name = ClientName, Description = ClientDescription };
                db.SaveChanges();



                Console.ReadKey();
            }
        }
    }
}
