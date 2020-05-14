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
    class Persona
    {
        private string pName;
        private string pLastName;
        private string pRut;
        private string pPost;

       
        public void SetPersonal(string pName, string pLastName, string pRut, string pPost)
        {
            this.pName = pName;
            this.pLastName = pLastName;
            this.pRut = pRut;
            this.pPost = pPost;
        }
        public string GetPersonal()
        {
            return ("Nombre: " + pName + " Apellido: " + pLastName + " RUT: " + pRut + " Cargo: " + pPost);
        }



    }
}
