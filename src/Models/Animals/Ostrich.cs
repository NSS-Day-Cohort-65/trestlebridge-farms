using System;
using System.Collections.Generic;
using Trestlebridge.Interfaces;

namespace Trestlebridge.Models.Animals {
    public class Ostrich : IResource, IGrazing, IMeatProducing, IEggProducing 
    {

        private Guid _id = Guid.NewGuid();
        private int _eggsProduced = 3;
        private double _meatProduced = 2.6;
        public double GrassPerDay { get; set; } = 2.3;
        public string Type { get; } = "Ostrich";
        private string _shortId 
        {
            get 
            {
                return this._id.ToString().Substring(this._id.ToString().Length - 6);
            }
        }


        // Methods
        public void Graze () 
        {
            Console.WriteLine($"Ostrich {this._shortId} just ate {this.GrassPerDay}kg of grass");
        }

        public int LayEggs ()
        {
            return _eggsProduced;
        }

        public double Butcher () 
        {
            return _meatProduced;
        }

        public override string ToString () 
        {
            return $"Ostrich {this._shortId}. Squack!";
        }
    }
}