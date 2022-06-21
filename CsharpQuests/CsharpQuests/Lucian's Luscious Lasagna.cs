namespace CsharpQuests;

public class Lasagna
{
    private const int _expectedMinutesInOven = 40;
    
    public int GetExpectedMinutesInOven() => _expectedMinutesInOven;

    public int RemainingMinutesInOven(int elapsed)
    {
        return _expectedMinutesInOven - elapsed; 
    }
    public int PreparationTimeInMinutes(int layers) => layers * 2;
    
    public int ElapsedTimeInMinutes(int usedLayers, int minutesInOven)
    {
        return PreparationTimeInMinutes(usedLayers) + minutesInOven;
    }
}