using System;
using System.Collections.Generic;
using RolePLay;
using System.Linq;

namespace RolePlay
{
    public class CampodeBatalla
    {
        public List<Personaje> ListaEnemigos;
        public List<Personaje> ListaHeroes;
        private bool EnemigosPrimero;

        public CampodeBatalla(List<Personaje> ListaEnemigos, List<Personaje> ListaHeroes)
        {
            this.ListaEnemigos = ListaEnemigos;
            this.ListaHeroes = ListaHeroes;
            this.EnemigosPrimero= true;
        }

        public void DoEncounter()
{
    if (EnemigosPrimero)
    {
        EnemigosPrimero = false;

        while (ListaEnemigos.Count > 0 && ListaHeroes.Count > 0)
        {
            if (ListaHeroes.Count > 0)
            {
                // Los enemigos atacan a los héroes primero
                foreach (var Enemigo in ListaEnemigos.ToList())
                {
                    foreach (var Heroe in ListaHeroes.ToList())
                    {
                        Heroe.RecibirAtaque(Enemigo.ObtenerAtaque());
                        Console.WriteLine($"La salud del héroe {Heroe.Nombre} es {Heroe.Salud}");
                        Console.WriteLine($"La salud del enemigo {Enemigo.Nombre} es {Enemigo.Salud}");
                        if (Heroe.Salud <= 0)
                        {
                            ListaHeroes.Remove(Heroe);
                        }
                        if (ListaHeroes.Count == 0)
                        {
                            break;
                        }
                    }

                    if (ListaHeroes.Count == 0)
                    {
                        break;
                    }
                }
            }

            if (ListaEnemigos.Count > 0)
            {
                // ahora los héroes atacan a los enemigos
                foreach (var Heroe in ListaHeroes.ToList())
                {
                    foreach (var Enemigo in ListaEnemigos.ToList())
                    {
                        Enemigo.RecibirAtaque(Heroe.ObtenerAtaque());
                        Console.WriteLine($"La salud del héroe {Heroe.Nombre} es {Heroe.Salud}");
                        Console.WriteLine($"La salud del enemigo {Enemigo.Nombre} es {Enemigo.Salud}");
                        if (Enemigo.Salud <= 0)
                        {
                            Heroe.ContadorVP += Enemigo.VP;
                            ListaEnemigos.Remove(Enemigo);
                            Console.WriteLine($"Los VP de los héroes son {Heroe.ContadorVP}");
                        }
                        if (ListaEnemigos.Count == 0)
                        {
                            break;
                        }
                    }

                    if (ListaEnemigos.Count == 0)
                    {
                        break;
                    }
                }
            }

            if (ListaHeroes.Count > 0)
            {
                foreach (var Heroe in ListaHeroes.ToList())
                {
                    if (Heroe.ContadorVP >= 5)
                    {
                        Heroe.Salud = Heroe.Salud + 100; // lógica de curación
                    }
                }
            }
        }
    }

    EnemigosPrimero = !EnemigosPrimero;
}


    }
}
