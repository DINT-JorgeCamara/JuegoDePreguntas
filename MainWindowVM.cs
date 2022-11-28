using JuegoDePreguntas.Clases;
using Microsoft.Toolkit.Mvvm.ComponentModel;
using Newtonsoft.Json;
using System.Collections.ObjectModel;
using Microsoft.Win32;
using System.IO;

namespace JuegoDePreguntas
{
    class MainWindowVM : ObservableObject
    {
        private ObservableCollection<Pregunta> preguntas;
        private ObservableCollection<Pregunta> Preguntas
        {
            get { return preguntas; }
            set { SetProperty(ref preguntas, value); }
        }

        private Pregunta preguntaSeleccionada;
        private Pregunta PreguntaSeleccionada
        {
            get { return preguntaSeleccionada; }
            set { SetProperty(ref preguntaSeleccionada, value); }
        }

        private Pregunta nuevaPregunta;
        private Pregunta NuevaPregunta
        {
            get { return nuevaPregunta; }
            set { SetProperty(ref nuevaPregunta, value); }
        }

        public MainWindowVM()
        {
            Preguntas = new ObservableCollection<Pregunta>();
            PreguntaSeleccionada = new Pregunta();
            NuevaPregunta = new Pregunta();
        }
        public void LimpiaFormulario_BtnClick()
        {
            nuevaPregunta = null;
        }
        public void Examinar_BtnClick()
        {
            string preguntaFichero;
            Microsoft.Win32.OpenFileDialog openFileDialog = new Microsoft.Win32.OpenFileDialog();
            if (openFileDialog.ShowDialog() == true)
            {
                preguntaFichero = File.ReadAllText(openFileDialog.FileName);
                NuevaPregunta = JsonConvert.DeserializeObject<Pregunta>(preguntaFichero);
            }
                

        }
        public void AñadirPregunta_BtnClick()
        {
            string preguntaJson = JsonConvert.SerializeObject(NuevaPregunta);

            Microsoft.Win32.SaveFileDialog saveFileDialog = new Microsoft.Win32.SaveFileDialog();
            if (saveFileDialog.ShowDialog() == true)
                File.WriteAllText(saveFileDialog.FileName, preguntaJson);
        }
    }
}
