public class Armor 
{
    //FIELDS
    public int armor ; // Amount of armor the item is giving 
    public string type ; //Item type 
    public int rank; //Item level (1-5) 

    //CONSTRUCTOR 
    public Armor(int armor, string type, int rank)
    {
        this.armor = armor ; 
        this.type = type; 
        this.rank = rank; 
    }
}