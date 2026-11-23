// Include the namespaces (code libraries) you need below.
using System;
using System.Drawing;
using System.Numerics;

// The namespace your code is in.
namespace MohawkGame2D
{
    /// <summary>
    ///     Your game code goes inside this class!
    /// </summary>
    public class Game
    {
        //Game Timer
        float gameTimer = 0f;
        float winTime = 20f;

        Rectangle collisionBox;
        float x6 = 160;
        float y4 = 350;
        Alien2[] alien2 = new Alien2[1];
        Cactus[] cactus = new Cactus[1];

        float gravity = 800f;
        float jumpforce = 400f;
        float velocityY = 0f;
        bool isGround = true;
        bool gameOver = false;
        bool win = false;

        public void RestartGame()
        {
            // Reset player
            x6 = 160;
            y4 = 350;

            // Reset jumping
            velocityY = 0;
            isGround = true;

            // Reset game states
            gameOver = false;
            win = false;

            // Reset cactus
            for (int i = 0; i < cactus.Length; i++)
            {
                cactus[i].Setup();
            }

            // Reset aliens
            for (int i = 0; i < alien2.Length; i++)
            {
                alien2[i].Setup();
            }
        }

        /// <summary>
        ///     Setup runs once before the game loop begins.
        /// </summary>
        public void Setup()
        {
            Window.SetTitle("When Aliens Invade");
            Window.SetSize(800, 600);
            Window.ClearBackground(120, 239, 250);
            Window.TargetFPS = 60;

            for (int i = 0; i < alien2.Length; i += 1)
            {
                alien2[i] = new Alien2();
                alien2[i].Setup();
            }

            for (int i = 0; i < cactus.Length; i += 1)
            {
                cactus[i] = new Cactus();
                cactus[i].Setup();
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
            Draw.SetLineSize(0);
            Draw.SetFillColor(Color.Red);
            Draw.Square(x6 + 10, y4 + 20, 10);
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

            if (Input.IsKeyboardKeyPressed(KeyboardKey.Space) == true)
            {
                //If it is, then:
                velocityY = -jumpforce;
                isGround = false;
            }

            if (isGround == false)
            {
                velocityY += gravity * Time.DeltaTime;
                y4 += velocityY * Time.DeltaTime;
            }

            if (y4 + 150 >= 500)
            {
                y4 = 350;
                velocityY = 0;
                isGround = true;
            }

            //Player Bounds
            //Left
            if (x6 - 80 < 0)
            {
                x6 = 80;
            }
            //Right
            if (x6 + 60 > 800)
            {
                x6 = 740;
            }
            //Top
            if (y4 < 90)
            {
                y4 = 90;
                velocityY = 0;
            }

            for (int i = 0; i < alien2.Length; i += 1)
            {
                alien2[i].Update();
            }

            for (int i = 0; i < cactus.Length; i += 1)
            {
                cactus[i].Update();
            }

            //collisionBoxes
            collisionBox = new Rectangle((int)(x6 - 80), (int)y4, 110, 150);

            if (collisionBox.IntersectsWith(cactus[0].collisionBox))
            {
                gameOver = true;
            }

            foreach (AlienProjectile alienprojectile in alien2[0].projectiles)
            {
                if (collisionBox.IntersectsWith(alienprojectile.collisionBox))
                {
                    gameOver = true;
                }
            }

            if (gameOver == true)
            {
                //Loss Screen
                Window.ClearBackground(Color.Black);
                
                if (Input.IsKeyboardKeyPressed(KeyboardKey.R) == true)
                {
                    RestartGame();
                }

                return;
            }

            if (gameOver == false && win == false)
            {
                gameTimer += Time.DeltaTime;
            }

            if (gameTimer >= winTime)
            {
                //Win Screen
                Window.ClearBackground(Color.Blue);

                if (Input.IsKeyboardKeyPressed(KeyboardKey.R) == true)
                {
                    RestartGame();
                }
            }
        }
    }

}
