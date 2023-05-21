using System;
using System.Collections.Generic;

namespace RolePLay
{
    public class LosMalos : Personaje, IAtacable
    {
        //public int VP {get;}  // no necesito poner este public int VP, como los malos heredan de personaje
                              // ya tienen este método.

        public LosMalos (string nombre, int salud, int VP): base(nombre, salud)
        {
            //this.VP=VP;  //Tampoco necesito inicializarlo en el constructor.
        }

        internal void Remove(List<LosMalos> listaEnemigos)
        {
            throw new NotImplementedException();
        }
    }
}