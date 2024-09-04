public record Product(string name, double price, int quantity);


public class Test
{
    public static void Main(string[] args)
    {

        List<Product> products = new List<Product>(){
            new Product("iphone 13", 240, 12),
            new Product("samsung", 120.4, 98),
            new Product("iphone 11", 23, 90),
            new Product("Motorola", 180, 12),

        };
        var sortedProductsByPrice = products.OrderBy(product => product.price);

        foreach (var item in sortedProductsByPrice)
        {
            Console.WriteLine($"{item}");

        }





        // Console.WriteLine($"Length: {numbers.Count}");

        // foreach (var number in numbers)
        // {
        //     Console.WriteLine($"{number}");

        // }



    }
}