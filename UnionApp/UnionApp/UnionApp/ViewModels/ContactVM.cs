using System;
using System.Collections.Generic;
using System.Text;
using UnionApp.Models;

namespace UnionApp.ViewModels
{
    public class ContactVM
    {
        public List<Contacto> ContactList { get; set; }

        public ContactVM()
        {
            ContactList = new List<Contacto>();
        }
        public void GetContactos()
        {
            List<Contacto> Contactos = new List<Contacto>();
            for (var i = 1; i < 5; i++)
            {
                Contactos.Add(
               new Contacto
               {
                   Nombre = "Persona " + i,
                   Cargo = "Lorem Ipsum Dolor",
                   Celular = "+593983779996"

               });
            }

            if (ContactList != null)
            {
                ContactList.Clear();
                foreach (var con in Contactos)
                {
                    ContactList.Add(con);
                }
            }
        }
    }
}
