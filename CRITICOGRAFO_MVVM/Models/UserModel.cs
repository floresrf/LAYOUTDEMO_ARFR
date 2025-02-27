using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRITICOGRAFO_MVVM.Models
{
    internal class UserModel
    {
        public string Name { get; set; }
        public string Gender { get; set; }
        public string Mensaje { get; set; }

        //atributos
        public bool Alto {  get; set; }
        public bool Feo { get; set; }
        public bool Listo { get; set; }
        public bool Extravagante { get; set; }
        public bool Raro { get; set; }
        public bool Grande { get; set; }

    }
}
