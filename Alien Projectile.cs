using System;
using System.Drawing;
using System.Numerics;

namespace MohawkGame2D;

public class AlienProjectile
{
	Rectangle collisionBox;
	Vector2 position;
	float speed;
	public void Setup(Vector2 startPosition)
	{

		position = startPosition;

		speed = 2;

		float x = position.X;
		float y = position.Y;

		collisionBox = new Rectangle((int)position.X, (int)position.Y, 5, 20);

	}

	public void Update()
	{
		position.Y += speed;

		Draw.SetLineSize(0);
		Draw.SetFillColor(Color.Red);
		Draw.Rectangle(position.X, position.Y, 5, 20);
	}
}
