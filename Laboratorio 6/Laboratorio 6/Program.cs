using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_6
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Company objcompañia = new Company();
            Random random = new Random();
            List<String> listName = new List<String>() { "Tony", "Steve", "Natalia", "Bruce", "Peter", "Thor", "Pepper","Wanda","Nick","Carol"};
            List<String> listLastname = new List<String>() { "Stark", "Rogers", "Romanova", "Banner", "Parker", "Hijo de Odin", "Potts", "Maximoff","Fury","Danvers"};
            
            

            while (true)
            {
                Console.WriteLine(""); 
                Console.WriteLine("  Bienvenido a su servidor de compañias:");
                Console.WriteLine("  --------------------------------------   ");
                Console.WriteLine("");
                Console.WriteLine("  Si desea ver la informacion de una empresa existente marque 1:");
                Console.WriteLine("  Si desea crear una empresa desde 0 marque 2:");
                Console.WriteLine("  Si desea salir ingrese 3:");
                int var1 = int.Parse(Console.ReadLine());
                switch (var1)
                {
                    case 1:
                        objcompañia = Load();
                        showCompany(objcompañia);
                        sawDivision(objcompañia);
                        break;
                    case 2:
                        addCompany();
                        List<String> RandomName = new List<String>() { listName[random.Next(0, 10)], listName[random.Next(0, 10)], listName[random.Next(0, 10)], listName[random.Next(0, 10)], listName[random.Next(0, 10)], listName[random.Next(0, 10)], listName[random.Next(0, 10)] };
                        List<String> RandomLastName = new List<String>() { listLastname[random.Next(0, 10)], listLastname[random.Next(0, 10)], listLastname[random.Next(0, 10)], listLastname[random.Next(0, 10)], listLastname[random.Next(0, 10)], listLastname[random.Next(0, 10)], listLastname[random.Next(0, 10)] };
                       
                        objcompañia.Recorrer(RandomName,RandomLastName);
                        
                        Save(objcompañia);
                        break;
                    case 3:
                        Save(objcompañia);
                        return;

                }

            }
            void addCompany()
            {
                Console.Write("Nombre: ");
                string name = Console.ReadLine();
                Console.Write("Rut: ");
                string rut = (Console.ReadLine());
                objcompañia.setCompany(name, rut);
               
            }

            void showCompany(Company company)
            {
                Console.WriteLine(company.Information());
            }

            void Save(Company company)
            {
                IFormatter formatter = new BinaryFormatter();
                Stream stream = new FileStream("Empresas.bin", FileMode.Create, FileAccess.Write, FileShare.None);
                formatter.Serialize(stream, company);
                stream.Close();
            }

            Company Load()
            {
                IFormatter formatter = new BinaryFormatter();
                Stream stream = new FileStream("Empresas.bin", FileMode.Open, FileAccess.Read, FileShare.Read);
                Company company = (Company)formatter.Deserialize(stream);
                stream.Close();
                return company;
            }
            void sawDivision(Company company)
            {
                for ( int i= 0; i < company.GetDivisions().Count(); i++)
                {
                    Console.WriteLine(company.GetDivisions()[i].getDivision());
                    Console.Write(company.GetDivisions()[i].getEncargado());
                    

                }
            }
        }
    }
}
