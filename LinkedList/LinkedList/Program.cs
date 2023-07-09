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
            Console.WriteLine("Enter 5 for Delete last Element ");
            Console.WriteLine("Enter 6 for Search Element ");
            Console.WriteLine("Enter 7 for Insert Element After a Element");
            Console.WriteLine("Enter 8 for Remove an Element and show linked list size");
            Console.WriteLine("Enter 9 for Sorted Insert");
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
                    linkedList.Remove_First();
                    Console.WriteLine("First Element Removed");
                    linkedList.Display();
                    break;
                case 5:
                    linkedList.Append(56);
                    linkedList.Append(30);
                    linkedList.Append(70);
                    Console.WriteLine("Element in Linked List");
                    linkedList.Display();
                    linkedList.Remove_Last();
                    linkedList.Display();
                    break;
                case 6:
                    linkedList.Append(56);
                    linkedList.Append(30);
                    linkedList.Append(70);
                    Console.WriteLine("Enter the value you want to find");
                    int val = Convert.ToInt32(Console.ReadLine());
                    linkedList.SearchValue(val);
                    break;
                case 7:
                    linkedList.Append(56);
                    linkedList.Append(30);
                    linkedList.Append(70);
                    Console.WriteLine("Element in Linked List are");
                    linkedList.Display();
                    Console.WriteLine("Enter the data you want to add");
                    int newdata = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter an exiting data you want to add after");
                    int exdata = Convert.ToInt32(Console.ReadLine());
                    linkedList.InsertDataAfterAData(exdata, newdata);
                    linkedList.Display();
                    break;
                case 8:
                    linkedList.Append(56);
                    linkedList.Append(30);
                    linkedList.Append(40);
                    linkedList.Append(70);
                    Console.WriteLine("Element in Linked List are");
                    linkedList.Display();
                    linkedList.Remove(40);
                    linkedList.Size();
                    break;
                case 9:
                    linkedList.SortedInsert(56);
                    linkedList.SortedInsert(30);
                    linkedList.SortedInsert(40);
                    linkedList.SortedInsert(70);
                    linkedList.Display();
                    break;
                default:
                    Console.WriteLine("Enter a valid choice");
                    break;
            }
        }

    }
}