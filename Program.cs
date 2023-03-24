using OrderProject.Entities.Enums;
using OrderProject.Entities;
using System.Globalization;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Enter client data: ");
        Console.Write("Name: ");
        string name = Console.ReadLine();
        Console.Write("Email: ");
        string email = Console.ReadLine();
        Console.Write("Birth date (DD/MM/YYYY): ");
        DateTime birthDate = DateTime.Parse(Console.ReadLine());
        Console.WriteLine("Enter order data: ");
        Console.Write("Status: ");
        OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine());

        Console.Write("How many items to this order? ");
        int n = int.Parse(Console.ReadLine());

        Client cliente = new(name, email, birthDate);
        Order order = new(DateTime.Now, status, cliente);

        for (int i = 1; i <= n; i++)
        {
            Console.WriteLine($"Enter #{i} item data:");
            Console.Write("Product name: ");
            string productName = Console.ReadLine();
            Console.Write("Product price: ");
            double price = double.Parse(Console.ReadLine());

            Product product = new(productName, price);

            Console.Write("Quantity: ");
            int quantity = int.Parse(Console.ReadLine());

            OrderItem item = new(quantity, price, product);

            order.AddItem(item);
        }
        Console.WriteLine();
        Console.WriteLine(order);
    }
}