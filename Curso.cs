public class Curso
{
private Dictionary<int, Alumno> alumnos = new Dictionary<int, Alumno>();

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
public void agregarFalta(int clave, double falta)
{
    if(alumnos.ContainsKey(clave))
    {
        alumnos[clave].agregarFalta(falta);
    }
}
public void mostrarAlumnos()
{
    foreach (int clave in alumnos.Keys)
    {
        Console.WriteLine(alumnos[clave].getNombre());
    }
}
public void mostrarAlumnosLibres()
{
    foreach (int clave in alumnos.Keys)
    {
        if(alumnos[clave].mostrarFaltas() >= 15)
        {
            Console.WriteLine(alumnos[clave].getNombre());
        }
    }
}
public bool existeAlumnoPorDNI(int dni)
{
    return alumnos.ContainsKey(dni);
}
}