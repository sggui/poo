using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace provaAtentativa2
{
    public class Carrinho
    {
        public string nome;
        public List<Produto> produtos { get; set; }
        public double pesoMax { get; set; }


        public void AdicionarProduto(Produto produto)
        {
            if (CalcularPeso() + produto.peso > pesoMax)
            {
                Console.WriteLine("Peso máximo do carrinho excedido!");
            }
            else
            {
                produtos.Add(produto);
                Console.WriteLine(produto.nome + " adicionado ao carrinho.");
            }
        }

        public void RemoveItens(Produto produto)
        {
            produtos.Remove(produto);
            Console.Write(produto.nome + " removido do carrinho!");
        }

        public void listarProdutos()
        {
            foreach (Produto produto in produtos)
            {
                Console.WriteLine(produto.nome = "- R$" + produto.preço);
            }
        }

        public double CalcularPeso()
            {
            double peso = 0;
            foreach(Produto produto in produtos)
            {
                peso += produto.peso;
            }
            return peso;
            }

        public double CalcularTotalCarrinho()
        {
            double total = 0;
            foreach (Produto produto in produtos)
            {
                total += produto.preço;
            }
            return total;
        }

        public void FinalizarCompra(Pessoa pessoa)
        {
            Console.WriteLine("Compra realizada com sucesso!!");
            Console.WriteLine("Segue os itens que foram comprados:");
            listarProdutos();
            Console.WriteLine("total: " + CalcularTotalCarrinho());
            Console.WriteLine("peso total: " + CalcularPeso());
            Console.WriteLine("valor pago: " + CalcularTotalCarrinho());

        }
    }
    
}
