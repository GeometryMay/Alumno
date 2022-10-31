namespace DatosdelAlumno
{
    public class soliticaciondatosdealumno
    {
        protected string matri, name, surname, sexo, specialty;

        public string Matri
        {
            set { matri = value; }
            get { return matri; }
        }

        public string Nombre
        {
            set { name  = value; }
            get { return name; }
        }

        public string Apellido
        {
            set { surname  = value; }
            get { return surname; }
        }

        public string Genero
        {
            set { sexo = value; }
            get { return sexo; }
        }

        public string Especialidad
        {
            set { specialty  = value; }
            get { return specialty; }
        }

        public class mostrar_inf : soliticaciondatosdealumno
        {

            public class datospersonales
            {
                static void Main(String[] args)
                {
                    string matricula, alumno, apellido, sexo, especialidad;

                    mostrar_inf datos = new mostrar_inf();

                    Console.WriteLine("Ingresa tu Matricula: "); matricula = Console.ReadLine();
                    datos.matri = String.Concat(matricula);

                    Console.WriteLine("Ingresa tu Nombre(s): ");
                    alumno = Console.ReadLine();
                    datos.name = String.Concat(alumno);

                    Console.WriteLine("Ingresa tu Apellido(s): ");
                    apellido = Console.ReadLine();
                    datos.surname = String.Concat(apellido);

                    Console.WriteLine("Ingresa tu Sexo: "); sexo = Console.ReadLine();
                    datos.sexo = String.Concat(sexo);

                    Console.WriteLine("Ingresa tu Especialidad: "); especialidad = Console.ReadLine();
                    datos.specialty = String.Concat(especialidad);

                    System.Console.Clear(); //se encarga de limpiar la consola

                    Console.WriteLine("Datos ingresados:" + "\n" +"\n" + "Matricula: " + matricula + "\n" + "\n" + "Nombre(s): " + alumno + "\n" + "\n" + "Apellido(s): " + apellido + "\n" + "\n" +
                    "Sexo: " + sexo + "\n" + "\n" + "Especialidad: " + especialidad + "\n" + "\n" + "By: Yael Moises May Caamal" + " \n" + "\n" + "Presiona cualquier tecla para terminar el programa :D");

                    Console.ReadLine(); //hace la función de pausar la consola, para que no termine por si sola

                }
            }
        }
    }
}