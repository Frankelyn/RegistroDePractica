using RegistroAnimes.Entidades;
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
using RegistroAnimes.BLL;

namespace RegistroAnimes.UI.Registros
{
    /// <summary>
    /// Interaction logic for rAnimes.xaml
    /// </summary>
    public partial class rAnimes : Window
    {
        public rAnimes()
        {
            InitializeComponent();
            this.DataContext = anime;
        }

        private Animes anime = new Animes();
        private void Limpiar()
        {
            this.anime = new Animes();
            this.DataContext = anime;
        }

        private bool validar()
        {
            bool esValido = true;

            if(nombreTextbox.Text.Length == 0)
            {
                esValido = false;
                MessageBox.Show("Transaccion Fallida", "Fallo", MessageBoxButton.OK, MessageBoxImage.Error);
            }

            return esValido;
        }

        private void BuscarButton_Click(object sender, RoutedEventArgs e)
        {
            var anime = AnimesBLL.Buscar(Utilidades.ToInt(AnimeIdTextbox.Text));

            if (anime != null)
                this.anime = anime;
            else
                this.anime = new Animes();

            this.DataContext = this.anime;
        }
        private void NuevoButton_Click(object sender, RoutedEventArgs e)
        {
            Limpiar();
        }

        private void GuardarButton_Click(object sender, RoutedEventArgs e)
        {
            if (!validar())
                return;

            var paso = AnimesBLL.Guardar(anime);
            
            if (paso)
            {
                Limpiar();
                MessageBox.Show("Transaccion exitosa!", "Exito", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else
            {
                MessageBox.Show("Transaccion Fallida!", "Fallo", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void EliminarButton_Click(object sender, RoutedEventArgs e)
        {
            if (AnimesBLL.Eliminar(Utilidades.ToInt(AnimeIdTextbox.Text)))
            {
                Limpiar();
                MessageBox.Show("Registro eliminado!", "Exito", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else
            {
                MessageBox.Show("No fue posible eliminar", "Fallo", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        
    }
}
