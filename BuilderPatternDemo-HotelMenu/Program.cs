using BuilderPatternDemo_HotelMenu.Models;

namespace BuilderPatternDemo_HotelMenu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Creating an order using the builder pattern
            Order order = new OrderBuilder()
                              .SetMainCourse("Grilled Chicken")
                              .SetSideDish("Caesar Salad")
                              .SetDrink("Lemonade")
                              .SetDessert("Cheesecake")
                              .SetTakeAway(true)
                              .Build();

            // Display the order details
            Console.WriteLine(order.ToString());
        }
    }
}
