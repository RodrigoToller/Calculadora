using System;

namespace ConsoleApp {
    class Program
    {
        static void Main(string[] args)
        {
            
            bool continuar = true;

            while (continuar)
            {
                InterfaceUsuario.ExibirMenu();
                string escolha = Console.ReadLine();

                try
                {
                    continuar = InterfaceUsuario.ProcessarEscolha(escolha);
                }
                catch (Exception ex)
                {
                    InterfaceUsuario.ExibirErro(ex.Message);
                }
            }
        }
    }
}
