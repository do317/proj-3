using System;
using Godot;
[GlobalClass]
public partial class Obstacle : Node {
//TODO: ObstacleDemo.tscn ar sakni Node un pievieno vienu Obstacle bērna mezglu
/*
Scēnā ObstacleDemo.tscn izveido trīs Obstacle bērna mezglus un nosauc tos pēc tabulas zemāk (mezgla Name palīdz atrast mezglu kodā, bet ObstacleName ir cilvēkam izdrukājamais teksts).
Inspector panelī iestati katram savu Obstacle Name un Penalty pēc tabulas. Saglabā scēnu.
Palaid ar F6 un salīdzini trīs Output izdrukas ar iestatījumiem.
Maini tikai PrinterQueue sodu Inspector panelī, palaid vēlreiz un README pieraksti, kuras izdrukas mainījās (un kāpēc scēnā saglabāta vērtība ir noteicošā pār koda sākuma penalty = 20).
*/

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