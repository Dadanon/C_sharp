public class Gun
{
	public int ammo_count = 10;
	
	public void fire() 
	{
		this.ammo_count -= 1;
	}
}

public class Transformer
{
	public Gun gun_left = new Gun();
	public Gun gun_right = new Gun();
	
	public void fire() 
	{
		this.gun_left.fire();
		this.gun_right.fire();
	}
	
	public void burst_fire() 
	{
		this.fire();
		this.fire();
		this.fire();
	}
}