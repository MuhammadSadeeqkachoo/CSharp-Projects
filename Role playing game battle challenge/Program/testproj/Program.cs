
int monsterHealth = 10 , heroHealth = 10 ;
Random Attact = new Random ();
int demage = 0;

do {
if(heroHealth > 0 && monsterHealth > 0) {
demage = Attact.Next (1, 10);
monsterHealth -= demage;
Console.WriteLine($"Monster was damaged and lost {demage} health and now has {monsterHealth} health.");


demage = Attact.Next (1, 10);
heroHealth -= demage;
Console.WriteLine ($"Hero was damaged and lost  {demage} health and now has {heroHealth} health.");
}

if(heroHealth > 0 && monsterHealth <= 0){
    Console.WriteLine("Hero Win!");
    break ;
}
else if(heroHealth <= 0 && monsterHealth > 0){
    Console.WriteLine("Monster Win!");
    break ;
}

}while(monsterHealth > 0 && heroHealth > 0);




