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

    }
}
