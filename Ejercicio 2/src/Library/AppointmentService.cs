using System;
using System.Text;

namespace Library
{
    public class AppointmentService
    {
    /*
    Aplicando el principio SRP, si tuvieramos que agregar datos al paciente, tendríamos que cambiar
    esta clase para que el dato se introduzca y que se valide. Además, si queremos modificar los datos
    que se introducen acerca del doctor, también tendríamos que modificar esta clase, haciendo que esta
    clase no cumpla con el principio SRP. Esta clase, viendo el nombre de la misma y del método que tiene,
    tiene como función el de crear una consulta médica, por lo cual las responsabilidades de tener datos
    válidos acerca del paciente y del doctor no recaen en esta clase. Eso no implica que no tenga que
    conocer estos datos, ya que sin ellos no podría funcionar. Por ende, lo que se debería hacer es crear
    clases que colaboren con "AppointmentService" para que pueda hacer su función de una manera más óptima.
    */
        public static string CreateAppointment(string name, string id, string phoneNumber, DateTime date, string appoinmentPlace, string doctorName)
        {
            StringBuilder stringBuilder = new StringBuilder("Scheduling appointment...\n");
            Boolean isValid = true;

            if (string.IsNullOrEmpty(name))
            {
                stringBuilder.Append("Unable to schedule appointment, Name is required\n");
                isValid = false;
            }

            if (string.IsNullOrEmpty(id))
            {
                stringBuilder.Append("Unable to schedule appointment, id is required\n");
                isValid = false;
            }

            if (string.IsNullOrEmpty(phoneNumber))
            {
                stringBuilder.Append("Unable to schedule appointment, Phone number is required\n");
                isValid = false;
            }

            if (string.IsNullOrEmpty(appoinmentPlace))
            {
                stringBuilder.Append("Unable to schedule appointment, Appoinment place is required\n");
                isValid = false;
            }

            
            if (string.IsNullOrEmpty(doctorName))
            {
                stringBuilder.Append("Unable to schedule appointment, Doctor name is required\n");
                isValid = false;
            }

            if (isValid)
            {
                stringBuilder.Append("Appoinment Scheduled");
            }

            return stringBuilder.ToString();
        }

    }
}
