using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure
{

    class Node
    {
        public int data;
        public Node next;

        public Node(int d)
        {
            data = d;
            next = null;
        }

        public void PrintList()
        {
            Console.Write(" " + data + " ");
            if (this.next != null)
            {
                this.next.PrintList();
            }
            Console.WriteLine();
        }


        public void AddSorted(int data)
        {
            if (this.next == null)
            {
                next = new Node(data);
            }
            else if (data < next.data)
            {
                Node temp = new Node(data);
                temp.next = this.next;
                this.next = temp;
            }
            else
            {
                this.next.AddSorted(data);
            }
        }

        public void AddToEnd(int data)
        {
            if (this.next == null)
            {
                next = new Node(data);
            }
            else
            {
                this.next.AddToEnd(data);
            }
        }

        public void RemoveFromTheEnd()
        {
            if (this.next.next == null)
            {
                this.next = null;
            }
            else
            {
                this.next.RemoveFromTheEnd();
            }
        }
        //public void RemoveAtTheGivenIndex(int index)
        //{
        //    int count = 0;
        //    while (count != index)
        //    {
        //        Node temp = this.next;
        //        count++;
        //    }

        //}


    }

    class MyList
    {
        public Node headNode;
        public MyList()
        {
            headNode = null;
        }

        public void AddSorted(int data)
        {
            if (headNode == null)
            {
                headNode = new Node(data);
            }
            else if (data < headNode.data)
            {
                AddToTheBeginingOfMyList(data);
            }
            else
            {
                headNode.AddSorted(data);
            }
        }


        public void RemoveFromTheBegining()
        {
            if (headNode == null)
            {
                Console.Write(" List is empty \n");
            }
            else
            {
                headNode = headNode.next;
            }
        }

        public void RemoveFromTheEnd()
        {
            if (headNode == null)
            {
                Console.Write(" List is empty \n");
            }
            else if (headNode.next == null)
            {
                headNode = null;
            }
            else
            {
                this.headNode.RemoveFromTheEnd();
            }

        }


        public void AddToEndOfMyList(int data)
        {
            if (this.headNode == null)
            {
                this.headNode = new Node(data);
            }
            else
            {
                this.headNode.AddToEnd(data);
            }
        }

        public void AddToTheBeginingOfMyList(int data)
        {
            if (headNode == null)
            {
                headNode = new Node(data);
            }
            else
            {
                Node temp = new Node(data);
                temp.next = headNode;
                headNode = temp;
            }
        }

        public void Print()
        {
            if (headNode != null)
            {
                this.headNode.PrintList();
            }
        }

        public void RemoveAtTheGivenIndex(int index)
        {
            // short-circuits
            if (headNode == null)
            {
                Console.WriteLine("Invalid Node Index");
                return;
            }
            else if (index == 0 && headNode.next != null)
            {
                RemoveFromTheBegining();
                return;
            }

            int count = 0;
            Node current = this.headNode;
            Node prev = null;
            while (count < index && current != null)
            {
                prev = current;
                current = current.next;
                count++;
            }
            if (current != null) // could be removed as it will always be true
            {
                if (prev == null)
                {
                    this.headNode = current.next;
                }
                else
                {
                    prev.next = current.next;
                    current = null;
                }
                current = null;
            }

        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //Node newNode = new Node(6);
            //newNode.AddToEnd(7);
            //newNode.AddToEnd(8);


            //newNode.PrintList();

            MyList mList = new MyList();
            //mList.AddToEndOfMyList(3);
            //mList.AddToEndOfMyList(6);
            //mList.AddToEndOfMyList(2);
            //mList.AddToTheBeginingOfMyList(1);
            //mList.AddToTheBeginingOfMyList(12);

            //mList.Print();

            mList.AddToEndOfMyList(4);
            mList.AddToEndOfMyList(131);
            mList.AddToEndOfMyList(11);
            mList.AddToEndOfMyList(133);
            // mList.AddSorted(11);
            //mList.Print();
            //mList.RemoveFromTheEnd();
            //mList.Print();
            //mList.RemoveFromTheEnd();
            //mList.Print();
            //mList.RemoveFromTheEnd();
            //mList.RemoveFromTheEnd();
            //mList.RemoveFromTheEnd();
            mList.Print();
            // mList.RemoveFromTheEnd();
            mList.RemoveAtTheGivenIndex(2);
            mList.Print();
            Console.ReadLine();

            //Arrays arrObj = new Arrays();
            //var array = Arrays.DeleteSmallElements(new int[] { 2, 4, 5, 3 }, 2);
        }
    }
}
