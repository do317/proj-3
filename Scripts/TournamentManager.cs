using Godot;

public partial class TournamentManager : Node
{
    public override void _Ready()
    {
        Participant anna = GetNode<Participant>("Anna");
        Participant janis = GetNode<Participant>("Janis");
        anna.Setup("Anna", 30);
        janis.Setup("Jānis", 20);

        anna.Finished += OnParticipantFinished;
        janis.Finished += OnParticipantFinished;

        anna.ApplyPenalty(10);  // Paliek 20. Signāla vēl nav.
        anna.ApplyPenalty(20);  // Anna izstājas.
        anna.ApplyPenalty(5);   // Atkārtots paziņojums nerodas.
        janis.ApplyPenalty(20); // Jānis izstājas.
    }

    private void OnParticipantFinished(string participantName)
    {
        GD.Print(participantName, " izstājās");
    }

    /*TODO:
    Izveido jaunu scēnu Scenes/Tournament.tscn pēc koka zemāk (abiem bērna mezgliem pievieno vienu un to pašu Participant.cs).
    Participant klasē pievieno Finished signāla pieteikumu un nosūtīšanu metodē ApplyPenalty brīdī, kad enerģija sasniedz nulli (pirms soda pārbaudi !IsActive() || amount <= 0).
    Nospied Build, atlasi dalībnieka mezglu un Node → Signals sarakstā atrodi Finished signālu.
    
    Tournament (Node, skripts TournamentManager.cs)
    ├── Anna (Node, skripts Participant.cs)
    └── Janis (Node, skripts Participant.cs)
    */
}