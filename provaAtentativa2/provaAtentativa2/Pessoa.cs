using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace provaAtentativa2
{
    public class Pessoa
    {
        public string nome;
        public int cpf;
        public double saldo;

        public Pessoa(string nome, int cpf, double saldo)
        {
            this.nome = nome;
            this.cpf = cpf;
            this.saldo = saldo;
            
        }
    }
}
