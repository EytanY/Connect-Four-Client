

# Connect Four Game
Welcome to the Connect Four game! 
This project consists of a client-side and a server-side implementation, allowing players to engage in exciting matches against the server. 
This README file will guide you through the setup, rules, and usage of the game.

# Rules
Connect Four is a two-player game played on a grid of six rows and seven columns. 
The goal is to be the first player to connect four of their colored discs in a row, column, or diagonal.

Players take turns dropping one of their colored discs into a chosen column.
The disc will fall to the lowest available spot in the column.
The game ends when either player successfully connects four discs or when the game board is full.
If the game board is full and no player has won, the game is considered a draw.


# Additional Notes

The server will automatically make its moves after receiving the client's move. You do not need to interact with the server directly.
The client and server communicate over a network socket, allowing for remote gameplay if the server is hosted on a different machine.
The server's moves are determined by a simple AI algorithm that aims to make strategic choices.
Feel free to modify and extend the codebase to enhance the game or add additional features.
Thank you for choosing the Connect Four game! Enjoy playing and have fun!
