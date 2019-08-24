using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica3Reynaldo
{
    class Program
    {
        static void Main(string[] args)
        {
            string seguir = "";
            int opc = 0;
            do
            {
                Console.WriteLine("seleccione un ejercicio del 1-8");
                opc = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
                switch (opc)
                {
                    case 1:
                        ejer1();
                        break;
                    case 2:
                        ejer2();
                        break;
                    case 3:
                        ejer3();
                        break;
                    case 4:
                        ejer4();
                        break;
                    case 5:
                        ejer5();

                        break;
                    case 6:
                        ejer6();
                        break;
                    case 7:
                        ejer7();
                        break;
                    case 8:
                        ejer8();
                        break;

                    default:
                        break;
                }
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("Desea hacer otro ejercicio? s/n");
                seguir = Console.ReadLine();
            } while (seguir == "S" || seguir == "s");
          

            Console.ReadKey();
        }

        static void ejer1()
        {
            DateTime h;
            Console.WriteLine("Coloque las horas en este formato [hh:00] ");
            h = Convert.ToDateTime(Console.ReadLine());
            h.ToString("hh:mm");

            if (h.Hour > 0)
            {
                Console.WriteLine("Minutos: {0}\n Segundos: {1}", h.Hour * 60, h.Hour * 3600);
            }
            else
            {
                Console.WriteLine("La hora no debe ser negativo");
            }

            
            

        }
        static void ejer2()
        {
          

           var Random  = new Random();
           var numero = Random.Next(1, 100);

           if (numero % 2 == 0)
           {
               Console.WriteLine(numero + " El numero es par");
           }
           else
           {
               Console.WriteLine(numero + " El numero es impar");
           }
                


           

        }


        static void ejer3()
        {
            Console.WriteLine("Coloque el primer numero");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Coloque el segundo numero");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Coloque el tercer numero");
            int c = int.Parse(Console.ReadLine());
            int mayor;
            int pequeño;
            int medio;

            if (a > b && a > c)
            {
                mayor = a;
            }
            else if (b > a && b > c)
            {
                mayor = b;
            }
            else
            {
                mayor = c;
            }

            if (a < b && a < c)
            {
                pequeño = a;
            }
            else if (b < a && b < c)
            {
                pequeño = b;
            }
            else
            {
                pequeño = c;
            }

            if (a > pequeño && a < mayor)
            {
                medio = a;
            }
            else if (b > pequeño && b < mayor)
            {
                medio = b;
            }
            else
            {
                medio = c;
            }

            Console.WriteLine("{0} {1} {2}", mayor, medio, pequeño);
          }

        static void ejer4()
        {
            int m, zona;
            double t=-0;
            Console.WriteLine("1.Occidental");
            Console.WriteLine("2.Central");
            Console.WriteLine("3.oriental");
            Console.WriteLine("En que zona hizo la llamada?");
            zona = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Coloque los minutos que duro la llamada");
            m = Convert.ToInt32(Console.ReadLine());

            switch (zona)
            {
                case 1:
                    t = m * 0.32;
                    break;
                case 2:
                    t = m * 0.25;
                    break;
                case 3:
                    t = m * 0.36;
                    break;

                
            }
            Console.WriteLine("El costo de la llamada es: $" + t);

        }
        static void ejer5()
        {
            int n ;
            string[] letras = { "uno", "dos", "tres", "cuatro", "cinco", "seis", "siete", "ocho", "nueve", "diez" };
            do
            {
                Console.WriteLine("Coloque el numero");
                n = Convert.ToInt32(Console.ReadLine());
                
            } while (n<1 && n>10);

            if (n==1)
            {
                Console.WriteLine(letras[0]);
            }
            else
            {
                if (n==2)
                {
                  Console.WriteLine(letras[1]);  
                }
                else
                {
                    if (n==3)
                    {
                        Console.WriteLine(letras[2]);
                    }
                    else
                    {
                        if (n == 4)
                        {
                            Console.WriteLine(letras[3]);
                        }
                        else
                        {
                            if (n == 5)
                            {
                                Console.WriteLine(letras[4]);
                            }
                            else
                            {
                                if (n == 6)
                                {
                                    Console.WriteLine(letras[5]);
                                }
                                else
                                {
                                    if (n == 7)
                                    {
                                        Console.WriteLine(letras[6]);
                                    }
                                    else
                                    {
                                        if (n == 8)
                                        {
                                            Console.WriteLine(letras[7]);
                                        }
                                        else
                                        {
                                            if (n == 9)
                                            {
                                                Console.WriteLine(letras[8]);
                                            }
                                            else
                                            {
                                                if (n == 10)
                                                {
                                                    Console.WriteLine(letras[9]);
                                                }
                                            }

                                        }

                                    }
                                }
                            }
                        }
                    }
                }


            }
            
        }


        static void ejer6()
        {
            double costo = 0, descuento = 0;
            Console.WriteLine("Coloque el monto de la compra");
            costo = Convert.ToDouble(Console.ReadLine());
            #region ifDelDescuento
            if (costo >= 0 && costo <= 100)
            {
                Console.WriteLine("No hay descuento");
            }
            else
            {
                if (costo >= 100.01 && costo <= 200)
                {
                    descuento = costo * 0.12;
                }
                else
                {
                    if (costo >= 200.01 && costo <= 500)
                    {
                        descuento = costo * 0.15;
                    }
                    else
                    {
                        if (costo >= 500.01)
                        {
                            descuento = costo * 0.20;
                        }
                    }
                }
            }
            #endregion
            double total = costo - descuento;
            Console.WriteLine("Descuento: {0}\n total: {1}", descuento, total);
        }


        static void ejer7()
        {
            double conversion = 0;
            double valor=0;
            int opcGenral = 0;
            Console.WriteLine("[1]Conversiones para onza");
            Console.WriteLine("[2]Conversiones para libra");
            Console.WriteLine("[3]Conversiones para gramos");
            Console.WriteLine("[4]Conversiones para toneladas");
            opcGenral = Convert.ToInt32(Console.ReadLine());
            switch (opcGenral)
            {
               
                case 1:
                      Console.WriteLine("      CONVERSION DE ONZAS:");
                    Console.WriteLine("----------------------------------");
                    Console.WriteLine("[1]De onza a libra");
                    Console.WriteLine("[2]De onza a gramos");
                    Console.WriteLine("[3]De onza a tonelada");               
                    int opcOnza = Convert.ToInt32(Console.ReadLine());
                    #region SwtchhOnzas
                    switch (opcOnza)
                    {
                        case 1:
                            Console.Clear();
                            Console.WriteLine("Coloque el valor de onzas a convertir");
                            valor = Convert.ToDouble(Console.ReadLine());
                            conversion = valor / 16;
                            break;
                        case 2:
                            Console.Clear();
                            Console.WriteLine("Coloque el valor de onzas a convertir");
                            valor = Convert.ToDouble(Console.ReadLine());
                            conversion = valor / 28.3495;
                            break;
                        case 3:
                            Console.Clear();
                            Console.WriteLine("Coloque el valor de onzas a convertir");
                            valor = Convert.ToDouble(Console.ReadLine());
                            conversion = valor / 35273.962;
                            break;
                           
                        default:
                            break;
                    }
                    #endregion
                   

                    break;
                case 2:
                     Console.WriteLine("      CONVERSION DE LIBRAS:");
                    Console.WriteLine("----------------------------------");
                    Console.WriteLine("[1]De libra a onza");
                    Console.WriteLine("[2]De libra a gramos");
                    Console.WriteLine("[3]De libra a tonelada");
                    int opcLibras = Convert.ToInt32(Console.ReadLine());

                    #region switchLibras
                    switch (opcLibras)
                    {
                        case 1:
                            Console.Clear();
                            Console.WriteLine("Coloque el valor de libras a convertir");
                            valor = Convert.ToDouble(Console.ReadLine());
                            conversion = valor * 16;
                            break;
                        case 2:
                            Console.Clear();
                            Console.WriteLine("Coloque el valor de libras a convertir");
                            valor = Convert.ToDouble(Console.ReadLine());
                            conversion = valor * 453.592;
                            break;
                        case 3:
                            Console.Clear();
                            Console.WriteLine("Coloque el valor de libras a convertir");
                            valor = Convert.ToDouble(Console.ReadLine());
                            conversion = valor / 2204.623;
                            break;

                        default:
                            break;
                    }
                    #endregion
                    break;
                case 3:
                     Console.WriteLine("      CONVERSION DE GRAMOS:");
                    Console.WriteLine("----------------------------------");
                    Console.WriteLine("[1]De gramos a libra");
                    Console.WriteLine("[2]De gramos a onza");
                    Console.WriteLine("[3]De gramos a tonelada");
                    
                    int opcGramos = Convert.ToInt32(Console.ReadLine());

                    #region switchGramos
                     switch (opcGramos)
                    {
                        case 1:
                            Console.Clear();
                            Console.WriteLine("Coloque el valor de gramos a convertir");
                            valor = Convert.ToDouble(Console.ReadLine());
                            conversion = valor / 453.592;
                            break;
                        case 2:
                            Console.Clear();
                            Console.WriteLine("Coloque el valor de gramos a convertir");
                            valor = Convert.ToDouble(Console.ReadLine());
                            conversion = valor / 28.35;
                            break;
                        case 3:
                            Console.Clear();
                            Console.WriteLine("Coloque el valor de gramos a convertir");
                            valor = Convert.ToDouble(Console.ReadLine());
                            conversion = valor / 1000000;
                            break;

                        default:
                            break;
                    }
                    #endregion
                    break;
                case 4:
                     Console.WriteLine("      CONVERSION DE TONELADAS:");
                    Console.WriteLine("----------------------------------");
                    Console.WriteLine("[1]De toneladas a libra");
                    Console.WriteLine("[2]De toneladas a gramos");
                    Console.WriteLine("[3]De toneladas a onza ");
                    
                    int opcToneladas = Convert.ToInt32(Console.ReadLine());
                    #region swtchToneladas
                      switch (opcToneladas)
                    {
                        case 1:
                            Console.Clear();
                            Console.WriteLine("Coloque el valor de toneladas a convertir");
                            valor = Convert.ToDouble(Console.ReadLine());
                            conversion = valor * 2204.623;
                            break;
                        case 2:
                            Console.Clear();
                            Console.WriteLine("Coloque el valor de toneladas a convertir");
                            valor = Convert.ToDouble(Console.ReadLine());
                            conversion = valor * 1000000;
                            break;
                        case 3:
                            Console.Clear();
                            Console.WriteLine("Coloque el valor de toneladas a convertir");
                            valor = Convert.ToDouble(Console.ReadLine());
                            conversion = valor * 35273.962;
                            break;

                        default:
                            break;
                    }
                    #endregion
                    break;
                default:
                    break;
            }

            Console.WriteLine("El resultado de la conversion es: {0} ", conversion);
        }


        static void ejer8()
        {
            double compra = 0, descuento=0;
            Random col = new Random();
            int color = col.Next(1, 5);
            string colores="";
            Console.WriteLine("Coloque el valor total de la compra");
            compra = Convert.ToInt32(Console.ReadLine());

            #region ifDeDescuento
            if (color == 1)
            {
                colores = "Blanca";
                  Console.WriteLine("No hay descuento");
            }
            else
            {
                if (color == 2)
                {
                    colores = "Verde";
                    descuento = compra * 0.15;
                }
                else
                {
                    if (color == 3)
                    {
                        colores = "Amarilla";
                        descuento = compra * 0.18;
                    }
                    else
                    {
                        if (color == 4)
                        {
                            colores = "Azul";
                            descuento = compra * 0.20;
                        }
                        else
                        {
                            if (color == 5)
                            {
                                colores = "Roja";
                                descuento = compra * 0.25;
                            }
                        }
                    }
                }
            }
            #endregion
            double total = compra - descuento;
            Console.WriteLine("Valor de la compra: {0}\nColor de bolita: {1}\nDescuento: {2}\nTotal: {3}", compra, colores, descuento, total);
        }
    }
}
