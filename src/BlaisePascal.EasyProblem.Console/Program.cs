using System.ComponentModel.Design;
using System.Security.Cryptography.X509Certificates;

public class Program
{
    public enum ConsignmentType
    {
        Consignment,
        Withdrawal
    }
    public static void Main()
    {
        Console.WriteLine("insert customer's name");
        string userName = Console.ReadLine();

        Console.WriteLine("insert the number of purchased books");
        int purchasedBooks = int.Parse(Console.ReadLine());

        Console.WriteLine("insert the cost of a book");
        double bookCost = double.Parse(Console.ReadLine());

        Console.WriteLine("Is the customer a student? true or false?");
        bool IsAStudent = bool.Parse(Console.ReadLine());

        Console.WriteLine("insert the type of the consignment, Consignment or Withdrawal?");
        ConsignmentType type = (ConsignmentType)Enum.Parse(typeof(ConsignmentType), Console.ReadLine(), true);

        double subTotal = purchasedBooks * bookCost;
        int consignmentCost = 5;
        double total = consignmentCost + subTotal;

        Console.WriteLine($" customer's name:{userName}");
        Console.WriteLine($" purchased books:{purchasedBooks}");
        Console.WriteLine($" cost of a book:{bookCost}");
        Console.WriteLine($" Type of the consignment:{type}");
        Console.WriteLine($" Subtotal:{subTotal} euro");
        Console.WriteLine($" Consignment's cost:{consignmentCost} euro");
        Console.WriteLine($" Final cost:{total} euro");
        if (subTotal <= 0) { Console.WriteLine(" order not valid"); }
        else
        {
            if (subTotal < 20)
            {
                Console.WriteLine("low cost order");
            }
            else { Console.WriteLine("Thanks for your order"); }
        }

    }
}
