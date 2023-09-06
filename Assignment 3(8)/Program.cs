using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class MyClass
{
    
    private void PrivateMethod()
    {
        Console.WriteLine("This is the private method.");
    }

   
    public void PublicMethod()
    {
        Console.WriteLine("This is the public method.");
        PrivateMethod(); 
    }
}

class Program
{
    static void Main(string[] args)
    {
        MyClass myObject = new MyClass();

        
        myObject.PublicMethod();

        

        Console.ReadLine();
    }
}
