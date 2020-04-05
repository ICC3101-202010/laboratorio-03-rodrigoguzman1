namespace Laboratorio3
{
    class Empleado : Persona
    {
        int sueldo;
        string horaEntrada;
        string horaSalida;

        public Empleado()
        {

        }

        public Empleado(string rut, string nombre, string apellido, string fechaNacimiento, string nacionalidad,int sueldo,string horaEntrada,string horaSalida) : base(rut, nombre, apellido, fechaNacimiento, nacionalidad)
        {
            this.sueldo = sueldo;
            this.horaEntrada = horaEntrada;
            this.horaSalida = horaSalida;

        }
        public new string Informacion()
        {
            return "Rut: " + rut + ", Nombre: " + nombre + ", Apellido: " + apellido + ", Fecha Nacimiento: " + fechaNacimiento + ", Nacionalidad: " + nacionalidad + ", Sueldo: $"+ sueldo + ", Hora de Entrada: "+ horaEntrada + ", Hora de Salida: " + horaSalida;
        }

        public void SetSueldo(int sueldo) { this.sueldo = sueldo; }
        public void SetHorarioTrabajo(string horaEntrada, string horaSalida) { this.horaEntrada = horaEntrada; this.horaSalida = horaSalida;}

        

    }
}
