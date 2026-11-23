using System;
using System.Collections.Generic;
using System.Numerics;

namespace MohawkGame2D;

public class Alien2
{
	Vector2 position;
	float speed;
	float shootTimer;

	public List<AlienProjectile> projectiles = new List<AlienProjectile>();

	public void Setup()
	{
		position = new Vector2(860, 40);
		speed = 1;
		shootTimer = 0;
	}

	public void Update()
	{
		position.X -= speed;

		if (position.X < -60)
		{
			position.X = 860;
		}

		shootTimer += Time.DeltaTime;

		if (shootTimer >= 2)
		{
			AlienProjectile projectile = new AlienProjectile();

			projectile.Setup(position);

			projectiles.Add(projectile);

			shootTimer = 0;
		}

        foreach (AlienProjectile alienprojectile in projectiles)
        {
            alienprojectile.Update();
        }

        Draw.SetLineSize(0);
        Draw.SetFillColor(Color.Magenta);
        Draw.Rectangle(position.X, 40, 80, 30);
        Draw.Square(position.X, 20, 10);
        Draw.Square(position.X + 10, 30, 10);
        Draw.Square(position.X + 60, 30, 10);
        Draw.Square(position.X + 70, 20, 10);
        Draw.Rectangle(position.X - 20, 30, 10, 30);
        Draw.Square(position.X - 10, 50, 10);
        Draw.Square(position.X + 10, 70, 10);
        Draw.Square(position.X + 60, 70, 10);
        Draw.Rectangle(position.X + 90, 30, 10, 30);
        Draw.Square(position.X + 80, 50, 10);
        Draw.SetLineSize(0);
        Draw.SetFillColor(Color.Black);
        Draw.Square(position.X + 20, 50, 10);
        Draw.Square(position.X + 50, 50, 10);
    }
}
