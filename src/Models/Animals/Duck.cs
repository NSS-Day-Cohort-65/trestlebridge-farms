using System;
using System.Collections.Generic;
using Trestlebridge.Interfaces;

namespace Trestlebridge.Models.Animals
{
    public class Duck : IResource
    {
        private Guid _id = Guid.NewGuid();
        private int _eggsProduced = 6;
        public string Type { get; } = "Duck";
        private string _shortId 
        {
            get 
            {
                return this._id.ToString().Substring(this._id.ToString().Length - 6);
            }
        }

        // Methods
        public int LayEggs ()
        {
            return _eggsProduced;
        }

        public override string ToString()
        {
            return $"Duck {this._shortId}. Quack!";
        }
    }
}