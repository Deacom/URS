using ModelLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            ActivityDbModel ctx = new ActivityDbModel();

            Activity myact = new Activity();
            myact.Name = "Test";
            myact.Date = new DateTime(2016, 03, 24);
            ctx.Activities.Add(myact);

            ctx.SaveChanges();

            Console.WriteLine(ctx.Activities.FirstOrDefault().Name); 

            Console.ReadKey();
        }
    }
}
