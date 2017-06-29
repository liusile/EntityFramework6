using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db=new MyDb())
            {
               // db.Database.Log = Console.Write;
                //add
                db.Student.Add(new Student
                {
                    Name = "haha"
                });
                db.SaveChanges();
                //search
                var entity = db.Student.ToList();
                foreach (var b in entity)
                {
                    Console.WriteLine(b.Id+"----"+b.Name);
                }
            }
            Console.ReadKey();
        }
    }
}
