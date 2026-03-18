public class Curso
{
private List<Alumno> alumnos = new List<Alumno>();

public void agregarAlumnos(Alumno alumno)
{
    this.alumnos.Add(alumno);
}
public Alumno buscarAlumnoPorDNI(int DNI)
{
    int i = 0;
    while (i < alumnos.Count && alumnos[i].getDNI() != DNI)
    {        
    i++;
    }
    if (i >= alumnos.Count)
    {
        return null;
    }
    else
    {
        return alumnos[i];
    }
}
public void agregarFalta(double falta, Alumno alumno)
{
  int i = 0;
    while (i < alumnos.Count && alumnos[i] != alumno)
    {        
    i++;
    }
    if (i < alumnos.Count)
    {
        alumnos[i].agregarFalta(falta);
    }
}
public void mostrarAlumnos()
{
    foreach (Alumno alumno in alumnos)
    {
        Console.WriteLine(alumno.getNombre());
    }
}
public void mostrarAlumnosLibres()
{
    foreach (Alumno alumno in alumnos)
    {
        if(alumno.mostrarFaltas() >= 15)
        {
            Console.WriteLine(alumno.getNombre());
        }
    }
}
}