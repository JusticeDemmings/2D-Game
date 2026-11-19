using System;
using System.Numerics;

namespace MohawkGame2D;

public class Alien1
{
	float x3;
	float y1;

	Vector2
	public void Setup()
	{

	}

	public void Update()
	{
		//Draw Spaceship
		Draw.SetLineSize(0);
		Draw.SetFillColor(255, 213, 0);
		Draw.Square(x3, y1, 10);
		Draw.Rectangle(x3 - 20, y1 + 10, 50, 10);
		Draw.Rectangle(x3 - 30, y1 + 20, 70, 10);
		Draw.Rectangle(x3 - 40, y1 + 30, 90, 10);
		Draw.Rectangle(x3 - 10, y1 + 40, 30, 10);
		Draw.Square(x3 - 30, y1 + 40, 10);
		Draw.Square(x3 - 40, y1 + 50, 10);
		Draw.Square(x3 + 30, y1 + 40, 10);
		Draw.Square(x3 + 40, y1 + 50, 10);
		//Draw Windows
		Draw.SetLineSize(0);
		Draw.SetFillColor(Color.Black);
		Draw.Square(x3 - 15, y1 + 20, 5);
		Draw.Square(x3 - 5, y1 + 20, 5);
		Draw.Square(x3 + 5, y1 + 20, 5);
		Draw.Square(x3 + 15, y1 + 20, 5);
		Draw.Square(x3 + 25, y1 + 20, 5);
		Draw.Square(x3 - 30, y1 + 30, 5);
		Draw.Square(x3 - 15, y1 + 30, 5);
		Draw.Square(x3 - 5, y1 + 30, 5);
		Draw.Square(x3 + 5, y1 + 30, 5);
		Draw.Square(x3 + 15, y1 + 30, 5);
		Draw.Square(x3 + 25, y1 + 30, 5);
		Draw.Square(x3 + 35, y1 + 30, 5);

	}
}
