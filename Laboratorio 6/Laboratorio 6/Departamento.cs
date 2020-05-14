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
    class Departamento : Division
    {
        private string idDepto = "Departamento";
        private Persona encdepto;



        public override void setEncargado(string edname, string edlastname, string rut)
        {
            Persona people = new Persona();
            people.SetPersonal(edname, edlastname, rut, "Encargado de Departamento");
            encdepto = people;


        }

        public override string getEncargado()
        {
            return ("Nombre Encargado Depto: " + encdepto.GetPersonal());
        }
        public void setId(string idDepto)
        {
            this.idDepto = idDepto;
        }
        public string getId()
        {
            return ("Id : " + idDepto);
        }
    }
}
