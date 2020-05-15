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
    class Bloque : Division
    {
        private string idBloque = "Bloque";
        private Persona encbloque;
        private List<Persona> lacayos = new List<Persona>() { new Persona(), new Persona()};


        public override void setEncargado(string ebname,string eblastname,string rut)
        {
            Persona people = new Persona();
            people.SetPersonal(ebname, eblastname, rut, "Encargado de Bloque");
            encbloque = people;

        }

        public override string getEncargado()
        {
            return ("Nombre Encargado Bloque: " + encbloque.GetPersonal() + Environment.NewLine + Environment.NewLine + "Lacayos: " + Environment.NewLine + Environment.NewLine + lacayos[0].GetPersonal() + Environment.NewLine + lacayos[1].GetPersonal() + Environment.NewLine + Environment.NewLine );
        }
        public void setId(string idBloque)
        {
            this.idBloque = idBloque;
        }
        public string getId()
        {
            return ("Id: " + idBloque);
        }
        public void setLacayo(List<String> name, List<String> lastname, List<String> rut)

        {
            Random random = new Random();
            for (int i = 0; i < lacayos.Count(); i++) 
            {
                
                lacayos[i].SetPersonal(name[i+5], lastname[i+5], rut[i], "Lacayo del Bloque");
            }
        }
        
    }
}
