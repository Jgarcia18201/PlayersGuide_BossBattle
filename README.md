# PlayersGuide_BossBattle

This is my solution to the part one boss battle of the book C# Players Guide 5th edition

Objectives: 
*Establish the game's starting state: the Manticore begins with 10 health points and the city with 15. The game starts at round 1.
*Ask the first player to choose the Manticore's distance from the city (0 to 100). Clear the screen afterward. 
*Run the game in a loop until either the Manticore's or city's health reaches 0.
*Before the second player's turn, display the round number, the city's health, and the Manticore's health. 
*Compute how much damage the cannon will deal this round: 10 points if the round number is a multiple of both 3 and 5, 3 if it is a multiple of 3 or 5(but not both),
and otherwise. Display this to the player.
*Get a target range from the second player, and resolve its effect. Tell the user if they overshot(too far), fell short, or hit the Manticore. If it was hit, reduce the
Manticore's heath by the expected amount. 
*If the Manticore is still alive, reduce the city's health by 1.
*Advance to the next round
*When the Manticore or the city's health reaches 0, end the game and display the outcome.
*Use different colors for different types of messages
