public class Curso
{
private Dictionary<Alumno> alumnos = new Dictionary<int, Alumno>();

public bool agregarAlumnos(int clave, Alumno alumno)
{
    if(alumnos.ContainsKey(clave))
    {
        return false;
    }
    else
    {
    this.alumnos.Add(clave, alumno);
        return true;
    }
}
public Alumno buscarAlumnoPorDNI(int DNI)
{
    return alumnos[DNI];
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