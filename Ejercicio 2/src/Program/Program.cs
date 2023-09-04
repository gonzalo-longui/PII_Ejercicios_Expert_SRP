using System;
using Library;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Appointment appointmentResult1 = Appointment.CreateAppointment("Joe Biden", "1", "123-456-789", "44", DateTime.Now, "Room 101", "Charlie", "1", "100-555-666", "General Surgeon");
            Appointment appointmentResult2 = Appointment.CreateAppointment("Dan Gheesling", "2", "123-555-123", "", DateTime.Now, "Room 102", "Dylan", "10", "987654321", "Traumatologist");
            Appointment appointmentResult3 = Appointment.CreateAppointment("Cirie Fields", "3", "123-555-1234", "3", DateTime.Now, "Room 103", "", "11", "4126598216", "Dentist");
        }
    }
}
