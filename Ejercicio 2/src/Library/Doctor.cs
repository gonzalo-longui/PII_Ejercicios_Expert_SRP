using System;
using System.Runtime.CompilerServices;
using System.Collections.Generic;
using System.Text;

namespace Library
{
    public class Doctor
    {
        /*TARJETA CRC
            ClassName: Doctor
            Responsabilidades:
                -Conocer el nombre del doctor
                -Conocer el ID del doctor
                -Conocer el número de teléfono del doctor
                -Conocer la especialidad del doctor
                -Validar cada uno de los datos para que no quede vacío
            Colaboradores: 
                - N/A    
        */

        //en la vida real me gustaría poner un IDcounter y que las ID se asignen de forma automática, pero no sé si se mantendrían
        //los incrementos cuando los hacemos por consola o con dotnet run
        public string Name { get; }
        public string Id { get; }
        public string PhoneNumber { get; }
        public string Specialty { get; }
        private static List<Doctor> doctors = new List<Doctor>(); 

        public Doctor(string name, string id, string phoneNumber, string specialty)
        {
            this.Name = name;
            this.Id = id;
            this.PhoneNumber = phoneNumber;
            this.Specialty = specialty;
            doctors.Add(this);
        }

        public static Doctor GetDoctorFromId(string id)
        {
            foreach (Doctor doctor in doctors)
            {
                if (doctor.Id == id)
                {
                    return doctor;
                }
            }
            return null;
        }
        
    }
}