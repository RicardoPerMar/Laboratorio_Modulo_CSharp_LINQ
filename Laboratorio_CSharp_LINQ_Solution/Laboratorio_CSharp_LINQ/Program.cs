using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_CSharp_LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Patient> listPatient = new List<Patient> {
            new Patient(1,"John","Doe","Male",36.8f, 80, "general medicine", 44),
            new Patient(2,"Jane","Doe","Female",36.8f, 70, "general medicine", 43),
            new Patient(3,"Junior","Doe","Male",36.8f, 90, "pediatrics", 8),
            new Patient(4,"Mary","Wien","Female",36.8f, 120, "general medicine", 20),
            new Patient(5,"Scarlett","Somez","Female",36.8f, 110, "general medicine", 30),
            new Patient(6,"Brian","Kid","Male",39.8f, 80, "pediatrics", 11)
            };

            List<Patient> listPatientPriority = new List<Patient> {
            new Patient(1,"John","Doe","Male",36.8f, 80, "general medicine", 44, false),
            new Patient(2,"Jane","Doe","Female",36.8f, 70, "general medicine", 43, false),
            new Patient(3,"Junior","Doe","Male",36.8f, 90, "pediatrics", 8, false),
            new Patient(4,"Mary","Wien","Female",36.8f, 120, "general medicine", 20, true),
            new Patient(5,"Scarlett","Somez","Female",36.8f, 110, "general medicine", 30, true),
            new Patient(6,"Brian","Kid","Male",39.8f, 80, "pediatrics", 11, true)
            };

            // 1. Lista de pacientes que sean de la especialidad pediatrics y que tengan menos de 10 años.
            /*
            var pediatrics = listPatient.Where(p => p.speciality.Equals("pediatrics"));

            foreach (var patient in pediatrics)
            {
                Console.WriteLine(patient.ToString());
            }
            */

            // 2. Protocolo de urgencia si hay algún paciente con ritmo cardíaco mayor que 100 o temperatura mayor a 39.
            /*
            var emergency = listPatient.Where(p => p.heartRate > 100 || p.temperature > 39).Count();

            if (emergency > 1)
            {
                Console.WriteLine("Emergency protocol activated!");
            }
            else
            {
                Console.WriteLine("It's all well");
            }
            */

            // 3. No podemos atender a todos los pacientes hoy por lo que vamos a crear una nueva coleccion y reasignar a los pacientes de pediatrics a general medicine
            /*
            var changeSpeciality = listPatient.Where(p => p.speciality.Equals("pediatrics"));

            foreach (var patient in changeSpeciality)
            {
                patient.speciality = "general medicine";
            }
            */
            
            // 4. Conocer de una sola consulta el numero de pacientes que estan asignado a "general medicine" y a "pediatrics".
            /*
            var countSpeciality = listPatient.GroupBy(p => p.speciality);

            foreach (var patient in countSpeciality)
            {
                Console.WriteLine($"{patient.Key}: {patient.Count()}");
            }
            */

            // 5. Devuelve una lista nueva que por cada paciente se indique si tiene prioridad o no. Se tendrá prioridad si el ritmo cardiaco es mayor 100 o la temperatura es mayor a 39.
            /*
            var hasPriority = listPatientPriority.OrderBy(p => p.priority);

            foreach (var patient in hasPriority)
            {
                Console.WriteLine(patient.ToString());
            }
            */

            // 6. Queremos conocer de una sola consulta La edad media de pacientes asignados a pediatrics y general medicine.
            /*
            var averageAge = listPatient.GroupBy(p => p.speciality);

            foreach (var patient in averageAge)
            {
                Console.WriteLine($"Average age of {patient.Key}: {patient.Average(p => p.age)}");
            }
            */
            
            Console.ReadLine();
        }
    }
}
