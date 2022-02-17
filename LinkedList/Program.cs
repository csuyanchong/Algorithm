namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkNode first = new LinkNode(1);
            LinkNode second = new LinkNode(2);
            //LinkNode first = new LinkNode(1);
            //LinkNode second = new LinkNode(2);
            LinkedList list = new LinkedList();
            list.head = first;
            first.next = second;


        }

        public class LinkedList
        {
            public LinkNode head;
        }
        public class LinkNode
        {
            public int val;
            public LinkNode next;
            public LinkNode(int data)
            {
                val = data;
                next = null;
            }
        }
    }
}
