using System;
using System.Collections.Generic;
using RolePlay;


namespace RolePLay
{
    class Program
    {
        static void Main(string[] args)
        {
            LosMalos malo = new LosMalos ("Marcos",100,50);
            LosMalos malo2 = new LosMalos ("Marcospete",100,100);
            Item item11 = new Item ("Arma","Machete",10,0);
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
           

            mago1.AgregarItem(item9);
            mago1.AgregarItem(item8);
            //Console.WriteLine(mago1.ObtenerAtaque);
            enano3.AgregarItem(item8);
            //Console.WriteLine(enano3.ObtenerDefensa());
            //enano3.RecibirAtaque(mago1.ObtenerAtaque);
            enano3.Curar();
            
            // agrego un enano  a la lista de personajes y un malo a la lista enemígos para probar el campo de batalla
            List<Personaje> ListaEnemigos = new List<Personaje>();
            malo.AgregarItem(item9);
            ListaEnemigos.Add(malo);
            ListaEnemigos.Add(malo2);
            
            List<Personaje> ListaPersonajes = new List<Personaje>();
            enano1.AgregarItem(item7);
            ListaPersonajes.Add(enano1);
            ListaPersonajes.Add(elfo1);

            CampodeBatalla campodeBatalla= new CampodeBatalla(ListaEnemigos,ListaPersonajes);
            campodeBatalla.DoEncounter();
            Console.ReadLine();
            enano3.ObtenerAtaque();
            Console.ReadLine();
            enano3.ObtenerDefensa();
            enano3.ObtenerAtaque();
            Console.ReadLine();            

            Item item12 = new Item("Combinado", "Cosa", item3.Daño + item11.Daño, item3.Defensa + item11.Defensa);
            




            

        }
    }
}
