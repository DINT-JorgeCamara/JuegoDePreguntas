using Microsoft.Toolkit.Mvvm.ComponentModel;
using System.Collections.ObjectModel;

namespace JuegoDePreguntas.Clases
{
    class Partida : ObservableObject
    {
        private ObservableCollection<Pregunta> preguntas; 
        private ObservableCollection<Pregunta> Preguntas
        {
            get { return preguntas; }
            set { SetProperty(ref preguntas, value); }
        }

    }
}
