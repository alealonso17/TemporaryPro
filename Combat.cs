using System.Security;

public class Combat
{
    //FIELDS 
    public Dictionary<string,Enemy> enemies = new Dictionary<string, Enemy>() ; 
    public object player ; 

    //CONSTRUCTOR  

    public Combat(object player)
    {
        this.player = player ; 
    }

    //METHOD 
    public void AddEnemy(string type, Enemy enemy )
    {
        enemies.Add(type, enemy); 
    }
}