using System;
using System.Collections.Generic;


// Aquí tengo el problema de el bucle infinito intenté imprimir el contenido de cada lista en cada iteracción
// y se mantienen en 1, entonces prové examinar el método atacar y cambiar el tipo de remove, de removeat de colecciónes genéricas a remove
namespace RolePLay
{

    public class CampodeBatalla
    {
        public List<Personaje> ListaEnemigos;
        public List<Personaje> ListaPersonajes;
        private bool EnemigosPrimero;
    
    public CampodeBatalla(List<Personaje> ListaEnemigos,  List<Personaje> ListaPersonajes)
    {
       this.ListaEnemigos=ListaEnemigos;
       this.ListaPersonajes=ListaPersonajes;


    }

    public void DoEncounter()
    {
         EnemigosPrimero=true;//defino una variable booleana en la que si es true se ejecuta
                                  // el ciclo en el que los enemigos atacan primero, si es false 
                                  // se ejecuta el ciclo en el que los heroes atacan primero, después lo invierto con !
        
        while(ListaEnemigos.Count>0 && ListaPersonajes.Count>0)

        {
            System.Console.WriteLine($"Cantidad de enemigos{ListaEnemigos.Count}");
            System.Console.WriteLine($"Cantidad de heroes {ListaPersonajes.Count}");
            // Los enemigos atacan a los hérores primero
            if(EnemigosPrimero)
            {
                foreach(var Enemigo in ListaEnemigos)
            {
                if(ListaPersonajes.Count>0)
                {
                    Personaje Heroe = ListaPersonajes[0];
                    Atacar(Enemigo, Heroe);
                    if (Heroe.Salud<=0)
                    {
                        ListaPersonajes.Remove(Heroe);    // si la salud del persona(Heroe) es menor a 0 lo remuevo de la lista
                    System.Console.WriteLine($"Lista se remueve o no ?{ListaPersonajes.Count}");                        
                                                            
                                                      

                    }

                    

                }

        
            }
            }
            else
            // ahora los heroes atacan a los enemigos
                foreach(var Heroe in ListaPersonajes)
                { 
                    if (ListaEnemigos.Count>0)
                {
                    Personaje Enemigo= ListaEnemigos[0];
                    Atacar(Heroe,Enemigo);
                    if (Enemigo.Salud<=0)
                    {
                         ListaEnemigos.Remove(Enemigo);
                         Heroe.ContadorVP += Enemigo.VP;
                    }

                {
                   
                    
                                                           
                    {
                       
                        {
                            
                   


                        }
                       

                    
                        
                        

                    }
                    
                    {
                        foreach(var heroe in ListaPersonajes)
                        {
                            if(Heroe.ContadorVP>=5) // lógica de curación.
                            {
                                Heroe.Salud=100;

                            }
                        }
                           if(ListaEnemigos.Count<=0 && ListaPersonajes.Count<=0)
                            {
                                break;
                            }
                        EnemigosPrimero = !EnemigosPrimero;
                        
                            

                
     

                        
                    }
                    
                }
                
                }
                
            }
        } 
        
        
    }
        private void Atacar( Personaje Enemigo,  Personaje Heroe) 
                                                                
        {
            if (ListaPersonajes.Count==0)
            {
                return;
            }
            if (EnemigosPrimero) //Lógica, atacan los enemigos
            {   
                if(ListaPersonajes.Count==1)
                {
                    // si hay un solo heroe, todos los enemigos atacan al mismo heroe
                    Heroe.Salud-=Enemigo.ObtenerAtaque(); // le resto la salud de mi heroe al ataque del enemigo
                    System.Console.WriteLine($"El enemigo atacó al heroe, salud del heroe {Heroe.Salud}"); //

                }
            } 
                                                              
            {
                if (ListaPersonajes.Count!=1 && ListaPersonajes.Count>0) 
                {
                    int IndiceEnemigo= ListaEnemigos.IndexOf(Enemigo);
                    int IndiceHeroe =  IndiceEnemigo  % ListaPersonajes.Count;
                    Personaje HeroeAtacado = ListaPersonajes[IndiceHeroe];
                    HeroeAtacado.Salud-= Enemigo.ObtenerAtaque();
                    System.Console.WriteLine("Enemigo"+IndiceEnemigo+"Ataca al Heroe"+IndiceHeroe+ "Salud Del Heroe: "+HeroeAtacado.Salud);
                    
                }

                
        
           
                else
                {
                    Enemigo.Salud-=Heroe.ObtenerAtaque();
                    System.Console.WriteLine($"El Héroe ataca al enemigo, salud del Enemigo{Enemigo.Salud}");
                }
                        
            }
          

           
           
        }
           

    }
}