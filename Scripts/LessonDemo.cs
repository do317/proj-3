using Godot;
using System.Collections.Generic;

public partial class LessonDemo : Node {

    public override void _Ready() {
        List<Participant> party = new List<Participant>();
        party.Add(new Participant("Ieva", 100));
        party.Add(new Captain("Anna"));
        party.Add(new Presenter("Jānis"));

        foreach (Participant p in party)
        {
            p.ApplyPenalty(20);
            GD.Print(p.Name, ": ", p.GetEnergy());
        }
    }
}