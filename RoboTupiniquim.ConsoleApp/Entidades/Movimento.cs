namespace RoboTupiniquim.ConsoleApp.Entidades;

public class Movimento
{
    public static void Movimentar(char[] instrucoes, ref char sentido, ref int y, ref int x)
    {
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
    }
}