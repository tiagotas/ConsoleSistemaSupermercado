using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleSistemaSupermercado
{
    public class ItemCompra
    {
        string produto;
        double quantidade;
        double preco_unitario;

        public string Produto
        {
            get { return produto; }
            set { produto = value; }
        }

        public double Quantidade
        {
            get { return quantidade; }
            set { quantidade = value; }
        }

        public double PrecoUnitario
        {
            get { return preco_unitario; }
            set { preco_unitario = value; }
        }

        public double PrecoTotal
        {
            get { return preco_unitario * quantidade; }
        }
    }
}
