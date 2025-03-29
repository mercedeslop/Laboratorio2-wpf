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

namespace Laboratorio2
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<profesor> profesores = new List<profesor>();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            List<profesor> profesores = new List<profesor>();
            profesores.Add(new profesor { Nombres = "Jennyfer", Apellidos = "Sapallanay" });
            profesores.Add(new profesor { Nombres = "Sindell", Apellidos = "Perez" });

            dgProfesores.ItemsSource = profesores;

         
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            List<curso> cursos = new List<curso>();
            cursos.Add(new curso { nombre = "Programacion", profesor = "Jennyfer", horas = 20 });
            cursos.Add(new curso { nombre = "Base de Datos", profesor = "Sindell", horas = 30 });
            dgCursos.ItemsSource = cursos;
            
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            
            profesores.Add(new profesor { 
                Nombres = txtNombres.Text,
                Apellidos = txtApellidos.Text
            });
            dgProfesores.ItemsSource = null;
            dgProfesores.ItemsSource = profesores;
            
        }
    }
}
