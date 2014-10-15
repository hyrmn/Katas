using Shouldly;

var fixie = Require<FixieRunner>();
fixie.RunAllTests(); 

public class Game
{
}

public class GameTests
{
	public void Gutter_game_has_zero_score()
	{
		var game = new Game();
	}
}