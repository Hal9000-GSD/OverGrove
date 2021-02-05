using System;

class MainClass {
  static void Main (string[] args) {
    int x = 0;
    int y = 0;
    int z = 0;
    int Time = 0;
    int Stop = 0;
    int Health = 10;
    bool Sword = true;
    bool Goblin = true;
    int GoblinHealth = 1;
    int GoblinRnd;
    bool Elf = true;
    int ElfHealth = 2;
    int ElfRnd;
    bool HGoblin = true;
    bool Dragon = true;
    string CmdLine = "null";
    Console.WriteLine("OverGrove: Ian Miller 2021");
    Console.WriteLine("You wake up under an oak tree \n(Type 'Help' For Help)");
    while(Stop < 1){
      CmdLine = Console.ReadLine();
      if(CmdLine == "n"){ // Goes North
        y++;
        if(x == 0 && y == 2 || x == 1 && y == 1 || x == -1 && y == 2|| x == 1 && y ==3 || x == 0 && y == 3 || x == 2 && y ==1 || x == 1 && y == 0){
          Console.WriteLine("You cant go that way");
          y--;
        }
        else{
          North();
        }
        if(x == 1 && y == 2 && Goblin == true){
        Look(x, y, Goblin, Elf,HGoblin, Dragon);
        }
      }
      else if(CmdLine == "s"){ // Goes South
        y--;
        if(x == 0 && y == 1 || x == 1 && y == 0 || x == 1 && y == -1 || x == -1 && y == -1 || x == 0 && y == -2 || x == 1 && y == -2 || x == 2 && y == -2 || x == 0 && y == -1){
          Console.WriteLine("You cant go that way");
          y++;
        }
        else{
          South();
        }
        if(x == 1 && y == 2 && Goblin == true){
          Look(x, y, Goblin, Elf,HGoblin, Dragon);
        }
        if(x == 1 && y ==1 && Goblin == true){
          Look(x, y, Goblin, Elf, HGoblin, Dragon);
          y++;
        }
      }
      else if(CmdLine == "e"){ // Goes East
        x++;
        if(x == 2 && y == 2 || x == 2 && y == 1 || x == 3 && y == 0 || x == 3 && y == -1){
          Console.WriteLine("You cant go that way");
          x--;
        }
        else{
          East();
        }
        if(x == 1 && y == 2 && Goblin == true){
        Look(x, y, Goblin, Elf,HGoblin, Dragon);
        }
      }
      else if(CmdLine == "w"){ // Goes West
        x--;
        if(x == -1 && y == 2 || x == -2 && y == 1 || x == -2 && y == 0 || x == -1 && y == -1){
          Console.WriteLine("You cant go that way");
          x++;
        }
        else{
          West();
        }
        if(x == 1 && y == 2 && Goblin == true){
          Look(x, y, Goblin, Elf,HGoblin, Dragon);
        }
        if(x == 1 && y ==1 && Goblin == true){
          Look(x, y, Goblin, Elf, HGoblin, Dragon);
          x++;
        }
      }
      else if(CmdLine == "N"){ // Goes North
        y++;
        if(x == 0 && y == 2 || x == 1 && y == 1 || x == -1 && y == 2|| x == 1 && y ==3 || x == 0 && y == 3 || x == 2 && y ==1 || x == 1 && y == 0){
          Console.WriteLine("You cant go that way");
          y--;
        }
        else{
          North();
        }
        if(x == 1 && y == 2 && Goblin == true){
        Look(x, y, Goblin, Elf, HGoblin, Dragon);
        }
      }
      else if(CmdLine == "S"){ // Goes South
        South();
        y--;
        if(x == 0 && y == 1 || x == 1 && y == 0 || x == 1 && y == -1 || x == -1 && y == -1 || x == 0 && y == -2 || x == 1 && y == -2 || x == 2 && y == -2){
          Console.WriteLine("You cant go that way");
          y++;
        }
        else{
          South();
        }
        if(x == 1 && y == 2 && Goblin == true){
        Look(x, y, Goblin, Elf, HGoblin, Dragon);
        }
      }
      else if(CmdLine == "E"){ // Goes East
        x++;
        if(x == 2 && y == 2 || x == 2 && y == 1 || x == 3 && y == 0 || x == 3 && y == -1){
          Console.WriteLine("You cant go that way");
          x--;
        }
        else{
          East();
        }
        if(x == 1 && y == 2 && Goblin == true){
        Look(x, y, Goblin, Elf, HGoblin, Dragon);
        }
      }
      else if(CmdLine == "W"){ // Goes West
        x--;
        if(x == -1 && y == 2 || x == -2 && y == 1 || x == -2 && y == 0 || x == -1 && y == -1){
          Console.WriteLine("You cant go that way");
          x++;
        }
        else{
          West();
        }
        if(x == 1 && y == 2 && Goblin == true){
        Look(x, y, Goblin, Elf, HGoblin, Dragon);
        }
      }
      else if(CmdLine == "Attack Goblin"){
        if(Sword == true){
          if(Goblin == true && x == 1 && y == 2){
            Random rnd = new Random();
            GoblinRnd = rnd.Next(1,4);
            if(GoblinRnd == 3){
              Console.WriteLine("You Kill the Goblin");
              GoblinHealth--;
            }
            else{
              if(GoblinRnd == 2){
                Console.WriteLine("Your Sword Misses by a mile And the Goblin Swings its Sword at you");
                Health--;
                Console.WriteLine("You Take Damage (" + Health + "/10)");
              }
              else if(GoblinRnd == 1){
                Console.WriteLine("Your sword barely misses the goblin");
              }
            }
          }
           else{
            Console.WriteLine("There is no goblin");
          }
        }
        else{
          Console.WriteLine("You Dont have a weapon to attack with");

        }
         
          if(GoblinHealth == 0){
          Goblin = false;
        }
        
      }
      else if(CmdLine == "Attack Elf"){
        if(Sword == true){
          if(Elf == true && x == 2 && y == 0){
            Random rnd = new Random();
            ElfRnd = rnd.Next(1,6);
            if(ElfRnd == 4 || ElfRnd == 5){
              ElfHealth--;
              if(ElfHealth == 0){
                Console.WriteLine("You kill the elf");
              }
              else{
                Console.WriteLine("You hit the Elf");
              }
            }
            else{
              if(ElfRnd == 2 || ElfRnd == 3){
                Console.WriteLine("Your Sword Misses by a mile And the Elf Swings its Dagger at you");
                Health--;
                Console.WriteLine("You Take Damage (" + Health + "/10)");
              }
              else if(ElfRnd == 1){
                Console.WriteLine("Your sword barely misses the elf");
              }
            }
          }
          else{
            Console.WriteLine("There is no elf");
          }
          
        }
        else{
          Console.WriteLine("You Dont have a weapon to attack with");
          }
          if(ElfHealth == 0){
          Elf = false;
          }
      }
      else if(CmdLine == "Help"){ // Help command
        Help();
      }
      else if(CmdLine == "Look"){ // Look command
        Look(x, y, Goblin, Elf, HGoblin, Dragon);
      }
      else if(CmdLine == "Wait") { // Wait command
        Wait();
        Time++;
      }
      else if(CmdLine == "help"){ // Help command
        Help();
      }
      else if(CmdLine == "look"){ // Look command
        Look(x, y, Goblin, Elf, HGoblin, Dragon);
      }
      else if(CmdLine == "wait") { // Wait command
        Wait();
        Time++;
      }
      else if(CmdLine == "Stop"){ // Stops The Game
        Stop++;
      }
      else if(CmdLine == "stop"){
        Stop++;
      }
      
        
        
      
      else{
        Console.WriteLine("I beg your pardon"); 
        CmdLine = "null";
        // For if you mistype 
      }
      Console.WriteLine(x);
      Console.WriteLine(y);
      Console.WriteLine(z);
      CmdLine = "null";
  }
  }

  
  
