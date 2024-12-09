using System;
using System.Collections.Generic;
using System.IO;

namespace ConsoleApp {
    static class InterfaceUsuario
    {
        private static List<string> historico = new List<string>(); // Lista para armazenar o histórico

        public static void ExibirMenu()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("╔══════════════════════════════════════════════════╗");
            Console.WriteLine("║            BEM-VINDO AO PROGRAMA                 ║");
            Console.WriteLine("╚══════════════════════════════════════════════════╝");
            Console.ResetColor();

            Console.WriteLine("Escolha uma das opções abaixo:\n");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("1. Soma");
            Console.WriteLine("2. Subtração");
            Console.WriteLine("3. Multiplicação");
            Console.WriteLine("4. Divisão");
            Console.WriteLine("5. Módulo");
            Console.WriteLine("6. Exponenciação");
            Console.WriteLine("7. Raiz Quadrada");
            Console.WriteLine("8. Seno");
            Console.WriteLine("9. Cosseno");
            Console.WriteLine("10. Tangente");
            Console.WriteLine("11. Fatorial");
            Console.WriteLine("12. Histórico");
            Console.WriteLine("13. Salvar Histórico");
            Console.WriteLine("14. Instruções");
            Console.WriteLine("0. Sair");
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\nDica: Digite o número correspondente à sua escolha.");
            Console.ResetColor();

            Console.Write("\nDigite sua escolha: ");
        }
        public static bool ProcessarEscolha(string escolha)
        {
            switch (escolha)
            {
                case "1":
                    ExecutarOperacaoBinaria("Soma", Operacoes.Soma);
                    break;
                case "2":
                    ExecutarOperacaoBinaria("Subtração", Operacoes.Subtracao);
                    break;
                case "3":
                    ExecutarOperacaoBinaria("Multiplicação", Operacoes.Multiplicacao);
                    break;
                case "4":
                    ExecutarOperacaoBinaria("Divisão", Operacoes.Divisao);
                    break;
                case "5":
                    ExecutarOperacaoBinaria("Módulo", Operacoes.Modulo);
                    break;
                case "6":
                    ExecutarOperacaoBinaria("Exponenciação", Operacoes.Exponenciacao);
                    break;
                case "7":
                    ExecutarOperacaoUnaria("Raiz Quadrada", Operacoes.RaizQuadrada);
                    break;
                case "8":
                    ExecutarOperacaoUnaria("Seno", Operacoes.Seno);
                    break;
                case "9":
                    ExecutarOperacaoUnaria("Cosseno", Operacoes.Cosseno);
                    break;
                case "10":
                    ExecutarOperacaoUnaria("Tangente", Operacoes.Tangente);
                    break;
                case "11":
                    ExecutarOperacaoUnaria("Fatorial", Operacoes.Fatorial);
                    break;
                case "12":
                    ExibirHistorico();
                    break;
                case "13":
                    SalvarHistorico();
                    break;
                case "14":
                    MostrarInstrucoes();
                    break;
                case "0":
                    Console.WriteLine("Saindo do Programa...");
                    return false;
                default:
                    throw new Exception("Opção inválida. Por favor, digite um número de 0 a 14.");
            }
            return true;
        }
        public static void ExecutarOperacaoBinaria(string operacaoNome, Func<double, double, double> operacao)
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Operação de {operacaoNome}:");
            Console.ResetColor();

            double num1 = LerNumero("Digite o primeiro número (exemplo: 5.5): ");
            double num2 = LerNumero("Digite o segundo número (exemplo: 2.2): ");
            double resultado = operacao(num1, num2);

            // Adiciona ao histórico
            historico.Add($"Operação: {operacaoNome}, Números: {num1}, {num2}, Resultado: {resultado}");

