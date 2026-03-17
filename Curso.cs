public class Curso
{
private List<Alumno> alumnos= new List<Alumno>;

public void agregarAlumnos(Alumno alumno)
{
    this.alumnos.Add(alumno)
}
public Alumno buscarAlumnoPorDNI(int DNI)
{
    int i = 0;
    while (i < alumnos.count && alumnos[i].getDNI() != DNI)
    {        
    i++;
    }
    if (i >= alumnos.count)
    {
        return null;
    }
    else
    {
        return alumno[i];
    }
}
public void agregarFalta(int falta, Alumno alumno)
{
  int i = 0;
    while (i < alumnos.count && alumnos[i] != alumno)
    {        
    i++;
    }
    if (i >= alumnos.count)
    {
       return null;
    }
    else
    {
        alumno[i].agregarFalta(falta);
    }  
}
public void mostrarAlumnos()
{
    foreach (Alumno alumno in alumnos)
    {
    Console.WriteLine(alumno);
    }
}
public void mostrarAlumnosLibres()
{
    foreach (Alumno alumno in alumnos)
    {
        if(alumno.mostrarFaltas() >= 15)
        {
            Console.WriteLine(alumno);
        }
    }
}
}