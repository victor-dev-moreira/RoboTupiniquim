using System.Xml.Schema;

Console.WriteLine("Robo Tupiniquin");
Console.WriteLine("----------------------");

Console.WriteLine("Posicão inicial é Y:1 X:2 Sentido: N");
Console.WriteLine("Comandos: M para mover | D para virar 90 graus para direita | E para virar 90 graus a esquerda");

Console.Write("Qual seu comando? ");
string? comando = Console.ReadLine().ToUpper();
char[] instrucoes = comando.ToCharArray();

int y = 1;
int x = 2;
int sentido = 0;
char sentidoChar = 'N';

for (int i = 0; i < instrucoes.Length; i++)
{
    if (instrucoes[i] == 'M')
    {
        if (sentido == 0)
        {
            y++;
        }
        else if (sentido == 1 || sentido == -3)
        {
            x++;
        }
        else if (sentido == 2 || sentido == -2)
        {
            y--;
        }
        else if (sentido == 3 || sentido == -1)
        {
            x--;
        }
    }
    else if (instrucoes[i] == 'E')
    {
        sentido--;
    }
    else if (instrucoes[i] == 'D')
    {
        sentido++;
    }

    if (sentido == 0)
    {
        sentidoChar = 'N';
    }
    else if (sentido == 1)
    {
        sentidoChar = 'L';
    }
    else if (sentido == 2)
    {
        sentidoChar = 'S';
    }
    else if (sentido == 3)
    {
        sentidoChar = 'O';
    }
}

Console.WriteLine($"Posicão é Y:{y} e X:{x} sentido:" + sentidoChar);
Console.ReadLine();