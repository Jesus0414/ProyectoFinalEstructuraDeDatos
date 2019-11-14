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
            serie.Add(new Serie("Drake & Josh", 2004, "Comedia", 4, "Dan Schneider",
                "Drake Parker y Josh Nichols son adolescentes que viven en San Diego, California que se vuelven " +
                "hermanastros cuando la mamá de Drake, Audrey Parker, y el papá de Josh, Walter Nichols, se casan.", 4));
            pelicula.Add(new Pelicula("Whiplash", 2014, "Drama", "Damien Chazelle", "Andrew Neiman es un joven y " +
                "ambicioso baterista de jazz. Marcado por el fracaso de la carrera literaria de su " +
                "padre, está obsesionado con alcanzar la cima dentro del elitista conservatorio de música " +
                "de la Costa Este en el que estudia.", 5));
            pelicula.Add(new Pelicula("Taxi Driver", 1976, "Drama", " Martin Scorsese", "Un veterano de Vietnam inicia " +
                "una confrontación violenta con los proxenetas que trabajan en las calles de Nueva York.", 4));

            //serie.Add(new Serie());
            //pelicula.Add(new Pelicula());
            lstCartelera.ItemsSource = serie;
            lstCartelera.ItemsSource = pelicula;

        }

        private void btnNuevoElemento_Click(object sender, RoutedEventArgs e)
        {
            grdElemento.Children.Clear();
            grdElemento.Children.Add(new SeleccionTipo());
            btnNuevoElemento.Visibility = Visibility.Hidden;
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
            btnNuevoElemento.Visibility = Visibility.Visible;
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
            btnNuevoElemento.Visibility = Visibility.Visible;
            btnAscendenteTitulo.Visibility = Visibility.Visible;
            btnDescendenteTitulo.Visibility = Visibility.Visible;
            btnAscendenteAño.Visibility = Visibility.Visible;
            btnDescendenteAño.Visibility = Visibility.Visible;
            btnGuardaElementoNuevo.Visibility = Visibility.Hidden;
            btnCancelarElementoNuevo.Visibility = Visibility.Hidden;
        }

        private void lstCartelera_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (lstCartelera.SelectedIndex != -1)
            {
                grdElemento.Children.Clear();
                grdElemento.Children.Add(new SeleccionTipo());
                /*txtNombreEditar.Text = pelicula[lstCartelera.SelectedIndex].Nombre;
                txtHexadecimalEditar.Text = pelicula[lstCartelera.SelectedIndex].Hexadecimal;
                txtRGBEditar.Text = pelicula[lstCartelera.SelectedIndex].RGB;*/
            }
        }
    }
}
