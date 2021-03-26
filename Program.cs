/*
 * Created by SharpDevelop.
 * User: pc
 * Date: 26/03/2021
 * Time: 17:00
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Programa_04
{
    class Program
    {
        public static void Main(string[] args)
        {
             
            string dato = "";
            
            int ActividadPerro = 0;
            double peso = 0.0;
            double edad = 0.0;
            int opcion = 0;
            
            
            
            do{
                
                Console.WriteLine("¡Bienvenido al programa de cuanto debe comer su perro!\n");
                
                Console.WriteLine("¿Cual es la edad de su perro?(en meses):");
                dato = Console.ReadLine();
                edad = Convert.ToDouble(dato);
                
                Console.WriteLine("\n¿Cual es el peso de su perro?(en kg):");
                dato = Console.ReadLine();
                peso = Convert.ToDouble(dato);
                
                Console.WriteLine("¿Cual es el nivel de actividad de su canino?");
                Console.WriteLine("1 - Actividad alta");
                Console.WriteLine("2 - Actividad normal");
                Console.WriteLine("3 - Actividad baja");
                dato = Console.ReadLine();
                ActividadPerro = Convert.ToInt32(dato);
                
                
                //Tamaño Miniatura
                if(edad >= 2 && peso >= 2  && peso <=5) 
                {
                    
                    switch (ActividadPerro) {
                        case 1:
                            Console.WriteLine("Su pequeño perro debe comer entre 60 - 115 gramos de alimento.");
                            break;
                        case 2:
                            Console.WriteLine("Su pequeño perro debe comer entre 55 y 100 gramos de alimento.");
                            break;
                        case 3:
                            Console.WriteLine("Su pequeño perro debe comer entre 45 -85 gramos de alimento.");
                            break;
                	}
                }
                            
                           
                            	
                          
                    //Tamaño pequeño
                    
                    if(edad >= 2 && peso > 5  && peso <=10) 
                {
                    
                    switch (ActividadPerro) {
                        case 1:
                            Console.WriteLine("Su perrito debe comer entre 115 - 190 gramos de alimento.");
                            break;
                        case 2:
                            Console.WriteLine("Su perrito debe comer entre 100 y 170 gramos de alimento.");
                            break;
                        case 3:
                            Console.WriteLine("Su perrito debe comer entre 85 -145 gramos de alimento.");
                            break;
                	}
                }
                          
                        
                       //Tamaño mediano
                       if(edad >= 2 && peso > 10  && peso <=15) 
                {
                    
                    switch (ActividadPerro) {
                        case 1:
                            Console.WriteLine("Su perro mediano debe comer entre 190 - 255 gramos de alimento.");
                            break;
                        case 2:
                            Console.WriteLine("Su perro mediano debe comer entre 170 y 225 gramos de alimento.");
                            break;
                        case 3:
                            Console.WriteLine("Su perro mediano debe comer entre 145 -195 gramos de alimento.");
                            break;
                	}
                }
                       
                       
                       //Tamaño grande
                        if(edad >= 2 && peso > 15  && peso <=55) 
                {
                    
                    switch (ActividadPerro) {
                        case 1:
                            Console.WriteLine("Su gran perro debe comer entre 255 - 680 gramos de alimento.");
                            break;
                        case 2:
                            Console.WriteLine("Su gran perro debe comer entre 225 y 600 gramos de alimento.");
                            break;
                        case 3:
                            Console.WriteLine("Su gran perro debe comer entre 195 -520 gramos de alimento.");
                            break;
                	}
                }
                
                
                
                Console.WriteLine("\nSi quiere continuar en el programa escriba 1\n sino escriba 4");
                dato = Console.ReadLine();
                opcion = Convert.ToInt32(dato);
                
                Console.Clear();
                
                
            }while(opcion != 4);
                        
            
    
            
            
        }
    }
}