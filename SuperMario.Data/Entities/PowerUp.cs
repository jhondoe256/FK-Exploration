
public class PowerUp
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public int Duration { get; set; } = 5000;

    public Mario Mario { get; set; }
    public Level Level { get; set; }
}
