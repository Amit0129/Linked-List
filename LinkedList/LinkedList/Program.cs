namespace LinkedList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LinkedListBuilder<int> linkedList = new LinkedListBuilder<int>();
            //LinkedListBuilder<string> linkedListDtring = new LinkedListBuilder<string>();
            Console.WriteLine("Enter 1 for Add First Like 56->30->70");
            Console.WriteLine("Enter 2 for Append Element Like 56->30->70");
            Console.WriteLine("Enter 3 for Insert an Element ");
            Console.WriteLine("Enter 4 for Delete first Element ");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    linkedList.AddFirst(70);
                    linkedList.AddFirst(30);
                    linkedList.AddFirst(56);
                    linkedList.Display();
                    break;
                case 2:
                    linkedList.Append(56);
                    linkedList.Append(30);
                    linkedList.Append(70);
                    linkedList.Display();
                    break;
                case 3:
                    linkedList.Append(56);
                    linkedList.Append(70);
                    linkedList.Insert(2, 30);
                    linkedList.Display();
                    break;
                case 4:
                    linkedList.Append(56);
                    linkedList.Append(30);
                    linkedList.Append(70);
                    linkedList.Display();
                    Console.WriteLine("==========");
                    linkedList.RemoveFirst();
                    linkedList.Display();
                    break;
                default:
                    Console.WriteLine("Enter a valid choice");
                    break;
            }
        }

    }
}