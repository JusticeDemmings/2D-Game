// Include the namespaces (code libraries) you need below.
using System;
using System.Numerics;

// The namespace your code is in.
namespace MohawkGame2D
{
    /// <summary>
    ///     Your game code goes inside this class!
    /// </summary>
    public class Game
    {
        /// <summary>
        ///     Setup runs once before the game loop begins.
        /// </summary>
        public void Setup()
        {
            Window.SetTitle("When Aliens Invade");
            Window.SetSize(800, 600);
            Window.ClearBackground(120, 239, 250);

            //Draw Sun
            Draw.SetLineSize(0);
            Draw.SetFillColor(255, 255, 0);
            Draw.Rectangle(650, 50, 30, 10);
            Draw.Rectangle(640, 60, 50, 10);
            Draw.Rectangle(630, 70, 70, 10);
            Draw.Rectangle(620, 80, 90, 30);
            Draw.Rectangle(630, 110, 70, 10);
            Draw.Rectangle(640, 120, 50, 10);
            Draw.Rectangle(650, 130, 30, 10);

            //Draw Ground
            Draw.SetLineSize(1);
            Draw.SetFillColor(150, 85, 20);
            Draw.Rectangle(0, 500, 800, 100);
        }

        /// <summary>
        ///     Update runs every frame.
        /// </summary>
        public void Update()
        {
            //Draw Player Character
            Draw.Rectangle(x6, y4, 30, 10);
            Draw.Square()
        }
    }

}
