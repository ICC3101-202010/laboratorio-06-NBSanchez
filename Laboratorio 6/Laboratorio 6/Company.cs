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


        public Company(string companyName, string companyRut)
        {
            this.companyName = companyName;
            this.companyRut = companyRut;
        }
        public string Information()
        {
            return ("Nombre: " + companyName + "  Rut: " + companyRut);
        }

    }
}
