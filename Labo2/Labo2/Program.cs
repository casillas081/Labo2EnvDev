using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labo2
{
    class Program
    {
        static void Main(string[] args)
        {
            PrivateContact privateContact1 = new PrivateContact("Eastpak", "Usa", 085958746, "eastpak.usa@gmail.com", new DateTime(1990, 09, 25));
            PrivateContact privateContact2 = new PrivateContact("Asus", "Sonic", 052461512, "asus.sonic@gmail.com");
        }
    }
}
