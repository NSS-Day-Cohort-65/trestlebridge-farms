using System;
using System.Text;
using System.Collections.Generic;
using Trestlebridge.Interfaces;
using Trestlebridge.Models.Animals;

namespace Trestlebridge.Models.Facilities
{
    public class DuckHouse : IFacility<Duck>
    {
        private int _capacity = 12;
        private Guid _id = Guid.NewGuid();
        private List<Duck> _ducks = new List<Duck>();
        public double Capacity
        {
            get 
            {
                return _capacity;
            }
        }

        // Methods
        public void AddResource (Duck duck)
        {
            //TODO: implement this...
            throw new NotImplementedException();
        }

        public void AddResource (List<Duck> ducks)
        {
            // TODO: implement this...
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            StringBuilder output = new StringBuilder();
            string shortId = $"{this._id.ToString().Substring(this._id.ToString().Length - 6)}";

            output.Append($"Duck house {shortId} has {this._ducks.Count} animals\n");
            this._ducks.ForEach(a => output.Append($"   {a}\n"));

            return output.ToString();
        }
    }
}