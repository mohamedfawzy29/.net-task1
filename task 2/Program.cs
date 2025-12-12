namespace task_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char choice; bool duplicate, find;
            int numToAdd, mean, sum, smallNum, largeNum, searchKey, index, total;
            List<int> numbers = new List<int>();
            while (true)
            {
                
                Console.WriteLine("Menu Options : \n" +
                    "\tP - Print numbers\n" +
                    "\tA - Add a number\n" +        
                    "\tM - Display mean of the numbers\n" +
                    "\tS - Display the smallest number\n" +
                    "\tL - Display the largest number\n" +
                    "\tF - Find a number\n" +
                    "\tO - Display the odd numbers\n" +
                    "\tE - Display the even numbers\n" +
                    "\tT - Display the total of the numbers\n" +
                    "\tC - Clear the list\n" +
                    "\tQ - Quit");
                Console.Write("Enter your choice : ");
                choice = Convert.ToChar(Console.ReadLine().ToUpper());
                switch (choice)
                {
                    case 'P':
                        {
                            Console.Clear();
                            if (numbers.Count == 0)
                            {
                                Console.WriteLine("[] - the list is empty");
                            }
                            else
                            {
                                Console.Write("Numbers in the list are : [ ");
                                for (int i = 0; i < numbers.Count; i++)
                                {
                                    Console.Write(numbers[i] + " ");
                                }
                                Console.Write("]");
                            }
                            break;
                        }
                    case 'A':
                        {
                            Console.Clear();
                            Console.Write("Enter the number to be added : ");
                            numToAdd = Convert.ToInt32(Console.ReadLine());
                            if (numbers.Count == 0)
                            {
                                numbers.Add(numToAdd);
                                Console.WriteLine(numToAdd + " added");
                            }
                            else
                            {
                                duplicate = false;
                                for (int i = 0; i < numbers.Count; i++)
                                {
                                    if (numbers[i] == numToAdd)
                                    {
                                        duplicate = true;
                                        break;
                                    }
                                }
                                if (duplicate)
                                {
                                    Console.WriteLine(numToAdd + " is already in the list , not added");
                                    break;
                                }
                                else
                                {
                                    numbers.Add(numToAdd);
                                    Console.WriteLine(numToAdd + " added");
                                }
                            }
                            break;
                        }
                    case 'M':
                        {
                            Console.Clear();
                            if (numbers.Count == 0)
                            {
                                Console.WriteLine("There is numbets in the list to calculate the mean");
                            }
                            else
                            {
                                sum = 0;
                                for (int i = 0; i < numbers.Count; i++)
                                {
                                    sum += numbers[i];
                                }
                                mean = sum / numbers.Count;
                                Console.WriteLine("Mean of the numbers is : " + mean);
                            }
                            break;
                        }
                    case 'S':
                        {
                            Console.Clear();
                            if (numbers.Count == 0)
                            {
                                Console.WriteLine("There is numbets in the list to calculate the minimum number");
                            }
                            else
                            {
                                smallNum = numbers[0];
                                for (int i = 0; i < numbers.Count; i++)
                                {
                                    if (smallNum > numbers[i])
                                    {
                                        smallNum = numbers[i];
                                    }
                                    
                                }
                                Console.WriteLine($"the smallest number in the list is : {smallNum}");
                            }
                            break;
                        }
                    case 'L':
                        {
                            Console.Clear();
                            if (numbers.Count == 0)
                            {
                                Console.WriteLine("There is numbets in the list to calculate the maximum number");
                            }
                            else
                            {
                                largeNum = numbers[0];
                                for (int i = 0; i < numbers.Count; i++)
                                {
                                    if (largeNum < numbers[i])
                                    {
                                        largeNum = numbers[i];
                                    }
                                }
                                Console.WriteLine($"the largest number in the list is : {largeNum}");
                            }
                            break;
                        }
                    case 'F':
                        {
                            Console.Clear();
                            find = false;
                            Console.Write("Enter the number to find : ");
                            searchKey = Convert.ToInt32(Console.ReadLine());
                            for ( index = 0; index < numbers.Count; index++)
                            {
                                if (numbers[index] == searchKey)
                                {
                                    find = true;
                                    break;
                                }
                            }
                            if (find)
                            {
                                Console.WriteLine($"{searchKey} is in the list and the index is {index}");
                            }
                            else
                            {
                                Console.WriteLine($"{searchKey} is not in the list");
                            }
                            break;
                        }
                    case 'O':
                        {
                            Console.Clear();
                            if (numbers.Count == 0)
                            {
                                Console.WriteLine("[] - the list is empty");
                            }
                            else
                            {
                                Console.Write("Odd numbers in the list are : [ ");
                                for (int i = 0; i < numbers.Count; i++)
                                {
                                    if ((numbers[i]&1)!=0)
                                    {
                                        Console.Write(numbers[i] + " ");
                                    }
                                }
                                Console.Write("]");
                            }
                            break;
                        }
                    case 'E':
                        {
                            Console.Clear();
                            if (numbers.Count == 0)
                            {
                                Console.WriteLine("[] - the list is empty");
                            }
                            else
                            {
                                Console.Write("Even numbers in the list are : [ ");
                                for (int i = 0; i < numbers.Count; i++)
                                {
                                    if ((numbers[i]&1)==0)
                                    {
                                        Console.Write(numbers[i] + " ");
                                    }
                                }
                                Console.Write("]");
                            }
                            break;
                        }
                    case 'T':
                        {
                            Console.Clear();
                            total = 0;
                            for (int i = 0; i < numbers.Count; i++)
                            {
                                total += numbers[i];
                            }
                            Console.WriteLine("Total of the numbers is : " + total);
                            break;
                        }
                    case 'C':
                        {
                            Console.Clear();
                            numbers.Clear();
                            Console.WriteLine("List cleared");
                            break;
                        }
                    case 'Q':
                        {
                            Console.Clear();
                            Console.WriteLine("Goodbye!");
                            return;
                        }
                }
                Console.WriteLine("\n--------------------------------------------------------------------------------------\n");

            }
        }
    }
}
