// See https://aka.ms/new-console-template for more information
using DataStructures;

Console.WriteLine("Hello, World!");

 LinkedList obj = new LinkedList();
obj.Traverse();
obj.AddAtIndex(0, 10);
obj.AddAtIndex(0, 20);
obj.AddAtIndex(1, 30);
obj.Traverse();
Console.WriteLine(obj.Get(0));


// obj.Traverse();
//  obj.AddAtHead(7);
//  obj.AddAtHead(2);
//  obj.AddAtHead(1);
//  obj.Traverse();
//   obj.AddAtIndex(3, 0);
//   obj.Traverse();
//  obj.DeleteAtIndex(2);
//  obj.Traverse();
//  obj.AddAtHead(6);
//  obj.AddAtTail(4);
//  obj.Traverse();
//  Console.WriteLine(obj.Get(4));
//   obj.AddAtHead(4);
// obj.AddAtIndex(5,0);
// obj.AddAtHead(6);     
// obj.Traverse();   
//  Console.WriteLine(obj.Get(1));
