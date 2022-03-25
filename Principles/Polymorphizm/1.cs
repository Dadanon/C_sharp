class Transformer 
{
	public void attack()
	{
		Console.WriteLine("Transformer is attacking!");
	}
}

class Decepticon : Transformer
{
	public void attack()
	{
		Console.WriteLine("Decepticon is attacking!");
	}
}

class Autobot : Transformer
{
	public void attack()
	{
		Console.WriteLine("Autobot is attacking!");
	}
}