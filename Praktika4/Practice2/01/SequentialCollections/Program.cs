using System;
using System.Collections;
namespace SequentialCollections
{
  class Program
  {
    static void Main(string[] args)
    {
      Queue queue = new Queue();

      queue.Enqueue("ARTEM");
      queue.Enqueue("DIMA");
      queue.Enqueue("LOVE C++");
      queue.Enqueue("***");

      while (queue.Count > 0)
      {
        object obj = queue.Dequeue();
        Console.WriteLine("From Queue: {0}", obj);
      }
    }
  }
}
