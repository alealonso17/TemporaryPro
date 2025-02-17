public class Weapon
{
    //FIELDS 
    private string type; //Weapon type 
    private int ad; // attack damage the weapon does 
    private int rank;  // level of the weapo (1-5) 


    //CONSTRUCTOR  
    public Weapon(string type , int ad, int rank)
    {
        this.type = type ; 
        this.ad = ad;
        this.rank = rank ; 
    }
}