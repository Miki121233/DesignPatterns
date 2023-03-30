using DesignPatterns.Builder;
using DesignPatterns.Factory;
using DesignPatterns.Prototype;
using DesignPatterns.Singleton;

namespace DesignPatterns
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Builder
            var userBuilder = new UserBuilder();
            var user = userBuilder
                .SetFirstName("Albert")
                .SetLastName("Einstein")
                .SetAge(76)
                .Build();
            Console.WriteLine($"First name: {user.FirstName}\nLast name: {user.LastName}\n" +
                $"Age: {user.Age}\n");
            #endregion

            #region Factory
            var shapeFactory = new ShapeFactory();
            var circle = shapeFactory.CreateShape(ShapeType.Circle);
            var rectangle = shapeFactory.CreateShape(ShapeType.Rectangle);
            circle.Render();
            rectangle.Render();
            Console.WriteLine();
            #endregion

            #region Singleton
            var config1 = Configuration.GetInstance();
            var config2 = Configuration.GetInstance();
            if (ReferenceEquals(config1, config2))
            {
                Console.WriteLine("It is Singleton\n");
            }
            #endregion

            #region Prototype
            var pentagon = new Pentagon()
            {
                X = 1,
                Y = 2,
                Border = new Border()
                {
                    Color = "Red",
                    Size = "2px"
                }
            };
            var pentagonShallowClone = (Pentagon)pentagon.ShallowClone();
            if (!ReferenceEquals(pentagon, pentagonShallowClone)
                && ReferenceEquals(pentagon.Border, pentagonShallowClone.Border))
            {
                Console.WriteLine("It is Pentagon class shallow copy");
            }
            var pentagonDeepClone = (Pentagon)pentagon.DeepClone();
            if (!ReferenceEquals(pentagon, pentagonDeepClone)
                && !ReferenceEquals(pentagon.Border, pentagonDeepClone.Border))
            {
                Console.WriteLine("It is Pentagon class deep copy");
            }
            #endregion
        }
    }
}