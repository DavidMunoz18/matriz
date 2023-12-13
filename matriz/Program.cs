namespace matriz
{
    class program
    {
        public static void Main(String[] args)
        {
            int filas = 10;
            int columnas = 10;

            int[,] matriz = new int[filas, columnas];

            int n = 100;
            for(int i = 0; i < filas; i++)
            {
                for(int j = 0; j < columnas; j++)
                {
                    matriz[i, j] = n;
                    n--;
                }
            }
            Console.WriteLine("Completa de forma automatica numeros del 1 al 100");
            for (int i = 0;i < filas; i++)
            {
                for (int j = 0;j < columnas; j++)
                {
                    Console.WriteLine(matriz[i, j]);
                }
            }
            Console.WriteLine("Imprime los numeros en orden ascendente");
            for (int i = 0; i <= 100; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
