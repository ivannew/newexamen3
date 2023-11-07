using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IvanSotoExam
{
    internal class problemas
    {
        public void curp()
        {
            Console.WriteLine("Escribe tu curp: (18 dijitos)");
            string curp = Console.ReadLine();

            if (curp.Length >= 18)
            {
                string fechaNacimiento = curp.Substring(4, 6);
                string genero = curp.Substring(10, 1);

                string fechaCompleto = fechaNacimiento.Substring(4, 2) + "/" + fechaNacimiento.Substring(2, 2) + "/" + fechaNacimiento.Substring(0, 2);
                string generoCompleto = (genero == "H") ? "Hombre" : (genero == "M") ? "Mujer" : "no identificado";

                Console.WriteLine($"Sexo: {generoCompleto}");
                Console.WriteLine($"Fecha De Nacimineto: {fechaCompleto}");
            }

            else
            {
                Console.WriteLine($" Lo siento no se encuentra {curp}");
            }
            Console.WriteLine();
        }


        public void Tabla()
        {
            int[,] tabla = {
            {500,3000,100,400},
            {1000,150,200,500},
            {250,1800,2900,300},
            {400,130,90,2400},
            {60,20,4000,3600},
            };

            for (int fila = 0; fila < tabla.GetLength(0); fila++)
            {
                for (int columna = 0; columna < tabla.GetLength(1); columna++)
                {
                    Console.Write(tabla[fila, columna] + "\t");
                }
                Console.WriteLine();


            }
            Console.WriteLine($"\n El vendedor 1 tuvo una ganancia de {tabla[0, 0] + tabla[1, 0] + tabla[2, 0] + tabla[3, 0] + tabla[4, 0]}");
            Console.WriteLine($" El vendedor 2 tuvo una ganancia de {tabla[0, 1] + tabla[1, 1] + tabla[2, 1] + tabla[3, 1] + tabla[4, 1]}");
            Console.WriteLine($" El vendedor 3 tuvo una ganancia de {tabla[0, 2] + tabla[1, 2] + tabla[2, 2] + tabla[3, 2] + tabla[4, 2]}");
            Console.WriteLine($" El vendedor 4 tuvo una ganancia de {tabla[0, 3] + tabla[1, 3] + tabla[2, 3] + tabla[3, 3] + tabla[4, 3]}");

            Console.WriteLine($"\n  El producto 1 tuvo una ganancia de {tabla[0, 0] + tabla[0, 1] + tabla[0, 2] + tabla[0, 3]}");
            Console.WriteLine($"  El producto 2 tuvo una ganancia de {tabla[1, 0] + tabla[1, 1] + tabla[1, 2] + tabla[1, 3]}");
            Console.WriteLine($"  El producto 3 tuvo una ganancia de {tabla[2, 0] + tabla[2, 1] + tabla[2, 2] + tabla[2, 3]}");
            Console.WriteLine($"  El producto 4 tuvo una ganancia de {tabla[3, 0] + tabla[3, 1] + tabla[3, 2] + tabla[3, 3]}");
            Console.WriteLine($"  El producto 5 tuvo una ganancia de {tabla[4, 0] + tabla[4, 1] + tabla[4, 2] + tabla[4, 3]}");
            Console.WriteLine();
        }

        public void Calificaciones()
        {
            int[] arreglo = new int[10];
            Random alea = new Random();

            for (int i = 0; i < arreglo.Length; i++)
            {
                int calificacion = alea.Next(1, 100);
                arreglo[i] = calificacion;
            }
            Console.WriteLine("CALIFICACIONES DESORDENADAS");
            for (int i = 0; i < arreglo.Length; i++)
            {
                Console.Write(arreglo[i] + " ");
            }
            Console.WriteLine();
            int tem;
            for (int i = 1; i < arreglo.Length; i++)
            {
                for (int j = arreglo.Length - 1; j >= i; j--)
                {
                    if (arreglo[j - 1] < arreglo[j])
                    {
                        tem = arreglo[j - 1];
                        arreglo[j - 1] = arreglo[j];
                        arreglo[j] = tem;
                    }
                }
            }
            Console.WriteLine("CALIFICACIONES ORDENADAS");
            for (int i = 0; i < arreglo.Length; i++)
            {
                Console.Write(arreglo[i] + " ");
            }
            Console.WriteLine();
            int numero = 75;
            int inicio = 0;
            int fin = arreglo.Length - 1;
            bool encontrar = false;

            while (inicio <= fin)
            {
                int medio = (inicio + fin) / 2;
                if (arreglo[medio] == numero)
                {
                    Console.WriteLine($"El numero {numero} esta en la posicion {medio}");
                    encontrar = true;
                    break;
                }
                else if (arreglo[medio] < numero)
                {
                    fin = medio - 1;
                    medio = (inicio + fin) / 2;

                }
                else
                {
                    inicio = medio + 1;
                    medio = (inicio + fin) / 2;
                }

            }
            if (!encontrar)
            {
                Console.WriteLine($"Lo siento el {numero} no se encuentra en la lista");
            }

        }
    }
}
