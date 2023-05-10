namespace RolePLay
{
    public class Item
    {
        string Tipo {get;}
        string Nombre {get;}
        public int Daño {get;}
        public int Defensa{get;}

        public Item(string tipo, string nombre, int daño, int defensa)
        {
            this.Tipo = tipo;
            this.Nombre = nombre;
            this.Daño = daño;
            this.Defensa = defensa;
        }
    }
}