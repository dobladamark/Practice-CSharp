using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_CSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Rectangle Area &Perimeter
            /*string input = Console.ReadLine();

            string[] parts = input.Split(' ');

            double length = double.Parse(parts[0]);
            double width = double.Parse(parts[1]);

            double area = length * width;
            double perimeter = 2 * (length + width);

            Console.WriteLine("Area " + area);
            Console.WriteLine("Perimeter " + perimeter);*/

            //even or odd
            /*int num;

            Console.WriteLine("Input number : ");
            num = int.Parse(Console.ReadLine());

            if (num % 2 == 0)
            {
                Console.WriteLine("Even");
                
            }
            else
            {
                Console.WriteLine("Odd");  
                 
            }
            
            // Grade Calculator
            int grade;
            Console.WriteLine("Input your grade");
            grade = int.Parse(Console.ReadLine());

            if (grade >= 90)
            {
                Console.WriteLine("A");
            }
            else if (grade >= 80)
            {
                Console.WriteLine("B");
            }
            else if (grade >= 70)
            {
                Console.WriteLine("C");
            }
            else if (grade >= 60)
            {
                Console.WriteLine("D");
            }
            else
            {
                Console.WriteLine("F");
            q

            }
            

            //Sum of N Numbers            
            int num;
            Console.WriteLine("Enter num");
            num = int.Parse(Console.ReadLine());

            int sum = 0;

            for (int i = 1; i <= num; i++)
            {
                   sum = sum + i;

            }

            Console.WriteLine("Sum is " + sum);
            

            //Multiplication Table
            int num;
            Console.WriteLine("Enter num");
            num = int.Parse(Console.ReadLine());

            int i = 1;

            do
            {
                Console.WriteLine(num + "x" + i + " = " + (num * i));   
                i++;
            } while (i <= 10);
            
            //Count down
            int n;
            Console.WriteLine("Enter num");
            n = Convert.ToInt32(Console.ReadLine());

            for (int i = n; i >= 1; i--)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("\n");  
            
           //factorial
            int n = int.Parse(Console.ReadLine());

         
            int factorial = 1;  

        
            for (int i = 1; i <= n; i++)
            {
                factorial = factorial * i;  
            }


            Console.WriteLine(factorial);
            
            //triangle pattern
            int num = 0;

            Console.WriteLine("Enter num");
            num = int.Parse(Console.ReadLine());


            for (int i = 0; i < num; i++) 
            { 
            
            for (int j = 0; j < i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            
            }
           
            //find maximum
            int n = int.Parse(Console.ReadLine());

            // Step 2: Read all the numbers (separated by spaces)
            string input = Console.ReadLine();
            string[] parts = input.Split(' ');

            // Step 3: Assume the first number is the maximum
            int max = int.Parse(parts[0]);

            // Step 4: Check each number to find the largest
            for (int i = 1; i < parts.Length; i++)
            {
                int current = int.Parse(parts[i]);

                if (current > max)
                {
                    max = current;  // Found a bigger number!
                }
            }

            // Step 5: Print the maximum
            Console.WriteLine(max);


            int n = int.Parse(Console.ReadLine());

            // Step 2: Read all numbers and split them
            string input = Console.ReadLine();
            string[] parts = input.Split(' ');

            // Step 3: Convert strings to integers and store in array
            int[] numbers = new int[n];
            for (int i = 0; i < n; i++)
            {
                numbers[i] = int.Parse(parts[i]);
            }

            // Step 4: Reverse the array
            Array.Reverse(numbers);

            // Step 5: Print the reversed array
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write(numbers[i] + " ");
            }

             */

            //REVERSE ARRAY
            int n = int.Parse(Console.ReadLine());

            // Step 2: Read all numbers and split them
            string input = Console.ReadLine();
            string[] parts = input.Split(' ');

            // Step 3: Convert strings to integers and store in array
            int[] numbers = new int[n];
            for (int i = 0; i < n; i++)
            {
                numbers[i] = int.Parse(parts[i]);
            }

            // Step 4: Reverse the array
            Array.Reverse(numbers);

            // Step 5: Print the reversed array
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write(numbers[i] + " ");
            }

            // ========================================
            // PROBLEM 2: COUNT VOWELS
            // ========================================

            // Step 1: Read the input string
            string text = Console.ReadLine();

            // Step 2: Convert to lowercase for easier comparison
            text = text.ToLower();

            // Step 3: Initialize counter for vowels
            int count = 0;

            // Step 4: Loop through each character in the string
            for (int i = 0; i < text.Length; i++)
            {
                char ch = text[i];

                // Step 5: Check if character is a vowel
                if (ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u')
                {
                    count++;  // Increment counter if vowel found
                }
            }

            // Step 6: Print the total count
            Console.WriteLine(count);

            // ========================================
            // PROBLEM 3: FIND ELEMENT IN ARRAY
            // ========================================

            // Step 1: Read array size
            int n = int.Parse(Console.ReadLine());

            // Step 2: Read all numbers
            string input = Console.ReadLine();
            string[] parts = input.Split(' ');

            // Step 3: Read the number to search for
            int search = int.Parse(Console.ReadLine());

            // Step 4: Create a flag to track if found
            bool found = false;

            // Step 5: Loop through array to search
            for (int i = 0; i < n; i++)
            {
                int current = int.Parse(parts[i]);

                // Step 6: Check if current number matches search
                if (current == search)
                {
                    found = true;  // Mark as found
                    break;         // Exit loop early (optimization)
                }
            }

            // Step 7: Print result based on flag
            if (found)
            {
                Console.WriteLine("Found");
            }
            else
            {
                Console.WriteLine("Not Found");
            }


            // ========================================
            // PROBLEM 4: PALINDROME CHECK
            // ========================================

            // Step 1: Read the input string
            string text = Console.ReadLine();

            // Step 2: Convert to lowercase (to handle case-insensitive)
            text = text.ToLower();

            // Step 3: Remove spaces (optional, depends on problem)
            text = text.Replace(" ", "");

            // Step 4: Create reversed version of string
            string reversed = "";
            for (int i = text.Length - 1; i >= 0; i--)
            {
                reversed = reversed + text[i];
            }

            // Step 5: Compare original with reversed
            if (text == reversed)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }

            // ========================================
            // PROBLEM 4: PALINDROME CHECK (Method 2)
            // ========================================

            string text = Console.ReadLine().ToLower();

            // Step 1: Use two pointers - start and end
            int left = 0;
            int right = text.Length - 1;

            // Step 2: Assume it's palindrome initially
            bool isPalindrome = true;

            // Step 3: Compare characters from both ends
            while (left < right)
            {
                if (text[left] != text[right])
                {
                    isPalindrome = false;  // Not matching
                    break;
                }
                left++;   // Move left pointer right
                right--;  // Move right pointer left
            }

            // Step 4: Print result
            if (isPalindrome)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }

            // ========================================
            // PROBLEM 5: AVERAGE OF ARRAY
            // ========================================

            // Step 1: Read number of elements
            int n = int.Parse(Console.ReadLine());

            // Step 2: Read all numbers
            string input = Console.ReadLine();
            string[] parts = input.Split(' ');

            // Step 3: Calculate sum of all numbers
            int sum = 0;
            for (int i = 0; i < n; i++)
            {
                int num = int.Parse(parts[i]);
                sum = sum + num;  // Add to sum
            }

            // Step 4: Calculate average (use double for decimal result)
            double average = (double)sum / n;

            // Step 5: Print the average
            Console.WriteLine(average);



            // ========================================
            // PROBLEM 6: SORT AND DISPLAY
            // ========================================

            // Step 1: Read number of elements
            int n = int.Parse(Console.ReadLine());

            // Step 2: Read all numbers
            string input = Console.ReadLine();
            string[] parts = input.Split(' ');

            // Step 3: Convert to integer array
            int[] numbers = new int[n];
            for (int i = 0; i < n; i++)
            {
                numbers[i] = int.Parse(parts[i]);
            }

            // Step 4: Sort the array (ascending order)
            Array.Sort(numbers);

            // Step 5: Print sorted numbers
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write(numbers[i] + " ");
            }


            // ========================================
            // PROBLEM 7: REMOVE DUPLICATES
            // ========================================

            // Step 1: Read number of elements
            int n = int.Parse(Console.ReadLine());

            // Step 2: Read all numbers
            string input = Console.ReadLine();
            string[] parts = input.Split(' ');

            // Step 3: Use List to store unique numbers
            List<int> unique = new List<int>();

            // Step 4: Loop through all numbers
            for (int i = 0; i < n; i++)
            {
                int num = int.Parse(parts[i]);

                // Step 5: Only add if not already in list
                if (!unique.Contains(num))
                {
                    unique.Add(num);
                }
            }

            // Step 6: Print unique numbers
            for (int i = 0; i < unique.Count; i++)
            {
                Console.Write(unique[i] + " ");
            }

            // ========================================
            // PROBLEM 7: REMOVE DUPLICATES (Method 2)
            // ========================================

            int n = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            string[] parts = input.Split(' ');

            // Step 1: Use HashSet (automatically removes duplicates)
            HashSet<int> unique = new HashSet<int>();

            // Step 2: Add all numbers (duplicates ignored automatically)
            for (int i = 0; i < n; i++)
            {
                unique.Add(int.Parse(parts[i]));
            }

            // Step 3: Print unique numbers
            foreach (int num in unique)
            {
                Console.Write(num + " ");
            }

            // ========================================
            // PROBLEM 8: POWER CALCULATOR
            // ========================================

            // Step 1: Read base and exponent
            string input = Console.ReadLine();
            string[] parts = input.Split(' ');

            int baseNum = int.Parse(parts[0]);      // Base number
            int exponent = int.Parse(parts[1]);     // Power/exponent

            // Step 2: Use Math.Pow to calculate
            double result = Math.Pow(baseNum, exponent);

            // Step 3: Convert to int and print
            Console.WriteLine((int)result);

            // ========================================
            // PROBLEM 8: POWER CALCULATOR (Method 2)
            // ========================================

            string input = Console.ReadLine();
            string[] parts = input.Split(' ');

            int baseNum = int.Parse(parts[0]);
            int exponent = int.Parse(parts[1]);

            // Step 1: Start with result = 1
            int result = 1;

            // Step 2: Multiply base by itself exponent times
            for (int i = 0; i < exponent; i++)
            {
                result = result * baseNum;
            }

            // Step 3: Print result
            Console.WriteLine(result);

            // ========================================
            // PROBLEM 9: SECOND LARGEST NUMBER
            // ========================================

            // Step 1: Read number of elements
            int n = int.Parse(Console.ReadLine());

            // Step 2: Read all numbers
            string input = Console.ReadLine();
            string[] parts = input.Split(' ');

            // Step 3: Convert to integer array
            int[] numbers = new int[n];
            for (int i = 0; i < n; i++)
            {
                numbers[i] = int.Parse(parts[i]);
            }

            // Step 4: Sort array in ascending order
            Array.Sort(numbers);

            // Step 5: Second largest is second from end
            int secondLargest = numbers[n - 2];

            // Step 6: Print result
            Console.WriteLine(secondLargest);

            // ========================================
            // PROBLEM 9: SECOND LARGEST (Method 2)
            // ========================================

            int n = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            string[] parts = input.Split(' ');

            // Step 1: Initialize largest and second largest
            int largest = int.Parse(parts[0]);
            int secondLargest = int.Parse(parts[0]);

            // Step 2: Loop through all numbers
            for (int i = 1; i < n; i++)
            {
                int current = int.Parse(parts[i]);

                // Step 3: If current is larger than largest
                if (current > largest)
                {
                    secondLargest = largest;  // Old largest becomes second
                    largest = current;         // Update largest
                }
                // Step 4: If current is between second and largest
                else if (current > secondLargest && current < largest)
                {
                    secondLargest = current;   // Update second largest
                }
            }

            Console.WriteLine(secondLargest);


            // ========================================
            // PROBLEM 10: FREQUENCY COUNTER
            // ========================================

            // Step 1: Read number of elements
            int n = int.Parse(Console.ReadLine());

            // Step 2: Read all numbers
            string input = Console.ReadLine();
            string[] parts = input.Split(' ');

            // Step 3: Read target number to count
            int target = int.Parse(Console.ReadLine());

            // Step 4: Initialize counter
            int count = 0;

            // Step 5: Loop through all numbers
            for (int i = 0; i < n; i++)
            {
                int current = int.Parse(parts[i]);

                // Step 6: If matches target, increment counter
                if (current == target)
                {
                    count++;
                }
            }

            // Step 7: Print frequency
            Console.WriteLine(count);
        }
    }
}
