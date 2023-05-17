using System;
using System.Collections.Generic;
namespace RolePLay
{
    public class CampodeBatalla
    {
        private List<LosMalos> ListaEnemigos;
        private List<Heroe> ListaHeroes;
    
        public CampodeBatalla(List<LosMalos> ListaEnemigos,  List<Heroe> ListaHeroes)
        {
        this.ListaEnemigos = ListaEnemigos;
        this.ListaHeroes = ListaHeroes;
        }

        public void DoEncounter()
        {
            while(ListaEnemigos.Count>0 && ListaHeroes.Count>0)
            {

                if (ListaHeroes.Count>0)
                {
                // Los enemigos atacan a los hérores primero
                    foreach(var Enemigo in ListaEnemigos)
                    {
                        foreach (var Heroe in ListaHeroes)
                        {
                            Heroe.RecibirAtaque(Enemigo.ObtenerAtaque());
                            if (Heroe.Salud<=0)
                            {
                                ListaHeroes.RemoveAt(0);    /* si la salud del persona(Heroe) es menor a 0 lo remuevo de la lista
                                                     uso el método RemoveAt de la clase collections generic */
                            }   
                        }
                    }
                }
        
                if (ListaEnemigos.Count > 0)
                {
                // ahora los heroes atacan a los enemigos
                    foreach(var Heroe in ListaHeroes)
                    {
                        foreach(var Enemigo in ListaEnemigos)
                        {
                            Enemigo.RecibirAtaque(Heroe.ObtenerAtaque()); // si la salud del Enemigo es menor a 0 lo remuevo de la lista
                                                            // uso el método RemoveAt de la clase collections generic
                            if (Enemigo.Salud<=0)
                            {
                                Heroe.ContadorVP+=Enemigo.VP;
                                Enemigo.Remove(ListaEnemigos);

                            }
                        }
                    }
                }
                if(ListaHeroes.Count>0)
                {
                    foreach(var Heroes in ListaHeroes)
                    {
                        if(Heroes.ContadorVP>=5)
                        {

                        }
                    }
                }
            }
        }
    }
} 