using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLibrary
{
    class PrestamosPendientes
    {
        public  User user { get; }
        public Book Book { get; }

        public PrestamosPendientes(User usuario, Book book)
        {
            user = usuario;
            Book = book;
        }
    }

}
