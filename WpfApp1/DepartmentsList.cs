using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    /// <summary>
    /// Класс использующий список департаментов
    /// </summary>
    class DepartmentsList
    {
        /// <summary>
        /// Список дипортаментов
        /// </summary>
        private ObservableCollection<Department> depList = new ObservableCollection<Department>();
        /// <summary>
        /// Свойство возвращающий список департаментов
        /// </summary>
        public ObservableCollection<Department> GetDepList { get { return depList; } }

        /// <summary>
        /// Добавление депортамента в список
        /// </summary>
        /// <param name="department">Департамент</param>
        public void AddDepartment(Department department)
        {
            depList.Add(department);
        }
        /// <summary>
        /// Удаление департамента из списка
        /// </summary>
        /// <param name="department">Департамент</param>
        public void RemoveDepartment(Department department)
        {
            depList.Remove(department);
        }
    }
}
