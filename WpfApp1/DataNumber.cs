using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    class DataNumber
    {
        public ObservableCollection<int> col = new ObservableCollection<int>();

        Random r = new Random();

        public void AddElemnt()
        {
            for (int i = 0; i < 50; i++)
            {
                col.Add(r.Next(100, 1200));
            }
        }

        public void Sort()
        {
            for (int i = 0; i < col.Count - 1; i++)
            {
                int index = i;
                for (int j = i; j < col.Count; j++)
                {
                    if (col[j] < col[index]) index = j;
                }
                int t = col[i];
                col[i] = col[index];
                col[index] = t;
            }
        }
    }
}
