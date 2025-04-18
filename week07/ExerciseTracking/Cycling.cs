public class Cycling : Activity
{
    private double _speedKph;

    public Cycling(DateTime date, int durationMinutes, double speedKph)
        : base(date, durationMinutes)
    {
        _speedKph = speedKph;
    }

    public override double GetDistance() => GetSpeed() * GetDurationMinutes() / 60;
    public override double GetSpeed() => _speedKph;
    public override double GetPace() => 60 / GetSpeed();
}