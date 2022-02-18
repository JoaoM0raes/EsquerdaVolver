using System;

namespace EsquerdaVolver
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escreva o Número Inicial");
            int Número = Convert.ToInt32(Console.ReadLine());
            string letras = "";

            string norte;
            string sul;
            string leste;
            string oeste;
            char posição = 'N';

            Console.Write("Escreva as funções em letra minuscula ");
            letras = Console.ReadLine();

            char[] arr = letras.ToCharArray();
            if (Número == arr.Length)
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[0] == 'e' && posição == 'N')
                    {
                        posição = 'o';
                    }
                    else if (arr[0] == 'd' && posição == 'N')
                    {
                        posição = 'l';

                    }
                    else if (arr[i] == 'd' && posição == 'l')
                    {
                        posição = 's';
                    }
                    else if (arr[i] == 'd' && posição == 's')
                    {
                        posição = 'o';
                    }
                    else if (arr[i] == 'd' && posição == 'o')
                    {
                        posição = 'N';

                    }
                    else if (arr[i] == 'e' && posição == 'o')
                    {
                        posição = 's';

                    }
                    else if (arr[i] == 'e' && posição == 's')
                    {
                        posição = 'l';

                    }
                    else if (arr[i] == 'e' && posição == 'l')
                    {
                        posição = 'N';

                    }
                    else
                    {
                        Console.WriteLine("Favor colocar a mesma quantidade de ações");
                    }
                }
                Console.WriteLine(posição);
            }
        }
    }
}
