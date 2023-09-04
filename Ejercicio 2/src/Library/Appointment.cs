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
        public static Appointment CreateAppointment(string patientName, string patientId, string patientPhoneNumber, string patientAge, DateTime date, string appointmentPlace, string doctorName, string doctorId, string doctorPhoneNumber, string doctorSpecialty)
        {
            /*
            Cada paciente podría ser su propio objeto con name, id, phoneNumber y otras cosas como edad, etc.
            Cada doctor podría ser su propio objeto con doctorName, especialidad y otras cosas
            appointmentPlace podría tener opciones
            */
            StringBuilder stringBuilder = new StringBuilder("Scheduling appointment...\n");
            if (String.IsNullOrEmpty(patientName) || String.IsNullOrEmpty(patientId) || String.IsNullOrEmpty(patientPhoneNumber) || String.IsNullOrEmpty(patientAge) || String.IsNullOrEmpty(appointmentPlace) || String.IsNullOrEmpty(doctorName) || String.IsNullOrEmpty(doctorId) || String.IsNullOrEmpty(doctorPhoneNumber) || String.IsNullOrEmpty(doctorSpecialty))
            {
                stringBuilder.Append($"Error: Some information is missing. Please complete all fields to proceed");
                Console.WriteLine(stringBuilder.ToString());
                return null;
            }
            else
            {
                Patient newPatient = new Patient(patientName, patientId, patientPhoneNumber, patientAge);
                Doctor newDoctor = new Doctor(doctorName, doctorId, doctorPhoneNumber, doctorSpecialty);
                Appointment newAppointment = new Appointment(newPatient, date, appointmentPlace, newDoctor);
                stringBuilder.Append($"Appoinment scheduled for patient {Patient.GetPatientFromId(patientId).Name}");
                Console.WriteLine(stringBuilder.ToString());
                
                return newAppointment;
            }
            
        }

    }
}
