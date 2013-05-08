using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CaixaEletronico.Domain;

namespace CaixaEletronico.Test
{
    /// <summary>
    /// Summary description for UnitTest1
    /// </summary>
    [TestClass]
    public class CaixaEletronicoFixture
    {
        [TestMethod]
        public void Ao_sacar_30_reais_entao_deve_retonar_uma_nota_de_20_e_uma_de_10()
        {
            var trintaReais = 30M;
            var caixaEletronico = new CaixaEletronico.Domain.CaixaEletronico();

            var notas = caixaEletronico.Sacar(trintaReais);

            Assert.IsTrue(notas.Contains(new Nota(1, NotaEnum.Dez)));
            Assert.IsTrue(notas.Contains(new Nota(1, NotaEnum.Vinte)));
        }

        [TestMethod]
        public void Ao_sacar_80_reais_entao_deve_retornar_uma_nota_de_50_uma_de_20_e_uma_de_10()
        {
            var oitentaReais = 80M;
            var caixaEletronico = new CaixaEletronico.Domain.CaixaEletronico();

            var notas = caixaEletronico.Sacar(oitentaReais);

            Assert.IsTrue(notas.Contains(new Nota(1, NotaEnum.Cinquenta)));
            Assert.IsTrue(notas.Contains(new Nota(1, NotaEnum.Vinte)));
            Assert.IsTrue(notas.Contains(new Nota(1, NotaEnum.Dez)));
        }
    }
}
