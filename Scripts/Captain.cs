using System;
using Godot;

public partial class Captain : Participant
{
    private int stability = 10;

    public void Setup(string name) { base.Setup(name,150); }

    public override void ApplyPenalty(int amount)
    {
        if (amount <= 0) return;
        int reduced = Math.Max(1, amount - stability);
        base.ApplyPenalty(reduced);
    }
}