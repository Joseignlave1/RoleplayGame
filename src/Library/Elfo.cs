using System.Collections.Generic;

namespace RolePLay
{
    public class Elfo : Personaje,  IAtacable
    {
        public Elfo (string nombre, int salud)
            :base(nombre, salud)
        {
        }
    }
}