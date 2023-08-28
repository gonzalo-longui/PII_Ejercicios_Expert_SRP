using System;
using System.Text;

namespace Library
{
    public class AppointmentService
    {
        /*
            ClassName: AppointmentService
            Responsabilidades:
                - Crear los appointments
                - Mostrar al usuario si la creación del appointment fue exitosa
            Colaboradores:
                - Patient
                - Doctor
        */
        public static string CreateAppointment(Patient patient, DateTime date, string appoinmentPlace, Doctor doctor)
        {
            /*
            Cada paciente podría ser su propio objeto con name, id, phoneNumber y otras cosas como edad, etc.
            Cada doctor podría ser su propio objeto con doctorName, especialidad y otras cosas
            appointmentPlace podría tener opciones
            */
            StringBuilder stringBuilder = new StringBuilder("Scheduling appointment...\n");

            stringBuilder.Append($"Appoinment scheduled for patient {patient.Name}");

            return stringBuilder.ToString();
        }

    }
}
