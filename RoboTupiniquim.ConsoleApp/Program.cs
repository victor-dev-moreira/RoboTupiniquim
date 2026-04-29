using RoboTupiniquim.ConsoleApp.Entidades;

namespace RoboTupiniquim.ConsoleApp;

class Program
{
    static void Main(string[] args)
    {
        int y = 1;
        int x = 2;
        char sentido = 'N';

        while (true)
        {
            string comando = Jogo.PedirComando(y, x, sentido);
            char[] instrucoes = comando.ToCharArray();

            Movimento.Movimentar(instrucoes, sentido, y, x);

            Console.Write("Deseja Prosseguir? (S/N)");
            string? continuar = Console.ReadLine().ToUpper();

            if (continuar != "S")
                break;
        }
    }
}