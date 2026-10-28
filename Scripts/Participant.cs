using Godot;
using System;

public partial class Participant : Node
{
    public string ParticipantName  = "";
    private Stats stats = new Stats(100, 10);
    public int Level = 1;

	List<Buff> buffs;

	public void Setup(string name, Stats stats)
	{
		ParticipantName  = name;
		this.stats = stats;
	}
	[Signal]
	public delegate void FinishedEventHandler(string participantName);

	public virtual void ApplyPenalty(int amount)
	{
		if (!IsActive() || amount <= 0) return;
		this.stats.Energy = Math.Max(0, this.stats.Energy - amount);
		if (this.stats.Energy == 0)
			EmitSignal(SignalName.Finished, ParticipantName);
	}

	public bool IsActive()
	{
		return this.energy > 0;
	}
	public Stats GetStats() {
		return this.stats;
	}
	
    public int GetEnergy() { return this.stats.Energy; }

    public void Heal(int amount)
    {
        if (IsActive()) stats.Heal(amount);
    }
	
    public void AddBuff(Buff buff)
    {
        buffs.Add(buff);
    }

    public void RemoveBuffAt(int index)
    {
        buffs.RemoveAt(index);
    }
	public int GetTotalFocus()
	{
		int total = stats.Focus;
		foreach (Buff buff in buffs)
		{
			total += buff.FocusBonus;
		}
		return total;
	}
}