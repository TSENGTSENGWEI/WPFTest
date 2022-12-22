using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFTest
{
    internal class MainViewModel:NotifyPropertyChange
    {


        public MainViewModel()
        {

            //_studentclass = new ObservableCollection<MyClass>
            //{
            //    new MyClass(){Name="Level"},
            //    new MyClass(){Name="Leve2"},
            //    new MyClass(){Name="Leve3"},
            //};

            //_student = new ObservableCollection<ModelStudent>
            //{
            //    new ModelStudent(){StudentName="Jeff",ClassId=StudentClass },
            //    new ModelStudent(){StudentName="Peter",ClassId=StudentClass},
            //    new ModelStudent(){StudentName="May",ClassId=StudentClass},
            //    new ModelStudent(){StudentName="Jerry",ClassId=StudentClass},
            //};
            _student = new ObservableCollection<ModelStudent>
            {
                new ModelStudent(){StudentName="Jeff",ClassId=new MyClass(){ Name="Level1" } },
                new ModelStudent(){StudentName="Peter",ClassId=new MyClass(){ Name="Level2" } },
                new ModelStudent(){StudentName="May",ClassId=new MyClass(){ Name="Level3" } },
                new ModelStudent(){StudentName="Jerry",ClassId= new MyClass() { Name = "Level4" } },
    
            };

            _data = new ObservableCollection<string>
            {
                "T1",
                "T2",
                "T3",
            };

            _combotext = "Current Tool name length";

        }

        private ObservableCollection<ModelStudent> _student;
        public ObservableCollection<ModelStudent> Student
        {
            get => _student;
            set => SetValue(ref _student, value);
        }

        private ObservableCollection<string> _data;
        public ObservableCollection<string> Data
        {
            get => _data;
            set => SetValue(ref _data, value);
        }

        private string _combotext;
        public string ComboText
        {
            get => _combotext;
            set => SetValue(ref _combotext, value);
        }

        //private ObservableCollection<MyClass> _studentclass;
        //public ObservableCollection<MyClass> StudentClass
        //{
        //    get => _studentclass;
        //    set => SetValue(ref _studentclass, value);
        //}



    }
}
