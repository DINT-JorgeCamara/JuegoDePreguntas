using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
