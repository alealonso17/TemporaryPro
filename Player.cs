public class Player
{
    //FIELDS
    private string name; 
    
   
  
    private List<object> inventory = new List<object>() ; 
   

// PROPERTIES 
    public int Hp { get; private set; }
    public int AttackDamage { get; private set; }
    public int Armor { get; private set; }
    public int Stage { get; set; }
    //CONSTRUCTOR  
    public Player(string name)
    {
        this.name = name; 
        Hp = 100; 
        AttackDamage = 10; 
        Armor = 0; 
        Stage = 0; 
    }
}