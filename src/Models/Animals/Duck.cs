using System;
using System.Collections.Generic;
using Trestlebridge.Interfaces;

namespace Trestlebridge.Models.Animals
{
    public class Duck : IResource, IDuckHouse, IEggProducing, IFeatherProducing
    {
        private Guid _id = Guid.NewGuid();
        private int _eggsProduced = 6;
        private double _feathersProduced = 0.75;
        public double FeedPerDay { get; set; } = 0.8;
        public string Type { get; } = "Duck";
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
            Console.WriteLine($"Duck {this._shortId} just ate {this.FeedPerDay}kg of food");
        }
        
        public int LayEggs ()
        {
            return _eggsProduced;
        }

        public double Pluck ()
        {
            return _feathersProduced;
        }

        public override string ToString()
        {
            return $"Duck {this._shortId}. Quack!";
        }
    }
}