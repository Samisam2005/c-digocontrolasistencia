using System; 

namespace ControlAsistencia
{
    class Program
    {
        public static void Main(string[] args)
        {
            Universidad.Estudiante estudiante1 = new Universidad.Estudiante
            {
                Nombre = "Marta",
                SesionesTotales = 40,
                SesionesAsistidas = 40,
            };

            Universidad.Estudiante estudiante2 = new Universidad.Estudiante
            {
                Nombre = "Belkin",
                SesionesTotales = 40,
                SesionesAsistidas = 35,
            };

            Universidad.Estudiante estudiante3 = new Universidad.Estudiante
            {
                Nombre = "Angello",
                SesionesTotales = 40,
                SesionesAsistidas = 17,
            };

            Universidad.Estudiante[] estudiantes = new Universidad.Estudiante[3];
            estudiantes[0] = estudiante1;
            estudiantes[1] = estudiante2;
            estudiantes[2] = estudiante3;

            foreach (Universidad.Estudiante estudiante in estudiantes)
            {
                estudiante.MostrarInformacion();
                Console.WriteLine("---------------------------------------------------------------------");
            }
        }
    }
}
