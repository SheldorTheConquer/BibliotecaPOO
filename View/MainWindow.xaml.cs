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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace View
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Negocio.Usuario nu = new Negocio.Usuario();
        Modelo.Log mlo = new Modelo.Log();
        Negocio.Log nlo = new Negocio.Log();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int IDultimo;
            var w = Application.Current.Windows[0];
            string login = loginTxt.Text;
            string senha = Persistencia.Crip.criptografarSenha(passTxt.Password.ToString());



            if (loginTxt.Text == "admin" && passTxt.Password == "admin")
            {

                AdmWindow win = new AdmWindow();
                w.Hide();
                win.ShowDialog();
            } else if (nu.Selecionar().Where(p => p.login == login && p.senha == senha).Count() > 0)
            {
                if (nlo.Selecionar().Count() == 0)
                {
                    IDultimo = 0;
                }
                else
                {
                    IDultimo = nlo.Selecionar().OrderBy(user => user.Id).OrderByDescending(x => x.Id).Take(1).Single().Id;
                }

                mlo.usuario = login;
                mlo.Id = IDultimo + 1;
                mlo.data = DateTime.Now;
                nlo.Inserir(mlo);

                NormalWindow win = new NormalWindow();
                w.Hide();
                win.ShowDialog();
            } else
            {
                MessageBox.Show("USUARIO NÃO CADASTRADO!");
            }
        }
    }
}
