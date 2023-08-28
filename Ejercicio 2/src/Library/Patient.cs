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
        public Patient(string name, string id, string phoneNumber, string age)
        {
            this.Name = name;
            while (string.IsNullOrEmpty(this.Name))
            {
                Console.WriteLine("Invalid Name: Name can't be empty. Please provide a name.");
                this.Name = Console.ReadLine();
            }
            this.Id = id;
            while (string.IsNullOrEmpty(this.Id))
            {
                Console.WriteLine($"Invalid ID: ID can't be empty. Please provide an ID for patient {this.Name}");
                this.Id = Console.ReadLine();
            }
            this.PhoneNumber = phoneNumber;
            while (string.IsNullOrEmpty(this.PhoneNumber))
            {
                Console.WriteLine($"Invalid Phone Number: Phone number can't be empty. Please provide a phone number for patient {this.Name}");
                this.PhoneNumber = Console.ReadLine();
            }
            this.Age = age;
            while (string.IsNullOrEmpty(this.Age))
            {
                Console.WriteLine($"Invalid Age: Age can't be empty. Please provide an age for patient {this.Name}");
                this.Age = Console.ReadLine();
            }
        }
        
        
    }
}
