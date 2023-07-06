namespace LinkedList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LinkedListBuilder<int> linkedList = new LinkedListBuilder<int>();
            Console.WriteLine("Enter 1 for Enter Element Like 56->30->70");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    linkedList.AddFirst(70);
                    linkedList.AddFirst(30);
                    linkedList.AddFirst(56);
                    linkedList.Display();
                    break;
                default:
                    Console.WriteLine("Enter a valid choice");
                    break;
            }
        }
    }
}