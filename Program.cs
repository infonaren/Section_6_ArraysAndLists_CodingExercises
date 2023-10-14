using System;
using System.Collections.Generic;
using System.Linq;

namespace Section_6_ArraysAndLists_CodingExercises
{
    class Program
    {

        static int FindMissingNumber(int[] arr1, int[] arr2)
        {


            int sum1 = arr1.Sum();
            int sum2 = arr2.Sum();

            return sum1 - sum2;
        }


        static List<int> GetNumbersFromUser()
        {
            Console.WriteLine("Supply a list of comma separated numbers (e.g 5, 1, 9, 2, 10)");
            var input = Console.ReadLine();
            var numbers = new List<int>();

            try
            {
                numbers = input.Split(',').Select(int.Parse).ToList();
            }

            catch (FormatException)
            {
                Console.WriteLine("Invalid input. Please enter numbers separated by commas.");

            }

            return numbers;

        }

        static int FindTheMissingNumber(List<int> list1, List<int> list2)
        {
            int list1Sum = 0;
            int list2Sum = 0;

            foreach (int num in list1)
            {
                list1Sum += num;
            }

            foreach (int num in list2)
            {
                list2Sum += num;
            }

            return list1Sum - list2Sum;
        }

        static List<int> GetThreeSmallestNumbers(List<int> inList)
        {
            return inList.OrderBy(n => n).Take(3).ToList();
        }

        static List<int> FiindMissingNumbers(List<int> list3, List<int> list4)
        {
            // Use LINQ to perform set operations
            List<int> missingNumbers = list3.Except(list4).ToList();
            missingNumbers.AddRange(list4.Except(list3));
            return missingNumbers;
        }
        static void Main(string[] args)
        {

            List<int> list3 = new List<int> { 2, 3, 5, 6 };
            List<int> list4 = new List<int> { 1, 3, 4, 6 };

            List<int> missingTnumbers = FiindMissingNumbers(list3, list4);

            Console.WriteLine("Missing numbers: " + string.Join(", ", missingTnumbers));

            List<int> list1 = new List<int> { 1, 2, 3, 4, 5, 6 };
            List<int> list2 = new List<int> { 1, 2, 3, 4, 6 };

            int missingNumber = FindTheMissingNumber(list1, list2);

            Console.WriteLine("The missing number is: " + missingNumber);
            int[] arr1 = { 1, 2, 3, 4, 5 };
            int[] arr2 = { 1, 2, 3, 4 };

            int missingNumbers = FindMissingNumber(arr1, arr2);

            Console.WriteLine("The missing number is: " + missingNumbers);

            int[] array1 = { 1, 2, 3, 4, 5 };
            int[] array2 = { 2, 3, 1, 0, 5 };

            var missingNuumbers = array1.Except(array2).Union(array2.Except(array1));

            Console.WriteLine("Missing numbers:");
            foreach (int num in missingNuumbers)
            {
                Console.WriteLine(num);
            }

            List<string> likedBy = new List<string>();

            while (true)
            {
                Console.Write("Enter a name (press Enter to finish): ");
                string name = Console.ReadLine();

                if (string.IsNullOrEmpty(name))
                {
                    break;
                }

                likedBy.Add(name);

                var numberOfLikes = likedBy.Count;

                if(numberOfLikes == 0)
                {
                    Console.WriteLine("No one likes your post. ");
                }
                else if (numberOfLikes == 1){
                    Console.WriteLine($"{likedBy[0]} likes your post.");
                }
                else if (numberOfLikes == 2)
                {
                    Console.WriteLine($"{likedBy[0]} and {likedBy[1]} like your post.");
                }
                else
                {
                    var othersCount = numberOfLikes - 2;
                    Console.WriteLine($"{likedBy[0]}, {likedBy[1]}, and {othersCount} like your post.");
                }
               
            }

            Console.WriteLine("Enter the user name: ");
            var username = Console.ReadLine();

            // Reverse a string using Array.Reverse() Method and iterate using for each loop
            char[] charArray = username.ToCharArray();
            Array.Reverse(charArray);

            foreach (var character in charArray)
                Console.Write(character);

            Console.WriteLine();

            // Reverse a string using traditional for loop
            var reverseString = String.Empty;
            Console.WriteLine("Reverse a string using traditional for loop");
            for (var i = username.Length - 1; i >= 0; i--)
                reverseString += username[i];

            Console.WriteLine("Reversing the string: " + reverseString);

            Console.WriteLine("\n");

            var numbersList = new List<int>();
            Console.WriteLine("Enter 5 numbers");

            var continueInput = true;
            while (continueInput)
            {

                for (var i = 1; i < 6; i++)
                {
                 
                    Console.WriteLine("Enter the number");
                    var userNumber = Convert.ToInt32(Console.ReadLine());

                    if (numbersList.Contains(userNumber))
                    {
                        Console.WriteLine("Error: Number has already been entered. Please try again.");

                    }
                    else
                    {
                        Console.WriteLine(string.Format("You've entered the {0} number", i));
                        numbersList.Add(userNumber);
                        if (i == 5)
                        {
                            continueInput = false;
                            break;
                        }
                    }
                   
                }
                  
            }
#pragma warning disable CS0162 // Unreachable code detected
            numbersList.Sort();
            foreach (var number in numbersList)
#pragma warning restore CS0162 // Unreachable code detected
                Console.WriteLine("The numbers are: {0}", number);
            int[] numbers = new int[5];
            int index = 0;

            while (index < 5)
            {
                Console.Write($"Enter number {index + 1}: ");
                int input = int.Parse(Console.ReadLine());

                if (Array.Exists(numbers, element => element == input))
                {
                    Console.WriteLine("Error: This number has been previously entered. Please re-try.");
                }
                else
                {
                    numbers[index] = input;
                    index++;
                }
            }

            Array.Sort(numbers);

            Console.WriteLine("Sorted Numbers:");
            foreach (int num in numbers)
            {
                Console.WriteLine(num);
            }

            var isContinue = true;
            var inputNumbersList = new List<int>();
            while (isContinue)
            {
                Console.WriteLine("Enter a number or type 'Quit' to exit.");
                var inputString = Console.ReadLine();
                
                if (inputString.ToLower().Equals("quit"))
                {
                    isContinue = false;
                    break;
                }

                else
                {
                    var inputNumber = Convert.ToInt32(inputString);
                    if (inputNumbersList.Contains(inputNumber))
                    {
                        Console.WriteLine("Error: Number has already been entered. Please try again.");
                    }
                    else
                    {
                        inputNumbersList.Add(inputNumber);
                    }
                } 
            }
            foreach (var number in inputNumbersList)
                Console.WriteLine("The unique numbers are: " + number);


            List<int> inList = GetNumbersFromUser();

            while (inList.Count < 5)
            {
                Console.WriteLine("Invalid List. Please enter at least 5 numbers.");

                inList = GetNumbersFromUser();
            }

           List<int> smallestThree = GetThreeSmallestNumbers(inList);
           Console.WriteLine("The three smallest numbers are: " + string.Join(", ", smallestThree));
     

        }


    }
    
}

