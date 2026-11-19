using System;
using System.Numerics;

namespace MohawkGame2D;

public class Alien3
{
	float x5;
	float y3;
    public void Setup()
	{
		x5 = Random.Float(100, 800);
	}

	public void Update()
	{
		Draw.SetLineSize(0);
		Draw.SetFillColor(0, 47, 255);
		Draw.Square(x5, y3, 10);
		Draw.Rectangle(x5 - 10, y3 + 10, 30, 10);
		Draw.Rectangle(x5 - 20, y3 + 20, 50, 30);
		Draw.Rectangle(x5 - 10, y3 + 50, 30, 10);
		Draw.Square(x5, y3 + 60, 10);
		Draw.Square(x5 - 30, y3 + 10, 10);
		Draw.Square(x5 + 30, y3 + 10, 10);
		Draw.Square(x5 - 20, y3 + 60, 10);
		Draw.Square(x5 - 20, y3 + 70, 10);
		Draw.Square(x5 + 20, y3 + 60, 10);
		Draw.Square(x5 + 20, y3 + 70, 10);
		Draw.SetLineSize(0);
		Draw.SetFillColor(Color.Black);
		Draw.Square(x5 - 10, y3 + 30, 10);
		Draw.Square(x5 + 10, y3 + 30, 10);
	}

}
