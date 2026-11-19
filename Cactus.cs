using System;
using System.Numerics;

namespace MohawkGame2D;

public class Cactus
{
	float x;

	public void Setup()
	{

	}

	public void Update()
	{
		Draw.SetLineSize(0);
		Draw.SetFillColor(Color.Green);
	    Draw.Rectangle(x, 420, 10, 40);
	    Draw.Rectangle(x + 20, 400, 20, 100);
	    Draw.Rectangle(x + 30, 410, 10, 30);
		Draw.Square(x + 10, 450, 10);
		Draw.Square(x + 40, 430, 10);
		Draw.SetLineSize(0);
		Draw.SetFillColor(Color.Black);
		Draw.Rectangle(x + 5, 420, 1, 40);
		Draw.Rectangle(x + 25, 400, 1, 100);
		Draw.Rectangle(x + 35, 400, 1, 100);
		Draw.Rectangle(x + 55, 410, 1, 30);
	}
}
