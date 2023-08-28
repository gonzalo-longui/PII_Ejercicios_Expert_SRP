using System;
using System.Runtime.CompilerServices;
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

        public Doctor(string name, string id, string phoneNumber, string specialty)
        {
            this.Name = name;
            while (string.IsNullOrEmpty(this.Name))
            {
                Console.WriteLine("Invalid Name: Name can't be empty");
                this.Name = Console.ReadLine();
            }
            this.Id = id;
            while (string.IsNullOrEmpty(this.Id))
            {
                Console.WriteLine($"Invalid ID: ID can't be empty. Please provide and ID for Doctor {this.Name}");
                this.Id = Console.ReadLine();
            }
            this.PhoneNumber = phoneNumber;
            while (string.IsNullOrEmpty(this.PhoneNumber))
            {
                Console.WriteLine($"Invalid Phone Number: Phone number can't be empty. Please provide a phone number for Doctor {this.Name}");
                this.PhoneNumber = Console.ReadLine();
            }
            this.Specialty = specialty;
            while (string.IsNullOrEmpty(this.Specialty))
            {
                Console.WriteLine($"Invalid Specialty: Specialty can't be empty. Please provide a specialty for Doctor {this.Name}");
                this.Specialty = Console.ReadLine();
            }
        }
        
        
    }
}