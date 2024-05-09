using System;

namespace maximocomundiv
{
    public class maximocomun
    {
        // Función para hallar el máximo común divisor de dos números
        public static int maxcmul(int a, int b)
        {
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }

        // Usar la misma funcion para cuatro números
        public static int maxcmul_CuatroNumeros(int nro1, int nro2, int nro3, int nro4)
        {
            int a_1 = maxcmul(nro1, nro2);
            int a_2 = maxcmul(nro3, nro4);
            return maxcmul(a_1, a_2);
        }

        public static void Main(string[] args)
        {
            int nro1 = 36;
            int nro2 = 24;
            int nro3 = 60;
            int nro4 = 48;
            int resul = maxcmul_CuatroNumeros(nro1, nro2, nro3, nro4);
            Console.WriteLine("El máximo común divisor es: ", resul);
        }

    }
}

