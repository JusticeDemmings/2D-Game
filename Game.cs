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
        float x6 = 160;
        float y4 = 350;

        Vector2 velocity;
        Vector2 position;
        Alien1[] alien1 = new Alien1[1];
        /// <summary>
        ///     Setup runs once before the game loop begins.
        /// </summary>
        public void Setup()
        {
            Window.SetTitle("When Aliens Invade");
            Window.SetSize(800, 600);
            Window.ClearBackground(120, 239, 250);
            Window.TargetFPS = 60;

            for (int i = 0; i < alien1.Length; i += 1)
            {
                alien1[i] = new Alien1();
                alien1[i].Setup();
            }
        }

        /// <summary>
        ///     Update runs every frame.
        /// </summary>
        public void Update()
        {
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

            //Draw Player Character
            Draw.SetLineSize(0);
            Draw.SetFillColor(245, 165, 5);
            Draw.Rectangle(x6, y4, 30, 10);
            Draw.Rectangle(x6 - 10, y4 + 10, 60, 30);
            Draw.Rectangle(x6, y4 + 40, 20, 10);
            Draw.Rectangle(x6, y4 + 50, 20, 10);
            Draw.Square(x6 - 10, y4 + 60, 20);
            Draw.Square(x6 - 20, y4 + 70, 10);
            Draw.Rectangle(x6, y4 + 80, 10, 30);
            Draw.Rectangle(x6 - 10, y4 + 90, 10, 30);
            Draw.Square(x6 - 30, y4 + 80, 20);
            Draw.Rectangle(x6 - 60, y4 + 110, 50, 10);
            Draw.Square(x6 - 50, y4 + 90, 20);
            Draw.Square(x6 - 70, y4 + 100, 10);
            Draw.Rectangle(x6 - 80, y4 + 90, 30, 10);
            Draw.Rectangle(x6 - 80, y4 + 80, 20, 10);
            Draw.SetFillColor(Color.Red);
            Draw.Square(x6 + 10, y4 + 20, 10);
            //Draw Robotics
            Draw.SetLineSize(1);
            Draw.SetFillColor(179, 178, 177);
            Draw.Square(x6 + 30, y4, 10);
            Draw.Square(x6 + 5, y4 + 15, 20);
            Draw.Square(x6 + 40, y4 + 20, 10);
            Draw.Square(x6 - 10, y4 + 40, 10);
            Draw.Rectangle(x6 + 20, y4 + 50, 30, 10);
            Draw.Rectangle(x6 + 10, y4 + 80, 20, 10);
            Draw.Square(x6 + 20, y4 + 90, 10);
            Draw.Square(x6 - 10, y4 + 80, 10);
            Draw.Rectangle(x6 - 30, y4 + 100, 20, 10);
            Draw.Square(x6 - 60, y4 + 100, 10);
            Draw.Rectangle(x6 - 80, y4 + 60, 10, 20);
            //Draw Legs
            Draw.SetLineSize(0);
            Draw.SetFillColor(245, 165, 5);
            Draw.Rectangle(x6 - 50, y4 + 120, 10, 30);
            Draw.Square(x6 - 50, y4 + 140, 10);
            Draw.Square(x6 - 20, y4 + 120, 10);
            Draw.Rectangle(x6 - 20, y4 + 140, 20, 10);
            Draw.SetFillColor(179, 178, 177);
            Draw.Square(x6 - 50, y4 + 140, 10);
            Draw.Square(x6 - 20, y4 + 130, 10);

            //Player Movement
            if (Input.IsKeyboardKeyDown(KeyboardKey.A) == true)
            {
                //If it is, then:
                x6 -= 100 * Time.DeltaTime;
            }

            if (Input.IsKeyboardKeyDown(KeyboardKey.D) == true)
            {
                //If it is, then:
                x6 += 100 * Time.DeltaTime;
            }

            if(Input.IsKeyboardKeyDown(KeyboardKey.Space) == true)
            {
                //If it is, then:
                y4 -= 100 * Time.DeltaTime;
                Vector2 gravity = new Vector2(0, 10);
                velocity += gravity * Time.DeltaTime;
                position += velocity;
            }

            for (int i = 0; i < alien1.Length; i += 1)
            {
                alien1[i].Update();
            }
        }
    }

}
