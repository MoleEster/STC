namespace STCTestTaskTwo
{
    public interface ISubscriber
    {
        int ID { get; }
        int amountOfSubscribers { get; }
        string Username { get; set; }
        void Subscribe(ISubscriber subscriber);
    }
}
