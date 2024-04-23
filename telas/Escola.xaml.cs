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
using CpfCnpjLibrary;

namespace Sistema_Renascer.telas
{
    /// <summary>
    /// Lógica interna para Escola.xaml
    /// </summary>
    public partial class Escola : Window
    {
        public Escola()
        {
            InitializeComponent();
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {//botao cadastrar
            try
            {
                bool validacaoCnpj = Cnpj.Validar(cnpj_txt.Text);
                if (validacaoCnpj == true)
                {
                    string nomeFantasia = nome_fantasia_txt.Text;
                    string cnpj = cnpj_txt.Text;
                    string razaoSocial = razao_social_txt.Text;
                    string endereco = endereco_txt.Text;
                    string estado = estado_txt.Text;
                    string cidade = cidade_txt.Text;
                    MessageBox.Show("Cadastrado com sucesso");
                }
                else
                {
                    MessageBox.Show("Cnpj inválido");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro" + ex.Message);
            }

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {//cancelar
            nome_fantasia_txt.Text = " ";
            cnpj_txt.Text = " ";
            razao_social_txt.Text = " ";
            endereco_txt.Text = " ";
            estado_txt.Text = " ";
            cidade_txt.Text = " ";
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {//consulta de escola
            Consulta_Escola conse = new Consulta_Escola();
            this.Close();
            conse.Show();

        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            Dashboard d = new Dashboard();
            this.Close();
            d.Show();
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            Aluno a = new Aluno();
            this.Close();
            a.Show();
        }
        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            Turma t = new Turma();
            this.Close();
            t.Show();

        }
        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            Curso c = new Curso();
            this.Close();
            c.Show();
        }
        private void Button_Click_7(object sender, RoutedEventArgs e)
        {

        }
        private void Button_Click_8(object sender, RoutedEventArgs e)
        {//relatorios

        }
        private void Button_Click_9(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

    }
}
