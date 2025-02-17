using System.Runtime.CompilerServices;

public class Enemy
{
    //FIELDS 
    private string type; //Type of monster
    private int hp; //HP of the monster 
    private int rank ; //level  Of the monster 
    private object item; // item the monster will drop 

    //CONSTRUCTOR 
    public Enemy(string type, int hp, int rank, object item)
    {
        this.type = type ; 
        this.hp = hp; 
        this.rank = rank; 
        this.item = item; 

    }
}