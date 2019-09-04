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

namespace Desafio_Agenda
{
    /// <summary>
    /// Lógica interna para WindowCompromissos.xaml
    /// </summary>
    public partial class WindowCompromissos : Window
    {
        public ViewModel.ViewModelContatos ModelContatos { get; set; }

        public WindowCompromissos()
        {
            InitializeComponent();
            this.ModelContatos = new ViewModel.ViewModelContatos();
            this.DataContext = this;
        }

        private void BtnAdicionar_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnRemover_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnSalvar_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnCancelar_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void BtnAdicionarPessoa_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
