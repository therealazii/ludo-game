# ludo-game
LUDO ASSESSMENT SOLUTIONS, CHALLENGES AND INSIGHTS

Goal: Build a small game for mobile that has the following;
- a board built as a ludo board that can rotate 360 degrees
- playable characters that can move around the board
- a binary that can be installed on mobile

CHALLENGE

The main goal given was to develop Ludo as a mobile game, and for this project I used the Unity Engine for games, accompanied with the C# language, while using corelDRAW for the art and graphics.

To begin, I first started development by designing the Ludo boards and all the tokens that are required. For this project I will only be making use of the default Unity UI, as it would be the most efficient way and least performant-expensive way to do it.

After designing the ludo board, I need to think of how I wanted the tokens to be placed on the board, with ease. I took a closer look at the board, and noticed that the board could be divided into a 15 by 15 grid of squares for coord(-7, -7) to coord(7, 7), with each position on the board fitting perfectly into one of 225 squares. Using this information, we can create a integer coordinate system that map every possible position of every piece on the board to a coordinate on the board. Next, we can reduce each position into steps, for each token. So for a red token for example, step_0 would be assigned to coord(-2, 5) (or wherever it is on the board), and so on, following the same convention. This convention is what the rest of he game would be built upon.
