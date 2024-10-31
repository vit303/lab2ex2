using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace lab2ex2
{
    public abstract class Document : InterfaceDocument
    {
        public string DocumentNumber { get; set; }
        public Date Date { get; set; }  // Используем собственный класс Date

        public abstract string GetDocumentType();

        public virtual void PrintDetails()
        {
            Console.WriteLine($"Document Number: {DocumentNumber}, Date: {Date}");
        }

        public override string ToString()
        {
            return $"Type: {GetDocumentType()}, Number: {DocumentNumber}, Date: {Date}";
        }
    }

}
