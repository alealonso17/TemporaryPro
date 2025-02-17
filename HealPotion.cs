public class HealPotion
{
    //FIELDS 
    public int heal;  // Amount of healing this potion is going to do 
    public int rank; // The level of this potion (1-5) 

    //CONSTRUCTOR 
    public HealPotion(int heal, int rank)
    {
        this.heal = heal; 
        this.rank = rank; 
    }
}