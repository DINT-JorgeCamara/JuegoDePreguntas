using JuegoDePreguntas.Clases;
using Microsoft.Toolkit.Mvvm.ComponentModel;
using Newtonsoft.Json;
using System.Collections.ObjectModel;
using Microsoft.Win32;
using System.IO;
using System;

namespace JuegoDePreguntas
{
    class MainWindowVM : ObservableObject
    {
        private ObservableCollection<Pregunta> preguntas;
        public ObservableCollection<Pregunta> Preguntas
        {
            get { return preguntas; }
            set { SetProperty(ref preguntas, value); }
        }

        private ObservableCollection<String> categorias;
        public ObservableCollection<String> Categorias
        {
            get { return categorias; }
            set { SetProperty(ref categorias, value); }
        }

        private ObservableCollection<String> dificultad;
        public ObservableCollection<String> Dificultades
        {
            get { return dificultad; }
            set { SetProperty(ref dificultad, value); }
        }

        private Pregunta preguntaSeleccionada;
        public Pregunta PreguntaSeleccionada
        {
            get { return preguntaSeleccionada; }
            set { SetProperty(ref preguntaSeleccionada, value); }
        }

        private Pregunta nuevaPregunta;
        public Pregunta NuevaPregunta
        {
            get { return nuevaPregunta; }
            set { SetProperty(ref nuevaPregunta, value); }
        }

        public MainWindowVM()
        {
            Preguntas = new ObservableCollection<Pregunta>();
            PreguntaSeleccionada = new Pregunta();
            NuevaPregunta = new Pregunta();

            Categorias = new ObservableCollection<string>();
            Categorias.Add("Series");
            Categorias.Add("Videojuegos");
            Categorias.Add("Películas");
            Categorias.Add("Geografía");

            Dificultades = new ObservableCollection<string>();
            Dificultades.Add("Fácil");
            Dificultades.Add("Medio");
            Dificultades.Add("Difícil");
        }
        public void LimpiaFormulario_BtnClick()
        {
            nuevaPregunta = null;
        }
        public void ExaminarImagen()
        {
            NuevaPregunta.Imagen = Servicios.ServicioDialogo.ExaminarImagen();
            /*
            string preguntaFichero;
            Microsoft.Win32.OpenFileDialog openFileDialog = new Microsoft.Win32.OpenFileDialog();
            if (openFileDialog.ShowDialog() == true)
            {
                preguntaFichero = File.ReadAllText(openFileDialog.FileName);
                NuevaPregunta = JsonConvert.DeserializeObject<Pregunta>(preguntaFichero);
            }*/


        }
        public void AñadirPregunta()
        {
            Preguntas.Add(NuevaPregunta);
            nuevaPregunta = new Pregunta();
        }
    }
}
