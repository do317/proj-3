public struct Stats
{
    public int Energy;
    public int MaxEnergy;
    public int Focus;

    public Stats(int energy, int focus)
    {
        Energy = energy;
        MaxEnergy = energy;
        Focus = focus;
    }

    
    public void Heal(int amount)
    {
        if (amount <= 0) return;
        Energy = Math.Min(MaxEnergy, Energy + amount);
    }
}