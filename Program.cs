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
                while(!curso.agregarAlumnos(dni, alumno));
                {
                    Console.WriteLine("DNI invalido, vuelva a ingresar");
                    dni = int.Parse(Console.ReadLine());
                    alumno.cambiarDNI(dni);
                };
            }
            else if( opcion == 2)
            {
                int dniBuscar;
                do{
                Console.WriteLine("ingrese el dni del alumno");
                dniBuscar = int.Parse(Console.ReadLine());
                if(!curso.existeAlumnoPorDNI(dniBuscar)){
                    Console.WriteLine("Ese dni no existe. Ingresar denuevo");
                }
                }while(!curso.existeAlumnoPorDNI(dniBuscar));

                dniBuscar = int.Parse(Console.ReadLine());
                Alumno alumnoPorDNI = curso.buscarAlumnoPorDNI(dniBuscar);
                Console.WriteLine(alumnoPorDNI.getNombre());

            }
            else if (opcion == 3)
            {
                double falta;
                int dniAlumno;
                
                do{
                Console.WriteLine("ingrese el dni del alumno");
                dniAlumno = int.Parse(Console.ReadLine());
                if(!curso.existeAlumnoPorDNI(dniAlumno)){
                    Console.WriteLine("Ese dni no existe. Ingresar denuevo");
                }
                }while(!curso.existeAlumnoPorDNI(dniAlumno));
                
                Console.WriteLine("Cuanta falta le quiere poner al alumno?");
                falta = double.Parse(Console.ReadLine());
                curso.agregarFalta(dniAlumno, falta);

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
