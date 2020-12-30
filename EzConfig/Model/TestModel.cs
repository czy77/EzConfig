using System.ComponentModel;
using System.Runtime.CompilerServices;
using EzConfig.Annotations;

namespace EzConfig.Model
{
    public class TestModel
    {
        public string First;
        public string Second;
        public string Third;

        public TestModel(string first, string second, string third)
        {
            First = first;
            Second = second;
            Third = third;
        }
        
    }
    
    
    
}