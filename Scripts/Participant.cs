using Godot;
using System;

public class Participant
{
    public string Name = "";
    private int energy;
    public int Level = 1;

	public Participant(string name, int energy)
	{
		Name = name;
		this.energy = energy;
	}

	public virtual void ApplyPenalty(int amount)
	{
		if (amount < 0) return; // Negatīvu sodu nepiemērojam.
		this.energy -= amount;
		if (this.energy < 0) this.energy = 0;
	}

	public bool IsActive()
	{
		return this.energy > 0;
	}
	
    public int GetEnergy() { return this.energy; }
}