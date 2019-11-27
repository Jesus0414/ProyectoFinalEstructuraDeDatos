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
using System.Collections.ObjectModel;

namespace ProyectoTercerSem
{
    /// <summary>
    /// Lógica de interacción para SeleccionTipo.xaml
    /// </summary>
    public partial class SeleccionTipo : UserControl
    {
        public SeleccionTipo()
        {
            InitializeComponent();
            rbtnPelicula.IsChecked = true;
            //grdSeleccionTipo.Children.Add(new Peliculas());
        }

        private void rbtnPelicula_Checked(object sender, RoutedEventArgs e)
        {
            //grdSeleccionTipo.Children.Clear();
            //grdSeleccionTipo.Children.Add(new Peliculas());
        }

        private void rbtnSerie_Checked(object sender, RoutedEventArgs e)
        {
            //grdSeleccionTipo.Children.Clear();
            //grdSeleccionTipo.Children.Add(new Series());
        }
    }
}
