using System;

namespace Comunidad
{
    // Clase base
    public class MiembroDeLaComunidad
    {
        public string Nombre { get; set; }
        public int Edad { get; set; }

        public MiembroDeLaComunidad(string nombre, int edad)
        {
            Nombre = nombre;
            Edad = edad;
        }

        public virtual void MostrarInformacion()
        {
            Console.WriteLine($"Nombre: {Nombre}, Edad: {Edad}");
        }
    }

    // Clase derivada de MiembroDeLaComunidad
    public class Empleado : MiembroDeLaComunidad
    {
        public string Puesto { get; set; }

        public Empleado(string nombre, int edad, string puesto)
            : base(nombre, edad)
        {
            Puesto = puesto;
        }

        public override void MostrarInformacion()
        {
            base.MostrarInformacion();
            Console.WriteLine($"Puesto: {Puesto}");
        }
    }

    // Clase derivada de MiembroDeLaComunidad
    public class Estudiante : MiembroDeLaComunidad
    {
        public string Carrera { get; set; }

        public Estudiante(string nombre, int edad, string carrera)
            : base(nombre, edad)
        {
            Carrera = carrera;
        }

        public override void MostrarInformacion()
        {
            base.MostrarInformacion();
            Console.WriteLine($"Carrera: {Carrera}");
        }
    }

    // Clase derivada de MiembroDeLaComunidad
    public class ExAlumno : MiembroDeLaComunidad
    {
        public int AnioDeGraduacion { get; set; }

        public ExAlumno(string nombre, int edad, int anioDeGraduacion)
            : base(nombre, edad)
        {
            AnioDeGraduacion = anioDeGraduacion;
        }

        public override void MostrarInformacion()
        {
            base.MostrarInformacion();
            Console.WriteLine($"Año de Graduación: {AnioDeGraduacion}");
        }
    }

    // Clase derivada de Empleado
    public class Docente : Empleado
    {
        public string Asignatura { get; set; }

        public Docente(string nombre, int edad, string puesto, string asignatura)
            : base(nombre, edad, puesto)
        {
            Asignatura = asignatura;
        }

        public override void MostrarInformacion()
        {
            base.MostrarInformacion();
            Console.WriteLine($"Asignatura: {Asignatura}");
        }
    }

    // Clase derivada de Empleado
    public class Administrativo : Empleado
    {
        public string Departamento { get; set; }

        public Administrativo(string nombre, int edad, string puesto, string departamento)
            : base(nombre, edad, puesto)
        {
            Departamento = departamento;
        }

        public override void MostrarInformacion()
        {
            base.MostrarInformacion();
            Console.WriteLine($"Departamento: {Departamento}");
        }
    }

    // Clase derivada de Docente
    public class Administrador : Docente
    {
        public Administrador(string nombre, int edad, string puesto, string asignatura)
            : base(nombre, edad, puesto, asignatura)
        {
        }
    }

    // Clase derivada de Docente
    public class Maestro : Docente
    {
        public Maestro(string nombre, int edad, string puesto, string asignatura)
            : base(nombre, edad, puesto, asignatura)
        {
        }
    }

    // Programa principal para probar la estructura
    class Program
    {
        static void Main(string[] args)
        {
            MiembroDeLaComunidad estudiante = new Estudiante("Carlos", 20, "Ingeniería");
            estudiante.MostrarInformacion();

            Empleado docente = new Docente("Ana", 30, "Docente", "Matemáticas");
            docente.MostrarInformacion();

            MiembroDeLaComunidad exAlumno = new ExAlumno("Luis", 25, 2018);
            exAlumno.MostrarInformacion();
        }
    }
}
