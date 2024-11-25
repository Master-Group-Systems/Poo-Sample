using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Polimorfismo.clases;

namespace Polimorfismo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            DEBUG.AppendText($"Debug Iniciado.\n\n");
            
            List<Produto> estoque = new()
            {
                //Polimorfismo por inclusão
            new MouseX("Mouse Logitech", 10),
                //Polimorfismo por inclusão
            new TecladoX("Teclado Mecânico", 5)
            };

            foreach (var produto in estoque)
            {
                //Polimorfismo
                produto.ExibirDetalhes(DEBUG);
            }

        }

    }
}