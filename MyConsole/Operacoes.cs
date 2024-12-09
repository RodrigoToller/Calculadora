using System;

namespace ConsoleApp {
    static class Operacoes
    {
        public static double Soma(double a, double b) => a + b;
        public static double Subtracao(double a, double b) => a - b;
        public static double Multiplicacao(double a, double b) => a * b;
        public static double Divisao(double a, double b) => b != 0 ? a / b : throw new Exception("Divisão por zero não é permitida.");
        public static double Modulo(double a, double b) => b != 0 ? a % b : throw new Exception("Divisão por zero não é permitida.");
        public static double Exponenciacao(double a, double b) => Math.Pow(a, b);
        public static double RaizQuadrada(double a) => a >= 0 ? Math.Sqrt(a) : throw new Exception("Não é possível calcular a raiz quadrada de um número negativo.");
        public static double Seno(double a) => Math.Sin(a);
        public static double Cosseno(double a) => Math.Cos(a);
        public static double Tangente(double a) => Math.Tan(a);

        public static double Fatorial(double n)
        {
            if (n < 0) throw new Exception("Fatorial não é definido para números negativos.");
            if (n == 0 || n == 1) return 1;
            double resultado = 1;
            for (int i = 2; i <= n; i++) resultado *= i;
            return resultado;
        }
    }
}
