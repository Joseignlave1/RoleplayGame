using System.Collections.Generic;

namespace RolePLay
{
    public interface IAtacable
    {
        void RecibirAtaque(Personaje Victima);
        int ObtenerDefensa();
    }
}