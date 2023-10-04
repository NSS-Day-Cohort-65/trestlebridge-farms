using System;
using System.Collections.Generic;
using Trestlebridge.Interfaces;

namespace Trestlebridge.Models.Animals
{
    public class Chicken : IResource, IChickenHouse, IEggProducing, IFeatherProducing, IMeatProducing
    {
        private Guid _id = Guid.NewGuid();
        private int _eggsProduced = 7;
        private double _feathersProduced = 0.5;
        private double _meatProduced = 1.7;
        public double FeedPerDay { get; set; } = 0.9;
        public string Type { get; } = "Chicken";
        private string _shortId
        {
            get 
            {
                return this._id.ToString().Substring(this._id.ToString().Length - 6);
            }
        }

        // Methods
        public void Feed ()
        {
            Console.WriteLine($"Chicken {this._shortId} just ate {this.FeedPerDay}kg of food");
        }
        
        public int LayEggs ()
        {
            return _eggsProduced;
        }

        public double Pluck ()
        {
            return _feathersProduced;
        }
        
        public double Butcher ()
        {
            return _meatProduced;
        }

        public override string ToString ()
        {
            return $"Chicken {this._shortId}. Cluck!";
        }
    }
}