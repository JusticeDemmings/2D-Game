using System;
using System.Numerics;

namespace MohawkGame2D;

public class AlienPorjectile
{
	Vector2 position;
	float speed;
	public void Setup()
	{
		position = new Vector2();

		position.X = startPosition.X;
		position.Y = startPosition.Y;

		speed = 2;

	}

	public void Update()
	{
		position.Y += speed;

		Draw.SetLineSize(0);
		Draw.SetFillColor(Color.Red);
		Draw.Rectangle(position.X, position.Y, 5, 20);
	}
}
