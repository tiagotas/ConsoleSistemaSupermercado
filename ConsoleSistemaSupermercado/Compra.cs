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


        public void editar()
        {

        }

        public void remover()
        {

        }

    }
}
