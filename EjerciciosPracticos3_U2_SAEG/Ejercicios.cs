using System;
using System.IO.IsolatedStorage;
using System.Runtime.Intrinsics.X86;

namespace EjerciciosPracticos3_U2_SAEG
{
    public class Ejercicios
    {
        //Ejercicio 1:
        //Declara una matriz bidimensional de enteros
        //con tamaño de 3x3. LLena la matriz con valores
        //enteros del 1 al 9 e imprime la matriz en la consola
        public void Ejercicio1()
        {
            int[,] matriz = new int[3, 3];
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (i == 0)
                    {
                        matriz[i, j] = i + 1 + j;
                    }
                    else if (i == 1)
                    {
                        matriz[i, j] = i + 3 + j;
                    }
                    else
                    {
                        matriz[i, j] = i + 5 + j;
                    }
                }
            }
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.WriteLine($"La posicion {i},{j} = {matriz[i, j]}");
                }
            }
            Console.WriteLine("Tabien se puede visualizar de la siguiente manera: ");
            for(int i = 0; i < 3; i++)
            {
                Console.Write($"Fila {i+1}: ");
                for(int j = 0; j < 3; j++)
                {
                    if(j < 2)
                    {
                        Console.Write($"| {matriz[i,j]} ");
                    }
                    else
                    {
                        Console.Write($"| {matriz[i,j]} |");
                    }
                }
                Console.WriteLine("");
            }
        }
        //Declara y crea una matriz bidimensional de cadenas de 
        //tamaño 2x2.Llena la matriz con nombres de colores
        //("Rojo", "Verde", "Azul", "Amarillo") e imprime
        //la matriz en la consola.
        public void Ejercicio2()
        {
            string[,] matrizDeColores = new string[2, 2] { { "Rojo","Verde" }, { "Azul","Amarillo"} };
            for (int i = 0; i < 2; i++)
            {
                for(int j = 0; j < 2; j++)
                {
                    Console.Write($"{matrizDeColores[i, j]} ");
                }
                Console.WriteLine();
            }
        }
        //Declara y crea una matriz bidimensional de números 
        //reales(doubles) de tamaño 4x3.Llena la matriz con
        //valores decimales y luego calcula y muestra la suma
        //de todos los elementos de la matriz.
        public void Ejercicio3() 
        {
            double[,] matrizDecimal = new double[4, 3];
            double sumaMatriz = 0;
            for(int i = 0; i < matrizDecimal.GetLength(0); i++)
            {
                for(int j = 0; j < matrizDecimal.GetLength(1); j++)
                {
                    Console.WriteLine($"Ingrese el valor {i},{j} en la matriz: ");
                    matrizDecimal[i, j] = Convert.ToDouble(Console.ReadLine());
                    sumaMatriz += matrizDecimal[i, j];
                }
            }
            Console.WriteLine("La matriz contiene: ");
            for (int i = 0; i < matrizDecimal.GetLength(0); i++)
            {
                for (int j = 0; j < matrizDecimal.GetLength(1); j++)
                {
                    Console.Write($"|{matrizDecimal[i,j]}");
                }
                Console.WriteLine();
            }
            Console.WriteLine($"Y la suma de todos sus elementos es: {sumaMatriz}");
        }
        //Declara y crea una matriz bidimensional de 
        //caracteres de tamaño 2x4.Llena la matriz con
        //caracteres alfabéticos y luego imprime la
        //matriz en forma de tabla.
        public void Ejercicio4()
        {
            char[,] matrizDeCaracteres = new char[2, 4];
            for (int i = 0; i < matrizDeCaracteres.GetLength(0); i++)
            {
                for (int j = 0; j < matrizDeCaracteres.GetLength(1); j++)
                {
                    Console.WriteLine($"Ingrese el valor {i},{j} en la matriz: ");
                    matrizDeCaracteres[i, j] = Convert.ToChar(Console.ReadLine());
                }
            }
            Console.WriteLine("La matriz contiene: ");
            for (int i = 0; i < matrizDeCaracteres.GetLength(0); i++)
            {
                for (int j = 0; j < matrizDeCaracteres.GetLength(1); j++)
                {
                    Console.Write($"|{matrizDeCaracteres[i, j]}");
                }
                Console.WriteLine();
            }
        }
    }
}
