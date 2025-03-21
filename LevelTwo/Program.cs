using System;
using Spectre.Console;

namespace LevelTwo
{
    public class Program
    {
        private static void Main(string[] args)
        {
            CanvasImage image = new CanvasImage("tux.png");

            image.MaxWidth(20);

            AnsiConsole.Render(image);
        }
    }
}
