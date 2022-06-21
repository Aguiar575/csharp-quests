namespace CsharpQuests;

public static class AssemblyLine
{
    private const int _carsProducedPerHour = 221; 
    
    public static double SuccessRate(int speed) => 
        speed switch 
        {
            > 0 and <= 4 => 1,
            >= 5 and <= 8 => 0.9,
            9 => 0.8, 
            10 => 0.77,
            _ => 0,
        };
    
    public static double ProductionRatePerHour(int speed) 
    {
        int producedCards = speed * _carsProducedPerHour;
        double cardsProducedWithSuccess = SuccessRate(speed) * producedCards;
        return cardsProducedWithSuccess;
    }
    
    public static int WorkingItemsPerMinute(int speed) => 
        (int)(ProductionRatePerHour(speed) / 60);
}