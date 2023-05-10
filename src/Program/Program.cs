using System;

namespace RolePLay
{
    class Program
    {
        static void Main(string[] args)
        {
            Enano enano1 = new Enano("Gonza", 100);
            Item item1 = new Item("Arma", "Martillo", 15, 0);
            Item item2 = new Item("Armadura", "Pechera", 0, 20); 

            Mago mago1 = new Mago("Juan", 100);
            Item item3 = new Item("Arma","Espada",10,0);
            Item item4 = new Item("Arma","Pistola",15,0);

            Elfo elfo1 = new  Elfo("Josesito",100);
            Item item5 = new Item("Arma","Banco de estadio",15,0);
            Item item6 = new Item("Arma","Bastón mágico",20,8);
            
            Enano enano2 = new Enano("Chorch", 100);
            Item item7 = new Item("Arma", "Hacha", 20,0);
            Item item8 = new Item("Armadura", "Escudo", 5,15);

            Enano enano3 = new Enano ("Anabelle", 100);
            Item item9 = new Item("Arma", "Lanza", 30, 0);
            Item item10 = new Item("Armadura", "Túnica", 0, 10);

            mago1.AgregarItem(item3);
            mago1.AgregarItem(item4);
            Console.WriteLine(mago1.ObtenerAtaque());
            enano2.AgregarItem(item8);
            Console.WriteLine(enano2.ObtenerDefensa());
            enano2.RecibirAtaque(mago1.ObtenerAtaque());
            enano2.Curar();
        }
    }
}
