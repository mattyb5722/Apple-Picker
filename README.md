# Apple-Picker

For our second project, we made a catching game in the vein of the common Apple Picker demo project. My game has a sprite moving back 
and forth across the screen, periodically spawning anddropping objects. The player then has control of a different object that 
they move across the bottom of the screen to catch the falling items. This project emphasizes several basic game design techniques, 
including how to spawn/destroy objects, how to detect player input, how to move objects around in the scene, and how to handle
collisions between different objects. For a more detailed breakdown of project requirements, see below. 

If you are looking to play this game you can. All you have to do is download the whole Runnable folder. Then you can run the Project2.exe file and enjoy the game.

## Part 1 Requirements

 - Must wait to start until the player presses the mouse button

 - Must have a sprite that automatically moves across the top of the screen without moving out of sight of the camera (i.e., off either side of the screen) and that follows an unpredictable path. This sprite should periodically spawn items that fall towards the bottom of the screen. If an object falls off the screen, the player should lose a life and the object should be destroyed

 - Must move an item across the bottom of the screen based on a chosen form of player input (e.g., the player moving their mouse cursor or the player using arrow keys). If a falling object hits the player object, the player should receive points and the falling object should be destroyed

 - Must include a UI display that keeps track of how many lives the player has and what their current score is

 - Must reset the game if the player runs out of lives 

## Part 2 Requirements

 - Must include a UI menu the player can use to change the music and sfx volume, or mute either of them

 - Must use PlayerPrefs to save and load information from the game. Must be able to save and load the top 10 player high scores whenever they start up the game. Must be able to save and load the player’s sound preferences whenever they start up the game

 - Must include at least two additional scenes, one before and one after your game scene. The first scene should be a start screen with a menu the player can use to start the game, view the current high scores for the game, or quit the application. The last scene should be a game over screen that displays the high scores and allows the player to either return to the main menu, play again, or quit the application

 - Must be submitted by giving me a link to a GitHub repository where I can access your game. That repository should include at least 3 commits, 2 branches, and 1 merge in its history. That repository and your project should also be set up appropriately for using Git with Unity 
