using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploSistemaComForWhileVetor
{
    class Barco
    {
        string[] barcosNomes = new string[100];
        string[] barcosCor = new string[100];
        double[] barcosPreco = new double[100];
        int atual = 0;

        public void CadastroBarcos()
        {
            Console.Clear();
            Console.Write("Nome do barco: ");
            barcosNomes[atual] = Console.ReadLine();
            Console.Write("Cor do barco: ");
            barcosCor[atual] = Console.ReadLine();
            Console.Write("Preço do barco: ");
            barcosPreco[atual] = Convert.ToDouble(Console.ReadLine());
            atual++;
        }

        public void ListarBarcos()
        {
            Console.Clear();
            Console.WriteLine("Lista de barcos ");
            for (int i = 0; i < atual; i++)
            {
                Console.WriteLine(
                    String.Format(
                        "\nNome: {0} \nCor: {1} \nPreço: {2}",
                        barcosNomes[i], barcosCor[i], barcosPreco[i]
                        )
                    );
            }                              
        }

        public void EditarBarco()
        {
            Console.Clear();
            Console.WriteLine("Digite um nome para pesquisa");
            string nomePesquisado = Console.ReadLine().ToLower().Trim();
            int posicao = -1;
            for (int i = 0; i < atual; i++)
            {
                if (nomePesquisado == barcosNomes[i])
                {
                    posicao = i;
                }
            }

            if (posicao != -1)
            {
                // encontrou o registro procurado
                Console.Write("Nome do barco: ");
                barcosNomes[atual] = Console.ReadLine();
                Console.Write("Cor do barco: ");
                barcosCor[atual] = Console.ReadLine();
                Console.Write("Preço do barco: ");
                barcosPreco[atual] = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Dados alterados com sucesso");
            }
            else
            {
                Console.WriteLine("Registro não encontrado");
                
            }
        }

        internal void BuscarBarco()
        {
            Console.WriteLine("Digite o nome para busca: ");
            string nomeBuscado = Console.ReadLine();
            bool achou = false;
            for (int i = 0; i < atual; i++)
            {
                if (nomeBuscado == barcosNomes[i])
                {
                    Console.WriteLine(
                        String.Format(
                            "\nNome: {0} \nCor: {1} \nPreço: {2}",
                            barcosNomes[i], barcosCor[i], barcosPreco[i]

                        )
                    );
                    achou = true;
                    break;
                }
            }
            if (!achou)
            {
                Console.WriteLine("Nome não encontrado");
            }
        }
    }       
}           
            