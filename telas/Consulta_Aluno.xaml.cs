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
    /// Lógica interna para Consulta_Aluno.xaml
    /// </summary>
    public partial class Consulta_Aluno : Window
    {
        public Consulta_Aluno()
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
    }
}
