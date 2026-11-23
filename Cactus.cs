using System;
using System.Drawing;
using System.Numerics;

namespace MohawkGame2D;

public class Cactus
{
	Vector2 position;
	float speed;
	public Rectangle collisionBox;
	
	public void Setup()
	{
		position = new Vector2(800, 400);
		speed = 3;
	}

	public void Update()
	{
        position.X -= speed;

		if (position.X < -60)
		{
			position.X = 800;
		}

		collisionBox = new Rectangle((int)position.X, 400, 60, 100);

        Draw.SetLineSize(0);
		Draw.SetFillColor(Color.Green);
	    Draw.Rectangle(position.X, 420, 10, 40);
        Draw.Rectangle(position.X + 50, 410, 10, 30);
        Draw.Rectangle(position.X + 20, 400, 20, 100);
		Draw.Square(position.X + 10, 450, 10);
		Draw.Square(position.X + 40, 430, 10);
		Draw.SetFillColor(Color.Black);
		Draw.Rectangle(position.X + 5, 420, 1, 40);
		Draw.Rectangle(position.X + 25, 400, 1, 100);
		Draw.Rectangle(position.X + 35, 400, 1, 100);
		Draw.Rectangle(position.X + 55, 410, 1, 30);

        collisionBox = new Rectangle((int)position.X, 400, 60, 100);
    }
}
