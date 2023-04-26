namespace RolePLay
{
    public class Item
    {
        string Tipo {get;}
        string Nombre {get;}
        int Daño {get;}
        int Defensa{get;}

        public Item(string tipo, string nombre, int daño, int defensa)
        {
            this.Tipo = tipo;
            this.Nombre = nombre;
            this.Daño = daño;
            this.Defensa = defensa;
        }
    }
}