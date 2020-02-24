using System;
using System.Collections.Generic;
using System.IO;

class Person {
    public int age;     
	public Person(int initialAge) 
    {
        
        if (initialAge > 0)
        {
            age = initialAge;
        } else 
        {
            age = 0
            Console.WriteLine("age is not valid, setting age to 0");
        }   
     }
     
     public void amIOld() 
     {
        if (age < 13)
        {
            Console.WriteLine("you are young");
        }
        if (age >= 13 && age < 18)
        {
            Console.WriteLine("you are a teenager");
        } else 
        {
            Console.WriteLine("You are old");
        }
     }

     public void yearPasses() {
        age ++;
     }

static void Main(String[] args) {
        int T=int.Parse(Console.In.ReadLine());
        for (int i = 0; i < T; i++) {
            int age=int.Parse(Console.In.ReadLine());
            Person p=new Person(age);
             p.amIOld();
                for (int j = 0; j < 3; j++) {
                  p.yearPasses();
                }
                p.amIOld();
                Console.WriteLine();
        }
    }
}