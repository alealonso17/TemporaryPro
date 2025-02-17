
// Create Basic Objects 
Console.WriteLine("Please Enter Your Name :"); string username = Console.ReadLine()?? " ";  // Ask for the username 
Player player1 = new Player(username); //Create player 

//Health Potions (ranks from 1 to 5 ) 
HealPotion h1 = new HealPotion(2, 1); 
HealPotion h2 = new HealPotion(5, 2); 
HealPotion h3 = new HealPotion(10, 3); 
HealPotion h4 = new HealPotion(25, 4); 
HealPotion h5 = new HealPotion(50, 5); 

//Strength Potions (ranks 1 to 5 )
StrengthPotion s1 = new StrengthPotion(2, 1); 
StrengthPotion s2 = new StrengthPotion(5, 2); 
StrengthPotion s3 = new StrengthPotion(10, 3); 
StrengthPotion s4 = new StrengthPotion(15, 4); 
StrengthPotion s5 = new StrengthPotion(20, 5); 

// Create diferent type of armor 
//Chest (rank from 1 to 5) 
Armor chestArmor1 = new Armor(5, "Chest Armor", 1); 
Armor chestArmor2 = new Armor(10, "Chest Armor", 2); 
Armor chestArmor3 = new Armor(15, "Chest Armor", 3); 
Armor chestArmor4 = new Armor(20, "Chest Armor", 4); 
Armor chestArmor5 = new Armor(30, "Chest Armor", 5); 

// Helmet (rank from 1 to 5) 
Armor headArmor1 = new Armor(1,"Head Armor", 1); 
Armor headArmor2= new Armor(3,"Head Armor", 2); 
Armor headArmor3 = new Armor(10,"Head Armor", 3); 
Armor headArmor4 = new Armor(15,"Head Armor", 4); 
Armor headArmor5= new Armor(20,"Head Armor", 5); 

//Pants (Rank from 1 to 5 ) 

Armor pantArmor1 = new Armor(1,"Pant Armor", 1); 
Armor pantArmor2= new Armor(3,"Pant Armor", 2); 
Armor pantArmor3 = new Armor(10,"Pant Armor", 3); 
Armor pantArmor4 = new Armor(15,"Pant Armor", 4); 
Armor pantArmor5= new Armor(20,"Pant Armor", 5); 

//Weapons 

Weapon bow1 = new Weapon("Bow", 10, 1); 
Weapon bow2 = new Weapon("Bow", 15, 2); 
Weapon bow3 = new Weapon("Bow", 20, 3); 

Weapon sword1 = new Weapon("Sword", 10, 1); 
Weapon sword2 = new Weapon("Sword", 20, 2); 
Weapon sword3 = new Weapon("Sword", 30, 3); 


//Creating enemies and adding them to the combat list 
Combat mainCombat = new Combat(player1);  // Create new combat system for player 1 
// Create and Add each enemy to the combat system of player 1 
Enemy e1 = new Enemy("Mage", 250, 5, s5,bow1) ; mainCombat.AddEnemy(e1.type, e1);
Enemy e2 = new Enemy("Rogue", 100, 2, pantArmor2,bow2) ;  mainCombat.AddEnemy(e2.type, e2);
Enemy e3 = new Enemy("Giant", 80, 1, h2, bow3) ;  mainCombat.AddEnemy(e3.type, e3);
Enemy e4 = new Enemy("Demon", 400, 5, chestArmor5,sword1) ;  mainCombat.AddEnemy(e4.type, e4);
Enemy e5 = new Enemy("Giant", 110, 2, h3,sword2) ;  mainCombat.AddEnemy(e5.type, e5);
Enemy e6 = new Enemy("Mage", 80, 1, headArmor1,sword3) ;  mainCombat.AddEnemy(e6.type, e6);
Enemy e7 = new Enemy("Lion", 100, 2, headArmor2,bow1) ;  mainCombat.AddEnemy(e7.type, e7);
Enemy e8 = new Enemy("Mage", 250, 5, s5,bow2) ;  mainCombat.AddEnemy(e8.type, e8);
Enemy e9= new Enemy("Mage", 250, 5, s5,bow3) ;  mainCombat.AddEnemy(e9.type, e9);
Enemy e10 = new Enemy("God Soldier", 200, 5, pantArmor5,bow3) ;  mainCombat.AddEnemy(e10.type, e10);





 

