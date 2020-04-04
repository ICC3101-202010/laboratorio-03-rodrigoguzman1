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

        public void SetSueldo(int sueldo) { this.sueldo = sueldo; }
        public void SetHorarioTrabao(string horaEntrada, string horaSalida) { this.horaEntrada = horaEntrada; this.horaSalida = horaSalida;}

        

    }
}
