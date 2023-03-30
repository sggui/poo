using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace provaAtentativa2
{
    public class ProdutoAlimenticio : Produto
    {
        public int dataValidade;

        public ProdutoAlimenticio(int dataValidade, string nome, string marca, double preço, double peso) : base(nome, marca, preço, peso)
        {

        }
    }
}
