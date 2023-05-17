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
            // Los enemigos atacan a los hérores primero
            foreach(var Enemigo in ListaEnemigos)
            {
                if(ListaHeroes.Count>0)
                {
                    var Heroe = ListaHeroes[0];
                    Heroe.RecibirAtaque(Enemigo.ObtenerAtaque());
                    if (Heroe.Salud<=0)
                    {
                        ListaHeroes.RemoveAt(0);    /* si la salud del persona(Heroe) es menor a 0 lo remuevo de la lista
                                                     uso el método RemoveAt de la clase collections generic */
                    }

                    

                }

        
            }
            // ahora los heroes atacan a los enemigos
            foreach(var Heroe in ListaHeroes)
            {
                foreach(var Enemigo in ListaEnemigos)
                {
                    Atacar(Heroe , Enemigo); // si la salud del Enemigo es menor a 0 lo remuevo de la lista
                                                            // uso el método RemoveAt de la clase collections generic
                    if (Enemigo.Salud<=0)
                    {
                        Heroe.ContadorVP+=Enemigo.VP;
                        Enemigo.Remove(ListaEnemigos);

                        break;


                    
                        
                        

                    }
                    if(ListaHeroes.Count>0)
                    {
                        foreach(var Heroes in ListaHeroes)
                        {
                            if(Heroes.ContadorVP>=5)
                            {

                            }

                            break;
                        }
                    }
                    
                }
            }
        } 
        
        
    }
        private void Atacar(Personaje Heroe, LosMalos Enemigo) // Falta ver como puedo hacer para "Invertir"
                                                                // los objetos que recibe la lista ya que como son dos clases distintas, para heroe y enemigo, primero quiero que
                                                                // reciba un enemigo y un héroe y después un heroe y un enemigo, en este orden, para indicar que los enemigos atacan primero.
        {

        }

    }
}