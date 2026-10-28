using Godot;
using System;

public partial class Presenter : Participant
{

    public override void ApplyPenalty(int amount)
    {
        if (amount <= 0) return;
        base.ApplyPenalty(amount + 5);
    }
}