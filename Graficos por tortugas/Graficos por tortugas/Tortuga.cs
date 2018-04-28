using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graficos_por_tortugas
{
    class Tortuga
    {

        public int X;
        public int Y; 
        public int destinoX;
        public int destinoY;
        string direccion;
        bool escribir; 
        public string[,] matriz; // se crea una matriz de 20 por 20 para el lugar donde la tortuga se mueve

        public Tortuga()
        {
            matriz = new string[20, 20]; // matriz[fila, columna]
            for (int fila = 0; fila < matriz.GetLength(0); fila++) // iniciamos ciclo( fila =0; si fila es menor a matriz; entonces incrementa fila)
            {
                for (int columna = 0; columna < matriz.GetLength(1); columna++)
                {
                    matriz[fila, columna] = "";// matriz [fila,columna] es igual a espacio
                }
            }
            matriz[0, 0] = "";
            X = 0; // cordenada X
            Y = 0; // cordenada Y
            destinoX = 0; // destino de la cordenada X
            destinoY = 0; // destino de la cordenada Y
            direccion = "ESTE"; // direccion Es igual a la cordenada Este
            escribir = false; 
        }

        public void plumaArriba()
        {
            escribir = false;
        }
        public void plumaAbajo()
        {
            escribir = true;
        }
        public void girarDerecha() // metodo de girar a la derecha 
        {
            if (direccion == "NORTE") 
                direccion = "NORTE";
            else if (direccion == "OESTE")
                direccion = "OESTE";
            else if (direccion == "SUR")
                direccion = "SUR";
            else 
                direccion = "ESTE";
        }
        public void girarIzquierda() // metodo de girar a la izquierda 
        {
            if (direccion == "ESTE") 
                direccion = "ESTE";
            else if (direccion == "SUR") 
                direccion = "SUR";
            else if (direccion == "OESTE") 
                direccion = "OESTE";
            else
                direccion = "NORTE"; 
        }
        public void avanzar(int avanzo) 
        {
            switch (direccion) // switch (Valor de direccion(este,sur, norte y oeste))
            {
                case "NORTE": 
                    {
                        if (Y + avanzo > matriz.GetLength(0) - 1) // si valor de cordenada Y + el valor de n es menor a matriz menos 1
                            destinoY = matriz.GetLength(0) - 1; //  sidestino de la cordenada y es igual a matriz menos uno
                        else 
                            destinoY += avanzo; // destino de cordenada Y  lo sera incrementando en el valor de n
                    }
                    break;
                case "SUR":
                    {
                        if (Y - avanzo < 0) 
                            destinoY = 0;
                        else
                            destinoY -= avanzo;
                    }
                    break;
                case "ESTE":
                    {
                        if (X + avanzo > matriz.GetLength(1) - 1)
                            destinoX = matriz.GetLength(1) - 1;
                        else
                            destinoX += avanzo;
                    }
                    break;
                case "OESTE":
                    {
                        if (X - avanzo < 0)
                            destinoX = 0;
                        else
                            destinoX -= avanzo;
                    }
                    break;
            }

            for (int fila = Y; fila <= destinoY; fila++)
            {
                for (int columna = X; columna <= destinoX; columna++)
                {
                    if (escribir == true)
                        matriz[fila, columna] = "-";
                }
            }
            X = destinoX;
            Y = destinoY;
            matriz[Y, X] = "@"; //☺

        }
        public override string ToString()
        {
            string m = "";
            for (int fila = 0; fila < matriz.GetLength(0); fila++)
            {
                for (int columna = 0; columna < matriz.GetLength(1); columna++)
                {
                    m += matriz[fila, columna].ToString();
                }
                m += Environment.NewLine;
            }
            return m;
        }
    }
}