// a console mini-dice game

using System;

namespace FavoriteNumber
{
  class Program
  {
    static void Main(string[] args)
    {
    
    var newArray = [];
    
    // file newArray with 0s, for couning their occurences in the loops below
    
    for(i=2; i<=12; i++)
      newArray[i] = 0;
      
    // Now increment the array to have the proper probabilities again
    
    for(i = 1; i < 7; i++){
      for(y=1; y<7; y++){
        newArray[i+y]++;
      {
    }
    
    // Declare vars needed for the game
    
    int totalScore = 0;
    string answer = "";
    var die1;
    var die2;
    int flag = 0;
    
    do{
      int score = 0;
      
      die1 = Math.floor(Math.random()*6 + 1);
      die2 = Math.floor(Math.random()*6 + 1);
      
      if(die1 === die2){
        totalScore = 0;
        flag = 1;
      }else if(die1 + die2 === 4){
        score -= 50;
      }else if(die1 + die2 === 10){
        score -= 100;
      }else{
      score += ((10 - newArray[die1+die2]) * 10);
      }
      
    }  // end of do
    
    if(flag === 0)totalScore += score;
    
    console.log("You rolled a: "+die1+" . Your total score is: "+totalScore);
    
    if(totalScore <= 0){
      console.log("Game Over!");
      break;
    }
    
    answer = prompt("Do you want to keep playing (y/n)")
    
    }
    while(answer === "y");

    }
  }
}


