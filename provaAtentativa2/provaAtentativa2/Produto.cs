using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace provaAtentativa2
{
    public class Produto
    {
        public string nome;
        public string marca;
        public double preço;
        public double peso;

        public Produto(string nome, string marca, double preço, double peso)
        {
            this.nome = nome;
            this.marca = marca;
            this.preço = preço;
            this.peso = peso;
        }
    }
}
