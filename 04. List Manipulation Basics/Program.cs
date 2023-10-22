//•	Reads a list of integers
//•	Then until you receive "end", you will receive different commands:
//o   "Add {number}": add a number to the end of the list
//o	"Remove {number}": remove a number from the list
//o	"RemoveAt {index}": remove a number at a given index
//o	"Insert {number} {index}": insert a number at a given index
//•	When you receive the "end" command, print the final state of the list (separated by spaces)
//Note: All the indices will be valid!


List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

string command = Console.ReadLine();


while (command != "end")
{
    string[] commandParts = command.Split();
    string commandName = commandParts[0];
    int element = int.Parse(commandParts[1]);

    if (commandName == "Add")
    {
        numbers.Add(element);
    }
    else if (commandName == "Insert")
    {
        int position = int.Parse(commandParts[2]);
        numbers.Insert(position, element);
    }
    else if (commandName == "Remove")
    {
        int position = int.Parse(commandParts[1]);
        numbers.Remove(position);
    }
    else if (commandName == "RemoveAt")
    {
        int position = int.Parse(commandParts[1]);
        numbers.RemoveAt(position);
    }

    command = Console.ReadLine();
}
Console.WriteLine(string.Join(" ", numbers));