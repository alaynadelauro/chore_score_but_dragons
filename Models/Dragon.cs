namespace chore_score_but_dragons.Models;
public class Dragon(int id, string name, int wings, int legs, bool scales, bool feathers, bool fur, string breathType, int eyes, bool canFly, string foundAt)
{
    public int Id { get; set; } = id;
    public string Name { get; set; } = name;
    public int Wings { get; set; } = wings;
    public int Legs { get; set; } = legs;
    public bool Scales { get; set; } = scales;
    public bool Feathers { get; set; } = feathers;
    public bool Fur { get; set; } = fur;
    public string BreathType { get; set; } = breathType;
    public int Eyes { get; set; } = eyes;
    public bool CanFly { get; set; } = canFly;
    public string FoundAt { get; set; } = foundAt;
}