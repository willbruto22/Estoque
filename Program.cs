using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace ConsoleApp1
{
    class Produto
    {

        public string Nome;
        public double Preco;
        public int Quantitade;

        public Produto(string nome, double preco, int quantitade) //método para contruir.
        {
            Nome = nome;
            Preco = preco;
            Quantitade = quantitade;
        }


        public double ValorTotalEstoque() //para calcular o valor do estoque.
        {
            return Preco * Quantitade;
        }

        public void Adiciona(int quantitade) //adiciona peças ao estoque.
        {
            Quantitade += quantitade;
        }

        public void Remover(int quantidade) //remove as peças do estoque.
        {
            Quantitade = Quantitade - quantidade;
        }

        public override string ToString() //método de ToString para mostrar as informações.
        {
            return Nome
                + ", R$ "
                + Preco.ToString("F2", CultureInfo.InvariantCulture)
                + ", "
                + Quantitade
                + " unidades, Total: R$ "
                + ValorTotalEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }

    }
}