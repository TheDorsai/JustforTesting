using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharpBeginners
{
    class Program
    {
        static void Main(string[] args)
        {
          //  // Section 45
          //  // Display Larger Number
          //  Console.Write("Enter 1st number: ");
          //  int number1 = Convert.ToInt32(Console.ReadLine());
          //  Console.Write("Enter 2nd number: ");
          //  int number2 = Convert.ToInt32(Console.ReadLine());

          //  if (number1 > number2)
          //  {
          //      Console.WriteLine(number1);
          //      Console.ReadLine();
          //  }
          //  else
          //  {
          //      if (number2 > number1)
          //      {
          //          Console.WriteLine(number2);
          //          Console.ReadLine();
          //      }
          //      else
          //      {
          //          if (number1 == number2)
          //          {
          //              Console.WriteLine("Numbers are equal");
          //              Console.ReadLine();
          //          }
          //      }

          //  }

          // // Landscape or Portrait
          //   Console.Write("Enter the width: ");
          //  int width = Convert.ToInt32(Console.ReadLine());
          //  Console.Write("Enter the height: ");
          //  int height = Convert.ToInt32(Console.ReadLine());

          //  if (width == height)
          //  {
          //      Console.WriteLine("Image is square");
          //      Console.Read();
          //  }
          //  if (height > width)
          //  {
          //      Console.WriteLine("Image is portrait");
          //      Console.Read();
          //  }
          //  Console.WriteLine("Image is landscape");
          //  Console.Read(); 

          // //Speed Camera
          //  Console.Write("Enter the speed limit :");
          //  int limit = Convert.ToInt32(Console.ReadLine());

          //  Console.Write("Enter vehicle speed :");
          //  int vehicle = Convert.ToInt32(Console.ReadLine());

          //  if (vehicle <= limit)
          //  {
          //      Console.WriteLine("Ok");
          //      Console.Read();
          //  }
          //  int speedDiff = vehicle - limit;

          //  int demerit = speedDiff / 5;
          //  Console.WriteLine("Demerits awarded for speeding {0}", demerit);

          //  if (demerit > 12)
          //  {
          //      Console.WriteLine("License Suspended");

          //  }

          ////  Section 49
          //  // Divisible by 3
          //  int numbersCounted = 0;
          //  for (int i = 1; i <= 100; i++)
          //  {
          //      if (i % 3 == 0)
          //      {
          //          numbersCounted++;
          //          Console.Write(i + " ");
          //      }
          //  }
          //  Console.WriteLine();
          //  Console.WriteLine(numbersCounted);

          //  //Calculate sum of all numbers entered
          //  bool ok = false;
          //  int total = 0;
          //  while (!ok)
          //  {
          //      Console.WriteLine("Enter a number or 'ok' to quit: ");
          //      var choice = Console.ReadLine();
          //      if (choice != "ok")
          //      {
          //          total += Convert.ToInt32(choice);
          //          continue;
          //      }
          //      Console.WriteLine(total);
          //      ok = true;
          //  }

          //  //Factorial of User's Number
          //   total = 1;
          //  Console.WriteLine("enter a number to compute factorial: ");
          //  int num = Convert.ToInt32(Console.ReadLine());
          //  for (int i = num; i > 0; i--)
          //  {
          //      total *= i;
          //  }
          //  Console.WriteLine(total);

          // // Guess the random number
          //  int guessCount = 4;
          //  var random = new Random();
          //  var numberToGuess = random.Next(1, 10);

          //  while (guessCount > 0)
          //  {
          //      Console.WriteLine("What is your guesss? ");
          //      int userGuess = Convert.ToInt32(Console.ReadLine());
          //      if (userGuess != numberToGuess)
          //      {
          //          guessCount--;
          //      }
          //      else if (userGuess == numberToGuess)
          //      {
          //          Console.WriteLine("Correct");
          //          break;
          //      }
          //  }
          //  if (guessCount == 0)
          //  {
          //      Console.WriteLine("You Lose. The number was " + numberToGuess);
          //  }

          // // Find Largest Number
          //  Console.WriteLine("Enter a list of numbers separated by a comma (10 numbers max)");
          //  string numString = Console.ReadLine();
          //  string[] numbersEntered = numString.Split(',');
          //  int[] numbers = new int[numbersEntered.Length];
          //  for (int i = 0; i < numbersEntered.Length; i++)
          //  {
          //      numbers[i] = Convert.ToInt32(numbersEntered[i]);
          //  }
          //  //Find Largest

          //  Console.WriteLine();

          //  Console.WriteLine("The smallest number is {0}", numbers.Min());
          //  Console.WriteLine("The largest number is {0}", numbers.Max());

          //  //Section 56
          // //Post Rater
          //  List<string> friends = new List<string>();
          //  string name = "";
          //  Console.WriteLine("Who liked your post? ");
          //  while (name == "")
          //  {
          //      string peopleWhoLiked = Console.ReadLine();
          //      if (peopleWhoLiked.Length > 0)
          //      {
          //          friends.Add(peopleWhoLiked);
          //      }
          //      else
          //      {
          //          name = "finished";
          //      }
          //  }
          //  switch (friends.Count)
          //  {
          //      case 0:
          //          Console.WriteLine("No one liked your post");
          //          break;

          //      case 1:
          //          Console.WriteLine("{0} liked your post", friends.ElementAt(0));
          //          break;

          //      case 2:
          //          Console.WriteLine("{0} and {1} liked your post", friends.ElementAt(0), friends.ElementAt(1));
          //          break;

          //      default:
          //          Console.WriteLine("{0} and {1}  and {2} other(s) liked your post", friends.ElementAt(0), friends.ElementAt(1), friends.Count - 2);
          //          break;
          //  }

          // // Reverse Name
          //  Console.WriteLine("Enter your name: ");
          //  var nameToReverse = Console.ReadLine();
          //  char[] nameArray = nameToReverse.ToCharArray();
          //  for (int i = nameArray.Length - 1; i >= 0; i--)
          //  {
          //      Console.Write(nameArray[i]);
          //  }
          //  Console.WriteLine();

          //  //Enter five unique numbers, sort list and display on console
          //  List<int> toSort = new List<int>();
          //  int totalNumbersEntered = 0;
          //  while (totalNumbersEntered <= 4)
          //  {
          //      Console.WriteLine("Enter a number: ");
          //      int inputNumber = Convert.ToInt32(Console.ReadLine());
          //      if (toSort.Contains(inputNumber))
          //      {
          //          Console.WriteLine("Already entered that number!");
          //      }
          //      else
          //      {
          //          toSort.Add(inputNumber);
          //          total++;
          //      }
          //  }
          //  toSort.Sort();
          //  foreach (int inputNumber in toSort)
          //  {
          //      Console.Write(num + " ");
          //  }
            Console.WriteLine();

           //Display unique numbers in list
            List<int> toCheck = new List<int>();
            List<int> uniques = new List<int>();
            Console.WriteLine("Enter numbers or 'quit' to exit: ");
            string input = "";
            while (input != "quit")
            {
                input = Console.ReadLine();
                if (input != "quit")
                {
                    toCheck.Add(Convert.ToInt32(input));
                }

            }
            toCheck.Sort();
            Console.WriteLine("List of numbers entered: ");
            foreach (int item in toCheck)
            {
                Console.Write(item + " ");
            }
            int[] numToCheck = new int[toCheck.Count];
            Console.WriteLine();
            Console.WriteLine("List of unique numbers entered: ");
            for (int i = 0; i <= toCheck.Count - 1; i++)
            {
                if (!uniques.Contains(toCheck[i]))
                {
                    numToCheck[i] = 1;
                    uniques.Add(toCheck[i]);
                }

            }
            for (int i = 0; i <= uniques.Count - 1; i++)
            {
                Console.Write(uniques[i] + " ");
            }

           // Input at least 5 numbers in a comma separated list and show smallest three numbers
            string status = "bad";

            Console.WriteLine("Input a list of five numbers separated by commas: ");

            while (status == "bad")
            {
                string inputToList = Console.ReadLine();
                string[] parsedString = inputToList.Split(",");
                status = (parsedString.Length >= 5) ? "good" : "bad";
                if (status == "bad")
                {
                    Console.WriteLine("Invalid list - try again");
                    continue;
                }
                int[] numberList = new int[parsedString.Length];
                for (int i = 0; i <= parsedString.Length - 1; i++)
                {
                    numberList[i] = Convert.ToInt32(parsedString[i]);
                }
                Array.Sort(numberList);
                Console.WriteLine("Three smallest are:  {0} {1} and {2}", numberList[0], numberList[1], numberList[2]);
            }

            //Section 68
            // Consecutive Numbers(Hyphen Separated)
            List<int> number = new List<int>();
            Console.WriteLine("Enter a hyphen separated list of numbers: ");
            string inputtocheck = Console.ReadLine();
            string[] digits = inputtocheck.Trim().Split("-");
            foreach (string digit in digits)
            {
                number.Add(Convert.ToInt32(digit));
            }
            bool inOrderUp = ascendingOrder(digits, number);
            bool inOrderDown = descendingOrder(digits, number);
            Console.WriteLine(((inOrderDown == true) || (inOrderUp == true)) ? "Consecutive" : "Not Consecutive");

            static bool ascendingOrder(string[] num, List<int> number)
            {
                for (int i = 0; i <= number.Count - 2; i++)
                {
                    if (number[i] + 1 != number[i + 1])
                    {
                        return false;
                    }

                }
                return true;
            }

            static bool descendingOrder(string[] num, List<int> number)
            {
                for (int i = number.Count - 1; i >= 1; i--)
                {
                    if (number[i] != number[i - 1] - 1)
                    {
                        return false;
                    }
                }
                return true;
            }

            var builder = new StringBuilder();
            builder.Append('-', 10);
            builder.AppendLine();
            builder.Append("Header");
            builder.AppendLine();
            builder.Append('-', 10);

            builder.Replace('-', '+');

            builder.Remove(0, 10);

            builder.Insert(0, new string('-', 10));

            Console.WriteLine("First character: {0}", builder[0]);
            Console.WriteLine(builder);


        }
    }
}

