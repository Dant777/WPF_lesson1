using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Collections.ObjectModel;

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Random rnd = new Random();
        ObservableCollection<Department> listDep;
        
        Department newDep;
        Employee emp;
        
        public MainWindow()
        {
            listDep = new ObservableCollection<Department>() { new Department("Dep_1"), new Department("Dep_2"), new Department("Dep_3") };
            newDep = new Department();
            emp = new Employee();

            InitializeComponent();

            lvDepart.ItemsSource = listDep;
            Random rnd = new Random();
            int count = 0;
            for (int i = 0; i < listDep.Count; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    listDep[i].AddEmployees(new Employee($"Name_{count}", rnd.Next(20, 45),rnd.Next(10000,80000)));
                    count++;
                }
            }
            
        }

        private void BtnAddDep_Click(object sender, RoutedEventArgs e)
        {
            if (txtNameDep.Text != "")
            {
                listDep.Add(new Department(txtNameDep.Text));
            }
        }

 

        private void BtnRemoveDep_Click(object sender, RoutedEventArgs e)
        {
            listDep.Remove((Department)lvDepart.SelectedItem);
        }

        private void BtnRenameDep_Click(object sender, RoutedEventArgs e)
        {
            int index = lvDepart.SelectedIndex;
            var a = (Department)lvDepart.SelectedItem;
            if (txtNameDep.Text != "")
            {
                a.Name = txtNameDep.Text;
                listDep[index] = null;    
                listDep[index] = a;
               
            }

        }

        private void LvDepart_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int index = lvDepart.SelectedIndex;
            var a = (Department)lvDepart.SelectedItem;
            if (a != null)
            {
                txtNameDep.Text = a.Name;
            }
            else txtNameDep.Text = "";

            if (index  != -1)
            {
                lvEmployee.ItemsSource = listDep[index].GetEmployees;
            }

            
        }

        private void BtnAddEmp_Click(object sender, RoutedEventArgs e)
        {
            int index = lvDepart.SelectedIndex;
            int age = Convert.ToInt32(txtAgeEmp.Text);
            int salary = Convert.ToInt32(txtSalaryEmp.Text);
            
            listDep[index].AddEmployees(new Employee(txtNameEmp.Text,age,salary));
        }

        private void BtnRemoveEmp_Click(object sender, RoutedEventArgs e)
        {
            int index = lvDepart.SelectedIndex;
            var a = (Employee)lvEmployee.SelectedItem;
            listDep[index].RemoveEmployees(a);
        }

        private void BtnRenameEmp_Click(object sender, RoutedEventArgs e)
        {
            int indexDep = lvDepart.SelectedIndex;
            int indexEmp = lvEmployee.SelectedIndex;

            var a = (Employee)lvEmployee.SelectedItem;
            if (txtNameDep.Text != "")
            {
                a.Name = txtNameEmp.Text;
                a.Age = Convert.ToInt32(txtAgeEmp.Text);
                a.Salary = Convert.ToInt32(txtSalaryEmp.Text);

            }
            listDep[indexDep].RenameEmployees(a, indexEmp);
        }

        private void LvEmployee_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //int index = lvEmployee.SelectedIndex;
            var a = (Employee)lvEmployee.SelectedItem;
            if (a != null)
            {
                txtNameEmp.Text = a.Name;
                txtAgeEmp.Text = a.Age.ToString();
                txtSalaryEmp.Text = a.Salary.ToString();
            }
            else
            {
                txtNameEmp.Text = "";
                txtAgeEmp.Text = "";
                txtSalaryEmp.Text = "";
            }
        }
    }
}
