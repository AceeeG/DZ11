using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab
{
    [AttributeUsage(AttributeTargets.Class)]
    internal class DeveloperInfoAttribute : Attribute
    {
        private string name;
        public string Name
        {
            get
            {
                return name;
            }
        }
        private string date;
        public string Date
        {
            get
            {
                return date;
            }
        }

        public DeveloperInfoAttribute(string name, string date) 
        { 
            this.name = name;
            this.date = date;
        }


    }
}
