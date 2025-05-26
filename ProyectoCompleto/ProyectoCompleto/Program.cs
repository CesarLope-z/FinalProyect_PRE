using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Security;
using System.Text;
using System.Threading.Tasks;





namespace ConsoleApp2
{
    internal class Program
    {
        static StreamReader leer;
        static StreamWriter EscribirD, EscribirE, EscribirA, EscribirP, EscribirC, EscribirCi, EscribirB;
        static void Main(string[] args)
        {

            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();
            EscribirD = new StreamWriter("Determinante.txt", true);
            EscribirE = new StreamWriter("Ecuación Cuadrática.txt", true);
            EscribirA = new StreamWriter("Angulo agudos.txt", true);
            EscribirP = new StreamWriter("Plano Cartesiano.txt", true);
            //EscribirC = new StreamWriter("Cuadrado.txt", true);
            EscribirCi = new StreamWriter("Circunferencia.txt", true);
            EscribirB = new StreamWriter("Cajero del BAC.txt", true);
            Console.WriteLine(@"
  ===========================================================================    
 |                               BIENVENIDOS                                 |
 |                                                                           |
 |                        P r o y e c t o    F i n a l                       |                       
 |                                                                           |
 |                             Matemática v4.0                               |                    
 |                                                                           |
  ===========================================================================
");

            Console.WriteLine("\t\n\nPresione ENTER para continuar");
            Console.ReadLine();

            Console.Clear();

            int op;

            double h, y, b, a, r, x, x2, x3, d, c, d1, d2;
            string e = "", cont = "", opc;

            try
            {
                do
                {

                    Console.WriteLine("\t¿Que ejercicio deseas realizar? ");
                    Console.WriteLine("\t[1] Área de figuras geométricas");
                    Console.WriteLine("\t[2] Ecuación Cuadrática");
                    Console.WriteLine("\t[3] Angulo agudos");
                    Console.WriteLine("\t[4] Plano Cartesiano");
                    Console.WriteLine("\t[5] Determinante");
                    Console.WriteLine("\t[6] Cajero del BAC");
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
                            //Brayan Alexander Raymundo Martínez
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
                                    EscribirC = new StreamWriter("Cuadrado.txt", true);

                                    //cuadrado
                                    Console.WriteLine(" Escogiste la Opcion A");
                                    Console.WriteLine("\n Coloca el Lado en cm");
                                    a = double.Parse(Console.ReadLine());
                                    A = a * 2;
                                    Console.Write(" El area del cuadrado es: ");
                                    Console.ForegroundColor = ConsoleColor.Red; Console.Write(A);
                                    Console.ForegroundColor = ConsoleColor.Black; Console.Write("cm²");
                                    EscribirC.WriteLine("\n Coloca el Lado en cm");
                                    EscribirC.WriteLine($"  {a}cm");
                                    EscribirC.WriteLine($" El area del cuadrado es: {A:F2}cm²");
                                    EscribirC.Close();
                                    Console.WriteLine("\t\n¿Desea abrir el archivo de texto? (s/n): ");
                                    opc = Console.ReadLine();
                                    if (opc == "s" || opc == "S")
                                    {
                                        Process.Start("Cuadrado.txt");
                                    }
                                    else { Console.WriteLine("\n\t Hasta la proxima"); }

                                    break;

                                case "B":

                                    //circunferencia
                                    Console.WriteLine("Escogiste la Opcion B");
                                    Console.WriteLine("Digite el radio en cm");
                                    r = double.Parse(Console.ReadLine());
                                    A = Math.PI * Math.Pow(r, 2);
                                    Console.Write(" El resultado es: ");
                                    Console.ForegroundColor = ConsoleColor.Red; Console.Write(Math.Round(A, 2));
                                    Console.ForegroundColor = ConsoleColor.Black; Console.Write("cm²");
                                    EscribirCi.WriteLine("\n Digite el radio en cm");
                                    EscribirCi.WriteLine($"  {r}cm");
                                    EscribirCi.WriteLine($" El resultado es: {A:F2}cm²");
                                    Console.WriteLine("\t\n¿Desea abrir el archivo de texto? (s/n): ");
                                    opc = Console.ReadLine();
                                    if (opc == "s" || opc == "S")
                                    {
                                        Process.Start("Circunferencia.txt");
                                    }
                                    else { Console.WriteLine("\n\t Hasta la proxima"); }


                                    break;
                                case "C":
                                    //rectangulo
                                    Console.WriteLine("Escogiste la Opcion C");
                                    Console.WriteLine("Digite la altura en cm");
                                    a = double.Parse(Console.ReadLine());
                                    Console.WriteLine("Digite la base en cm");
                                    b = double.Parse(Console.ReadLine());
                                    Console.WriteLine("El area es: ");
                                    Console.ForegroundColor = ConsoleColor.Red; Console.Write(a * b);
                                    Console.ForegroundColor = ConsoleColor.Black; Console.Write("cm²");

                                    break;

                                case "D":
                                    //romboide
                                    Console.Write("********************************");
                                    Console.WriteLine("Escogiste la Opcion D");
                                    Console.WriteLine("Digite la base en cm");
                                    a = double.Parse(Console.ReadLine());
                                    Console.WriteLine("Digite la altura en cm");
                                    h = double.Parse(Console.ReadLine());
                                    Console.WriteLine("El area es: ");
                                    Console.ForegroundColor = ConsoleColor.Red; Console.Write(a * h);
                                    Console.ForegroundColor = ConsoleColor.Black; Console.Write("cm²");

                                    break;

                                case "E":
                                    //Trapecio
                                    Console.Write("********************************");
                                    Console.WriteLine("Escogiste la Opcion E");
                                    Console.WriteLine("Dijite la base a en cm");
                                    a = double.Parse(Console.ReadLine());
                                    Console.WriteLine("Coloca la base b en cm");
                                    b = double.Parse(Console.ReadLine());
                                    Console.WriteLine("Dijite la altura en cm");
                                    h = double.Parse(Console.ReadLine());
                                    A = (a * b) * h / 2;
                                    Console.WriteLine("El area es: ");
                                    Console.ForegroundColor = ConsoleColor.Red; Console.Write(A);
                                    Console.ForegroundColor = ConsoleColor.Black; Console.Write("cm²");
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
                            //Amilcar Alexander Anaya González
                            Console.WriteLine("Ecuación Cuadrática ax² + bx + c = 0, ingrese los siguientes valores ");
                            Console.WriteLine("ingrese el valor cuadratico a ");
                            a = double.Parse(Console.ReadLine());
                            if (a == 0) { Console.WriteLine(" el valor cuadratico es 0 coloque uno distinto"); }
                            else
                            {
                                Console.WriteLine("ingrese el valor lineal b");
                                b = double.Parse(Console.ReadLine());
                                Console.WriteLine("ingrese constante c");
                                c = double.Parse(Console.ReadLine());
                                if (b < 0)
                                {
                                    Console.WriteLine($"Ecuación Cuadrática ingresada {a}x² {b}x + {c} = 0 ");
                                    EscribirE.WriteLine($"Ecuación Cuadrática ingresada {a}x² {b}x + {c} = 0 ");
                                }
                                else if (c < 0)
                                {
                                    EscribirE.WriteLine($"Ecuación Cuadrática ingresada {a}x² + {b}x {c} = 0 ");
                                    Console.WriteLine($"Ecuación Cuadrática ingresada {a}x² + {b}x {c} = 0");
                                }
                                else if (b < 0 & c < 0)
                                {
                                    Console.WriteLine($"Ecuación Cuadrática ingresada {a}x² {b}x {c} = 0 ");
                                    EscribirE.WriteLine($"Ecuación Cuadrática ingresada {a}x² {b}x {c} = 0 ");
                                }
                                else
                                {
                                    Console.WriteLine($"Ecuación Cuadrática ingresada {a}x² + {b}x + {c} = 0 ");
                                    EscribirE.WriteLine($"Ecuación Cuadrática ingresada {a}x² + {b}x + {c} = 0 ");
                                }

                                d = Math.Pow(b, 2) - 4 * a * c;

                                if (d < 0)
                                {
                                    d1 = Math.Sqrt(Math.Abs(d));

                                    x = -(b);
                                    x2 = 2 * a;

                                    x3 = x / x2;
                                    d2 = d1 / x2;

                                    Console.WriteLine("sus resultdos contiene un numero imaginario ");
                                    if (d2 < 0)
                                    {
                                        Console.Write("X1 = ");
                                        Console.ForegroundColor = ConsoleColor.Red; Console.Write($"{x3:f2} + {-1 * d2:f2}i");
                                        Console.ForegroundColor = ConsoleColor.Black;
                                        Console.Write("\nX2 = ");
                                        Console.ForegroundColor = ConsoleColor.Red; Console.Write($"{x3:f2}{d2:f2}i");
                                        Console.ForegroundColor = ConsoleColor.Black;
                                        EscribirE.WriteLine("sus resultdos contiene un numero imaginario ");
                                        EscribirE.WriteLine($"X1 = {x3:F2} + {-1 * d2:f2}i");
                                        EscribirE.WriteLine($"X2 = {x3:F2}{d2:f2}i");

                                    }
                                    else
                                    {
                                        Console.Write("X1 = ");
                                        Console.ForegroundColor = ConsoleColor.Red; Console.Write($"{x3:f2} + {d2:f2}i");
                                        Console.ForegroundColor = ConsoleColor.Black;
                                        Console.Write("\nX2 = ");
                                        Console.ForegroundColor = ConsoleColor.Red; Console.Write($"{x3:f2} - {d2:f2}i");
                                        Console.ForegroundColor = ConsoleColor.Black;
                                        EscribirE.WriteLine("sus resultdos contiene un numero imaginario ");
                                        EscribirE.WriteLine($"X1 = {x3:F2} - {d2:f2}i");
                                        EscribirE.WriteLine($"X2 = {x3:F2} + {d2:f2}i");
                                    }


                                }
                                else
                                {

                                    x = (-(b) + Math.Sqrt(d)) / (2 * a);
                                    x2 = (-(b) - Math.Sqrt(d)) / (2 * a);
                                    Console.WriteLine("su resultados son los siguientes");
                                    Console.Write("X1 = ");
                                    Console.ForegroundColor = ConsoleColor.Red; Console.Write(Math.Round(x, 2));
                                    Console.ForegroundColor = ConsoleColor.Black;
                                    Console.Write("\nX2 = ");
                                    Console.ForegroundColor = ConsoleColor.Red; Console.Write(Math.Round(x2, 2));
                                    Console.ForegroundColor = ConsoleColor.Black;
                                    EscribirE.WriteLine("sus resultdos son los siguientes");
                                    EscribirE.WriteLine($"X1 = {x:f2}");
                                    EscribirE.WriteLine($"X2 = {x2:f2}");
                                }
                            }

                            Console.WriteLine("\t\n¿Desea abrir el archivo de texto? (s/n): ");
                            opc = Console.ReadLine();

                            if (opc == "s" || opc == "S")
                            {
                                Process.Start("Ecuación Cuadrática.txt");
                            }
                            else { Console.WriteLine("\n\t Hasta la proxima"); }

                            break;
                        case 3:
                            //Jefferson Abel García Torrez
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
                            Console.WriteLine("ingrese el valor del cateto menor en cm ");
                            while (!double.TryParse(Console.ReadLine(), out b) || b <= 0)
                            { Console.WriteLine("Error: El cateto debe ser un número mayor que cero. Intente de nuevo:"); }
                            Console.WriteLine("ingrese el valor del cateto mayor en cm");
                            while (!double.TryParse(Console.ReadLine(), out c) || c <= 0)
                            { Console.WriteLine("Error: El cateto debe ser un número mayor que cero. Intente de nuevo:"); }
                            EscribirA.WriteLine($" Cateto menor = {b}cm \n Cateto mayor = {c}cm");
                            double cattMe = Math.Min(b, c);
                            double cattMa = Math.Max(b, c);


                            x3 = Math.Atan(cattMe / cattMa);
                            a = x3 * (180 / Math.PI);
                            d = 90 - a;

                            Console.Write("el valor del angulo B es ");
                            Console.ForegroundColor = ConsoleColor.Red; Console.Write(Math.Round(a, 2) + "°");
                            Console.ForegroundColor = ConsoleColor.Black;
                            Console.Write("el valor del angulo C es ");
                            Console.ForegroundColor = ConsoleColor.Red; Console.Write(Math.Round(d, 2) + "°");
                            Console.ForegroundColor = ConsoleColor.Black;
                            EscribirA.WriteLine($"el valor del angulo B es {a:f2}°");
                            EscribirA.WriteLine($"el valor del angulo C es {d:f2}°");

                            Console.WriteLine("\t\n¿Desea abrir el archivo de texto? (s/n): ");
                            opc = Console.ReadLine();
                            if (opc == "s" || opc == "S")
                            {
                                Process.Start("Angulo agudos.txt");
                            }
                            else { Console.WriteLine("\n\t Hasta la proxima"); }


                            break;
                        case 4:
                            //Brayan Alexander Raymundo Martínez

                            Console.WriteLine("Plano cartesiano ");
                            Console.Write(" Ingrese la coordenada x:");
                            x = double.Parse(Console.ReadLine());
                            Console.Write(" Ingrese la coordenada y:");
                            y = double.Parse(Console.ReadLine());
                            EscribirP.WriteLine($"coordenada ingresada ({x},{y})");

                            if (x == 0 && y == 0)
                            {
                                Console.Write($"El punto ");
                                Console.ForegroundColor = ConsoleColor.Red; Console.Write($"[{x}, {y}] ");
                                Console.ForegroundColor = ConsoleColor.Black;
                                Console.Write("se encuentra en:");
                                Console.ForegroundColor = ConsoleColor.Red; Console.Write(" El origen ");
                                Console.ForegroundColor = ConsoleColor.Black;
                                Console.Write(@"
  
           │
           │
 ──────────°────
           │");
                                EscribirP.WriteLine($"El punto[{x}, {y}] se encuentra en: El origen");

                            }
                            else if (x == 0 && y > 0)
                            {

                                Console.Write($"El punto ");
                                Console.ForegroundColor = ConsoleColor.Red; Console.Write($"[{x}, {y}] ");
                                Console.ForegroundColor = ConsoleColor.Black;
                                Console.Write("se encuentra en:");
                                Console.ForegroundColor = ConsoleColor.Red; Console.Write(" Eje Y+ ");
                                Console.ForegroundColor = ConsoleColor.Black;
                                Console.Write(@"
       |
       °   
───────┼────
       │");
                                EscribirP.WriteLine($"El punto[{x}, {y}] se encuentra en: Eje Y+");

                            }
                            else if (x == 0 && y < 0)
                            {


                                Console.Write($"El punto ");
                                Console.ForegroundColor = ConsoleColor.Red; Console.Write($"[{x}, {y}] ");
                                Console.ForegroundColor = ConsoleColor.Black;
                                Console.Write("se encuentra en:");
                                Console.ForegroundColor = ConsoleColor.Red; Console.Write(" Eje Y- ");
                                Console.ForegroundColor = ConsoleColor.Black;
                                Console.Write(@"
  
       │   
───────┼────
       °
       |");
                                EscribirP.WriteLine($"El punto[{x}, {y}] se encuentra en: Eje Y-");
                            }
                            else if (y == 0 && x > 0)
                            {


                                Console.Write($"El punto ");
                                Console.ForegroundColor = ConsoleColor.Red; Console.Write($"[{x}, {y}] ");
                                Console.ForegroundColor = ConsoleColor.Black;
                                Console.Write("se encuentra en:");
                                Console.ForegroundColor = ConsoleColor.Red; Console.Write(" Eje X+ ");
                                Console.Write(@"
  
       │  
───────┼──°──
       │");
                                Console.ForegroundColor = ConsoleColor.Black;
                                EscribirP.WriteLine($"El punto[{x}, {y}] se encuentra en: Eje X+");
                            }
                            else if (y == 0 && x < 0)
                            {


                                Console.Write($"El punto ");
                                Console.ForegroundColor = ConsoleColor.Red; Console.Write($"[{x}, {y}] ");
                                Console.ForegroundColor = ConsoleColor.Black;
                                Console.Write("se encuentra en:");
                                Console.ForegroundColor = ConsoleColor.Red; Console.Write(" Eje X- ");
                                Console.ForegroundColor = ConsoleColor.Black;
                                Console.Write(@"
  
       │   
────°──┼────
       │");
                                EscribirP.WriteLine($"El punto[{x}, {y}] se encuentra en: Eje X-");
                            }
                            else if (x > 0 && y > 0)
                            {


                                Console.Write($"El punto ");
                                Console.ForegroundColor = ConsoleColor.Red; Console.Write($"[{x}, {y}] ");
                                Console.ForegroundColor = ConsoleColor.Black;
                                Console.Write("se encuentra en:");
                                Console.ForegroundColor = ConsoleColor.Red; Console.Write(" Cuadrante I ");
                                Console.ForegroundColor = ConsoleColor.Black;
                                Console.Write(@"
  
       │  ° 
───────┼────
       │");
                                EscribirP.WriteLine($"El punto[{x}, {y}] se encuentra en: Cuadrante I");
                            }
                            else if (x < 0 && y > 0)
                            {

                                Console.Write($"El punto ");
                                Console.ForegroundColor = ConsoleColor.Red; Console.Write($"[{x}, {y}] ");
                                Console.ForegroundColor = ConsoleColor.Black;
                                Console.Write("se encuentra en:");
                                Console.ForegroundColor = ConsoleColor.Red; Console.Write(" Cuadrante II ");
                                Console.ForegroundColor = ConsoleColor.Black;
                                Console.Write(@"
  
    °  │   
───────┼────
       │");
                                EscribirP.WriteLine($"El punto[{x}, {y}] se encuentra en: Cuadrante II");
                            }
                            else if (x < 0 && y < 0)
                            {

                                Console.Write($"El punto ");
                                Console.ForegroundColor = ConsoleColor.Red; Console.Write($"[{x}, {y}] ");
                                Console.ForegroundColor = ConsoleColor.Black;
                                Console.Write("se encuentra en:");
                                Console.ForegroundColor = ConsoleColor.Red; Console.Write(" Cuadrante III ");
                                Console.ForegroundColor = ConsoleColor.Black;
                                Console.Write(@"
  
       │  
───────┼────
   °   │");
                                EscribirP.WriteLine($"El punto[{x}, {y}] se encuentra en: Cuadrante III");
                            }
                            else
                            {


                                Console.Write($"El punto ");
                                Console.ForegroundColor = ConsoleColor.Red; Console.Write($"[{x}, {y}] ");
                                Console.ForegroundColor = ConsoleColor.Black;
                                Console.Write("se encuentra en:");
                                Console.ForegroundColor = ConsoleColor.Red; Console.Write(" Cuadrante IV ");
                                Console.ForegroundColor = ConsoleColor.Black;
                                Console.Write(@"
  
       │   
───────┼────
       │  °");
                                EscribirP.WriteLine($"El punto[{x}, {y}] se encuentra en: Cuadrante IV");
                            }


                            Console.WriteLine("\t\n¿Desea abrir el archivo de texto? (s/n): ");
                            opc = Console.ReadLine();
                            if (opc == "s" || opc == "S")
                            {
                                Process.Start("Plano Cartesiano.txt");
                            }
                            else { Console.WriteLine("\n\t Hasta la proxima"); }

                            break;
                        case 5:
                            //Jefferson Abel García Torrez, Amilcar Alexander Anaya González
                            double[,] matriz = new double[2, 3];

                            Console.WriteLine("Introduce los coeficientes y resultados para cada ecuación (formato: ax + by = c):");


                            for (int i = 0; i < 2; i++)
                            {
                                Console.WriteLine($"\nEcuación {i + 1}:");
                                Console.Write("Coeficiente de x: ");
                                matriz[i, 0] = double.Parse(Console.ReadLine());

                                Console.Write("Coeficiente de y: ");
                                matriz[i, 1] = double.Parse(Console.ReadLine());

                                Console.Write("Resultado (término independiente): ");
                                matriz[i, 2] = double.Parse(Console.ReadLine());
                                EscribirD.WriteLine($"\nEcuación {i + 1}:");
                                if (matriz[i, 1] < 0)
                                {
                                    EscribirD.WriteLine($"{matriz[i, 0]}x {matriz[i, 1]}y = {matriz[i, 2]}");
                                }
                                else
                                {
                                    EscribirD.WriteLine($"{matriz[i, 0]}x + {matriz[i, 1]}y = {matriz[i, 2]}");
                                }

                            }


                            double[,] M = {
            { matriz[0, 0], matriz[0, 1] },
            { matriz[1, 0], matriz[1, 1] }};

                            double[,] Mx = {
            { matriz[0, 2], matriz[0, 1] },
            { matriz[1, 2], matriz[1, 1] }};

                            double[,] My = {
            { matriz[0, 0], matriz[0, 2] },
            { matriz[1, 0], matriz[1, 2] }};


                            double detM = Determinante(M);
                            double detMx = Determinante(Mx);
                            double detMy = Determinante(My);

                            if (detM != 0)
                            {
                                x = detMx / detM;
                                y = detMy / detM;

                                Console.WriteLine($"\n Solución del sistema:");
                                Console.Write("x = "); Console.ForegroundColor = ConsoleColor.Red; Console.Write($"{x:F2}");
                                Console.ForegroundColor = ConsoleColor.Black; Console.Write("\ny = "); Console.ForegroundColor = ConsoleColor.Red; Console.Write($"{y:F2}");
                                Console.ForegroundColor = ConsoleColor.Black;
                                EscribirD.WriteLine($"\n Solución del sistema:");
                                EscribirD.WriteLine($"x ={x:F2}\ny ={y:F2}");
                            }
                            else
                            {
                                Console.WriteLine("\n El sistema no tiene solución única (el determinante principal es cero).");
                                EscribirD.WriteLine("\n El sistema no tiene solución única (el determinante principal es cero).");

                            }

                            Console.WriteLine("\t\n¿Desea abrir el archivo de texto? (s/n): ");
                            opc = Console.ReadLine();
                            if (opc == "s" || opc == "S")
                            {
                                Process.Start("Determinante.txt");
                            }
                            else { Console.WriteLine("\n\t Hasta la proxima"); }

                            break;
                        case 6:
                            //César Giovanni Lopez Ortiz ,Brayan Alexander Raymundo Martínez
                            int[] denom = { 100, 20, 10, 5, 1 };
                            int[] canti = new int[5];

                            Console.Write("Ingrese el monto a retirar: ");
                            int monto = Convert.ToInt32(Console.ReadLine());

                            int montori = monto;


                            for (int i = 0; i < 5; i++)
                            {
                                canti[i] = monto / denom[i];
                                monto = monto % denom[i];
                            }

                            Console.WriteLine($"\nCantidad a retirar ${montori}:");
                            EscribirB.WriteLine($"\nCantidad a retirar ${montori}:");

                            for (int i = 0; i < 5; i++)
                            {
                                if (canti[i] > 0)
                                {
                                    Console.WriteLine($"Billetes de ${denom[i]}: {canti[i]}");
                                    EscribirB.WriteLine($"Billetes de ${denom[i]}: {canti[i]}");
                                }
                            }
                            Console.WriteLine("\t\n¿Desea abrir el archivo de texto? (s/n): ");
                            opc = Console.ReadLine();
                            if (opc == "s" || opc == "S")
                            {
                                Process.Start("Cajero del BAC.txt");
                            }
                            else { Console.WriteLine("\n\t Hasta la proxima"); }

                            break;
                        case 7:
                            //César Giovanni Lopez Ortiz
                            double total = 0;
                            int can = 0;
                            Console.WriteLine("\tSuper Selectos");
                            do
                            {
                                Console.Write("Ingrese el precio del artículo: $ ");
                                double precio = Convert.ToDouble(Console.ReadLine());
                                Console.Write("Ingrese la cantidad de artículos: ");
                                int cantidad = Convert.ToInt32(Console.ReadLine());

                                double t = precio * cantidad;
                                Console.WriteLine("desea agregrar otro artículo");
                                cont = Console.ReadLine();
                                can += cantidad;
                                total += t;
                            } while (cont == "si");
                            Console.WriteLine("------------------------------------------");
                            Console.Write($"Total de productos............");
                            Console.ForegroundColor = ConsoleColor.Red; Console.Write(can);
                            Console.ForegroundColor = ConsoleColor.Black;
                            Console.Write($"\nTotal a pagar................");
                            Console.ForegroundColor = ConsoleColor.Red; Console.Write("$" + total);
                            Console.ForegroundColor = ConsoleColor.Black;
                            Console.WriteLine("\n------------------------------------------");
                            break;
                        case 8:
                            //César Giovanni Lopez Ortiz
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

                            Console.Write($"Juan recibe: ");
                            Console.ForegroundColor = ConsoleColor.Red; Console.Write($"${juan - abogadoJuan:F2}");
                            Console.ForegroundColor = ConsoleColor.Black;
                            Console.Write(", Luis recibe: ");
                            Console.ForegroundColor = ConsoleColor.Red; Console.Write($"${luis - abogadoLuis:F2}");
                            Console.ForegroundColor = ConsoleColor.Black;
                            Console.Write(", Rosa recibe: ");
                            Console.ForegroundColor = ConsoleColor.Red; Console.Write($"${rosa - abogadoRosa:F2}");
                            Console.ForegroundColor = ConsoleColor.Black;
                            Console.Write($"\nEl abogado recibe:");
                            Console.ForegroundColor = ConsoleColor.Red; Console.Write($" ${abogadoJuan + abogadoLuis + abogadoRosa:F2}");
                            Console.ForegroundColor = ConsoleColor.Black;
                            break;
                        case 9:
                            //Jefferson Abel García Torrez
                            Console.WriteLine($"Por favor intrese un numero del 1 a 366");
                            d = int.Parse(Console.ReadLine());

                            if (d < 1 || d > 366)
                            {
                                Console.WriteLine($" Numero fuera del rango");
                                return;
                            }

                            if (d <= 31)
                            {
                                Console.WriteLine($"ENERO");
                            }
                            else if (d <= 31 + 29)
                            {
                                Console.WriteLine($"FEBRERO");
                            }
                            else if (d <= 31 + 29 + 31)
                            {
                                Console.WriteLine($"MARZO");

                            }
                            else if (d <= 31 + 29 + 31 + 30)
                            {
                                Console.WriteLine($"ABRIL");
                            }
                            else if (d <= 31 + 29 + 31 + 30 + 31)
                            {
                                Console.WriteLine($"MAYO");
                            }
                            else if (d <= 31 + 29 + 31 + 30 + 31 + 30)
                            {
                                Console.WriteLine($"JUNIO");

                            }
                            else if (d <= 31 + 29 + 31 + 30 + 31 + 30 + 31)
                            {
                                Console.WriteLine($"JULIO");

                            }
                            else if (d <= 31 + 29 + 31 + 30 + 31 + 30 + 30 + 31 + 31)
                            {
                                Console.WriteLine($"AGOSTO");

                            }
                            else if (d <= 31 + 29 + 31 + 30 + 31 + 30 + 31 + 31 + 30)
                            {
                                Console.WriteLine($"SEPTIEMBRE");

                            }
                            else if (d <= 31 + 29 + 31 + 30 + 31 + 30 + 31 + 31 + 30 + 31)
                            {
                                Console.WriteLine($"OCTUBRE");

                            }
                            else if (d <= 31 + 29 + 31 + 30 + 31 + 30 + 31 + 31 + 30 + 31 + 30)
                            {
                                Console.WriteLine($"NOVEMBRE");

                            }
                            else
                            {
                                Console.WriteLine($"DICIEMBRE");

                            }
                            break;

                        case 10:
                            //Amilcar Alexander Anaya González
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

                            MCD(nu1, mcd, nu2);

                            break;
                        case 11:
                            Console.WriteLine("******************************************************************");
                            Console.WriteLine("---------------------------Integrantes----------------------------");
                            Console.WriteLine("\t Amilcar Alexander Anaya González ");
                            Console.WriteLine("\t César Giovanni Lopez Ortiz ");
                            Console.WriteLine("\t Jefferson Abel García Torrez  ");
                            Console.WriteLine("\t Brayan Alexander Raymundo Martínez  ");

                            Console.WriteLine("------------------------------------------------------------------");
                            break;
                        case 12:
                            Console.WriteLine("\tGracias por usar nuestro menu ¡Pasa un buen dia!");
                            Environment.Exit(0);
                            break;

                        default: Console.WriteLine("\topcion ivalida"); break;
                    }


                    Console.WriteLine("\n\n\tdesea regresar al menu principal. si/no");
                    e = Console.ReadLine();
                    Console.Clear();

                } while (e == "si" || e == "Si");

                EscribirP.Close();
                EscribirE.Close();
                EscribirA.Close();
                EscribirD.Close();
                //EscribirC.Close();
                EscribirCi.Close();
                EscribirB.Close();


            }
            catch (Exception ex) { Console.WriteLine($"Error: {ex.Message}"); }
            Console.ReadKey();

        }
        static void MCD(double nu1, double mcd, double nu2)
        {
            double x;
            x = (nu1 / mcd) * nu2;
            Console.Write($" El minimo como un multiplo de {nu1} y {nu2} es ");
            Console.ForegroundColor = ConsoleColor.Red; Console.Write($"{x}");
            Console.ForegroundColor = ConsoleColor.Black;

        }
        static double Determinante(double[,] m)
        {
            return (m[0, 0] * m[1, 1]) - (m[0, 1] * m[1, 0]);
        }
    }
}
