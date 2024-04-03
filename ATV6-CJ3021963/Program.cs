namespace ATV5_CJ3021963

{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opcgeral;

            Console.WriteLine("**MENU DE ATIVIDADES** \n 1-ATIVIDADE DE SALA \n 2-EXERCÍCIO 1 \n 3-EXERCÍCIO 2 \n 4-EXERCÍCIO 3 \n 5-EXERCÍCIO 4 \n 6-EXERCÍCIO 5 \n 7-EXERCÍCIO 6 \n 8-EXERCÍCIO 7");
            opcgeral = int.Parse(Console.ReadLine());

            switch (opcgeral)
            {
                case 1:
                    Console.WriteLine("ATIVIDADE DE SALA");
                    //ATV SALA
                    int a, temp;
                    int soma = 0;

                    for (a = 0; a < 3; a++)
                    {
                        Console.WriteLine("digite um valor: ");
                        temp = int.Parse(Console.ReadLine());
                        if (temp < 0)
                        {
                            break;
                        }
                        soma = soma + temp;
                    }
                    Console.WriteLine("a medida é: {0}", soma / 3);
                    break;

                case 2:
                    Console.WriteLine("ATIVIDADE 1");
                    //ATV 1
                    int n, m;

                    Console.WriteLine("digite um número inteiro aleatório: ");
                    m = int.Parse(Console.ReadLine());

                    for (n = 1; n <= m; n++)
                        Console.WriteLine("{0}", n);
                    break;

                case 3:
                    Console.WriteLine("ATIVIDADE 2");
                    //ATV 2
                    int a2, n1;

                    Console.WriteLine("Escreva um número inteiro aleatório: ");
                    n1 = int.Parse(Console.ReadLine());

                    for (a2 = 0; a2 <= n1; a2++)
                    {
                        if (a2 % 2 == 0)
                        {
                            Console.WriteLine(a2);
                        }
                    }
                    break;

                case 4:
                    Console.WriteLine("ATIVIDADE 3");
                    //ATV 3

                    int div = 1000;

                    Console.WriteLine("Escreva um úmero interiro menor que 1000");
                    int mil = int.Parse(Console.ReadLine());

                    if (mil < 1000)
                    {
                        for (div = 1000; div >= mil; div--)
                        {
                            if ((div % 2) == 0)
                            {
                                Console.WriteLine(div);
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("OPÇÃO INVÁLIDA");
                    }
                    break;

                case 5:
                    Console.WriteLine("ATIVIDADE 4");
                    //ATV 4

                    int somaPositivos = 0;

                    while (somaPositivos < 200)
                    {
                        Console.Write("Digite um número inteiro: ");
                        int n2 = int.Parse(Console.ReadLine());

                        if (n2 > 0)
                        {
                            Console.WriteLine("Número positivo: " + n2);
                            somaPositivos += n2;
                        }
                    }
                    Console.WriteLine("Soma dos números positivos atingiu ou ultrapassou 200.");
                    Console.WriteLine("Programa encerrado.");
                    break;

                case 6:
                    Console.WriteLine("ATIVIDADE 5");
                    //ATV 5

                    int numero;
                    Console.Write("Digite um número inteiro positivo: ");
                    numero = int.Parse(Console.ReadLine());

                    Console.WriteLine("Divisores de {0}:", numero);

                    for (int i = 1; i <= numero; i++)
                    {
                        if (numero % i == 0)
                        {
                            Console.WriteLine(i);
                        }
                    }
                    break;

                case 7:
                    Console.WriteLine("ATIVIDADE 6");
                    //ATV 6
                    int quantidadeNumeros = 10;
                    int maiorNumero = int.MinValue;
                    int menorNumero = int.MaxValue;

                    for (int i = 1; i <= quantidadeNumeros; i++)
                    {
                        Console.Write("Digite o número " + i + ": ");
                        int n3 = int.Parse(Console.ReadLine());

                        if (n3 > maiorNumero)
                        {
                            maiorNumero = n3;
                        }

                        if (n3 < menorNumero)
                        {
                            menorNumero = n3;
                        }
                    }

                    Console.WriteLine("O maior número digitado foi: " + maiorNumero);
                    Console.WriteLine("O menor número digitado foi: " + menorNumero);
                    break;

                case 8:
                    Console.WriteLine("ATIVIDADE 7");
                    //ATV 7
                    int somaPares = 0;
                    int somaImpares = 0;

                    while (true)
                    {
                        Console.Write("Digite um número (ou zero para sair): ");
                        int n4 = int.Parse(Console.ReadLine());

                        if (n4 == 0)
                        {
                            break;
                        }

                        if (n4 % 2 == 0)
                        {
                            somaPares += n4;
                        }
                        else
                        {
                            somaImpares += n4;
                        }
                    }

                    Console.WriteLine("Soma dos números pares: " + somaPares);
                    Console.WriteLine("Soma dos números ímpares: " + somaImpares);

                    break;

                default:
                    Console.WriteLine("opção inválida");
                    break;
            }
        }
    }
}
