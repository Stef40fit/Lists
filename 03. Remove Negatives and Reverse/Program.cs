//•	Read a list of integers,
//•	Remove all negative numbers from it 
//•	Print the remaining elements in reversed order
//•	If there are no elements left in the list, print "empty"


using System;

List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
numbers.RemoveAll(number => number < 0);
numbers.Reverse();
if (numbers.Count == 0)
{
    Console.WriteLine("empty");
}
else
{
    Console.WriteLine(string.Join(" ", numbers));
}
