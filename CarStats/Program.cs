using System;
using Spectre.Console;
using Bogus;
using Microsoft.VisualBasic;
using System.Collections.Generic;

namespace CarStats
{
    public class Program
    {

        private static void Main(string[] args)
        {
            Faker faker = new Faker();

            int Count = 3;

            if (args.Length > 0 && int.TryParse(args[0], out int count))
            {
                Count = count;
            }


            BarChart bc = new BarChart()
                .Width(60)
                .Label("[white bold underline]Car Sales[/]")
                .CenterLabel();

            for (int i = 0; i < Count; i++)
            {
                string Brand = faker.Vehicle.Manufacturer();
                int Number = faker.Random.Number(1, 20);
                Color color = new Color(faker.Random.Byte(), faker.Random.Byte(), faker.Random.Byte());

                bc.AddItem(Brand, Number, color);
            }

            AnsiConsole.Write(bc);
        }
    }
}
