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
    /// Lógica interna para Turma.xaml
    /// </summary>
    public partial class Turma : Window
    {
        public Turma()
        {
            InitializeComponent();
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {//menu
            Dashboard d = new Dashboard();
            this.Close();
            d.Show();

        }
        private void Button_Click_2(object sender, RoutedEventArgs e)
        {//alunos
            Aluno a = new Aluno();
            this.Close();
            a.Show();
        }
        private void Button_Click_3(object sender, RoutedEventArgs e)
        {//turma
            Turma t = new Turma();
            this.Close();

        }
        private void Button_Click_4(object sender, RoutedEventArgs e)
        {   //curso
            Curso c = new Curso();
            this.Close();
            c.Show();
        }
        private void Button_Click_5(object sender, RoutedEventArgs e)
        {//escolas
            Escola es = new Escola();
            this.Close();
            es.Show();

        }
        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            //relatorios
        }
        private void Button_Click_7(object sender, RoutedEventArgs e)
        {//exit
            Application.Current.Shutdown();
        }
        private void Button_Click_8(object sender, RoutedEventArgs e)
        {//consultar
            Consulta_Turma ct = new Consulta_Turma();
            this.Close();
            ct.Show();
        }

        private void Button_Click_9(object sender, RoutedEventArgs e)
        {//cadastro
            try
            {
                string sigla = sigla_txt.Text;
                int qtde = Convert.ToInt32(vagas_txt.Text);
                string situacao = situacao_cbx.Text;
                int ano = Convert.ToInt32(ano_txt.Text);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Ocorreu um erro");
            }
          
        }

        private void Button_Click_10(object sender, RoutedEventArgs e)
        {
            
        }
    }
}
