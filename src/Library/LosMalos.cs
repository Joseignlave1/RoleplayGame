using System.Collections.Generic;

namespace RolePLay
{
    public class LosMalos : Personaje, IAtacable
    {
        public int VP {get;}

        public LosMalos (string nombre, int salud, int VP): base(nombre, salud)
        {
            this.VP = VP;
        }

    
    }
}