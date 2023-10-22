
    
        List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

        string command = " ";
        while ((command = Console.ReadLine()) != "end")
        {
            string[] inputs = command.Split();
            string action = inputs[0];

            if (action == "Contains")
            {
                int numberToCheck = int.Parse(inputs[1]);
                if (numbers.Contains(numberToCheck))
                {
                    Console.WriteLine("Yes");
                }
                else
                {
                    Console.WriteLine("No such number");
                }
            }
            else if (action == "PrintEven")
            {
                Console.WriteLine(string.Join(" ", numbers.Where(n => n % 2 == 0)));
            }
            else if (action == "PrintOdd")
            {
                Console.WriteLine(string.Join(" ", numbers.Where(n => n % 2 != 0)));
            }
            else if (action == "GetSum")
            {
                Console.WriteLine(numbers.Sum());
            }
            else if (action == "Filter")
            {
                string condition = inputs[1];
                int filterNumber = int.Parse(inputs[2]);

                List<int> filteredNumbers = new List<int>();

                if (condition == "<")
                {
                    filteredNumbers = numbers.Where(n => n < filterNumber).ToList();
                }
                else if (condition == ">")
                {
                    filteredNumbers = numbers.Where(n => n > filterNumber).ToList();
                }
                else if (condition == ">=")
                {
                    filteredNumbers = numbers.Where(n => n >= filterNumber).ToList();
                }
                else if (condition == "<=")
                {
                    filteredNumbers = numbers.Where(n => n <= filterNumber).ToList();
                }

                Console.WriteLine(string.Join(" ", filteredNumbers));
            }
        }

        Console.WriteLine(string.Join(" ", numbers));
    
