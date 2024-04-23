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
using System.Xml.Linq;

namespace Sistema_Renascer.telas
{
    /// <summary>
    /// Lógica interna para Login.xaml
    /// </summary>
    public partial class Login : Window
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {//entrar
            try
            {
                string name = user_txt.Text;
                string password = password_txt.Text;

                /*
                if (string.IsNullOrEmpty(name) && string.IsNullOrEmpty(password))
                {
                    if(name != null)
                    {
                        if(password != null)
                        {
                            MessageBox.Show("Bem-vindo");
                        }
                    }
                }
                
                else
                {
                
                }
           */
                MessageBox.Show("Bem-vindo ao sistema");
                Dashboard d = new Dashboard();
                this.Close();
                d.Show();
            }

            catch(Exception ex)
            {
                MessageBox.Show("Ocorreu um erro" + ex.Message);
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {//cancelar
            user_txt.Text = " ";
            password_txt.Text = " ";
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {//criar conta
            Cadastro c = new Cadastro();
            this.Show();
            c.Show();

        }
    }
}
