using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace View
{
    /// <summary>
    /// Interaction logic for NormalWindow.xaml
    /// </summary>
    public partial class NormalWindow : Window
    {
        Negocio.Livros nl = new Negocio.Livros();

        public NormalWindow()
        {
            InitializeComponent();
            list.ItemsSource = nl.Selecionar();
        }

        /*private void AtualizarClick(object sender, RoutedEventArgs e)
        {
            list.ItemsSource = nl.Selecionar();
        }*/
    }
}
