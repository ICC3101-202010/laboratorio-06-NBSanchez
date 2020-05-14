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
            List<Company> compañia = new List<Company>();
            compañia = Load();

            while (true)
            {
                Console.WriteLine("Bienvenido a su servidor de compañias:");
                Console.WriteLine("Si desea ver la informacion de la empresa ingrese 1:");
                Console.WriteLine("Si desea agregar informacion a la empresa ingrese 2:");
                Console.WriteLine("Si desea salir ingrese 3");
                int var1 = int.Parse(Console.ReadLine());
                switch (var1)
                {
                    case 1:
                        showCompany(compañia);
                        break;
                    case 2:
                        addCompany(compañia);
                        break;
                    case 3:
                        Save(compañia);
                        return;

                }

            }
            void addCompany(List<Company> company)
            {
                Console.Write("Nombre: ");
                string name = Console.ReadLine();
                Console.Write("Rut: ");
                string rut = (Console.ReadLine());
                company.Add(new Company(name, rut));
            }

            void showCompany(List<Company> company)
            {
                for (int i = 0; i < compañia.Count(); i++)
                {
                    Console.WriteLine(company[i].Information());
                }
                Console.WriteLine();
            }

            void Save(List<Company> company)
            {
                IFormatter formatter = new BinaryFormatter();
                Stream stream = new FileStream("Empresas.bin", FileMode.Create, FileAccess.Write, FileShare.None);
                formatter.Serialize(stream, company);
                stream.Close();
            }

            List<Company> Load()
            {
                IFormatter formatter = new BinaryFormatter();
                Stream stream = new FileStream("Empresas.bin", FileMode.Open, FileAccess.Read, FileShare.Read);
                List<Company> company = (List<Company>)formatter.Deserialize(stream);
                stream.Close();
                return company;
            }
        }
    }
}
