﻿int fila, columna;
fila = columna = 3;
int[,] matriz = new int[3,3]{ { 200, 30, 3 } , { 33, 54, 51 } , { 32, 32, 2 } };
//Console.WriteLine("el maximo elemento de la matriz es: " + maxMatriz(matriz,fila,columna));
//Console.WriteLine("el minimo elemento de la matriz es: " + minMatriz(matriz, fila, columna));
//Console.WriteLine("el promedio de la matriz es: " + promedioMatriz(matriz, fila, columna));
piramideInvertida();

int maxMatriz(int [,]matriz,int f,int c)
{
    int i, j;
    int max = 0;
    for (i = 0; i < f; i++)
    {
        for (j = 0; j < c; j++)
        {
            max = (matriz[i, j] > max) ? matriz[i, j] : max;
        }
    }
    return max;
}

int minMatriz(int[,] matriz, int f, int c)
{
    int i, j;
    int min = 9999;
    for (i = 0; i < f; i++)
    {
        for (j = 0; j < c; j++)
        {
            min = (matriz[i, j] < min) ? matriz[i, j] : min;
        }
    }
    return min;
}

double promedioMatriz(int[,] matriz, int f, int c)
{
    int i, j, acum;
    acum = 0;
    for (i = 0; i < f; i++)
    {
        for (j = 0; j < c; j++)
        {
            acum += matriz[i, j];  
        }
    }
    return (double)acum / (f*c);
}

void piramideInvertida()
{
    int n,i,j,h;
    Console.WriteLine("ingrese un numero positivo");
    n = int.Parse(Console.ReadLine());
    for (i=n;i>0;i--) //cantidad ingresada 
    {
        for (h=n-i;h>0;h--)
        {
            Console.Write(" ");
        }
        for (j=1+(i-1)*2;j>0;j--) //formula para cantidad de "ladrillos"
        {
            Console.Write("*");
        }
        Console.WriteLine();   
    }

}