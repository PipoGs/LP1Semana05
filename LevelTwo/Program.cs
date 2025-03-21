using System;
using Spectre.Console;

namespace LevelTwo
{
    public class Program
    {
        private static void Main(string[] args)
        {
            string input = args[0];
            int maxWidth = 24;

            if (args.Length > 0)
            {
                input = args[0];
            }

            if (args.Length > 1 && int.TryParse(args[1], out int width))
            {
                maxWidth = width;
            }

            CanvasImage image = new CanvasImage(input);

            image.MaxWidth(maxWidth);

            AnsiConsole.Write(image);
        }
    }
}
