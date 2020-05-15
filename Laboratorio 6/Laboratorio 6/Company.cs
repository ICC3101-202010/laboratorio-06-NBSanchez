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
        private List<Division> listDivision = new List<Division> { new Division(), new Area(), new Departamento(), new Seccion(), new Bloque(), new Bloque() };


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
            List<String> listrut = new List<String>() { Convert.ToString(random.Next(16234678, 26000000)) + "-" + Convert.ToString(random.Next(0, 10)), Convert.ToString(random.Next(16234678, 26000000)) + "-" + Convert.ToString(random.Next(0, 10)) };
            List<String> listrut1 = new List<String>() { Convert.ToString(random.Next(16234678, 26000000)) + "-" + Convert.ToString(random.Next(0, 10)), Convert.ToString(random.Next(16234678, 26000000)) + "-" + Convert.ToString(random.Next(0, 10)) };
            bloque.setEncargado(name[4], lastname[4], rut1);
            bloque.setLacayo(name, lastname,listrut);
            listDivision[4] = bloque;
            name.RemoveAt(5);
            lastname.RemoveAt(5);
            name.RemoveAt(6);
            lastname.RemoveAt(6);
            name.RemoveAt(1);
            lastname.RemoveAt(1);
            Bloque bloque1 = new Bloque();
            string rut2 = Convert.ToString(random.Next(16234678, 26000000)) + "-" + Convert.ToString(random.Next(0, 10));
            bloque1.setEncargado(name[5], lastname[5],rut2);
            bloque1.setLacayo(name, lastname,listrut1);
            listDivision[5] = bloque1;

        }


    }
}
