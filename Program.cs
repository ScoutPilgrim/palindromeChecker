using System;
using System.Linq;

class Program
{
  static void Main()
  {
    Console.WriteLine("Enter a word:");
    string userString = Console.ReadLine();
    char[] userStrLeft = userString.Substring(0, (userString.Length/2)).ToCharArray();
    char[] userStringRight = userString.Substring(userString.Length/2).ToCharArray();
    char[] revUserStrLeft = new char[userStrLeft.Length];
    char[] shavedUserStringRight = new char[userStringRight.Length - 1];
    Array.Copy(userStrLeft, revUserStrLeft, userStrLeft.Length);
    Array.Reverse(revUserStrLeft);
    string output = "";
    string leftStr = "";
    string rightStr = "";
    string revLeftStr = "";
    for(int i = 0; i < userStrLeft.Length; i++)
    {
      leftStr += userStrLeft[i];
    }
    for(int i = 0; i < userStringRight.Length; i++)
    {
      rightStr += userStringRight[i];
    }
    for(int i = 0; i < revUserStrLeft.Length; i++)
    {
      revLeftStr += revUserStrLeft[i];
    }
    Console.WriteLine("Left half: " + leftStr);
    Console.WriteLine("Right half: " + rightStr);
    Console.WriteLine("Reversed Left Half: " + revLeftStr);

    if(userString.Length % 2 != 0){
      Array.Copy(userStringRight, 1, shavedUserStringRight, 0, shavedUserStringRight.Length);
      rightStr = "";
      for(int i = 0; i < shavedUserStringRight.Length; i++)
      {
        rightStr += shavedUserStringRight[i];
      }
      Console.WriteLine("Shaved off right half: " + rightStr);
      output = revUserStrLeft.SequenceEqual(shavedUserStringRight) ? "Is a palindrome." : "Is NOT a palindrome";
      Console.WriteLine(output);
      return;
    }
    output = revUserStrLeft.SequenceEqual(userStringRight) ? "Is a palindrome." : "Is NOT a palindrome";
    Console.WriteLine(output);
  }
}
