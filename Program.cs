// Develop program using Queue.
// create queue of callers

internal class Program
{
    static void Main(string[] args)
    {
        Queue<string> callers = new Queue<string>();
        callers.Enqueue("Taylor");
        callers.Enqueue("Alexander");
        callers.Enqueue(" Johnathan");
        callers.Enqueue("Tiffany");
        foreach (var item in callers)
        {
            Console.WriteLine(item + " ");
        }
        Console.WriteLine();
            callers.Dequeue();
            Console.WriteLine("after dq:  ");
            foreach( var item in callers)
            {
                Console.WriteLine(item + " ");
            }
            Console.ReadKey();
        }
    }
