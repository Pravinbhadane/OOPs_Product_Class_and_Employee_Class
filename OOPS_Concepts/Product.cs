using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS_Concepts
{
    public class Product
    {
        private int id, price;
        private string name;
        private double discount,discPrice;

        public int Id
        {
            set { id = value; }
            get { return id; }
        }
        public int Price
        {
            set { price = value; }
            get { return price; }
        }
        public string Name
        {
            set { name = value; }
            get { return name; }
        }
        public double Discount
        {
            set { discount = value; }
            get { return discount; }
        }
        public void DiscDetail()
        {
            discPrice = price - (discount / 100);
        }

        public override string ToString()
        {
           return  $"Product ID = {id}\nProduct Name = {name}\nPrice = {price}\n With Discount Price = {discPrice}";
        }

      
    }

    public class Employee
    {
        private int id, salary;
        private string name , city;

        public Employee (int id,int salary, string name, string city = "pune")
        {
            this.id = id;
            this.salary = salary;
            this.name = name;
            this.city = city;
        }
        public string PrintDetails()
        {
            return $"Employee Details: \nID= {id}\nName = {name} Salary= {salary}\ncity : {city}\n";
        }


    }
}
