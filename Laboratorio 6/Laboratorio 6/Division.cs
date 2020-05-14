using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Threading.Tasks;

namespace Laboratorio_6
{
    [Serializable]
    class Division
    {
        protected string divisionName;
        protected Persona encdivision;

        public void setDivision(string divisionName)
        {
            this.divisionName = divisionName;

        }
        public string getDivision()
        {
            return divisionName;
        }
        public virtual void setEncargado(string name, string lastname, string rut)
        {
            Persona people = new Persona();
            people.SetPersonal(name, lastname, rut, "Encargado de Division");
            encdivision = people;

        }
        public virtual string getEncargado()
        {
            return ("Nombre Encargado Division: " + encdivision.GetPersonal());
        }
       
    }
}
