using System.Collections.Generic;

namespace RolePLay
{
    public class Mago
    {
        string Nombre {get;}
        int Salud {get; set;}
        public List<Item> listaItems = new List<Item>();

        public Mago (string nombre, int salud)
        {
            this.Nombre = nombre;
            this.Salud = salud;
        }

        public void AgregarItem(Item item)
        {
            listaItems.Add(item);
        }

        public void SacarItem(Item item)
        {
            listaItems.Remove(item);
        }

        public void RecibirAtaque(int daño)
        {
            this.Salud = this.Salud - (this.ObtenerDefensa() - daño);
        }

        public int ObtenerAtaque()
        {
            int AtaqueTotal = 0;
            for (int i = 0; i < listaItems.Count; i++)
            {
                AtaqueTotal += listaItems[i].Daño;
            }
            return AtaqueTotal;
        }

        public int ObtenerDefensa()
        {
            int DefensaTotal = 0;
            for(int i = 0; i < listaItems.Count; i++)
            {
                DefensaTotal += listaItems[i].Defensa;
            }
            return DefensaTotal;
        }

        public void Curar()
        {
            this.Salud = 100;
        }
    }
}