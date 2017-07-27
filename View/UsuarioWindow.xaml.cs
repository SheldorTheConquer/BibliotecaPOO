using System.Windows;
using System.Linq;
using System;
using System.Text.RegularExpressions;
using System.Windows.Input;

namespace View
{
    /// <summary>
    /// Interaction logic for UsuarioWindow.xaml
    /// </summary>
    public partial class UsuarioWindow : Window
    {
        Negocio.Usuario nu = new Negocio.Usuario();
        Modelo.Usuario mu = new Modelo.Usuario();

        

        public UsuarioWindow()
        {
            InitializeComponent();
            userList.ItemsSource = nu.Selecionar();
        }

        private void NumberValidationTextBox(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }

        private void CadastrarClick(object sender, RoutedEventArgs e)
        {
            int IDultimo;

            try
            {
                if(nu.Selecionar().Count() == 0)
                {
                    IDultimo = 0;   
                } else
                {
                    IDultimo = nu.Selecionar().OrderBy(user => user.Id).OrderByDescending(x => x.Id).Take(1).Single().Id;
                }

                mu.login = login.Text;
                mu.senha = Persistencia.Crip.criptografarSenha(senha.Password);
                mu.Id = IDultimo + 1;
                nu.Inserir(mu);

                login.Text = "";
                senha.Password = "";

                userList.ItemsSource = nu.Selecionar();

                MessageBox.Show("USUARIO CADASTRADO!");
            }
            catch (ArgumentNullException)
            {
                MessageBox.Show("DADOS NÃO INFORMADOS!");
            }
           /* catch (InvalidOperationException)
            {
                MessageBox.Show("USUARIO JÁ CADASTRADO!");
            }*/
        }

        private void RemoverClick(object sender, RoutedEventArgs e)
        {
            mu.Id = int.Parse(txtId.Text);
            nu.Deletar(mu);
            userList.ItemsSource = nu.Selecionar();
        }
    }
}
