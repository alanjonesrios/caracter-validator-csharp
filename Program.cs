using System;
using System.Collections.Generic;

namespace caracter_validator_csharp
{
  public class Program
  {
    static void Main(string[] args)
    {
      bool error = false;
      var str = "";
      var count = 0;
      Stack<char> stack = new Stack<char>();
      foreach (var item in str.ToCharArray())
      {
        if (item == '(' || item == '{' || item == '[')
        {
          stack.Push(item);
          count++;
        }
        else if (item == ')' || item == '}' || item == ']')
        {
          if (stack.Peek() != GetComplementBracket(item))
          {
            Console.WriteLine("ERROR");
            error = true;
            break;
          }
          else
          {
            count--;
          }
        }
      }

      if (error || count > 0)
        Console.WriteLine("Incorrect brackets");
      else
        Console.WriteLine("Brackets are fine");
      Console.ReadLine();
    }

    private static char GetComplementBracket(char item)
    {
      switch (item)
      {
        case ')':
          return '(';
        case '}':
          return '{';
        case ']':
          return '[';
        default:
          return ' ';
      }
    }
  }

}
