using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using EzConfig.Model;

namespace EzConfig.ViewModel
{
    public class MainWindowViewModel : NotificationObject
    {

        private List<TestModel> _models = new List<TestModel>
        {
            new TestModel("1", "hello", "world"),
            new TestModel("2", "hello", "world"),
            new TestModel("3", "hello", "world"),
            new TestModel("4", "hello", "world"),
        };

        public List<TestModel> Models
        {
            get => _models;
            set
            {
                _models = value;
                this.OnPropertyChanged(nameof(_models));
            }
        }


        public TestModel M1 { get; set; } = new TestModel("1", "hello", "world");
    }
}