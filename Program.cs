namespace act_1._5;

class Program
{
    static void Main(string[] args)
    {
        Curso curso = new Curso();
       int opcion;
       do{
            Console.WriteLine("Seleccione una opcion:");
            Console.WriteLine("1. Agregar nuevos alumnos");
            Console.WriteLine("2. Buscar un alumno por su dni");
            Console.WriteLine("3. Agregar una falta o media falta a un alumno.");
            Console.WriteLine("4. Mostrar todos los alumnos");
            Console.WriteLine("5. Mostrar los alumnos con mas de 15 faltas (Libres)");
            Console.WriteLine("6. Salir");
            opcion = int.Parse(Console.ReadLine());
            Console.Clear();
            if(opcion > 6 || opcion < 1){
                Console.WriteLine("Error, opcion no valida.");
            }
            else if(opcion == 1)
            {
                string nombre;
                int dni;
                Console.WriteLine("escriba el nombre");
                nombre = Console.ReadLine();
                Console.WriteLine("escriba el dni");
                dni = int.Parse(Console.ReadLine());
                Alumno alumno = new Alumno (nombre, dni);
                curso.agregarAlumnos(alumno);
            }
            else if( opcion == 2)
            {
                int dniBuscar;
                Console.WriteLine("Ingrese el dni");
                dniBuscar = int.Parse(Console.ReadLine());
                Alumno alumnoPorDNI = curso.buscarAlumnoPorDNI(dniBuscar);
                Console.WriteLine(alumnoPorDNI.getNombre());

            }
            else if (opcion == 3)
            {
                double falta;
                int dniAlumno;
                Console.WriteLine("ingrese el dni del alumno");
                dniAlumno = int.Parse(Console.ReadLine());
                Console.WriteLine("Cuanta falta le quiere poner al alumno?");
                falta = double.Parse(Console.ReadLine());
                Alumno alumnoFalta = curso.buscarAlumnoPorDNI(dniAlumno);
                if (alumnoFalta != null) 
                {
                    alumnoFalta.agregarFalta(falta);
                }
                else
                {
                    Console.WriteLine("Ese alumno no existe");
                }

                
            }
            else if (opcion == 4)
            {
                curso.mostrarAlumnos();
            }
            else if (opcion == 5)
            {
                curso.mostrarAlumnosLibres();
            }
        }while (opcion != 6);
    }
}
