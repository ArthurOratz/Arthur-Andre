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

namespace Desafio_Agenda
{
    /// <summary>
    /// Interação lógica para MainWindow.xam
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void BtnContato_Click(object sender, RoutedEventArgs e)
        {
            WindowContatos windowContatos = new WindowContatos();
            windowContatos.Show();
        }

        private void BtnCompromisso_Click(object sender, RoutedEventArgs e)
        {
            WindowCompromissos windowCompromissos = new WindowCompromissos();
            windowCompromissos.Show();
        }

        private void BtnFinalizar_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
