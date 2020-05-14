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
    class Area : Division
    {
        private string idArea = "Area";
        private Persona encarea;

      
        public override void setEncargado(string eaname, string ealastname, string rut)
        {
            Persona people = new Persona();
            people.SetPersonal(eaname, ealastname, rut, "Encargado de Area");
            encarea = people;

        }
        
        public override string getEncargado()
        {
            return ("Nombre Encargado Area: " + encarea.GetPersonal());
        }
        public void setId(string idArea)
        {
            this.idArea = idArea;
        }
        public string getId()
        {
            return ("Id : " + idArea);
        }

    }
}
