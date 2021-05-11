using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Globalization;

namespace ConsoleSistemaSupermercado
{
    public class Compra
    {
        NumberFormatInfo nfi = new CultureInfo("pt-BR").NumberFormat;

        List<ItemCompra> lista_de_compra = new List<ItemCompra>();

        public void inserir()
        {
            Console.WriteLine("Qual produto?");
            string prod = Console.ReadLine();

            Console.WriteLine("Qual a quantidade?");
            double qnt = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Qual o preço unitário?");
            double p_unit = Convert.ToDouble(Console.ReadLine());

            lista_de_compra.Add(new ItemCompra()
            {
                Produto = prod,
                Quantidade = qnt,
                PrecoUnitario = p_unit
            });
        }


        public void listar()
        {
            if (lista_de_compra.Count > 0)
            {
                Console.WriteLine("Item    Produto          Quantidade      Preço Unitário     Preço Total");

                for (int i = 0; i < lista_de_compra.Count; i++)
                {
                    Console.WriteLine(
                        "{0}    {1}          {2}             {3}            {4}",
                        i,
                        lista_de_compra[i].Produto,
                        lista_de_compra[i].Quantidade,
                        lista_de_compra[i].PrecoUnitario.ToString("C", nfi),
                        lista_de_compra[i].PrecoTotal.ToString("C", nfi)
                    );
                }

                double total_compra = lista_de_compra.Sum(i => i.PrecoTotal);

                Console.WriteLine("Total da Compra {0} ", total_compra.ToString("C"));
            }
            else
            {
                Console.BackgroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("Nenhum Produto na Compra ainda.");
                Console.BackgroundColor = ConsoleColor.Black;

            }
        }


        public void editar()
        {
            if (lista_de_compra.Count > 0)
            {
                Console.WriteLine("Qual o número Item quer mudar a quantidade?");
                int i = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine(
                    "Qual a nova quantidade de {0}, quantidade atual é {1} ",
                    lista_de_compra[i].Produto,
                    lista_de_compra[i].Quantidade
                 );

                lista_de_compra[i].Quantidade = Convert.ToDouble(Console.ReadLine());

                Console.BackgroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("Produto Editado com Sucesso!");
                Console.BackgroundColor = ConsoleColor.Black;

            }
            else
            {
                Console.BackgroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("Nenhum Produto na Compra ainda.");
                Console.BackgroundColor = ConsoleColor.Black;
            }
        }

        public void remover()
        {
            if (lista_de_compra.Count > 0)
            {
                Console.WriteLine("Qual o número Item que você quer remover?");
                int i = Convert.ToInt32(Console.ReadLine());

                lista_de_compra.RemoveAt(i);

                Console.BackgroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("Produto Removido com Sucesso!");
                Console.BackgroundColor = ConsoleColor.Black;
            }
            else
            {
                Console.BackgroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("Nenhum Produto na Compra ainda.");
                Console.BackgroundColor = ConsoleColor.Black;
            }
        }
    }
}
