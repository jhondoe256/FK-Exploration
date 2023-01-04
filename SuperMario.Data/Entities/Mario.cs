
public class Mario
{
    public int Id { get; set; }
    public string Name { get; set; } = "Mario";
    public float Speed { get; set; }
    public int Size { get; set; }
    public int HP { get; set; } = 3;

    public Player Player { get; set; }

    public List<PowerUp> PowerUps { get; set; } = new List<PowerUp>();
}
