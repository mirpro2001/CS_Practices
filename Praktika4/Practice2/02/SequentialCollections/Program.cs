﻿using System;
using System.Collections;
namespace SequentialCollections
{
  class Program
  {
    static void Main(string[] args)
    {
      Stack stack = new Stack();
      stack.Push("FIL");
      stack.Push("MERS");
      stack.Push("TRUB");
      stack.Push("Hokkey");
      while (stack.Count > 0)
      {
        object obj = stack.Pop();
        Console.WriteLine("'From Stack: {0}", obj);
      }

    }
  }
}
