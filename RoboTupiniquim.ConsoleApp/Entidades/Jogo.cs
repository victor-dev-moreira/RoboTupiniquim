namespace RoboTupiniquim.ConsoleApp.Entidades;

public class Jogo
{
    static string comando;
    public static string PedirComando(int y, int x, char sentido)
    {
        Console.WriteLine("----------------------");
        Console.WriteLine("Robo Tupiniquin");
        Console.WriteLine("----------------------");

        Console.WriteLine($"Posicão atual é Y:{y} X:{x} Sentido: {sentido}");
        Console.WriteLine("Comandos: M para mover | D para virar 90 graus para direita | E para virar 90 graus a esquerda");

        Console.Write("Qual seu comando? ");
        comando = Console.ReadLine().ToUpper();

        return comando;
    }
}
