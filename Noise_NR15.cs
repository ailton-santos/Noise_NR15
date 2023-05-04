using System;

namespace IdentificacaoRiscosRuido
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Identificação de Riscos de Ruído em Indústria Automotiva\n");

            // Obter dados do usuário
            Console.Write("Digite o nível de pressão sonora medido (em dB): ");
            double nivelPressaoSonora = double.Parse(Console.ReadLine());

            Console.Write("Digite o tempo de exposição ao ruído (em horas): ");
            double tempoExposicao = double.Parse(Console.ReadLine());

            Console.Write("Digite o nível de dobra desejado (em dB): ");
            double nivelDobra = double.Parse(Console.ReadLine());

            // Calcular o índice de dose de ruído (IDR)
            double IDR = (nivelPressaoSonora / nivelDobra) * Math.Pow(2, tempoExposicao);

            // Classificar o risco de acordo com o IDR
            string classificacaoRisco;

            if (IDR < 1)
            {
                classificacaoRisco = "Sem risco";
            }
            else if (IDR < 2)
            {
                classificacaoRisco = "Risco leve";
            }
            else if (IDR < 4)
            {
                classificacaoRisco = "Risco moderado";
            }
            else if (IDR < 8)
            {
                classificacaoRisco = "Risco alto";
            }
            else
            {
                classificacaoRisco = "Risco muito alto";
            }

            // Exibir resultado
            Console.WriteLine("\nÍndice de Dose de Ruído (IDR): " + IDR.ToString("0.00"));
            Console.WriteLine("Classificação de Risco: " + classificacaoRisco);

            Console.ReadKey();
        }
    }
}
