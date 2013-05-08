using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CaixaEletronico.Domain
{
    public enum NotaEnum
    {
        Dez = 10,
        Vinte = 20,
        Cinquenta = 50
    }

    public class Nota
    {
        private int quantidade;
        private NotaEnum valor;

        public Nota(int quantidade, NotaEnum valor)
        {
            this.quantidade = quantidade;
            this.valor = valor;
        }

        public int Quantidade { get { return quantidade; } }
        public NotaEnum Valor { get { return valor; } }

        public override bool Equals(object obj)
        {
            var that = obj as Nota;

            if (that == null)
                return false;

            return this.quantidade == that.quantidade && this.valor == that.valor;
        }
    }
}
