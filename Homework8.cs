﻿namespace Homework8;

using System;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        // Create customer objects and customer list
        Customer cus1 = new Customer(customerName: "Alice", customerAge: 33, customerCity: "Amarillo", customerCredit: 198.5);
        Customer cus2 = new Customer(customerName: "Bob", customerAge: 23, customerCity: "Amarillo", customerCredit: 226);
        Customer cus3 = new Customer(customerName: "Cathy", customerAge: 45, customerCity: "Amarillo", customerCredit: 89.0);
        Customer cus4 = new Customer(customerName: "David", customerAge: 58, customerCity: "Amarillo", customerCredit: 198.5);
        Customer cus5 = new Customer(customerName: "Jack", customerAge: 28, customerCity: "Canyon", customerCredit: 561.6);
        Customer cus6 = new Customer(customerName: "Tom", customerAge: 36, customerCity: "Canyon", customerCredit: 98.4);
        Customer cus7 = new Customer(customerName: "Tony", customerAge: 24, customerCity: "Canyon", customerCredit: 18.5);
        Customer cus8 = new Customer(customerName: "Sam", customerAge: 35, customerCity: "Canyon", customerCredit: 228.3);

        Customer[] customer_list = { cus1, cus2, cus3, cus4, cus5, cus6, cus7, cus8 };

        // Call methods
        TotalCredits(customer_list);            // Q1
        AmarilloAverageAge(customer_list);      // Q2
        CanyonAge(customer_list);               // Q3
    }

    // Q1: Calculate and print the total credit of all customers
    public static void TotalCredits(Customer[] customer_list)
    {
        double total = customer_list.Sum(c => c.customerCredit);
        Console.WriteLine($"Q1: The total credits: {total}");
    }

    // Q2: Calculate and print average age of customers in Amarillo
    public static void AmarilloAverageAge(Customer[] customer_list)
    {
        var amarilloCustomers = customer_list.Where(c => c.customerCity == "Amarillo").ToArray();
        double avgAge = amarilloCustomers.Average(c => c.customerAge);
        Console.WriteLine($"Q2: The average age of customers in Amarillo: {avgAge:F2}");
    }

    // Q3: Print names of customers in Canyon and over 30 years old
    public static void CanyonAge(Customer[] customer_list)
    {
        var canyonList = customer_list
                         .Where(c => c.customerCity == "Canyon" && c.customerAge > 30)
                         .Select(c => c.customerName)
                         .ToList();

        Console.Write("Q3: Customers who live in Canyon and over 30 years old: ");
        Console.WriteLine(string.Join(", ", canyonList) + ", ");
    }
}

// Q0: Customer class
class Customer
{
    public string customerName;
    public int customerAge;
    public string customerCity;
    public double customerCredit;

    public Customer(string customerName, int customerAge, string customerCity, double customerCredit)
    {
        this.customerName = customerName;
        this.customerAge = customerAge;
        this.customerCity = customerCity;
        this.customerCredit = customerCredit;
    }
}
