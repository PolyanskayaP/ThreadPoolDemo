// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using System;
using System.Threading;

class Program
{
    static void ShowMyText(object state)
    {
        string myText = (string)state;
        Console.WriteLine("Thread: {0} - {1}", Thread.CurrentThread.ManagedThreadId, myText);
        

    }
    static void Main(string[] args)
    {
        WaitCallback callback = new WaitCallback(ShowMyText);
        ThreadPool.QueueUserWorkItem(callback, "iste");
        ThreadPool.QueueUserWorkItem(callback, "kuzu kuzu");
        ThreadPool.QueueUserWorkItem(callback, "geldim");
        ThreadPool.QueueUserWorkItem(callback, "atese");
        ThreadPool.QueueUserWorkItem(callback, "verdim");
        ThreadPool.QueueUserWorkItem(callback, "yaktim");
        Console.Read();
    }

}