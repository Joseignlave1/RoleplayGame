namespace RolePLay
{
    public class Heroe : Personaje
    {
        public int VP {get;}
        public Heroe (string nombre, int salud)
            :base(nombre, salud)
        {
            this.VP = 0;
        }
    }
}