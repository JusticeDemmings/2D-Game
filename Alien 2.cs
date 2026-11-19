using System;
using System.Numerics;

namespace MohawkGame2D;

public class Alien2
{
	float x4;
	float y2;

	Vector2
	public void Setup()
	{

	}

	public void Update()
	{
		Draw.SetLineSize(0);
		Draw.SetFillColor(Color.Magenta);
		Draw.Rectangle(x4, y2, 80, 30);
		Draw.Square(x4, y2 - 20, 10);
		Draw.Square(x4 + 10, y2 - 10, 10);
		Draw.Square(x4 + 70, y2 - 20, 10);
		Draw.Square(x4 + 60, y2 - 10, 10);
		Draw.Rectangle(x4 - 20, y2 - 10, 10, 30);
		Draw.Square(x4 - 10, y2 + 10, 10);
		Draw.Rectangle(x4 + 90, y2 - 10, 10, 30);
		Draw.Square(x4 + 80, y2 + 10, 10);
		Draw.Square(x4 + 10, y2 + 30, 10);
		Draw.Square(x4 + 60, y2 + 30, 10);
		Draw.SetLineSize(0);
		Draw.SetFillColor(Color.Black);
		Draw.Square(x4 + 20, y2 + 10, 10);
		Draw.Square(x4 + 50, y2 + 10, 10);
	}
}
