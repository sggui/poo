using provaAtentativa2;
using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)

    {

        Pessoa p1 = new Pessoa("Guilherme", 555555, 200);
        Pessoa p2 = new Pessoa("Joao", 5222222, 200);

        Produto produto1 = new ProdutoEletronico(2, "Mouse", "razer", 100, 50);
        Produto produto2 = new ProdutoEletronico(2, "Monitor", "LG", 50, 50);

        Carrinho carrinho = new Carrinho();

        carrinho.AdicionarProduto(produto1);
        carrinho.AdicionarProduto(produto2);

        carrinho.listarProdutos();

        double total = carrinho.CalcularTotalCarrinho();
        Console.WriteLine("Total do carrinho: " + total);

        if(p1.saldo >= total)
        {
            p1.saldo -= total;
            carrinho.FinalizarCompra(p1);
        } else
        {

            Console.WriteLine("Sem saldo disponível!\n" + "seu saldo é: " + p1.saldo);
        }




    }
}