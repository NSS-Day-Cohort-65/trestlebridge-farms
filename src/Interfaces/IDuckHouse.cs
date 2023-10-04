using System.Runtime.CompilerServices;

namespace Trestlebridge.Interfaces
{
    public interface IDuckHouse
    {
        double FeedPerDay { get; set; }
        void Feed();
    }
}