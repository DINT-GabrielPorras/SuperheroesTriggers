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

namespace Superheroes
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Superheroe> listaHeroes;
        int contador = 0;
        public MainWindow()
        {
            InitializeComponent();

            listaHeroes = Superheroe.GetSamples();

            dockPanelPrincipal.DataContext = listaHeroes.FirstOrDefault();
        }

        public void FlechaDerecha_MouseLeftButtonDown(Object sender, EventArgs e)
        {
            if (contador > 0)
                contador--;

            dockPanelPrincipal.DataContext = listaHeroes[contador];

            CambiaNumeros(contador);
        }

        public void FlechaIzquierda_MouseLeftButtonDown(Object sender, EventArgs e)
        {
            if(contador < 2)
                contador++;

            dockPanelPrincipal.DataContext = listaHeroes[contador];

            CambiaNumeros(contador);
        }

        public void CambiaNumeros(int contador)
        {
            if (contador == 0)
            {
                numeros.Text = "1/3";              
            }
                
            if (contador == 1)
            {
                numeros.Text = "2/3";              
            }
                
            if (contador == 2)
            {
                numeros.Text = "3/3";                
            }               
        }
    }
}
