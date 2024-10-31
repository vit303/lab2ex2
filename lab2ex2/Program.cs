using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace lab2ex2
{
    internal class Program
    {
        static void Main()
        {
            Document[] documents = new Document[]
            {
                new Receipt { DocumentNumber = "R000", Date = new Date { Day = 15, Month = 1, Year = 2024 } },
                new Invoice { DocumentNumber = "I000", Date = new Date { Day = 16, Month = 7, Year = 2024 } },
                new Check { DocumentNumber = "C007", Date = new Date { Day = 17, Month = 12, Year = 1000 } }
            };

            foreach (var doc in documents)
            {
                Console.WriteLine(doc.ToString());
                doc.PrintDetails();
                Console.WriteLine();
            }

            // Создание объектов класса Date и Organization
            Date date = new Date { Day = 15, Month = 10, Year = 2020 };
            Organization org = new Organization { Name = "Ooorganization", Address = "123 Main Street" };

            Console.WriteLine(date.ToString());
            Console.WriteLine(org.ToString());
        }
    }
}
