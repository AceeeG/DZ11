using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab
{
    internal class BuildingList
    {
        private Building[] buildings = new Building[10];
        public Building[] Buildings 
        {
            get 
            { 
                return buildings;
            }
            set
            {
                buildings = value;
            }
        }
        public Building this[int index]
        {
            get
            {
                return buildings[index];
            }
        }
        public BuildingList()
        {
            for(int i = 0; i < buildings.Length; i++)
            {
                buildings[i] = new Building();
            }
        }
        public void Print()
        {
            for(int i = 0; i < buildings.Length; i++) 
            {
                this[i].Print();
            }
        }
    }
}
