using System.Collections.Generic;

namespace RolePLay
{
    public interface IAtacable
    {
        void RecibirAtaque(int daño);
        int ObtenerDefensa();
    }
}