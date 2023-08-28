using System;
using Library;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Patient patient1 = new Patient("Joe Biden","1","123-456-789", "44");
            Patient patient2 = new Patient("Dan Gheesling", "2", "123-555-123", "");
            Patient patient3 = new Patient("Cirie Fields", "", "444-555-666", "63");
            Doctor doctor1 = new Doctor("Charlie", "1", "100-555-556", "General Practitioner");
            Doctor doctor2 = new Doctor("Dylan", "2", "999-888-777", "General Surgery");

            string appointmentResult = AppointmentService.CreateAppointment(patient1, DateTime.Now, "Wall Street", doctor1);
            string appointmentResult2 = AppointmentService.CreateAppointment(patient2, DateTime.Now, "Canal Street", doctor2);
            string appointmentResult3 = AppointmentService.CreateAppointment(patient3, DateTime.Now, "Canal Street", doctor2);


            Console.WriteLine(appointmentResult);
            Console.WriteLine(appointmentResult2);
            Console.WriteLine(appointmentResult3);
        }
    }
}
