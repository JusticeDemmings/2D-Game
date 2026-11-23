using System;
using System.Drawing;
using System.Numerics;

namespace MohawkGame2D;

public class AlienProjectile
{
	public Rectangle collisionBox;
	Vector2 position;
	float speed;
	public void Setup(Vector2 alienPosition)
	{

		position = new Vector2(alienPosition.X + 40, alienPosition.Y + 70);

		speed = 1;

		collisionBox = new Rectangle((int)position.X, (int)position.Y, 5, 20);

	}

	public void Update()
	{
		position.Y += speed;

		collisionBox = new Rectangle((int)position.X, (int)position.Y, 5, 20);

		Draw.SetLineSize(0);
		Draw.SetFillColor(Color.Red);
		Draw.Rectangle(position.X, position.Y, 5, 20);
	}
}
