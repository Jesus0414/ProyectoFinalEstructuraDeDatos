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
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ObservableCollection<Serie> serie = new ObservableCollection<Serie>();
        ObservableCollection<Pelicula> pelicula = new ObservableCollection<Pelicula>();
        public MainWindow()
        {
            InitializeComponent();

            serie.Add(new Serie("Malcolm in the middle", 2000, "Comedia", 7, "Linwood Boomer", 
                "La serie trata principalmente sobre un chico llamado Malcolm y su familia disfuncional.", 5));
            pelicula.Add(new Pelicula("Whiplash", 2014, "Drama", "Damien Chazelle", "Andrew Neiman es un joven y " +
                "ambicioso baterista de jazz. Marcado por el fracaso de la carrera literaria de su " +
                "padre, está obsesionado con alcanzar la cima dentro del elitista conservatorio de música " +
                "de la Costa Este en el que estudia.", 5));

            //serie.Add(new Serie());
            //pelicula.Add(new Pelicula());
            lstCartelera.ItemsSource = serie;
            lstCartelera.ItemsSource = pelicula;

        }

        private void btnNuevoElemento_Click(object sender, RoutedEventArgs e)
        {
            grdElemento.Children.Clear();
            grdElemento.Children.Add(new SeleccionTipo());
            btnAscendenteTitulo.Visibility = Visibility.Hidden;
            btnDescendenteTitulo.Visibility = Visibility.Hidden;
            btnAscendenteAño.Visibility = Visibility.Hidden;
            btnDescendenteAño.Visibility = Visibility.Hidden;
            btnGuardaElementoNuevo.Visibility = Visibility.Visible;
            btnCancelarElementoNuevo.Visibility = Visibility.Visible;
        }

        private void btnGuardaElementoNuevo_Click(object sender, RoutedEventArgs e)
        {
            grdElemento.Children.Clear();
            btnAscendenteTitulo.Visibility = Visibility.Visible;
            btnDescendenteTitulo.Visibility = Visibility.Visible;
            btnAscendenteAño.Visibility = Visibility.Visible;
            btnDescendenteAño.Visibility = Visibility.Visible;
            btnGuardaElementoNuevo.Visibility = Visibility.Hidden;
            btnCancelarElementoNuevo.Visibility = Visibility.Hidden;
        }

        private void btnCancelarElementoNuevo_Click(object sender, RoutedEventArgs e)
        {
            grdElemento.Children.Clear();
            btnAscendenteTitulo.Visibility = Visibility.Visible;
            btnDescendenteTitulo.Visibility = Visibility.Visible;
            btnAscendenteAño.Visibility = Visibility.Visible;
            btnDescendenteAño.Visibility = Visibility.Visible;
            btnGuardaElementoNuevo.Visibility = Visibility.Hidden;
            btnCancelarElementoNuevo.Visibility = Visibility.Hidden;
        }
    }
}
