using System;

namespace Ejercicio1
{
    /* Crea un "struct" que almacene datos de una canción en formato MP3: Artista, Título, Duración (en segundos),
Tamaño del fichero (en KB). Un programa debe pedir los datos de una canción al usuario, almacenarlos en
dicho "struct" y después mostrarlos en pantalla. */
    class Program
    {
        struct Canciones
        {
            public string Artista;
            public string Titulo;
            public double Duracion;

            public Canciones(string artista, string titulo, double duracion)
            {
                this.Artista = artista;
                this.Titulo = titulo;
                this.Duracion = duracion;
            }
            public void AsignarDatosCancion(string artista, string titulo, double duracion)
            {
                this.Artista = artista;
                this.Titulo = titulo;
                this.Duracion = duracion;
            }
            public override string ToString()
            {
                return $"\nCancion: {Titulo} \n Artista: {Artista} \n Duracion: {Duracion}";
            }
        }
        static void Main(string[] args)
        {
            Console.Write("Cual es el artista?: ");
            string setArtista = Convert.ToString(Console.ReadLine());
            Console.Write("Indique el titulo del artista: ");
            string setTitulo = Convert.ToString(Console.ReadLine());

            Console.Write("De cuanto es la duracion? ");

            double setDuracion = Convert.ToDouble(Console.ReadLine());

            Canciones canciones = new Canciones();

            canciones.AsignarDatosCancion(setArtista, setTitulo, setDuracion);
            Console.WriteLine(canciones);
        }
    }
}
