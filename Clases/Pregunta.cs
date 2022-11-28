using Microsoft.Toolkit.Mvvm.ComponentModel;
using System;

namespace JuegoDePreguntas.Clases
{
    class Pregunta : ObservableObject
    {
        private string textoPregunta;
        private string TextoPregunta
        {
            get { return textoPregunta; }
            set { SetProperty(ref textoPregunta, value); }
        }

        private string respuesta;
        private string Respuesta
        {
            get { return respuesta; }
            set { SetProperty(ref respuesta, value); }
        }
        private string categoria;
        private string Categoria
        {
            get { return categoria; }
            set { SetProperty(ref categoria, value); }
        }
        private string dificultad;
        private string Dificultad
        {
            get { return dificultad; }
            set { SetProperty(ref dificultad, value); }
        }
        private string imagen;
        private string Imagen
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
