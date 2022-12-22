using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFTest
{
    //public enum Level { Level1, Level2, Level3 }

    internal class ModelStudent : NotifyPropertyChange
    {

        public ModelStudent()
        {
            _studentname = string.Empty;
            //_classid = new ObservableCollection<MyClass>();
            _classid = new MyClass() { Name = "Level1" };
        }
        
        private string _studentname;

        public string StudentName
        {
            get=> _studentname;
            set=> SetValue(ref _studentname, value);
        }

        //private ObservableCollection<MyClass> _classid;
        //public ObservableCollection<MyClass> ClassId
        //{
        //    get=> _classid;
        //    set=> SetValue(ref _classid, value);    
        //}
        private MyClass _classid;
        public MyClass ClassId
        {
            get => _classid;
            set => SetValue(ref _classid, value);
        }

    }

    internal class MyClass
    {
      
        public string? Name { get; set; }
       
    }
}
