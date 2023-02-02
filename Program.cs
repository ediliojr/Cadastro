//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace cadastro
//{
//    public class Program
//    {
//        static void Cadastro(string[] args)
//        {
//        public string Nome { get; set; };
//        public string Sobrnome { get; set; };
//        public int CPF { get; set; };
//        public int tetefone { get; set; };
//    }
//    }
//}


//public class RegistraCadastro
//{
//    private string[] args;
//            {

//    }

//}
using System;
using System.Collections.Generic;

class Patient
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Address { get; set; }
    public int Age { get; set; }
    public string PhoneNumber { get; set; }
}

class HospitalRegistration
{
    static List<Patient> patients = new List<Patient>();

    static void Main(string[] args)
    {
        bool exit = false;
        while (!exit)
        {
            Console.WriteLine("Hospital Registration System");
            Console.WriteLine("1. Register a patient");
            Console.WriteLine("2. View registered patients");
            Console.WriteLine("3. Alter registration");
            Console.WriteLine("3. Exit");
            Console.Write("Enter your choice: ");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    RegisterPatient();
                    break;
                case 2:
                    ViewPatients();
                    break;
                case 3:
                    AlterPatients();
                    break;
                case 4:
                    exit = true;
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }

    static void RegisterPatient()
    {
        Patient patient = new Patient();
        Console.Write("Enter first name: ");
        patient.FirstName = Console.ReadLine();
        Console.Write("Enter last name: ");
        patient.LastName = Console.ReadLine();
        Console.Write("Enter address: ");
        patient.Address = Console.ReadLine();
        Console.Write("Enter age: ");
        patient.Age = int.Parse(Console.ReadLine());
        Console.Write("Enter phone number: ");
        patient.PhoneNumber = Console.ReadLine();

        patients.Add(patient);
        Console.WriteLine("Patient registered successfully.");
    }

    static void ViewPatients()
    {
        Console.WriteLine("List of registered patients:");
        foreach (Patient patient in patients)
        {
            Console.WriteLine("Name: {0} {1}", patient.FirstName, patient.LastName);
            Console.WriteLine("Address: {0}", patient.Address);
            Console.WriteLine("Age: {0}", patient.Age);
            Console.WriteLine("Phone Number: {0}", patient.PhoneNumber);
            Console.WriteLine();
        }
    }

    static void AlterPatients()
    {
        int numero;
        Console.WriteLine("Digite o numero do paciente que deseja modificar:");
        try
        {
            numero = int.Parse(Console.ReadLine());
            Console.WriteLine("Name: {0} {1} {2} Address:{3} ", patients[numero].FirstName, patients[numero].LastName, patients[numero].Age, patients[numero].Address);
            Console.Write("Enter first name: ");
            patients[numero].FirstName = Console.ReadLine();
            Console.Write("Enter last name: ");
            patients[numero].LastName = Console.ReadLine();
            Console.Write("Enter address: ");
            patients[numero].Address = Console.ReadLine();
            Console.Write("Enter age: ");
            patients[numero].Age = int.Parse(Console.ReadLine());
            Console.Write("Enter phone number: ");
            patients[numero].PhoneNumber = Console.ReadLine();

        }
        catch
        {
            numero = 0;
            Console.WriteLine("Id do paciente inexistente");
        }
        
        
    }

}
