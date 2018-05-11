namespace Queues
{
    interface IQueue
    {
        void Enqueue<T>(T item);

        void Dequeue(string itemId);

        //void Peek();
    }
}