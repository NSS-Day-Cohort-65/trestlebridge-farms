using System;
using System.Collections.Generic;
using Trestlebridge.Interfaces;

namespace Trestlebridge.Models.Animals
{
    public class Goat : IResource
    {
        private Guid _id = Guid.NewGuid();
        public string Type { get; } = "Goat";
        private string _shortId
        {
            get 
            {
                return this._id.ToString().Substring(this._id.ToString().Length - 6);
            }
        }

        // Methods
        public override string ToString ()
        {
            return $"Goat {this._shortId}. Maa!";
        }
    }
}