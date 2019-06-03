using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

namespace WpfApp1
{
    public class Department
    {
        /// <summary>
        /// Список рабочих в данном дипортаменте
        /// </summary>
        private ObservableCollection<Employee> dep = new ObservableCollection<Employee>();

        /// <summary>
        ///  Имя департамента
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Возвращает список трудяг
        /// </summary>
        public ObservableCollection<Employee> GetEmployees { get { return dep; } }
        public Department()
        {
            
        }
        /// <summary>
        /// Конструктор класса, с вводом имени 
        /// </summary>
        /// <param name="Name">Имя департамент</param>
        public Department(string Name)
        {
            this.Name = Name;
        }
        /// <summary>
        /// Добавление работника в депортамент
        /// </summary>
        /// <param name="employee">Работник</param>
        public void AddEmployees(Employee employee)
        {
            dep.Add(employee);
        }
        /// <summary>
        /// Удаление работника из департамент
        /// </summary>
        /// <param name="employee">Работник</param>
        public void RemoveEmployees(Employee employee)
        {
            dep.Remove(employee);
        }
        /// <summary>
        /// Изменение парматров работнеика1
        /// </summary>
        /// <param name="employee">Работник с новыми параметрами</param>
        /// <param name="index">Индекс в колекции работника</param>
        public void RenameEmployees(Employee employee, int index)
        {
            dep[index] = null;
            dep[index] = employee;

        }
        /// <summary>
        /// Изменение имени департамента
        /// </summary>
        /// <param name="name">Новое имя</param>
        public void Rename(string name)
        {
            this.Name = name;
        }

        public override string ToString()
        {
            return $"{this.Name}";
        }

    }
}
