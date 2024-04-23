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
    /// Lógica interna para Dashboard.xaml
    /// </summary>
    public partial class Dashboard : Window
    {
        public Dashboard()
        {
            InitializeComponent();
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {

            Aluno a = new Aluno();
            this.Close();
            a.Show();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Curso c = new Curso();
            this.Close();
            c.Show();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            Turma t = new Turma();
            this.Close();
            t.Show();
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            Escola es = new Escola();
            this.Close();
            es.Show();
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}
