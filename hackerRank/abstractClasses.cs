using System;
using System.Collections.Generic;
using System.IO;
abstract class Book
{
    
    protected String title;
    protected  String author;
    
    public Book(String t,String a){
        title=t;
        author=a;
    }
    public abstract void display();


}
//notes:
//The abstract modifier indicates that the thing being modified has a missing or incomplete implementation, must override in order to edit inside another class w inheritance
//Use the abstract modifier in a class declaration to indicate that a class is intended only to be a base class of other classes, not instantiated on its own

//The base keyword is used to access members of the base class from within a derived class:

//Write MyBook class

class MyBook : Book
{

public int price = 0;

    public MyBook(string title, string author, int price)
    :base(title, author)
    {
        this.title = title;
        this.author = author;
        this.price = price;

    }


//The override modifier is required to extend or modify the abstract or virtual implementation of an inherited method, property, indexer, or event.
    public override void display()
    {
        Console.WriteLine("Title: " + this.title);
        Console.WriteLine("Author: " + this.author);
        Console.WriteLine("Price: " + this.price);
    }



}

class Solution {
    static void Main(String[] args) {
      String title=Console.ReadLine();
      String author=Console.ReadLine();
      int price=Int32.Parse(Console.ReadLine());
      Book new_novel=new MyBook(title,author,price);
      new_novel.display();
    }
}