public static class Program
{
    public static void Main()
    {
        Console.WriteLine(Addition.Add(1, 2));
        Console.WriteLine(Subtraction.Subtract(3, 4));
        Console.WriteLine(Multiplication.Multiply(5, 6));
        Console.WriteLine(Division.Divide(7, 8));
    }
}

// esta  es la operacion de multiplicacion 
public class Multiplication
{
    public static int Multiply(int a, int b)
    {
        return a * b;
    }
}

<<<<<<< HEAD
public class Division
  {
     public static double Divide(int a, int b)
     {
         return (double)a / b;
=======
// esta  es la operacion de adicion
 public class Addition
  {
     public static int Add(int a, int b)
     {
         return a + b;
>>>>>>> 9d1b272abc2047b47ff121f5517f9c91e1cca312
     }
  }

