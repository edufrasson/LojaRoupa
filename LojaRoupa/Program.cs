using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaRoupa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] nome_roupa = new string[100];
            int[] qnt_roupa = new int[100];
            double[] valor_unit_roupa = new double[100];
            double[] valor_roupa_vendida = new double[100];
            double valor_total = 0;
            double dinheiro_cliente;
            double troco;
            int i = 0;
            int j = 1;
            string continuar;

            while (true)
            {
                i++;

                Console.WriteLine("Digite o nome da roupa: ");
                nome_roupa[i] = Console.ReadLine();
                Console.WriteLine("Digite a quantidade de roupa: ");
                qnt_roupa[i] = int.Parse(Console.ReadLine());
                Console.WriteLine("Digite o valor unitario da roupa");
                valor_unit_roupa[i] = double.Parse(Console.ReadLine());
                valor_roupa_vendida[i] = qnt_roupa[i] * valor_unit_roupa[i];
                valor_total += valor_roupa_vendida[i];

                Console.WriteLine("Continuar?");
                continuar = Console.ReadLine().ToUpper();
                if (continuar == "N")
                {
                    break;
                }
            }

            while (j <= i)
            {
                Console.WriteLine("===============================");
                Console.WriteLine("Nome da roupa: " + nome_roupa[j]);
                Console.WriteLine("Quantidade de roupa: " + qnt_roupa[j]);
                Console.WriteLine("Valor unitário: " + valor_unit_roupa[j]);
                Console.WriteLine("Valor total do item: " + valor_roupa_vendida[j]);


                j++;
            }
            Console.WriteLine("===============================");
            Console.WriteLine("Valor total da compra: R$" + valor_total);
            Console.Write("Dinheiro do cliente: R$");
            dinheiro_cliente = double.Parse(Console.ReadLine());
            if (dinheiro_cliente >= valor_total)
            {
                troco = dinheiro_cliente - valor_total;
            }
            else
            {
                Console.WriteLine("Valor insuficiente!");
                troco = 0;
            }

            Console.WriteLine("Troco: R$" + troco);

            Console.ReadKey();
        }
    }
}
