using DevExpress.Xpf.Grid;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace WpfApplication6
{
    public class ViewModel
    {

        private ObservableCollection<Task> _List;

        public ObservableCollection<Task> List
        {
            get
            {
                _List = new ObservableCollection<Task>();
                for (int i = 0; i < 20; i++)
                {
                    _List.Add(new Task() { Name = "Task " + i, FirstValue = i, SecondValue = i * i, IsCompleted = i % 2 != 0 });
                }
                return _List;
            }
        }

        public class Task
        {
            public string Name { get; set; }
            public int FirstValue { get; set; }
            public int SecondValue { get; set; }
            public bool IsCompleted { get; set; }
        }
    }
}
