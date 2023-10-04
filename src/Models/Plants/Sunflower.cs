using Trestlebridge.Interfaces;

namespace Trestlebridge.Models.Plants
{
    public class Sunflower: IResource, IPlant, ISeedProducing, ICompostProducing
    {
        private int _seedsProduced = 650;
        private double _compostProduced = 21.6;
        public string Type { get; } = "Sunflower";

        public double Harvest () 
        {
            return _seedsProduced;
        }

        public double Collect () 
        {
            return _compostProduced;
        }

        public override string ToString ()
        {
            return $"Sunflower. A-aay-aaay-aaay!";
        }
    }
}