/*
                                                Exercises
            Note: For any of these exercises, ignore input validation unless otherwise directed.
            Assume the user enters values in the format that the program expects.



             1- When you post a message on Facebook, depending on the number of people who like your post, 
             Facebook displays different information.
             If no one likes your post, it doesn't display anything.
             If only one person likes your post, it displays: [Friend's Name] likes your post.
             If two people like your post, it displays: [Friend 1] and [Friend 2] like your post.
             If more than two people like your post, it displays: [Friend 1], [Friend 2] and [Number of Other People]
             others like your post.
            
             Write a program and continuously ask the user to enter different names, until the user presses Enter 
            (without supplying a name).
             Depending on the number of names provided, display a message based on the above pattern.



             2- Write a program and ask the user to enter their name. Use an array to reverse the name and then
             store the result in a new string. Display the reversed name on the console.


             3- Write a program and ask the user to enter 5 numbers. If a number has been previously entered,
             display an error message and ask the user to re-try. Once the user successfully enters 5 unique numbers,
             sort them and display the result on the console.



             4- Write a program and ask the user to continuously enter a number or type "Quit" to exit. 
             The list of numbers may include duplicates. Display the unique numbers that the user has entered.



             5- Write a program and ask the user to supply a list of comma separated numbers (e.g 5, 1, 9, 2, 10).
             If the list is empty or includes less than 5 numbers, display "Invalid List" and ask the user to 
             re-try; otherwise, display the 3 smallest numbers in the list. 

             6- Write a C# program to find the missing numbers of two arrays.

             7- Write a C# program to find the missing number in one of the two arrays.

             8- Write a C# program to find the missing numbers of two lists.

             9- Write a C# program to find the missing numbers in one of the two lists.

 
             
             */