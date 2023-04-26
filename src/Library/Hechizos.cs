namespace RolePLay
{
    public class Hechizo
    {
        string Nombre {get;}
        int Daño {get;}
        int Defensa {get;}

        public Hechizo (string nombre, int daño, int defensa)
        {
            this.Nombre = nombre;
            this.Daño = daño;
            this.Defensa = defensa;
        }
    }
}