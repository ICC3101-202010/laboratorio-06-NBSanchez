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
    [Serializable]
    class Company
    {
        private string companyName;
        private string companyRut;
        private List<Division> listDivision = new List<Division> { new Division(), new Area(), new Departamento(), new Seccion(), new Bloque() };


        public void setCompany(string companyName, string companyRut)
        {
            this.companyName = companyName;
            this.companyRut = companyRut;
        }
        public string Information()
        {
            return ("Nombre: " + companyName + "  Rut: " + companyRut);
        }
        public List<Division> GetDivisions()
        {
            return listDivision;
        }
        public void Recorrer(List<String> name, List<String> lastname)
        {
            Random random = new Random();

            for ( int x = 0; x < listDivision.Count()-1; x++)
            {
                string rut = Convert.ToString(random.Next(16234678, 26000000)) + "-" + Convert.ToString(random.Next(0,10));
                listDivision[x].setEncargado(name[x], lastname[x], rut);
            }
            Bloque bloque = new Bloque();
            string rut1 = Convert.ToString(random.Next(16234678, 26000000)) + "-" + Convert.ToString(random.Next(0, 10));
            bloque.setEncargado(name[4], lastname[4], rut1);
            bloque.setLacayo(name, lastname);
            listDivision[4] = bloque;
            
        }


    }
}
