namespace RolePLay
{
    public class Heroe : Personaje
    {
     

        public Heroe (string nombre, int salud)
            :base(nombre, salud)
    
        {
            
            
        }
        public override void RecibirAtaque(Personaje Victima)
        {
            base.RecibirAtaque(Victima);
            this.VP+= Victima.VP;
        }
    }
}
