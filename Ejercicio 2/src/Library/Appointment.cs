using System;
using System.Text;
namespace Library
{
    public class Appointment
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
        private static int appointmentId = 0;
        private static string appointmentIdToString = appointmentId.ToString();
        public Patient Patient {get;set;}
        public DateTime DateTime {get;set;}
        public string AppointmentPlace {get;set;}
        public Doctor Doctor {get;set;}

        
        
        public Appointment(Patient patient, DateTime date, string appointmentPlace, Doctor doctor)
        {
            this.Patient = patient;
            this.DateTime = date;
            this.AppointmentPlace = appointmentPlace;
            this.Doctor = doctor;
        }
        public static Appointment CreateAppointment(string patientId, DateTime date, string appointmentPlace, string doctorId)
        {
            /*
            Cada paciente podría ser su propio objeto con name, id, phoneNumber y otras cosas como edad, etc.
            Cada doctor podría ser su propio objeto con doctorName, especialidad y otras cosas
            appointmentPlace podría tener opciones
            */
            StringBuilder stringBuilder = new StringBuilder("Scheduling appointment...\n");
            if (Patient.GetPatientFromId(patientId) == null || Doctor.GetDoctorFromId(doctorId) == null || String.IsNullOrEmpty(Patient.GetPatientFromId(patientId).Name) || String.IsNullOrEmpty(Doctor.GetDoctorFromId(doctorId).Name) || String.IsNullOrEmpty(Patient.GetPatientFromId(patientId).PhoneNumber) || String.IsNullOrEmpty(Patient.GetPatientFromId(patientId).Age) || String.IsNullOrEmpty(Doctor.GetDoctorFromId(patientId).PhoneNumber) || String.IsNullOrEmpty(Doctor.GetDoctorFromId(patientId).Specialty))
            {
                stringBuilder.Append($"Error: Some information is missing. Please complete all fields to proceed");
                Console.WriteLine(stringBuilder.ToString());
                return null;
            }
            else
            {
                stringBuilder.Append($"Appoinment scheduled for patient {Patient.GetPatientFromId(patientId).Name}");
                Console.WriteLine(stringBuilder.ToString());
                Appointment newAppointment = new Appointment(Patient.GetPatientFromId(patientId), date, appointmentPlace, Doctor.GetDoctorFromId(doctorId));
                return newAppointment;
            }
            
        }

    }
}
