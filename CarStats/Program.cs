using System;
using Spectre.Console;
using Bogus;

namespace CarStats
{
    public class Program
    {

        private static void Main(string[] args)
        {

            string cars = new Faker().Vehicle.Manufacturer();
            double numbers = new Faker().Random.Number(1, 20);



            AnsiConsole.Write(new BarChart()
            .Width(60)
            .Label("Car Sales[/]")
            .CenterLabel()
            .AddItem(cars, numbers, Color.DarkSlateGray1)
            .AddItem(cars, numbers, Color.DarkSlateGray1)
            .AddItem(cars, numbers, Color.DarkSlateGray1));
        }
    }
}