            Console.WriteLine($"Resultado: {resultado}");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("Pressione qualquer tecla para continuar...");
            Console.ResetColor();
            Console.ReadLine();
        }
        public static void ExecutarOperacaoUnaria(string operacaoNome, Func<double, double> operacao)
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Operação de {operacaoNome}:");
            Console.ResetColor();

            double num = LerNumero("Digite o número (exemplo: 25): ");
            double resultado = operacao(num);

            // Adiciona ao histórico
            historico.Add($"Operação: {operacaoNome}, Número: {num}, Resultado: {resultado}");

            Console.WriteLine($"Resultado: {resultado}");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("Pressione qualquer tecla para continuar...");
            Console.ResetColor();
            Console.ReadLine();
        }
        public static double LerNumero(string mensagem)
        {
            while (true)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write(mensagem);
                Console.ResetColor();

                if (double.TryParse(Console.ReadLine(), out double numero))
                {
                    return numero;
                }
                else
                {
                    ExibirErro("Entrada inválida. Por favor, insira um número válido.");
                }
            }
        }
        public static void ExibirHistorico()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("╔══════════════════════════════════════════════════╗");
            Console.WriteLine("║              HISTÓRICO DE OPERAÇÕES             ║");
            Console.WriteLine("╚══════════════════════════════════════════════════╝");
            Console.ResetColor();

            if (historico.Count == 0)
            {
                Console.WriteLine("Nenhuma operação realizada até o momento.");
            }
            else
            {
                foreach (var entrada in historico)
                {
                    Console.WriteLine(entrada);
                }
            }

            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("\nPressione qualquer tecla para voltar ao menu...");
            Console.ResetColor();
            Console.ReadLine();
        }
        public static void MostrarInstrucoes()
{
    Console.Clear();
    Console.ForegroundColor = ConsoleColor.Cyan;
    Console.WriteLine("╔══════════════════════════════════════════════════╗");
    Console.WriteLine("║                  INSTRUÇÕES                      ║");
    Console.WriteLine("╚══════════════════════════════════════════════════╝");
    Console.ResetColor();

    Console.WriteLine();
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine("OPERACOES BÁSICAS:");
    Console.ResetColor();
    Console.WriteLine("1. Soma - Adiciona dois números fornecidos pelo usuário.");
    Console.WriteLine("2. Subtração - Subtrai o segundo número do primeiro.");
    Console.WriteLine("3. Multiplicação - Multiplica dois números.");
    Console.WriteLine("4. Divisão - Divide o primeiro número pelo segundo. Trata divisão por zero.");
    Console.WriteLine("5. Módulo - Calcula o resto da divisão do primeiro número pelo segundo.");

    Console.WriteLine();
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine("OPERACOES AVANÇADAS:");
    Console.ResetColor();
    Console.WriteLine("6. Exponenciação - Calcula o resultado de um número elevado a outro.");
    Console.WriteLine("7. Raiz Quadrada - Calcula a raiz quadrada de um número. Apenas números não-negativos.");
    Console.WriteLine("8. Seno - Calcula o seno de um número em radianos.");
    Console.WriteLine("9. Cosseno - Calcula o cosseno de um número em radianos.");
    Console.WriteLine("10. Tangente - Calcula a tangente de um número em radianos.");
    Console.WriteLine("11. Fatorial - Calcula o fatorial de um número inteiro positivo.");

    Console.WriteLine();
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine("OUTRAS FUNCIONALIDADES:");
    Console.ResetColor();
    Console.WriteLine("12. Histórico - Exibe o histórico das operações realizadas.");
    Console.WriteLine("13. Salvar Histórico - Salva o histórico em um arquivo chamado 'historico_operacoes.txt'.");

    Console.WriteLine();
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("Pressione qualquer tecla para voltar ao menu...");
    Console.ResetColor();
    Console.ReadLine();
}
        public static void ExibirErro(string mensagem)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"\nErro: {mensagem}");
            Console.ResetColor();
        }
        public static void SalvarHistorico()
        {
            Console.Clear();
            Console.WriteLine("Salvando Histórico...\n");

            string caminhoArquivo = "historico_operacoes.txt";

            try
            {
                using (StreamWriter sw = new StreamWriter(caminhoArquivo))
                {
                    foreach (var entrada in historico)
                    {
                        sw.WriteLine(entrada);
                    }
                }

                Console.WriteLine($"Histórico salvo com sucesso no arquivo: {caminhoArquivo}");
            }
            catch (Exception ex)
            {
                ExibirErro($"Erro ao salvar o histórico: {ex.Message}");
            }

            Console.WriteLine("\nPressione qualquer tecla para voltar ao menu...");
            Console.ReadLine();
        }







        
    }
}