  //Help
  static void Help(){
    Console.WriteLine("Most commands are case sensitive");
    Console.WriteLine("Type 'Help' to return to this page");
    Console.WriteLine("Type 'Look' To Check current room");
    Console.WriteLine("Type 'n' to go North");
    Console.WriteLine("Type 's' to go South");
    Console.WriteLine("Type 'e' to go East");
    Console.WriteLine("Type 'w' to go West");
    Console.WriteLine("Type 'u' to go Up");
    Console.WriteLine("Tyoe 'd' to go Down");
    Console.WriteLine("Type 'Wait' to wait (duh)");
    Console.WriteLine("Type 'Stop' to stop the program");
  }
  //Look
  static void Look(int x, int y, bool Goblin, bool Elf, bool HGoblin, bool Dragon){
    if(x == 0 && y == 0){
      Console.WriteLine("There is a tall and sturdy oak tree here it almost looks climbable, there are paths going to the North, East, And West (n,e,w)");
    }
    else if(x == 0 && y == 1){
      Console.WriteLine("A wide open field stretchs out infront of you with a path going east, west, and south, there is a sign here (e,w,s)");
    }
    else if(x == 1 && y == 1){
      Console.WriteLine("The path your on continues North, there is a large wooden chest here (w,n)");
    }
    else if(x == 1 && y == 2){
      if(Goblin == true){
        Console.WriteLine("A Goblin Blocks your path");
      }
      else{
        Console.WriteLine("There is a ransacked camp here there is a small trail going west(w,s)");
      }
    }
    else if(x == 0 && y == 2){
      Console.WriteLine("There is an abandon goblin camp, there is a chest in the middle of camp(e)");
    }
    else if(x == -1 && y == 1){
      Console.WriteLine("There is a single market stall here the shop owner looks board and tierd");
    }
    else if(x == -1 && y == 0){
      Console.WriteLine("There is an empty town square, there is a peice of paper pinned to a job board");
    }
    else if(x == 1 && y == 0){
      Console.WriteLine("There is an entrance to a stone cave there is a sign and a lever here, the cave continues east (e,w)");
    }
    else if(x == 2 && y == 0){
      if(Elf == true){
        Console.WriteLine("An elf bocks your path");
      }
      else{
        Console.WriteLine("The cave your in apears to be the home of a Stone Elf, there is a chest here the cave continues south(w,s)");
      }
    }
    else if(x == 2 && y == -1){
      if(HGoblin == true){
        Console.WriteLine("A HobGoblin Blocks your path");
      }
      else{
        Console.WriteLine("The cave looks like it was once the home of a HobGoblin there is a chest here the cave continues to the west(w,n)");
      }
    }
    else if(x == 1 && y == -1){
      if(Dragon == true){
        Console.WriteLine("A Dragon blocks your path");
      }
      else{
        Console.WriteLine("There are scratches all over the walls of this large cave the cave continues west (w, e)");
      }
    }
    else if(x == 0 && y == -1){
        Console.WriteLine("This part of the cave is small and a faint light comes from the north(n, e)");
      }
  }
  //Wait
  static void Wait(){
    Console.WriteLine("Time Passes");
  }
  static void North(){
    Console.WriteLine("You Moved North");
  }
  static void South(){
    Console.WriteLine("You Moved South");
  }
  static void East(){
    Console.WriteLine("You Moved East");
  }
  static void West(){
    Console.WriteLine("You Moved West");
  }
  static void Up(){
  }
  static void Down(){
  }
}