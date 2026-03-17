public class Alumno
{
private int DNI;
private string nombre;
private double CantidaFaltas;

public Alumno(string nombre, int DNI)
    {
        this.nombre = nombre;
        this.DNI = DNI;
        this.CantidaFaltas = 0;
    }
public int getDNI()
{
 return this.DNI;
}
}
public void agregarFalta(int falta)
{
    alumno.CantidaFaltas += falta;
}
public double mostrarFaltas(){
    return this.CantidaFaltas
}
