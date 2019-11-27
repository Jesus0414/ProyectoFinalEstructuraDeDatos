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
            txtDirector.Visibility = Visibility.Visible;
            lblDirector.Visibility = Visibility.Visible;
            txtProductor.Visibility = Visibility.Hidden;
            lblProductor.Visibility = Visibility.Hidden;
            txtSinopsis.Visibility = Visibility.Visible;
            lblSinopsis.Visibility = Visibility.Visible;
            txtDescripcion.Visibility = Visibility.Hidden;
            lblDescripcion.Visibility = Visibility.Hidden;
            cmbTemporadas.Visibility = Visibility.Hidden;
            lblTemporadas.Visibility = Visibility.Hidden;
        }

        private void rbtnSerie_Checked(object sender, RoutedEventArgs e)
        {
            txtDirector.Visibility = Visibility.Hidden;
            lblDirector.Visibility = Visibility.Hidden;
            txtProductor.Visibility = Visibility.Visible;
            lblProductor.Visibility = Visibility.Visible;
            txtSinopsis.Visibility = Visibility.Hidden;
            lblSinopsis.Visibility = Visibility.Hidden;
            txtDescripcion.Visibility = Visibility.Visible;
            lblDescripcion.Visibility = Visibility.Visible;
            cmbTemporadas.Visibility = Visibility.Visible;
            lblTemporadas.Visibility = Visibility.Visible;
        }
    }
}
