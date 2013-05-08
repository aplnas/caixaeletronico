using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CaixaEletronico.Domain
{
    public class CaixaEletronico
    {
        private List<NotaEnum> notasDisponiveis = new List<NotaEnum>();

        public CaixaEletronico()
        {
            notasDisponiveis.Add(NotaEnum.Cinquenta);
            notasDisponiveis.Add(NotaEnum.Vinte);
            notasDisponiveis.Add(NotaEnum.Dez);
        }


        public IEnumerable<Nota> Sacar(decimal valor)
        {
            long valorParaCalculo = (long)valor;

            foreach (var notaDisponivel in notasDisponiveis)
            {
                long quantidade;
                quantidade = Math.DivRem(valorParaCalculo, (int)notaDisponivel, out valorParaCalculo);

                yield return new Nota((int)quantidade, notaDisponivel);
            }
        }
    }
}
