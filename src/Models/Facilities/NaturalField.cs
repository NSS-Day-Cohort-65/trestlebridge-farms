using System;
using System.Collections.Generic;
using Trestlebridge.Interfaces;

namespace Trestlebridge.Models.Facilities
{
    public class NaturalField : IFacility<IPlant>
    {
        private Guid _id = Guid.NewGuid();
        private int _rows = 10;
        private int _plantsPerRow = 6;
        private List<IPlant> _plants = new List<IPlant>();
        public double Capacity
        {
            get 
            {
                return _rows * _plantsPerRow;
            }
        }

        // Methods
        public void AddResource (IPlant plant)
        {

        }

        public void AddResource (List<IPlant> plants)
        {

        }
    }
}