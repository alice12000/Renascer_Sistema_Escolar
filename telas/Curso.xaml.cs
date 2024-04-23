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
    /// Lógica interna para Curso.xaml
    /// </summary>
    public partial class Curso : Window
    {
        public Curso()
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
            Aluno a = new Aluno();
            this.Close();
            a.Show();
        }
        private void Button_Click_2(object sender, RoutedEventArgs e)
        {//turma
            Turma t = new Turma();
            this.Close();
            t.Show();
        }
        private void Button_Click_3(object sender, RoutedEventArgs e)
        {//curso

        }
        private void Button_Click_4(object sender, RoutedEventArgs e)
        {//escolas
            Escola es = new Escola();
            this.Close();
            es.Show();
        }
        private void Button_Click_5(object sender, RoutedEventArgs e)
        {//relatorios

        }
        private void Button_Click_6(object sender, RoutedEventArgs e)
        {//exit
            Application.Current.Shutdown();

        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {//consulta de curso
            Consulta_Curso consc = new Consulta_Curso();
            this.Close();
            consc.Show();

        }

        private void Button_Click_8(object sender, RoutedEventArgs e)
        {//cancelar
            name_txt.Text = " ";
            codigo_txt.Text = " ";
            desc_txt.Text = " ";
            coordenador_txt.Text = " ";
            situacao_cbx.SelectedItem = null;
        }

        private void Button_Click_9(object sender, RoutedEventArgs e)
        {//cadastrar
            try
            {
                string name = name_txt.Text;
                int codigo = Convert.ToInt32(codigo_txt.Text);
                string descricao = desc_txt.Text;
                string coordenador = coordenador_txt.Text;
                string situacao = situacao_cbx.Text;
                bool ativo;
                if(situacao == "Sim")
                {
                    ativo = true;
                }
                else
                {
                    ativo = false;
                }

                MessageBox.Show("Cadastrado com sucesso");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro" + ex.Message);
            }

        }

        private void situacao_cbx_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
