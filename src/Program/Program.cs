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

            Elfo elfo1= new  Elfo("Josesito",100);
            Item item5= new Item("Arma","Banco de estadio",15,0);
            Item item6 = new Item("Arma","Bastón mágico",20,8);

            
        
        }
    }
}
