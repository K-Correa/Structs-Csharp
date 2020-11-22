using System;

namespace ConsoleApp1
{
    class Program
    {
        struct Nacimiento
        {
            public int Mes;
            public int Dia;
            public int Año;

            //constructor

            public Nacimiento(int dia, int mes, int año)
            {
                this.Dia = dia;
                this.Mes = mes;
                this.Año = año;
            }
            //Metodos
            public void AsignarNacimiento(int dia, int mes, int año)
            {
                this.Dia = dia;
                this.Mes = mes;
                this.Año = año;
            }

            public override string ToString()
            {
                return Dia + "/" + Mes + "/" + Año;
            }
        }
        static void Main(string[] args)
        {
            Nacimiento fecha;
            Nacimiento fecha2 = new Nacimiento();
            Nacimiento fecha3 = new Nacimiento(12, 1, 1992);

            fecha.Dia = 12;
            fecha.Mes = 4;
            fecha.Año = 1900;

            Console.WriteLine("El dia de nacimiento es {0}", fecha.Dia);
            fecha.AsignarNacimiento(1, 1, 2020);
            Console.WriteLine("La nueva fecha es {0}", fecha);
        }
    }
}
