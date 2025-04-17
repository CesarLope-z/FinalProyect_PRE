using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Final
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();


            Console.WriteLine("\t menu");

            int op;

            double h, b, a, r, x2, x3, d, c, d1, d3;
            string e = "";





            do
            {

                Console.WriteLine("\t¿Que ejercicio deseas realizar? ");
                Console.WriteLine("\t[1] Área de figuras geométricas");
                Console.WriteLine("\t[2] Ecuación Cuadrática");
                Console.WriteLine("\t[3] Angulo agudos");
                Console.WriteLine("\t[4] Plano Cartesiano");
                Console.WriteLine("\t[7] Super Selectos");
                Console.WriteLine("\t[8] Herencia");
                Console.WriteLine("\t[9] Año Bisiesto");
                Console.WriteLine("\t[10] MCM ");
                Console.WriteLine("\t[11] Creditos");
                Console.WriteLine("\t[12] Salir");

                op = int.Parse(Console.ReadLine());
                Console.Clear();

                switch (op)
                {
                    case 1:

                        Console.Write("\n Escogiste area de figuras Geometricas");
                        Console.Write("\nELIGE UNA OPCION EN MAYUSCULAS");
                        Console.Write("\n\n");
                        Console.WriteLine(" A) Cuadrado                       D) Romboide");
                        Console.WriteLine(" B) Circunferencia                 E) Trapecio");
                        Console.WriteLine(" C) Rectangulo                     F) Salir");
                        Console.Write("\n");
                        double A;
                        switch (Console.ReadLine())
                        {
                            case "A":

                                //cuadrado
                                Console.WriteLine(" Escogiste la Opcion A");
                                Console.WriteLine("\n Coloca el Lado del cuadrado");
                                a = double.Parse(Console.ReadLine());
                                A = a * a;
                                Console.Write(" El area del cuadrado es: " + A);
                                break;

                            case "B":

                                //circunferencia
                                Console.WriteLine("Escogiste la Opcion B");
                                Console.WriteLine("Digite el radio");
                                r = double.Parse(Console.ReadLine());
                                A = Math.PI * Math.Pow(r, 2);
                                Console.Write(" El resultado es :" + A);

                                break;
                            
                            case "C":
                                //rectangulo
                                Console.WriteLine("Escogiste la Opcion C");
                                Console.WriteLine("Digite la altura");
                                a = double.Parse(Console.ReadLine());
                                Console.WriteLine("Digite la base");
                                b = double.Parse(Console.ReadLine());
                                Console.WriteLine("El area es " + a * b);

                                break;

                            case "D":
                                //romboide
                                Console.Write("********************************");
                                Console.WriteLine("Escogiste la Opcion D");
                                Console.WriteLine("Digite la altura");
                                a = double.Parse(Console.ReadLine());
                                Console.WriteLine("Digite la hipotenusa");
                                h = double.Parse(Console.ReadLine());
                                Console.WriteLine("El area es " + a * h);
                                break;

                            case "E":
                                //Trapecio
                                Console.Write("********************************");
                                Console.WriteLine("Escogiste la Opcion E");
                                Console.WriteLine("Digite la altura");
                                a = double.Parse(Console.ReadLine());
                                Console.WriteLine("Coloca la base");
                                b = double.Parse(Console.ReadLine());
                                Console.WriteLine("Digite la Hipotenusa");
                                h = double.Parse(Console.ReadLine());
                                A = ((a + b) * h) / 2;
                                Console.WriteLine("El area es: " + A);
                                break;
                            
                            case "F":
                                Console.WriteLine(" GRACIAS POR USAR ESTE PROGRAMA");
                                break;
                            
                            default:
                                Console.WriteLine("Escoge la opcion correcta");
                                break;
                        }


                        break;

                    case 2:
                        double xc; // variable Xcuadratica
                        Console.WriteLine("Ecuación Cuadrática ax² + bx + c = 0, ingrese los siguientes valores ");
                        Console.WriteLine("ingrese a ");
                        a = double.Parse(Console.ReadLine());
                        Console.WriteLine("ingrese b");
                        b = double.Parse(Console.ReadLine());
                        Console.WriteLine("ingrese el termino independiente c");
                        c = double.Parse(Console.ReadLine());

                        d = Math.Pow(b, 2) - 4 * a * c;

                        if (d < 0)
                        {
                            d1 = Math.Sqrt(Math.Abs(d));

                            xc = -(b);
                            x2 = 2 * a;

                            x3 = xc / x2;
                            d3 = d1 / x2;

                            Console.WriteLine("sus resultados contienen un numero imaginario ");
                            Console.WriteLine("x = " + x3 + "-" + Math.Round(d3, 2) + "i");
                            Console.WriteLine("x = " + x3 + "+" + Math.Round(d3, 2) + "i");

                        }
                        else if (d > 0)
                        {


                            xc = (-(b) + Math.Sqrt(d)) / (2 * a);
                            x2 = (-(b) - Math.Sqrt(d)) / (2 * a);
                            Console.WriteLine("su resultados son los siguientes");
                            Console.WriteLine("x = " + xc);
                            Console.WriteLine("x = " + x2);
                        }


                        break;
                    case 3:
                        Console.WriteLine(@"
                                        C
                                        |\
                                        | \    H = Hipotenusa
                                        |  \      
                            b = Cateto  |   \  a
                                Menor   |    \
                                        |     \
                                        |      \
                                        |_______\
                                        A   c    B
                                        Cateto Mayor");
                        Console.WriteLine("Angulo agudos");
                        Console.WriteLine("ingrese el valor del cateto menor ");
                        b = double.Parse(Console.ReadLine());
                        Console.WriteLine("ingrese el valor del cateto mayor");
                        c = double.Parse(Console.ReadLine());


                        x3 = Math.Atan(b / c);
                        a = x3 * (180 / Math.PI);
                        d = 90 - a;

                        Console.WriteLine("el valor del angulo B es " + Math.Round(a, 2));
                        Console.WriteLine("el valor del angulo C es " + Math.Round(d, 2));
                    case 4:

                        Console.WriteLine("Ingrese la coordenada X:");
                        double x = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Ingrese la coordenada Y:");
                        double y = Convert.ToDouble(Console.ReadLine());

                        string ubicacion;

                        if (x > 0 && y > 0)
                            ubicacion = "Cuadrante I";
                        else if (x < 0 && y > 0)
                            ubicacion = "Cuadrante II";
                        else if (x < 0 && y < 0)
                            ubicacion = "Cuadrante III";
                        else if (x > 0 && y < 0)
                            ubicacion = "Cuadrante IV";
                        else if (x == 0 && y != 0)
                            ubicacion = y > 0 ? "Eje Y+" : "Eje Y-";
                        else if (y == 0 && x != 0)
                            ubicacion = x > 0 ? "Eje X+" : "Eje X-";
                        else
                            ubicacion = "Origen";

                        Console.WriteLine("El punto se encuentra en: " + ubicacion);
                        break;

                    case 7:
                        Console.Write("Ingrese el precio del artículo: ");
                        double precio = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Ingrese la cantidad de artículos: ");
                        int cantidad = Convert.ToInt32(Console.ReadLine());
                        double total = precio * cantidad;
                        Console.WriteLine("Numero de productos: " + cantidad);
                        Console.WriteLine("Total a pagar: $" + total);
                        break;
                    case 8:
                        Console.Write("Ingrese el total de la herencia: ");
                        double herencia = Convert.ToDouble(Console.ReadLine());
                        double juan = herencia / 3;
                        double luis = (4.0 / 3.0) * juan;
                        double rosa = luis / 2;
                        double abogadoJuan, abogadoLuis, abogadoRosa;

                        if (juan < herencia / 3)
                            abogadoJuan = juan * 0.03;
                        else
                            abogadoJuan = juan * 0.05;

                        if (luis < herencia / 3)
                            abogadoLuis = luis * 0.03;
                        else
                            abogadoLuis = luis * 0.05;

                        if (rosa < herencia / 3)
                            abogadoRosa = rosa * 0.03;
                        else
                            abogadoRosa = rosa * 0.05;

                        Console.WriteLine($"Juan recibe: ${juan - abogadoJuan}, Luis recibe: ${luis - abogadoLuis}, Rosa recibe: ${rosa - abogadoRosa}");
                        Console.WriteLine($"El abogado recibe: ${abogadoJuan + abogadoLuis + abogadoRosa}");
                        break;
                    case 9:
                        Console.Write("Ingrese el número de días transcurridos: ");
                        int dias = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("El mes es: " + Mes(dias));
                        break;

                    case 10:
                        Console.WriteLine("Minimo comun Multiplo  ");
                        Console.WriteLine("Ingresa el primer número");
                        double nu1 = double.Parse(Console.ReadLine());
                        Console.WriteLine("ingresa el segundo número");
                        double nu2 = double.Parse(Console.ReadLine());
                        a = nu1;
                        b = nu2;
                        while (b != 0)
                        {
                            double tem = b;
                            b = a % b;
                            a = tem;
                        }
                        double mcd = a;
                        x = (nu1 / mcd) * nu2;

                        Console.WriteLine($" El minimo como un multiplo de {nu1} y {nu2} es {x}");
                        break;
                    case 11:
                        Console.WriteLine("******************************************************************");
                        Console.WriteLine("---------------------------Integrantes----------------------------");
                        Console.WriteLine("\t Amilcar Alexander Anaya Gonzalez ");
                        Console.WriteLine("\t César Giovanni Lopez Ortiz ");
                        /* nombres
                         que
                         faltan*/

                        Console.WriteLine("------------------------------------------------------------------");
                        break;
                    case 12:
                        Console.WriteLine("\tGracias por usar nuestro menu ¡Pasa un buen dia!");
                        Environment.Exit(0);
                        break;





                    default: Console.WriteLine("\topcion invalida"); break;
                }




                Console.WriteLine("\n\tdesea regresar al menu principal. si/no");
                e = Console.ReadLine();
                Console.Clear();





            } while (e == "si");
            Console.ReadKey();

        }
        static string Mes(int dias)
        {
            if (dias <= 31) return "ENERO";
            if (dias <= 60) return "FEBRERO";
            if (dias <= 91) return "MARZO";
            if (dias <= 121) return "ABRIL";
            if (dias <= 152) return "MAYO";
            if (dias <= 182) return "JUNIO";
            if (dias <= 213) return "JULIO";
            if (dias <= 244) return "AGOSTO";
            if (dias <= 274) return "SEPTIEMBRE";
            if (dias <= 305) return "OCTUBRE";
            if (dias <= 335) return "NOVIEMBRE";
            if (dias <= 366) return "DICIEMBRE";
            return "DATO INCORRECTO";
        }
    }
}

