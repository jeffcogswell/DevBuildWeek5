using System;

namespace TestingDemo
{
	enum GameState
	{
		Exploring,
		Fighting,
		Won
	}

	// Make a class called Game with a GameState member, and a number of players member.

	class Game
	{
		protected GameState state;
		protected int numberOfPlayers;

		public Game(GameState _State, int _NumberOfPlayers)
		{
			state = _State;
			numberOfPlayers = _NumberOfPlayers;
		}

	}

	class Program
	{
		static void Main(string[] args)
		{
			Game mygame = new Game(GameState.Exploring, 15);
			//Console.WriteLine(mygame.state);
			//Console.WriteLine(mygame.numberOfPlayers);

			//mygame.state = GameState.Exploring;
			//Console.WriteLine(mygame.state);
			//mygame.numberOfPlayers = 10;
			//Console.WriteLine(mygame.numberOfPlayers);
		}
	}
}
