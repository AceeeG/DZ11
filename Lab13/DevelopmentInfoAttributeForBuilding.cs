using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab13
{
    [AttributeUsage(AttributeTargets.Class)]
    internal class DevelopmentBuildingInfoAttribute : Attribute
    {
        private string name;
        public string Name
        {
            get
            {
                return name;
            }
        }
        private string organization;
        public string Organization
        {
            get
            {
                return organization;
            }
        }
        public DevelopmentBuildingInfoAttribute(string name, string organization)
        {
            this.name = name;
            this.organization = organization;
        }
    }
}
