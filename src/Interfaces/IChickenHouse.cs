namespace Trestlebridge.Interfaces
{
    public interface IChickenHouse
    {
        double FeedPerDay { get; set; }
        void Feed();
    }
}