using System;
using Godot;

public partial class Captain : Participant
{
    private int stability = 10;

    public override void ApplyPenalty(int amount)
    {
        if (amount <= 0) return;
        int reduced = Math.Max(1, amount - stability);
        base.ApplyPenalty(reduced);
    }
}