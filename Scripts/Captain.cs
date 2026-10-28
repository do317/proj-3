using System;

public class Captain : Participant
{
    private int stability = 10;

    public Captain(string name) : base(name, 150) { }

    public override void ApplyPenalty(int amount)
    {
        if (amount <= 0) return;
        int reduced = Math.Max(1, amount - stability);
        base.ApplyPenalty(reduced);
    }
}