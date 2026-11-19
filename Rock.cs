using System;
using System.Numerics;

namespace MohawkGame2D;

public class Rock
{
	float x2;

	Vector2
	public void Setup()
	{

	}

	public void Update()
	{
		Draw.SetLineSize(0);
		Draw.SetFillColor(Color.White);
		Draw.Rectangle(x2, 440, 20, 10);
		Draw.Rectangle(x2 - 10, 450, 40, 10);
		Draw.Rectangle(x2 - 20, 460, 60, 10);
		Draw.Rectangle(x2 - 30, 470, 80, 10);
		Draw.Rectangle(x2 - 40, 480, 100, 20);
	}
}
