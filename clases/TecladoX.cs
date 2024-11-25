using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Polimorfismo.clases
{
    public class TecladoX : Produto
    {
        public TecladoX(string nome, int quantidade) : base(nome, quantidade)
        {
        }

        //Polimorfismo
        public override void ExibirDetalhes(RichTextBox DEBUG)
        {
            DEBUG.AppendText($"Produto: Teclado, Nome: {Nome}, Quantidade: {Quantidade}\n");
        }
    }

}
