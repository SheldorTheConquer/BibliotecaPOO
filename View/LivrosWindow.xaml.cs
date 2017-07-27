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
using System.Text.RegularExpressions;

namespace View
{
    /// <summary>
    /// Interaction logic for LivrosWindow.xaml
    /// </summary>
    public partial class LivrosWindow : Window
    {

        Negocio.Livros nl = new Negocio.Livros();
        Modelo.Livros ml = new Modelo.Livros();

        public LivrosWindow()
        {
            InitializeComponent();
            list.ItemsSource = nl.Selecionar();
        }

        private void NumberValidationTextBox(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }

        private void InserirClick(object sender, RoutedEventArgs e)
        {
            int IDultimo;

            try
            {
                if (nl.Selecionar().Count() == 0)
                {
                    IDultimo = 0;
                }
                else
                {
                    IDultimo = nl.Selecionar().OrderBy(user => user.Id).OrderByDescending(x => x.Id).Take(1).Single().Id;
                }

                ml.titulo = txtTitulo.Text;
                ml.editora = txtEditora.Text;
                ml.Id = IDultimo + 1;
                ml.unidades = int.Parse(txtUni.Text);
                nl.Inserir(ml);
               
                list.ItemsSource = nl.Selecionar();

                MessageBox.Show("LIVRO CADASTRADO!");
            }
            catch (ArgumentNullException)
            {
                MessageBox.Show("DADOS INVALIDOS!");
            }
            catch (InvalidOperationException)
            {
                MessageBox.Show("LIVRO JÁ CADASTRADO!");
            }
            
        }

        private void AtualizarClick(object sender, RoutedEventArgs e)
        {
            ml.Id = int.Parse(txtId.Text);
            ml.unidades = int.Parse(txtUni.Text);
            ml.titulo = txtTitulo.Text;
            ml.editora = txtEditora.Text;
            nl.Atualizar(ml);
            list.ItemsSource = nl.Selecionar();
        }

        private void RemoverClick(object sender, RoutedEventArgs e)
        {
            ml.Id = int.Parse(txtId.Text);
            nl.Deletar(ml);
            list.ItemsSource = nl.Selecionar();
        }
    }
}
