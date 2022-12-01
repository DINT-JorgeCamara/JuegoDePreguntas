using System.Windows;

namespace JuegoDePreguntas
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        MainWindowVM vm = new MainWindowVM();
        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = vm;

        }
        //C:/Users/alumno/Pictures/Saved Pictures/robetpatinsonuwu.png
        private void LimpiaFormulario_BtnClick(object sender, RoutedEventArgs e)
        {
            vm.LimpiaFormulario_BtnClick();
        }

        private void ExaminarImagen_BtnClick(object sender, RoutedEventArgs e)
        {
            vm.ExaminarImagen();
        }

        private void AñadirPregunta_BtnClick(object sender, RoutedEventArgs e)
        {
            vm.AñadirPregunta();
        }
    }
}
