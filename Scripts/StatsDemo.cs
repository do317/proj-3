using Godot;

public partial class StatsDemo : Node
{
    public override void _Ready()
    {
        Stats original = new Stats(100, 10);
        Stats copy = original;
        copy.Energy = 40;
        GD.Print(original.Energy); // 100
        GD.Print(copy.Energy);     // 40
    }
}