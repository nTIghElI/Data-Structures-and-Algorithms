//Example 1: Analyzing an Array-Based Operation

int[] numbers = { 1, 2, 3, 4, 5 };
// Accessing an element by index
Console.WriteLine(numbers[2]);  // O(1)
// Looping through all elements
for (int i = 0; i < numbers.Length; i++)
{
    Console.WriteLine(numbers[i]);  // O(n)
}

//Example 2: Analyzing a Linked List Operation
Console.Clear();
Console.ReadLine();
// Creating a linked list
LinkedList<int> list = new LinkedList<int>(new int[] { 1, 2, 3, 4, 5 });
// Traversing a linked list
foreach (var num in list)
{
    Console.WriteLine(num);  // O(n)
}

//
Console.Clear();
Console.ReadLine();


