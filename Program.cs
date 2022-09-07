namespace ConditionalStatementsD24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("\n 1. Vowel Consonant Check \n 2. Positive Negative Check \n 3. Largest among 3 (nested) \n 4. Largest Among 3 (using array.max) \n 5. Print a-z \n 6. Exit \n\n Input the number corresponding to desired program : "); var input = Console.ReadLine();
            switch (input)
            {
                case "1":
                    Console.Write("\nInput an alphabet : "); var character = (Console.ReadLine()).ToLower();
                    if (character.Length > 1) { Console.WriteLine("\n Invalid Input !! Try Again"); Main(args); }
                    VowelConsonant.ChkAlphabet(character);
                    Main(args);
                    break;

                case "2":
                    Console.Write("\nInput a number : "); var number = Convert.ToInt32(Console.ReadLine());
                    NumberSign.CheckNumber(number);
                    Main(args);
                    break;

                case "3":
                    Console.Write("\nInput 3 numbers (separated by space) : "); var strNumber = Console.ReadLine();
                    string[] stringNumbers = strNumber.Split(' ');
                    int[] numbers = new int[stringNumbers.Length];
                    for (var i = 0; i < numbers.Length; i++)
                        numbers[i] = Convert.ToInt32(stringNumbers[i]);

                    FindLargest.UsingNestedCondition(numbers);
                    Main(args);
                    break;

                case "4":
                    Console.Write("\nInput 3 numbers (separated by space) : "); var strNum = Console.ReadLine();
                    string[] strNumbers = strNum.Split(' ');
                    int[] nums = new int[strNumbers.Length];
                    for (var i = 0; i < nums.Length; i++)
                        nums[i] = Convert.ToInt32(strNumbers[i]);

                    FindLargest.UsingAccumulator(nums);
                    Main(args);
                    break;

                case "5":
                    PrintAlphabets.Print();
                    Main(args);
                    break;

                case "6":
                    break;

                default:
                    Main(args);
                    break;
            }
        }
    }
}