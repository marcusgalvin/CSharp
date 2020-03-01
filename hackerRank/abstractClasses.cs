//Write MyBook class
 class MyBook : Book
{
    public int price = 0;
    public MyBook(string title, string author, int price)
    : base(title, author)
    {
        this.title = title;
        this.author = author;
        this.price = price;
    }

     public override void display()
    {
        Console.WriteLine("Title: {0}", this.title);
        Console.WriteLine("Author: {0}", this.author);
        Console.WriteLine("Price: {0}", this.price);
    }

}
