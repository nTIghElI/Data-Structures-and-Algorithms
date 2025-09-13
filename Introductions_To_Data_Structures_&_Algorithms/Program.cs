//By the end of this lab, you will be able to implement arrays, linked lists, stacks, and queues with key operations in Visual Studio Code.
//Declare and initialize a string array containing the following five mathematical expressions:
Console.Clear();
string[] expressions = {
    "5 + 3",
    "10 - 2",
    "7 * 4",
    "20 / 5",
    "3 ^ 2" // This will be a bitwise XOR, not exponentiation. For exponentiation, you'd typically use Math.Pow.
};

//Use a loop to iterate through and print each expression.
foreach (string expression in expressions)
{
    Console.WriteLine(expression);
}

//Modify the second expression ("10 - 2") and change it to "10 / 2".
expressions[1] = "10 / 2";

Console.WriteLine($"Notice that \"10 - 2\" will change soon.\nPress 'Enter' to continue.");
Console.ReadLine(); // to pause to note difference
foreach (string expression in expressions)
{
    Console.WriteLine(expression);
}
Console.WriteLine("Pretty cool, huh?");
Initial.Continue(); //declare a LinkedList

LinkedList<string> linkedList = new LinkedList<string>();

//Add the following calculations to the linked list using .AddLast():"Result: 8", "Result: 5", "Result: 28", "Result: 4", "Result: 9"
linkedList.AddLast("Result: 8");
linkedList.AddLast("Result: 5");
linkedList.AddLast("Result: 28");
linkedList.AddLast("Result: 4");
linkedList.AddLast("Result: 9");

foreach (string value in linkedList)
{
    Console.WriteLine(value);
}

Initial.Continue();
//Remove "Result: 5" from the linked list.
linkedList.Remove("Result: 5");

//Iterate through the linked list and print all values.
foreach (string value in linkedList)
{
    Console.WriteLine(value);
}

Initial.Continue(); //New Program

//Declare a Stack.
Stack<string> stack = new Stack<string>();

//Use .Push(value) to add the following actions to the stack:, "Entered 5 + 3", "Entered 10 - 2", "Entered 7 * 4", "Entered 20 / 5", "Entered 3 ^ 2"
stack.Push("Entered 5 + 3");
stack.Push("Entered 10 - 2");
stack.Push("Entered 7 * 4");
stack.Push("Entered 20 / 5");
stack.Push("Entered 3 ^ 2");

foreach (string value in stack)
{
    Console.WriteLine(value);
}

Initial.Continue();

//Use .Pop() to remove and display the most recent action.
stack.Pop();

//Iterate through the stack and print all remaining elements.
foreach (string value in stack)
{
    Console.WriteLine(value);
}

//New Program
Initial.Continue(); //declare a Queue
Queue<string> queue = new Queue<string>();

//Use .Enqueue(value) to add the following expressions to the queue:, "Calculate: 15 + 5", "Calculate: 12 - 3", "Calculate: 9 * 2", "Calculate: 16 / 4", "Calculate: 2 ^ 3"
queue.Enqueue("Calculate: 15 + 5");
queue.Enqueue("Calculate: 12 - 3");
queue.Enqueue("Calculate: 9 * 2");
queue.Enqueue("Calculate: 16 / 4");
queue.Enqueue("Calculate: 2 ^ 3");

foreach (string value in queue)
{
    Console.WriteLine(value);
}

Initial.Continue();

//Use .Dequeue() to remove and display the first pending calculation.
queue.Dequeue();

//Iterate through the queue and print all remaining elements.
foreach (string value in queue)
{
    Console.WriteLine(value);
}

Initial.Continue();

//Class
public static class Initial
{
    public static void Continue()
    {
        // Console.Clear();
        Console.WriteLine("Press 'Enter' to continue.");
        Console.ReadLine(); // to pause to note difference
    }
}
