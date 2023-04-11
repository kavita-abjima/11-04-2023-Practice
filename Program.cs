using Collections;
using System;
using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;

namespace NGSTACKDEMO { 
    class Program
    {
        static void Main(string[] args)
        {   //Stack
            Stack MyStack = new Stack();
            MyStack.Push("Kavita");
            MyStack.Push(27);
            MyStack.Push(5.1);
            MyStack.Push(false);
            MyStack.Push("Soniya");
            MyStack.Push(null);
            MyStack.Push("Kavita");
            Console.WriteLine(MyStack.Peek());
            Console.WriteLine("____________");
            Console.WriteLine(MyStack.Contains("Kavita"));
            foreach (object item in MyStack)
            {
                Console.WriteLine(item);

            }

            MyStack.Clear();      //Clear all the data from stack
            Console.WriteLine("_________________");
            foreach (object item in MyStack)
            {
                Console.WriteLine(item);

            }
            Console.WriteLine("_____________");
            //QUEUE
            Queue MyQueue = new Queue();
            MyQueue.Enqueue("Kavita");
            MyQueue.Enqueue("Soniya");
            MyQueue.Enqueue(null);
            MyQueue.Enqueue("Soniya");
            MyQueue.Enqueue(27);
            MyQueue.Enqueue(26);
            MyQueue.Enqueue(true);
            
            foreach (object item in MyQueue)
            {
                Console.WriteLine(item);
            }

            //MyQueue.Dequeue();
            //foreach (object item in MyQueue)
            //{
            //    Console.WriteLine(item);
            //}
            Console.WriteLine(MyQueue.Count);
            while (MyQueue.Count > 0)
            {
                MyQueue.Dequeue();
            }
            Console.WriteLine(MyQueue.Count);
            Console.WriteLine("_____________");

            //Generic Collections
            List<int> MyList = new List<int>();
            MyList.Add(12);
            MyList.Add(24);
            MyList.Add(36);
            MyList.Add(48);
            MyList.Insert(1, 15);
            MyList.InsertRange(2, MyList);
            MyList.RemoveRange(2, 3);
            MyList.Contains(48);
            foreach (object item in MyList)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("______________");
            MyList.AddRange(MyList);
            foreach (object item in MyList)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("_________");
            Employee emp1 = new Employee()
            {
                name = "Kavita",
                age = 27,
                designation = "Manager"
            };
            Employee emp2 = new Employee()
            {
                name = "Soniya",
                age = 26,
                designation = "Director"
            };
            Employee emp3 = new Employee()
            {
                name = "Kanchan",
                age = 28,
                designation = "abc"
            };


            List<Employee> EmpList = new List<Employee>();
            EmpList.Add(emp1);
            EmpList.Add(emp2);
            EmpList.Add(emp3);

            foreach(Employee emp in EmpList)
            {
                Console.WriteLine("Employee name is :{0}, age is: {1} and designation is: {2}",emp.name,emp.age,emp.designation);
            }
            Console.WriteLine("__________________");
            EmpList.RemoveAll(emp => emp.name == "Kanchan");
            foreach (Employee emp in EmpList)
            {
                Console.WriteLine("Employee name is :{0}, age is: {1} and designation is: {2}", emp.name, emp.age, emp.designation);
            }
            Console.WriteLine(EmpList.Exists(emp=>emp.name.StartsWith('k')));
            Console.WriteLine("__________________________");
            //Dictionary
            Dictionary<string, string> MyDict = new Dictionary<string, string>();

            MyDict.Add("Active", "ngaging or ready to engage in physically energetic pursuits:");
            MyDict.Add("Amezing", "causing great surprise or wonder; astonishing");
            MyDict.Add("Honest", "free of deceit; truthful and sincere:");
            MyDict.Add("Petriotic", "having or expressing devotion to and vigorous support for one's country");
            MyDict.Add("quarantine", "place of isolation ");

            //Accessing the value of key
            Console.WriteLine(MyDict["Active"]);

            foreach(KeyValuePair<string,string> item in MyDict)
            {
                Console.WriteLine("Key is :" +item.Key + "Value is :"+item.Value);
            }

            foreach(string key in MyDict.Keys)
            {
                Console.WriteLine(key);
            }
            Console.ReadLine();
        }
    }
}

