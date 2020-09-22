﻿using System;
using System.Collections;

namespace BasicCollection
{
  class Program
  {

    static void Main(string[] args)
    {
      ArrayList myList = new ArrayList() { "PURGEN" };
      myList.Add("DIMA");
      myList.Add("ARTEM");
      myList.Add("HENESSY");
      myList.Add("assembler");
      foreach (string item in myList)
      {
        Console.WriteLine("Unsorted: {0}", item);
      }
      // Сортировка при помощи стандартного объекта сравнения 
      myList.Sort();
      //myList.Reverse();
      foreach (string item in myList)
      {
        Console.WriteLine("   Sorted: {0}", item);
      }

    }

  }
}