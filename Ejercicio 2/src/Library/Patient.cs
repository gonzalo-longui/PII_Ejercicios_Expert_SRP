using System;
using System.Collections.Generic;
using System.Text;

namespace Library
{
    public class Patient
    {
        /*TARJETA CRC
            ClassName: Patient
            Responsabilidades:
                - Conocer el nombre, ID, número de teléfono y edad de los pacientes
                - Validar cada uno de los datos para que no quede vacío
            Colaboradores:
                - N/A
        */
        public string Name { get; }
        public string Id { get; }
        public string PhoneNumber { get; }
        public string Age { get; }
        private static List<Patient> patients = new List<Patient>();
        public Patient(string name, string id, string phoneNumber, string age)
        {
            this.Name = name;
            this.Id = id;
            this.PhoneNumber = phoneNumber;
            this.Age = age;
            patients.Add(this);
        }
        
        public static Patient GetPatientFromId(string id)
        {
            foreach (Patient patient in patients)
            {
                if (patient.Id == id)
                {
                    return patient;
                }
            }
            return null;
        }
        
    }
}
