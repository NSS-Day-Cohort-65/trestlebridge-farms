using System;
using Trestlebridge.Interfaces;

namespace Trestlebridge.Models.Plants
{
    public class Wildflower : IResource, IPlant, ICompostProducing
    {
        private double _compostProduced = 30.3;
        public string Type { get; } = "Wildflower";

        public double Collect () 
        {
            return _compostProduced;
        }

        public override string ToString () 
        {
            return $"Wildflower. Nice!";
        }
    }
}