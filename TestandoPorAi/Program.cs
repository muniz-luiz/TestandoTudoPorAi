using System;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;
using TestandoPorAi;
using System.Collections.Generic;

namespace PrimeiroProjeto
{
    internal class Program
    {
        static void Main(string[] args)
        {

                   


            /*double[,] mat = new double[2,3];

            Console.WriteLine(mat.Rank);

            Console.WriteLine(mat.GetLength(0));

            List<string> list = new List<string>();

            list.Add("Edu");
            list.Add("Bruna");
            list.Add("Solari");
            list.Add("Luísa");
            list.Insert(4, "Lucas");


            foreach (string s in list)
            {
                Console.WriteLine(s);
            }

            Console.WriteLine(list.Count);

            string s1 = list.Find(x => x[0] == 'L');
            Console.WriteLine(s1);

            string s2 = list.FindLast(x => x[0] == 'L');
            Console.WriteLine(s2);

            List<string> filter = list.FindAll(x => x.Length >= 5);
            Console.WriteLine("000000000000000");
            foreach(string s in filter) Console.WriteLine(s);

            Console.WriteLine("XXXXXXXXXXXXXXXXXXXXXX");
            Console.WriteLine();
            Console.WriteLine("XXXXXXXXXXXXXXXXXXXX");


            list.Remove("Bruna");
            foreach(string s in list) Console.WriteLine(s);
           




            string[] vetor = new string[] { "Matis", "Edu", "Bruna" };

            foreach(string v in vetor)
            {
                Console.WriteLine(v);
            }





            int n = int.Parse(Console.ReadLine());

            double[] vect = new double[n];

            for (int i = 0; i < n; i++)
            {
                vect[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }

            double sum = 0.0;

            for(int i = 0 ; i < n; i++)
            {
                sum += vect[i];
            }

            double avg = sum / n;
            Console.WriteLine(avg);






            Triangulo x, y;
            x = new Triangulo();
            y = new Triangulo();

  

            Console.WriteLine("Digite 03 medidas para o triângulo X: ");
            x.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Obrigado!\n");


            Console.WriteLine("Agora digite 03 medidas para o triângulo Y: ");
            y.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


            double areaX = x.Area();
            double areaY = y.Area(); 

            Console.WriteLine("Área de X = " + areaX.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Área de Y = " + areaY.ToString("F2", CultureInfo.InvariantCulture));

            if (areaX > areaY)
            {
                Console.WriteLine("O maior é: X ");
            }
            else 
            {
                Console.WriteLine("O maior é: Y ");
            }
            
            


            Console.WriteLine("Digite a quantidade de valores: ");

            int qdtValores = int.Parse(Console.ReadLine());
            int soma = 0;

            for (int i = 1; i <= qdtValores; i++)
            {
                Console.WriteLine("O valor #{0}: ", i);
                int valor = int.Parse(Console.ReadLine());
                soma += valor;
            }

            Console.WriteLine("O total é: " + soma);

            Console.Write("Digite um número: ");

            double numDigitado = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            while (numDigitado >= 0.0)
            {
                double raiz = Math.Sqrt(numDigitado);
                Console.WriteLine("Digite um número: ");
                Console.WriteLine(raiz.ToString("F3", CultureInfo.InvariantCulture));
                numDigitado = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            }
            Console.WriteLine("Robertete é chutepete");

            Console.WriteLine("Digite 03 números: ");

            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            int n3 = int.Parse(Console.ReadLine());

            double somaTotal = numMaior(n1, n2, n3);

            
            Console.WriteLine(somaTotal);

            static int numMaior(int n1, int n2, int n3)
            {
                int maior;
                if (n1 > n2 && n1 > n3 ) 
                { 
                maior = n1;
                }
                else if (n2 > n3)
                {
                    maior = n2;
                }
                else
                {
                    maior = n3;
                }
                return maior;
            }
                      
            Console.WriteLine("Digite o número do raio: ");
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double pi = 3.1415;
            double area = pi * Math.Pow(raio, 2.0);
            Console.WriteLine("A área: " + area.ToString("F4", CultureInfo.InvariantCulture));

            Console.WriteLine("Digite um numero: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite outro numero: ");
            int num2 = int.Parse(Console.ReadLine());
            int soma = num1 + num2;
            Console.WriteLine("A soma é: " + soma);


            Console.WriteLine("Entre com o seu nome completo: ");
            string nome = Console.ReadLine();

            Console.WriteLine("Quantos quartos tem na sua casa: ");
            int quartos = int.Parse(Console.ReadLine());

            Console.WriteLine("Entre como preço de um produto: ");
            double produto = double.Parse(Console.ReadLine());

            Console.WriteLine("Entre seu último nome, idade e altura: ");
            string[] tudo = Console.ReadLine().Split(' ');
            string nomeFinal = tudo[0];
            int idadeTotal = int.Parse(tudo[1]);
            float alturaTotal = float.Parse(tudo[2], CultureInfo.InvariantCulture);
            
            Console.WriteLine("O seu nome é : " + nome);
            Console.WriteLine("A quantidade de quartos é: " + quartos);
            Console.WriteLine("O preço do produto é: " + produto);
            Console.WriteLine("O resultado de tudo é: " + nomeFinal);
            Console.WriteLine("O resultado de tudo é: " + idadeTotal);
            Console.WriteLine("O resultado de tudo é: " +alturaTotal);*/

        }
    }
}
