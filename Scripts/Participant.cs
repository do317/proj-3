using Godot;
using System;

public partial class Participant : Node
{
    public string ParticipantName  = "";
    private int energy;
    public int Level = 1;

	public void Setup(string name, int energy)
	{
		ParticipantName  = name;
		this.energy = energy;
	}
	[Signal]
	public delegate void FinishedEventHandler(string participantName);

	public virtual void ApplyPenalty(int amount)
	{
		if (!IsActive() || amount <= 0) return;
		energy = Math.Max(0, energy - amount);
		if (energy == 0)
			EmitSignal(SignalName.Finished, ParticipantName);
	}

	public bool IsActive()
	{
		return this.energy > 0;
	}
	
    public int GetEnergy() { return this.energy; }
}