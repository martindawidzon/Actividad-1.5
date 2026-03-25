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
    public void agregarFalta(double falta)
    {
        this.CantidaFaltas += falta;
    }
    public double mostrarFaltas()
    {
        return this.CantidaFaltas;
    }
    public string getNombre()
    {
        return this.nombre;
    }
    public void cambiarDNI(int DNI)
    {
        this.DNI = DNI;
    }
}
