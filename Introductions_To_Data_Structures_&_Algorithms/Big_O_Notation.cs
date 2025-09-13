//Example 1: Analyzing an Array-Based Operation
class Big_O
{
    static void Main()
    {

        int[] numbers = { 1, 2, 3, 4, 5 };
        // Accessing an element by index
        Console.WriteLine(numbers[2]);  // O(1)
                                        // Looping through all elements
        for (int i = 0; i < numbers.Length; i++)
        {
            Console.WriteLine(numbers[i]);  // O(n)
        }

        //Example 2: Analyzing a Linked List Operation
        Console.Clear();
        Console.ReadLine();
        // Creating a linked list
        LinkedList<int> list = new LinkedList<int>(new int[] { 1, 2, 3, 4, 5 });
        // Traversing a linked list
        foreach (var num in list)
        {
            Console.WriteLine(num);  // O(n)
        }

        //Task 1: Analyzing a Stack Operation
        Console.Clear();
        Console.ReadLine();

        Stack<int> stack = new Stack<int>();
        stack.Push(10);  // O(1) – Constant time insertion
        stack.Push(20);
        Console.WriteLine(stack.Pop());  // O(1) – Constant time removal
        Queue<int> queue = new Queue<int>();
        queue.Enqueue(10);  // O(1) – Constant time insertion
        queue.Enqueue(20);
        Console.WriteLine(queue.Dequeue());  // O(1) – Constant time removal


        //Student Task 2: Evaluating Space Complexity in Data Structures
        Console.Clear();
        Console.ReadLine();

        int n = 5; // Define 'n' for the example
        int[] array = new int[n];  // O(n) space - Preallocated memory
        LinkedList<int> anotherList = new LinkedList<int>();  // O(n) space - Dynamic memory allocation
        for (int i = 0; i < n; i++)
        {
            anotherList.AddLast(i);  // O(1) per insertion, O(n) total space
        }

    }
}
