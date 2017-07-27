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
    /// Interaction logic for AdmWindow.xaml
    /// </summary>
    public partial class AdmWindow : Window
    {
        Negocio.Livros nl = new Negocio.Livros();

        public AdmWindow()
        {
            InitializeComponent();
            list.ItemsSource = nl.Selecionar();
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            UsuarioWindow win = new UsuarioWindow();
            win.ShowDialog();
        }

        private void MenuItem_Click_1(object sender, RoutedEventArgs e)
        {
            LivrosWindow win = new LivrosWindow();
            win.ShowDialog();
        }

        private void AtualizarClick(object sender, RoutedEventArgs e)
        {
            list.ItemsSource = nl.Selecionar();
        }

        private void logClick(object sender, RoutedEventArgs e)
        {
            LogWindow win = new LogWindow();
            win.ShowDialog();
        }
    }
}
