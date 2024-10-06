using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ControlAsistencia
{
    public class Universidad
    {
        public class Estudiante
        {
            public string Nombre { get; set; }
            public int SesionesTotales { get; set; }
            public int SesionesAsistidas { get; set; }

            public class Asistencia
            {
                public static double CalcularPorcentajeAsistencia(int sesionesTotales, int sesionesAsistidas)
                {
                    if (sesionesTotales == 0) return 0;
                    return (double)sesionesAsistidas / sesionesTotales * 100;
                }

                public static string VerificarAsistencia(int sesionesTotales, int sesionesAsistidas)
                {
                    double porcentajeAsistencia = CalcularPorcentajeAsistencia(sesionesTotales, sesionesAsistidas);
                    if (porcentajeAsistencia >= 75)
                    {
                        return $"El estudiante cumple con el mínimo de asistencia: {porcentajeAsistencia}%";
                    }
                    else
                    {
                        return $"El estudiante NO cumple con el mínimo de asistencia: {porcentajeAsistencia}%";
                    }
                }
            }
        }
    }

    public static class EstudianteExtencion
    {
        public static void MostrarInformacion(this ControlAsistencia.Universidad.Estudiante estudiante)
        {
            double porcentajeAsistencia = ControlAsistencia.Universidad.Estudiante.Asistencia.CalcularPorcentajeAsistencia(estudiante.SesionesTotales, estudiante.SesionesAsistidas);
            string cumplimiento = ControlAsistencia.Universidad.Estudiante.Asistencia.VerificarAsistencia(estudiante.SesionesTotales, estudiante.SesionesAsistidas);

            Console.WriteLine($"Nombre: {estudiante.Nombre}");
            Console.WriteLine($"Sesiones Totales: {estudiante.SesionesTotales}");
            Console.WriteLine($"Sesiones Asistidas: {estudiante.SesionesAsistidas}");
            Console.WriteLine($"Porcentaje de Asistencia: {porcentajeAsistencia}%");
            Console.WriteLine(cumplimiento);
        }
    }
}

