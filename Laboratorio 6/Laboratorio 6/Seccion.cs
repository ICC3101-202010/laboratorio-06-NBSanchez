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
    class Seccion : Division
    {
        private string idSeccion = "Seccion";
        private Persona encseccion;



        public override void setEncargado(string esname, string eslastname,string rut)
        {
            Persona people = new Persona();
            people.SetPersonal(esname, eslastname, rut, "Encargado de Seccion");
            encseccion = people;

        }

        public override string getEncargado()
        {
            return ("Nombre Encargado Seccion: " + encseccion.GetPersonal());
        }
        public void setId(string idSeccion)
        {
            this.idSeccion = idSeccion;
        }
        public string getId()
        {
            return ("Id: " + idSeccion);
        }
    }
}
