// See https://aka.ms/new-console-template for more information

using OOPS_Concepts;
using System.Threading.Channels;

public class Program
{
    static void Main(string[] args)
    {
        Product product1 = new Product();
        product1.Id = 1234;
        product1.Price = 15000;
        product1.Name = "Mobile Phone";

        Console.WriteLine(product1.ToString());


        Product product2 = new Product() { Id = 1240, Name = "Iphone", Price = 60000 };

        Console.WriteLine(product2.ToString());


        Employee emp1 = new Employee ( 1234, 50000,"Pravin");
        
        Employee emp2 = new Employee ( 5678, 60000,"Pawan" , city:"Nashik");

        Console.WriteLine(emp1.PrintDetails());

        Console.WriteLine(emp2.PrintDetails());

        
    }
   

}
