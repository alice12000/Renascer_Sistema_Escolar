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
using CpfCnpjLibrary;
using System.Windows.Shapes;

namespace Sistema_Renascer.telas
{
    /// <summary>
    /// Lógica interna para Aluno.xaml
    /// </summary>
    public partial class Aluno : Window
    {
        public Aluno()
        {
            InitializeComponent();
        }


        private void Button_Click(object sender, RoutedEventArgs e)
        {//menu
            Dashboard d = new Dashboard();
            this.Close();
            d.Show();

        }
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {//aluno
        }
        private void Button_Click_2(object sender, RoutedEventArgs e)
        {//turma
            Turma t = new Turma();
            this.Close();
            t.Show();
        }
        private void Button_Click_3(object sender, RoutedEventArgs e)
        {//curso
            Curso c = new Curso();
            this.Close();
            c.Show();

        }
        private void Button_Click_4(object sender, RoutedEventArgs e)
        {//escolas
            Escola es = new Escola();
            this.Close();
            es.Show();
        }
        private void Button_Click_6(object sender, RoutedEventArgs e)
        {//exit
            Application.Current.Shutdown();
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {//cancelar
            name_txt.Text = " ";
            data_txt.Text = " ";
            cpf_txt.Text = " ";
            rg_txt.Text = " ";
            sexo_txt.Text = " ";
            email_txt.Text = " ";
            telefone_txt.Text = " ";
            endereço_txt.Text = " ";
            cpe_txt.Text = " ";

        }

        private void Button_Click_9(object sender, RoutedEventArgs e)
        {//cadastro
            try
            {

                bool validacaoCpf = Cpf.Validar(cpf_txt.Text);

                if (validacaoCpf == true)
                {
                    string nome = name_txt.Text;
                    DateTime data = Convert.ToDateTime(data_txt.Text);
                    string cpf = cpf_txt.Text;
                    int rg = Convert.ToInt32(rg_txt.Text);
                    string sexo = sexo_txt.Text;
                    string email = email_txt.Text;
                    string telefone = telefone_txt.Text;
                    string endereco = endereço_txt.Text;
                    int cpe = Convert.ToInt32(cpe_txt.Text);
                    MessageBox.Show("Cadastrado com sucesso");
                }
                else
                {
                    MessageBox.Show("Cpf inválido");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro" + ex.Message);
            }


        }

        private void Button_Click_10(object sender, RoutedEventArgs e)
        {
            Consulta_Aluno consa = new Consulta_Aluno();
            this.Close();
            consa.Show();
        }
    }
}
