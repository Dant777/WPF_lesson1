using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    /// <summary>
    /// Класс трудяга
    /// </summary>
    public class Employee
    {
        public Employee()
        {

        }

        /// <summary>
        /// Конструктор класса трудяга
        /// </summary>
        /// <param name="Name">Имя трудяги</param>
        /// <param name="Age">Возраст трдяги</param>
        /// <param name="Salary">Зарплата трудяги</param>
        
        public Employee(string Name, int Age, int Salary)
        {
            this.Name = Name;
            this.Age = Age;
            this.Salary = Salary;
            
        }
        /// <summary>
        /// Имя трудяги
        /// </summary>
        public string Name { get;set; }
        /// <summary>
        /// Возраст трудяги
        /// </summary>
        public int Age { get; set; }
        /// <summary>
        /// Зарплату трудяги
        /// </summary>
        public int Salary { get; set; }

        /// <summary>
        /// Изменение имени
        /// </summary>
        /// <param name="Name">Новое имя</param>
        public void Rename(string Name)
        {
            this.Name = Name;
        }
        /// <summary>
        /// Изменить возвраст
        /// </summary>
        /// <param name="Age">Новый возвраст</param>
        public void ChangeAge(int Age)
        {
            this.Age = Age;
        }
        /// <summary>
        /// Изменить зарплату
        /// </summary>
        /// <param name="Salary">Новая зарплата</param>
        public void ChangeSalary(int Salary)
        {
            this.Salary = Salary;
        }
        public override string ToString()
        {
            return $"{this.Name} {this.Age} {this.Salary} ";
        }

    }

}

