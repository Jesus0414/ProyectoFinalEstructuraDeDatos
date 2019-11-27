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
        ObservableCollection<SeriesPeliculas> seriesPeliculas = new ObservableCollection<SeriesPeliculas>();
        //ObservableCollection<Pelicula> pelicula = new ObservableCollection<Pelicula>();
        //ObservableCollection<Serie> serie = new ObservableCollection<Serie>();
        public MainWindow()
        {
            InitializeComponent();

            Serie serie1 = new Serie("Malcolm in the middle", 2000, "Comedia", 7, "Linwood Boomer",
                "La serie trata principalmente sobre un chico llamado Malcolm y su familia disfuncional.", 5);
            Serie serie2 = new Serie("Drake & Josh", 2004, "Comedia", 4, "Dan Schneider",
                "Drake Parker y Josh Nichols son adolescentes que viven en San Diego, California que se vuelven " +
                "hermanastros cuando la mamá de Drake, Audrey Parker, y el papá de Josh, Walter Nichols, se casan.", 4);
            Pelicula pelicula1 = new Pelicula("Whiplash", 2014, "Drama", "Damien Chazelle", "Andrew Neiman es un joven y " +
                "ambicioso baterista de jazz. Marcado por el fracaso de la carrera literaria de su " +
                "padre, está obsesionado con alcanzar la cima dentro del elitista conservatorio de música " +
                "de la Costa Este en el que estudia.", 5);
            Pelicula pelicula2 = new Pelicula("Taxi Driver", 1976, "Drama", " Martin Scorsese", "Un veterano de Vietnam inicia " +
                "una confrontación violenta con los proxenetas que trabajan en las calles de Nueva York.", 4);

            seriesPeliculas.Add(serie1);
            seriesPeliculas.Add(serie2);
            seriesPeliculas.Add(pelicula1);
            seriesPeliculas.Add(pelicula2);
            lstCartelera.ItemsSource = seriesPeliculas;

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
            /*lblAgregar.Visibility = Visibility.Visible;
            lblTipo.Visibility = Visibility.Visible;
            rbtnPelicula.Visibility = Visibility.Visible;
            rbtnSerie.Visibility = Visibility.Visible;*/

        }

        private void btnGuardaElementoNuevo_Click(object sender, RoutedEventArgs e)
        {
           
            var elementos = ((SeleccionTipo)(grdElemento.Children[0]));

            if (elementos.rbtnPelicula.IsChecked == true)
            {
                seriesPeliculas.Add(new Pelicula(elementos.txtTitulo.Text, Convert.ToInt32(elementos.txtAño.Text),
                    elementos.cmbGenero.Text, elementos.txtDirector.Text, elementos.txtSinopsis.Text,
                    Convert.ToInt32(elementos.cmbRating.Text)));
            }
            if (elementos.rbtnSerie.IsChecked == true)
            {
                seriesPeliculas.Add(new Serie(elementos.txtTitulo.Text, Convert.ToInt32(elementos.txtAño.Text),
                    elementos.cmbGenero.Text, Convert.ToInt32(elementos.cmbTemporadas.Text), elementos.txtProductor.Text, 
                    elementos.txtDescripcion.Text, Convert.ToInt32(elementos.cmbRating.Text)));
            }

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
            btnEliminarElemento.Visibility = Visibility.Hidden;
            btnHabilitarEdicion.Visibility = Visibility.Hidden;
            btnActualizarEdicion.Visibility = Visibility.Hidden;
        }

        private void lstCartelera_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (lstCartelera.SelectedIndex != -1)
            {
                grdElemento.Children.Clear();
                grdElemento.Children.Add(new Visualizar());
                btnNuevoElemento.Visibility = Visibility.Hidden;
                btnAscendenteTitulo.Visibility = Visibility.Hidden;
                btnDescendenteTitulo.Visibility = Visibility.Hidden;
                btnAscendenteAño.Visibility = Visibility.Hidden;
                btnDescendenteAño.Visibility = Visibility.Hidden;
                btnEliminarElemento.Visibility = Visibility.Visible;
                btnHabilitarEdicion.Visibility = Visibility.Visible;
                btnActualizarEdicion.Visibility = Visibility.Hidden;
                btnCancelarElementoNuevo.Visibility = Visibility.Visible;



                var elementosVisu = ((Visualizar)(grdElemento.Children[0]));
                var parametrosLista = seriesPeliculas[lstCartelera.SelectedIndex];
                if (parametrosLista.Tipo == "Pelicula") 
                {
                    elementosVisu.lblTipo.Text = parametrosLista.Tipo;
                    elementosVisu.txtTitulo.Text = parametrosLista.Titulo;
                    elementosVisu.txtAño.Text = parametrosLista.Año.ToString();
                    elementosVisu.txtDirector.Text = parametrosLista.Director;
                    elementosVisu.cmbGenero.Text = parametrosLista.Genero;
                    //Convert.ToInt32()
                    elementosVisu.txtSinopsis.Text = parametrosLista.Sinopsis;
                    elementosVisu.cmbRating.Text = parametrosLista.Rating.ToString();


                    if (parametrosLista.Rating == 1)
                    {
                        elementosVisu.Estrella1.Visibility = Visibility.Visible;
                    }
                    if (parametrosLista.Rating == 2)
                    {
                        elementosVisu.Estrella2.Visibility = Visibility.Visible;
                    }
                    if (parametrosLista.Rating == 3)
                    {
                        elementosVisu.Estrella3.Visibility = Visibility.Visible;
                    }
                    if (parametrosLista.Rating == 4)
                    {
                        elementosVisu.Estrella4.Visibility = Visibility.Visible;
                    }
                    if (parametrosLista.Rating == 5)
                    {
                        elementosVisu.Estrella5.Visibility = Visibility.Visible;
                    }

                    elementosVisu.txtTitulo.IsEnabled = false;
                    elementosVisu.txtAño.IsEnabled = false;
                    elementosVisu.txtDirector.IsEnabled = false;
                    elementosVisu.cmbGenero.IsEnabled = false;
                    elementosVisu.txtSinopsis.IsEnabled = false;
                    elementosVisu.cmbRating.IsEnabled = false;
                }
                if (parametrosLista.Tipo == "Serie")
                {
                    elementosVisu.lblTipo.Text = parametrosLista.Tipo;
                    elementosVisu.txtTitulo.Text = parametrosLista.Titulo;
                    elementosVisu.txtAño.Text = parametrosLista.Año.ToString();
                    elementosVisu.txtDirector.Visibility = Visibility.Hidden;
                    elementosVisu.lblDirector.Visibility = Visibility.Hidden;
                    elementosVisu.txtProductor.Visibility = Visibility.Visible;
                    elementosVisu.lblProductor.Visibility = Visibility.Visible;
                    elementosVisu.txtProductor.Text = parametrosLista.Productor;
                    elementosVisu.txtSinopsis.Visibility = Visibility.Hidden;
                    elementosVisu.lblSinopsis.Visibility = Visibility.Hidden;
                    elementosVisu.txtDescripcion.Visibility = Visibility.Visible;
                    elementosVisu.lblDescripcion.Visibility = Visibility.Visible;
                    elementosVisu.txtDescripcion.Text = parametrosLista.Descripcion;
                    elementosVisu.cmbTemporadas.Visibility = Visibility.Visible;
                    elementosVisu.lblTemporadas.Visibility = Visibility.Visible;
                    elementosVisu.cmbTemporadas.Text = parametrosLista.Temporada.ToString();
                    elementosVisu.cmbGenero.Text = parametrosLista.Genero;
                    elementosVisu.cmbRating.Text = parametrosLista.Rating.ToString();

                    if (parametrosLista.Rating == 1)
                    {
                        elementosVisu.Estrella1.Visibility = Visibility.Visible;
                    }
                    if (parametrosLista.Rating == 2)
                    {
                        elementosVisu.Estrella2.Visibility = Visibility.Visible;
                    }
                    if (parametrosLista.Rating == 3)
                    {
                        elementosVisu.Estrella3.Visibility = Visibility.Visible;
                    }
                    if (parametrosLista.Rating == 4)
                    {
                        elementosVisu.Estrella4.Visibility = Visibility.Visible;
                    }
                    if (parametrosLista.Rating == 5)
                    {
                        elementosVisu.Estrella5.Visibility = Visibility.Visible;
                    }
                    elementosVisu.txtTitulo.IsEnabled = false;
                    elementosVisu.txtAño.IsEnabled = false;
                    elementosVisu.txtProductor.IsEnabled = false;
                    elementosVisu.cmbGenero.IsEnabled = false;
                    elementosVisu.txtDescripcion.IsEnabled = false;
                    elementosVisu.cmbRating.IsEnabled = false;
                    elementosVisu.cmbTemporadas.IsEnabled = false;
                }

            }
        }

        private void btnAscendenteAño_Click(object sender, RoutedEventArgs e)
        {
            int gap, i;
            gap = seriesPeliculas.Count / 2;
            while (gap > 0)
            {
                for (i = 0; i < seriesPeliculas.Count; i++)
                {
                    if (gap + i < seriesPeliculas.Count && seriesPeliculas[i].Año > seriesPeliculas[gap + i].Año)
                    {
                        var temp = seriesPeliculas[i];
                        seriesPeliculas[i] = seriesPeliculas[gap + i];
                        seriesPeliculas[gap + i] = temp;
                    }
                }
                gap--;
            }
        }

        private void btnDescendenteAño_Click(object sender, RoutedEventArgs e)
        {
            int gap, i;
            gap = seriesPeliculas.Count / 2;
            while (gap > 0)
            {
                for (i = 0; i < seriesPeliculas.Count; i++)
                {
                    if (gap + i < seriesPeliculas.Count && seriesPeliculas[i].Año < seriesPeliculas[gap + i].Año)
                    {
                        var temp = seriesPeliculas[i];
                        seriesPeliculas[i] = seriesPeliculas[gap + i];
                        seriesPeliculas[gap + i] = temp;
                    }
                }
                gap--;
            }
        }

        private void btnAscendenteTitulo_Click(object sender, RoutedEventArgs e)
        {
            bool cambio;
            do
            {
                cambio = false;
                for (int i = 0; i < (seriesPeliculas.Count - 1); i++)
                {
                    if (string.Compare(seriesPeliculas[i].Titulo, seriesPeliculas[i + 1].Titulo) > 0)
                    {
                        var temp = seriesPeliculas[i];
                        seriesPeliculas[i] = seriesPeliculas[i + 1];
                        seriesPeliculas[i + 1] = temp;
                        cambio = true;
                    }
                }
            } while (cambio == true);
        }

        private void btnDescendenteTitulo_Click(object sender, RoutedEventArgs e)
        {
            bool cambio;
            do
            {
                cambio = false;
                for (int i = 0; i < (seriesPeliculas.Count - 1); i++)
                {
                    if (string.Compare(seriesPeliculas[i].Titulo, seriesPeliculas[i + 1].Titulo) < 0)
                    {
                        var temp = seriesPeliculas[i];
                        seriesPeliculas[i] = seriesPeliculas[i + 1];
                        seriesPeliculas[i + 1] = temp;
                        cambio = true;
                    }
                }
            } while (cambio == true);
        }

        private void btnEliminarElemento_Click(object sender, RoutedEventArgs e)
        {
            grdElemento.Children.Clear();
            btnNuevoElemento.Visibility = Visibility.Visible;
            btnAscendenteTitulo.Visibility = Visibility.Visible;
            btnDescendenteTitulo.Visibility = Visibility.Visible;
            btnAscendenteAño.Visibility = Visibility.Visible;
            btnDescendenteAño.Visibility = Visibility.Visible;
            btnGuardaElementoNuevo.Visibility = Visibility.Hidden;
            btnCancelarElementoNuevo.Visibility = Visibility.Hidden;
            btnHabilitarEdicion.Visibility = Visibility.Hidden;
            btnEliminarElemento.Visibility = Visibility.Hidden;
            btnActualizarEdicion.Visibility = Visibility.Hidden;

            if (lstCartelera.SelectedIndex != -1)
            {
                seriesPeliculas.RemoveAt(lstCartelera.SelectedIndex);
            }
        }

        private void btnHabilitarEdicion_Click(object sender, RoutedEventArgs e)
        {
            btnHabilitarEdicion.Visibility = Visibility.Hidden;
            btnActualizarEdicion.Visibility = Visibility.Visible;

            var elementosVisu = ((Visualizar)(grdElemento.Children[0]));

            elementosVisu.txtTitulo.IsEnabled = true;
            elementosVisu.txtAño.IsEnabled = true;
            elementosVisu.txtProductor.IsEnabled = true;
            elementosVisu.txtDirector.IsEnabled = true;
            elementosVisu.cmbGenero.IsEnabled = true;
            elementosVisu.txtDescripcion.IsEnabled = true;
            elementosVisu.txtSinopsis.IsEnabled = true;
            elementosVisu.cmbRating.IsEnabled = true;
            elementosVisu.cmbTemporadas.IsEnabled = true;
        }

        private void btnActualizarEdicion_Click(object sender, RoutedEventArgs e)
        {
            var elementosVisu = ((Visualizar)(grdElemento.Children[0]));
            var parametrosLista = seriesPeliculas[lstCartelera.SelectedIndex];

            parametrosLista.Titulo = elementosVisu.txtTitulo.Text;
            parametrosLista.Año = Convert.ToInt32(elementosVisu.txtAño.Text);
            parametrosLista.Productor = elementosVisu.txtProductor.Text;
            parametrosLista.Director = elementosVisu.txtDirector.Text;
            parametrosLista.Genero = elementosVisu.cmbGenero.Text;
            parametrosLista.Descripcion = elementosVisu.txtDescripcion.Text;
            parametrosLista.Sinopsis = elementosVisu.txtSinopsis.Text;
            parametrosLista.Rating = Convert.ToInt32(elementosVisu.cmbRating.Text);

            lstCartelera.Items.Refresh();

            elementosVisu.txtTitulo.IsEnabled = false;
            elementosVisu.txtAño.IsEnabled = false;
            elementosVisu.txtProductor.IsEnabled = false;
            elementosVisu.txtDirector.IsEnabled = false;
            elementosVisu.cmbGenero.IsEnabled = false;
            elementosVisu.txtDescripcion.IsEnabled = false;
            elementosVisu.txtSinopsis.IsEnabled = false;
            elementosVisu.cmbRating.IsEnabled = false;
            elementosVisu.cmbTemporadas.IsEnabled = false;
        }

        private void rbtnPelicula_Checked(object sender, RoutedEventArgs e)
        {
            grdElemento.Children.Clear();
            btnGuardaElementoNuevo.Visibility = Visibility.Visible;
        }

        private void rbtnSerie_Checked(object sender, RoutedEventArgs e)
        {
            grdElemento.Children.Clear();
            btnGuardaElementoNuevo.Visibility = Visibility.Visible;
        }
    }
}
