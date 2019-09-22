using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace UnionApp.Models
{
    public class Contacto : INotifyPropertyChanged
    {

        public event PropertyChangedEventHandler PropertyChanged;
        public string Nombre {get;set;}
        public string Cargo {get;set;}
        public string Celular {get;set; }

    }

}


