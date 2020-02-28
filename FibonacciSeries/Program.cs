using System;

namespace FibonacciSeries {
  class Program {
	  const int MAGIC_NUMBER = 10;
	  
    static void Main(string[] args) {
      int[] fibonacci = CreateFibonacciSeries(MAGIC_NUMBER);

      for (int i = 0; i < fibonacci.Length; i++) {
        Console.Out.Write(fibonacci[i]);
        Console.Out.Write(" ");
      }
      Console.Out.WriteLine();
    }

    static int CreateFibonacciNumber(int index) {
      if (index == 0) return 0;
      if (index == 1) return 1;
      return CreateFibonacciNumber(index - 1) + CreateFibonacciNumber(index - 2);
    }

    static int[] CreateFibonacciSeries(int count) {
	  if (count < 0) {
		Console.Out.Write("Fibonacci count has to be > 0");
		return new int[1];
	  }
	  
      int[] fibonacciSeries = new int[count];
      for (int i = 0; i < count; i++)
        fibonacciSeries[i] = CreateFibonacciNumber(i);
      return fibonacciSeries;
    }
  }
}
