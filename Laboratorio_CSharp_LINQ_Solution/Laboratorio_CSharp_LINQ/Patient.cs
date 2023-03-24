using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_CSharp_LINQ
{
    class Patient
    {
        public int id;
        public string name;
        public string lastname;
        public string sex;
        public float temperature;
        public int heartRate;
        public string speciality;
        public int age;
        public bool priority;

        public Patient(int id, string name, string lastname, string sex, float temperature, int heartRate, string speciality, int age)
        {
            this.id = id;
            this.name = name;
            this.lastname = lastname;
            this.sex = sex;
            this.temperature = temperature;
            this.heartRate = heartRate;
            this.speciality = speciality;
            this.age = age;
        }

        public Patient(int id, string name, string lastname, string sex, float temperature, int heartRate, string speciality, int age, bool priority)
        {
            this.id = id;
            this.name = name;
            this.lastname = lastname;
            this.sex = sex;
            this.temperature = temperature;
            this.heartRate = heartRate;
            this.speciality = speciality;
            this.age = age;
            this.priority = priority;
        }

        public override string ToString()
        {
            return $"----------------------------------------------------------------\n" +
                $"ID: {id}\nName: {name}\nLastname: {lastname}\nSex: {sex}\nTemperature: {temperature}\nHeart rate: {heartRate}\nSpeciality: {speciality}\nAge: {age}\nPriority: {priority}";
        }
    }
}
