public class Level
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;

    public World World { get; set; }
    public Mario Mario { get; set; }
    public List<Koopa> Koopas { get; set; } = new List<Koopa>();
    public List<PowerUp> PowerUps { get; set; } = new List<PowerUp>();

}