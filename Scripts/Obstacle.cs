using System;
using Godot;
[GlobalClass]
public partial class Obstacle : Node {
//TODO: ObstacleDemo.tscn ar sakni Node un pievieno vienu Obstacle bērna mezglu

    private int penalty = 20;

    [Export]
    public string ObstacleName { get; set; } = "Rinda pie printera";

    [Export(PropertyHint.Range, "1,50,1")]
    public int Penalty
    {
        get { return penalty; }
        set { penalty = Math.Max(1, value); }
    }

    public override void _Ready()
    {
        GD.Print(ObstacleName, ": sods ", Penalty);
    }
}