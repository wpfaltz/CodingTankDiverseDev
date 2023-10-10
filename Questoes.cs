using System.Drawing;

namespace Prova
{
    internal class Questoes
    {
        
        static void Main(string[] args)
        {
            // Questao1();
            // Questao2();
            Questao3();
        }

        static void Questao1()
        {
            /*
             * Escreva um programa que faça a leitura de 5 valores Inteiros do usuário. 
             * Em seguida, o programa deve exibir no console a informação de quantos dos valores digitados são pares, 
             * quantos dos valores digitados são ímpares, quantos deles são positivos e, por fim, quantos são negativos. 
             * Cada uma das informações deve ser escrita em uma linha diferente.
             */

            int pares = 0, impares = 0, positivos = 0, negativos = 0;

            for (int i = 1; i <= 5; i++)
            {
                int valor = 0;
                bool entradaValida = false;

                while (!entradaValida)
                {
                    Console.Write("Digite o " + i + "º valor: ");
                    if (int.TryParse(Console.ReadLine(), out valor))
                    {
                        entradaValida = true;
                    }
                    else
                    {
                        Console.WriteLine("Valor inválido. Digite um número inteiro válido.");
                    }
                }

                if (valor % 2 == 0)
                {
                    pares++;
                }
                else
                {
                    impares++;
                }

                if (valor > 0)
                {
                    positivos++;
                }
                else if (valor < 0)
                {
                    negativos++;
                }
            }

            Console.WriteLine($"Quantidade de números pares: {pares}");
            Console.WriteLine($"Quantidade de números ímpares: {impares}");
            Console.WriteLine($"Quantidade de números positivos: {positivos}");
            Console.WriteLine($"Quantidade de números negativos: {negativos}");
        }

        static void Questao2()
        {
            /* Escreva um programa que calcule e escreva a multiplicação e a divisão inteira de dois números inteiros, N1 por N2, que devem ser lidos do teclado. 
             * É importante observar que a máquina que irá executar este programa é capaz de efetuar apenas duas operações matemáticas: adição e subtração. 
             * Ou seja, você não poderá usar os operadores de multiplicação, divisão, módulo etc. bem como truncamentos.
             */

            bool entradaN1Valida = false;
            int N1 = 0;

            while (!entradaN1Valida)
            {
                Console.Write("Digite o primeiro número (N1): ");
                if (int.TryParse(Console.ReadLine(), out N1))
                {
                    entradaN1Valida = true;
                }
                else
                {
                    Console.WriteLine("Valor inválido. Digite um número inteiro válido.");
                }
            }

            bool entradaN2Valida = false;
            int N2 = 0;

            while (!entradaN2Valida)
            {
                Console.Write("Digite o primeiro número (N2): ");
                if (int.TryParse(Console.ReadLine(), out N2))
                {   
                    if (N2 == 0)
                    {
                        Console.WriteLine("Valor inválido. Não é possível fazer divisão por zero.");
                    }
                    else
                    {
                        entradaN2Valida = true;
                    }
                }
                else
                {
                    Console.WriteLine("Valor inválido. Digite um número inteiro válido.");
                }
            }

            int multiplicacao = 0;
            int divisao = 0;
            int qtd_sinais_negativos = 0;

            if (N1 < 0) 
            {
                qtd_sinais_negativos++;
                N1 = -N1;
            }
            if (N2 < 0) 
            {
                qtd_sinais_negativos++;
                N2 = -N2;
            }


            for (int i = 0; i < N2; i++)
            {
                multiplicacao += N1;
            }

            while (N1 >= N2)
            {
                N1 -= N2;
                divisao++;
            }

            // Verificar a quantidade de sinais negativos
            if (qtd_sinais_negativos == 1)
            {
                multiplicacao = -multiplicacao;
                divisao = -divisao;
            }

            Console.WriteLine($"Multiplicação: {multiplicacao}");
            Console.WriteLine($"Divisão: {divisao}");
        }

        static void Questao3()
        {
            /* Escreva um programa que recebe como entrada uma frase do usuário. Como saída o programa deve exibir no console as seguintes informações: 
             * quantas palavras são maiúsculas, quantas palavras são minúsculas, 
             * quantas palavras iniciam com letra maiúscula, quantas palavras iniciam com letra minúscula e 
             * a quantidade de palavras.
             */
            string frase = null;

            while (frase == null)
            {
                Console.Write("Digite uma frase: ");
                frase = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(frase))
                {
                    Console.WriteLine("Frase não pode ser nula ou em branco. Tente novamente.");
                    frase = null;
                }
            }          

            // Quebrando a frase em palavras usando espaços como delimitadores
            string[] palavras = frase.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries); // Ignora espaços em branco

            int totalPalavras = palavras.Length;
            int maiusculas = 0;
            int minusculas = 0;
            int comLetraMaiuscula = 0;
            int comLetraMinuscula = 0;

            foreach (string palavra in palavras)
            {
                if (string.IsNullOrWhiteSpace(palavra))
                {
                    // Ignorar palavras vazias
                    continue;
                }

                if (palavra.All(char.IsUpper))
                {
                    maiusculas++;
                }
                else if (palavra.All(char.IsLower))
                {
                    minusculas++;
                }
                else if (char.IsUpper(palavra[0]))
                {
                    comLetraMaiuscula++;
                }
                else if (char.IsLower(palavra[0]))
                {
                    comLetraMinuscula++;
                }
            }

            Console.WriteLine($"Palavras com todas as letras maiúsculas: {maiusculas}");
            Console.WriteLine($"Palavras com todas as letras minúsculas: {minusculas}");
            Console.WriteLine($"Palavras iniciando com letra maiúscula: {comLetraMaiuscula}");
            Console.WriteLine($"Palavras iniciando com letra minúscula: {comLetraMinuscula}");
            Console.WriteLine($"Total de palavras: {totalPalavras}");
        }
    }
}