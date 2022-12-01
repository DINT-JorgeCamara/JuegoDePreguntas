using Microsoft.Toolkit.Mvvm.ComponentModel;
using System;

namespace JuegoDePreguntas.Clases
{
    class Pregunta : ObservableObject
    {
        private string textoPregunta;
        public string TextoPregunta
        {
            get { return textoPregunta; }
            set { SetProperty(ref textoPregunta, value); }
        }

        private string respuesta;
        public string Respuesta
        {
            get { return respuesta; }
            set { SetProperty(ref respuesta, value); }
        }

        private string categoria;
        public string Categoria
        {
            get { return categoria; }
            set { SetProperty(ref categoria, value); }
        }

        private string dificultad;
        public string Dificultad
        {
            get { return dificultad; }
            set { SetProperty(ref dificultad, value); }
        }
        
        private string imagen;
        public string Imagen
        {
            get { return imagen; }
            set { SetProperty(ref imagen, value); }
        }

        public Pregunta()
        {}
        public Pregunta(String textoPregunta, String respuesta, string categoria, string dificultad, string imagen)
        {
            TextoPregunta = textoPregunta;
            Respuesta = respuesta;
            Categoria = categoria;
            Dificultad = dificultad;
            Imagen = imagen;
        }
    }
}
