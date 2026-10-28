
using System;

public class Presenter : Participant
{

    public Presenter(string name) : base(name, 80) { }

    public override void ApplyPenalty(int amount)
    {
        if (amount <= 0) return;
        base.ApplyPenalty(amount + 5);
    }
}