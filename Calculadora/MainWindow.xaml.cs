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

namespace Calculadora
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            capturaNumero(1);
        }
        int numero1= 0;
        int numero2 = 0;
        double resultado = 0;

        private void Button_Click_Mas(object sender, RoutedEventArgs e)
        {
            pantalla.Text = pantalla.Text + "+";
            
        }
        private void Button_Click_Menos(object sender, RoutedEventArgs e)
        {
            pantalla.Text = pantalla.Text + "-";

        }
        private void Button_Click_Multi(object sender, RoutedEventArgs e)
        {
            pantalla.Text = pantalla.Text + "*";

        }
        private void Button_Click_Div(object sender, RoutedEventArgs e)
        {
            pantalla.Text = pantalla.Text + "/";

        }

        private void Button_Click_Igual(object sender, RoutedEventArgs e)
        {
            char operador = ' ';

            if (pantalla.Text.Contains("+"))
                operador = '+';
            else if (pantalla.Text.Contains("-"))
                operador = '-';
            else if (pantalla.Text.Contains('*'))
                operador = '*';
            else if (pantalla.Text.Contains('/'))
                operador = '/';

            string[] partes = pantalla.Text.Split(operador);
            numero1= int.Parse(partes[0]);
            numero2 = int.Parse(partes[1]);

            switch (operador) 
            {
                case '+':
                    resultado = numero1 + numero2;
                 break;
                case '-':
                    resultado = numero1 - numero2;
                break;
                case '*':
                    resultado = numero1 * numero2;
                break;
                case '/':
                    resultado = (double)numero1 / numero2;
                break;
            }

            pantalla.Text= resultado.ToString();
        }

        private void capturaNumero(int numero)
        {
            if (pantalla.Text.Length == 0)
                pantalla.Text = numero.ToString();
            else
                pantalla.Text = pantalla.Text + numero.ToString();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            capturaNumero(2);
        }
        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            capturaNumero(3);
        }
        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            capturaNumero(4);
        }
        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            capturaNumero(5);
        }
        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            capturaNumero(6);
        }
        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            capturaNumero(7);
        }
        private void Button_Click_8(object sender, RoutedEventArgs e)
        {
            capturaNumero(8);
        }
        private void Button_Click_9(object sender, RoutedEventArgs e)
        {
            capturaNumero(9);
        }
    }
}
