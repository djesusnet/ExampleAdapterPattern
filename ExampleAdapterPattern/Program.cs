using ExampleAdapterPattern.Interfaces;
using System;

namespace ExampleAdapterPattern
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            ILumiaXMLTarget lumiaXMLTarget = new LumiaXMLAdapter();
            var xmlLumiaMobile = lumiaXMLTarget.GetLumiaMobilesXMLSpecifications();
            Console.WriteLine(xmlLumiaMobile.InnerText);
        }
    }
}