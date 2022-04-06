using System;
using System.Collections;
using System.Collections.Generic;

namespace GenericsApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] nums = { 1, 2, 3, 4 };


            //MyCollection<int> ints = new MyCollection<int>();
            //ints.AddItem(5);
            //ints.AddItem(52);
            //ints.AddItem(15);
            //ints.AddItem(41);
            //ints.RemoveLast();

            //MyCollection<string> strs = new MyCollection<string>();
            //strs.AddItem("asdasd");

            //MyCollection<Person> people = new MyCollection<Person>();
            //people.AddItem(new Person("Mamed","Aliyev",12));
            //Person p2 = new Person("Isa", "Balayev", 12);
            //people.AddItem(p2);

            //people.PrintItems();


            //Person p1 = new Person("Mamed", "Aliyev", 12);
            //Person p2 = new Person("Isa", "Balayev", 12);

            //ArrayList items = new ArrayList();
            //items.Add(p1);
            //items.Add(p2);
            //items.Add(true);
            //items.Add(true);
            //items.Add(true);
            //items.Add("salam");
            //items.Add(12);


            //items.Insert(2,91);


            //items.Remove(items[0]);
            //items.RemoveAt(0);

            //for (int i = 0; i < items.Count; i++)
            //{
            //    items.RemoveAt(i);
            //}


            //int itemCount = items.Count;
            //for (int i = 0; i < itemCount; i++)
            //{
            //    items.RemoveAt(0);
            //}

            //items.Remove(12.Equals(12));
            //items.RemoveAt(0);
            //items.Clear();


            //foreach (var item in items)
            //{
            //    Console.WriteLine(item);
            //}


            //List<Object> people = new List<Object>();
            //Person p1 = new Person("Mamed", "Aliyev", 12);
            //Person p2 = new Person("Isa", "Balayev", 12);
            //people.Add(p1);
            //people.Add(p2);
            //people.Add(12);

            //SortedDictionary<string, string> phoneNumbers = new SortedDictionary<string, string>();

            //phoneNumbers.Add("Mamed","+994 51 123123");
            //phoneNumbers.Add("Isa","+994 51 6456456");
            //phoneNumbers.Add("Rasim", "+994 51 5634535");
            //phoneNumbers.Add("Aga","+994 51 123123");


            ////Console.WriteLine(phoneNumbers["Mamed"]);

            //foreach (var item in phoneNumbers)
            //{
            //    Console.WriteLine($"{item.Key} - {item.Value}");
            //}


            //Queue queue = new Queue();
            //queue.Enqueue("Mamed");



            //Queue<string> queue2 = new Queue<string>();
            //queue2.Enqueue("Mamed");
            //queue2.Enqueue("Isa");
            //queue2.Enqueue("Rasim");
            //queue2.Enqueue("Sudabe");
            //queue2.Enqueue("Tofiq");


            //Console.WriteLine(queue2.Count);
            //Console.WriteLine(queue2.Dequeue());
            //Console.WriteLine(queue2.Dequeue());
            //Console.WriteLine(queue2.Dequeue());
            //Console.WriteLine(queue2.Peek());
            //Console.WriteLine(queue2.Count);


            Stack<string> stack = new Stack<string>();

            stack.Push("paper-74");
            stack.Push("paper-42");
            stack.Push("paper-79");
            stack.Push("paper-27");
            stack.Push("paper-34");

            Console.WriteLine(stack.Count);
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Peek());
            Console.WriteLine(stack.Count);



        }
    }
    //public class MyCollection<T> where T : IComparable
    //{
    //    private T[] items = new T[0];

    //    public void AddItem(T item)
    //    {
    //        Array.Resize(ref items, items.Length + 1);
    //        items[items.Length - 1] = item;
    //    }

    //    public void RemoveLast()
    //    {
    //        Array.Resize(ref items, items.Length - 1);
    //    }

    //    public void PrintItems()
    //    {
    //        foreach (T item in items)
    //        {
    //            Console.WriteLine(item);
    //        }
    //    }

    //    public T this[int index]
    //    {
    //        get
    //        {
    //            return items[index];
    //        }
    //        set
    //        {
    //            items[index] = value;
    //        }
    //    }
    //}


    //public class MyCollection
    //{
    //    private object[] items = new object[0];

    //    public void AddItem(object item)
    //    {
    //        Array.Resize(ref items, items.Length + 1);
    //        items[items.Length - 1] = item;
    //    }

    //    public void RemoveLast()
    //    {
    //        Array.Resize(ref items, items.Length - 1);
    //    }

    //    public void PrintItems()
    //    {
    //        foreach (object item in items)
    //        {
    //            Console.WriteLine(item);
    //        }
    //    }

    //    public object this[int index]
    //    {
    //        get
    //        {
    //            return items[index];
    //        }
    //        set
    //        {
    //            items[index] = value;
    //        }
    //    }
    //}

    //public class MyIntCollection
    //{
    //    private int[] items = new int[0];

    //    public void AddItem(int item)
    //    {
    //        Array.Resize(ref items, items.Length + 1);
    //        items[items.Length - 1] = item;
    //    }

    //    public void RemoveLast()
    //    {
    //        Array.Resize(ref items, items.Length - 1);
    //    }

    //    public void PrintItems()
    //    {
    //        foreach (int item in items)
    //        {
    //            Console.WriteLine(item);
    //        }
    //    }

    //    public int this[int index]
    //    {
    //        get
    //        {
    //            return items[index];
    //        }
    //        set
    //        {
    //            items[index] = value;
    //        }
    //    }
    //}

    //public class MyStrCollection
    //{
    //    private string[] items = new string[0];

    //    public void AddItem(string item)
    //    {
    //        Array.Resize(ref items, items.Length + 1);
    //        items[items.Length - 1] = item;
    //    }

    //    public void RemoveLast()
    //    {
    //        Array.Resize(ref items, items.Length - 1);
    //    }

    //    public void PrintItems()
    //    {
    //        foreach (string item in items)
    //        {
    //            Console.WriteLine(item);
    //        }
    //    }

    //    public string this[int index]
    //    {
    //        get
    //        {
    //            return items[index];
    //        }
    //        set
    //        {
    //            items[index] = value;
    //        }
    //    }
    //}

    //public class MyPersonCollection
    //{
    //    private Person[] items = new Person[0];

    //    public void AddItem(Person item)
    //    {
    //        Array.Resize(ref items, items.Length + 1);
    //        items[items.Length - 1] = item;
    //    }

    //    public void RemoveLast()
    //    {
    //        Array.Resize(ref items, items.Length - 1);
    //    }

    //    public void PrintItems()
    //    {
    //        foreach (Person item in items)
    //        {
    //            Console.WriteLine(item);
    //        }
    //    }

    //    public Person this[int index]
    //    {
    //        get
    //        {
    //            return items[index];
    //        }
    //        set
    //        {
    //            items[index] = value;
    //        }
    //    }
    //}
}
