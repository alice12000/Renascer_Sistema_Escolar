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

namespace Sistema_Renascer.telas
{
    /// <summary>
    /// Lógica interna para Cadastro.xaml
    /// </summary>
    public partial class Cadastro : Window
    {
        public Cadastro()
        {
            InitializeComponent();
        }

        private void Button_Click_9(object sender, RoutedEventArgs e)
        {//cadastro
            try
            {
                string nome = userName_txt.Text;
                string email = email_txt.Text;
                string senha = password_txt.Text;
                string EnterSenha = enter_password_txt.Text;

                if(senha == EnterSenha)
                {
                    MessageBox.Show("Bem-vindo ao sistema");
                    Dashboard d = new Dashboard();
                    this.Close();
                    d.Show();
                }
                else
                {
                    MessageBox.Show("Senhas incompativeis");
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show("Ocorreu um erro" + ex.Message);
            }
        }
    }
}
