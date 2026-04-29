using System.Xml.Schema;

class Program
{
    static void Main(string[] args)
    {
        int y = 1;
        int x = 2;
        char sentido = 'N';

        while (true)
        {
            Console.WriteLine("----------------------");
            Console.WriteLine("Robo Tupiniquin");
            Console.WriteLine("----------------------");

            Console.WriteLine($"Posicão atual é Y:{y} X:{x} Sentido: {sentido}");
            Console.WriteLine("Comandos: M para mover | D para virar 90 graus para direita | E para virar 90 graus a esquerda");

            Console.Write("Qual seu comando? ");
            string? comando = Console.ReadLine().ToUpper();
            char[] instrucoes = comando.ToCharArray();

            for (int i = 0; i < instrucoes.Length; i++)
            {
                if (instrucoes[i] == 'M')
                {
                    if (sentido == 'N')
                    {
                        y++;
                    }
                    else if (sentido == 'L')
                    {
                        x++;
                    }
                    else if (sentido == 'O')
                    {
                        x--;
                    }
                    else if (sentido == 'S')
                    {
                        y--;
                    }
                }
                else if (instrucoes[i] == 'E')
                {
                    if (sentido == 'N')
                    {
                        sentido = 'O';
                    }
                    else if (sentido == 'O')
                    {
                        sentido = 'S';
                    }
                    else if (sentido == 'S')
                    {
                        sentido = 'L';
                    }
                    else if (sentido == 'L')
                    {
                        sentido = 'N';
                    }
                }
                else if (instrucoes[i] == 'D')
                {
                    if (sentido == 'N')
                    {
                        sentido = 'L';
                    }
                    else if (sentido == 'L')
                    {
                        sentido = 'S';
                    }
                    else if (sentido == 'S')
                    {
                        sentido = 'O';
                    }
                    else if (sentido == 'O')
                    {
                        sentido = 'N';
                    }
                }
            }

            Console.WriteLine("----------------------");
            Console.WriteLine($"Posicão é Y:{y} e X:{x} sentido:" + sentido);
            Console.WriteLine("----------------------");

            Console.Write("Deseja Prosseguir? (S/N)");
            string? continuar = Console.ReadLine().ToUpper();

            if (continuar != "S")
                break;
        }
    }
}

