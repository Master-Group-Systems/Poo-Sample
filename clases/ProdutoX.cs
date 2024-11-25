using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Polimorfismo.clases
{
    public abstract class Produto
    {
        public string Nome { get; set; }
        public int Quantidade { get; set; }

        public Produto(string nome, int quantidade)
        {
            Nome = nome;
            Quantidade = quantidade;
        }

        //Metodo base do Polimorfismo
        public abstract void ExibirDetalhes(RichTextBox DEBUG);
    }

}
