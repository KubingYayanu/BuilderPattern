using BuilderPattern.Real_world;
using BuilderPattern.Structural;
using System;

namespace BuilderPattern
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            StructuralBuilder();
            RealWorldBuilder();
        }

        private static void StructuralBuilder()
        {
            // Create director and builders
            Director director = new Director();
            Builder b1 = new ConcreteBuilder1();
            Builder b2 = new ConcreteBuilder2();

            // Construct two products
            director.Construct(b1);
            Product p1 = b1.GetResult();
            p1.Show();

            director.Construct(b2);
            Product p2 = b2.GetResult();
            p2.Show();

            // Wait for user
            Console.ReadKey();
        }

        private static void RealWorldBuilder()
        {
            VehicleBuilder builder;

            // Create shop with vehicle builders
            Shop shop = new Shop();

            // Construct and display vehicles
            builder = new ScooterBuilder();
            shop.Construct(builder);
            builder.Vehicle.Show();

            builder = new CarBuilder();
            shop.Construct(builder);
            builder.Vehicle.Show();

            builder = new MotorCycleBuilder();
            shop.Construct(builder);
            builder.Vehicle.Show();

            // Wait for user
            Console.ReadKey();
        }
    }
}