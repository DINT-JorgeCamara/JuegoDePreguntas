using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuegoDePreguntas.Servicios
{
    class ServicioDialogo
    {
        /*public static void AñadirPregunta(Clases.Pregunta NuevaPregunta)
        {
            string preguntaJson = JsonConvert.SerializeObject(NuevaPregunta);

            Microsoft.Win32.SaveFileDialog saveFileDialog = new Microsoft.Win32.SaveFileDialog();
            if (saveFileDialog.ShowDialog() == true)
                File.WriteAllText(saveFileDialog.FileName, preguntaJson);
        }*/
        public static string ExaminarImagen()
        {
            Microsoft.Win32.OpenFileDialog openFileDialog = new Microsoft.Win32.OpenFileDialog();
            openFileDialog.Filter = "Image files (*.png;*.jpeg*.jpg)|*.png;*.jpeg;*.jpg";
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            if (openFileDialog.ShowDialog() == true)
                return openFileDialog.FileName;
            else return null;
        }
    }
}
