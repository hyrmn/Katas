using Shouldly;

var fixie = Require<FixieRunner>();
fixie.RunAllTests(); 

public class Game
{
	public void Roll(int pins)
	{
	}
	
	public int Score()
	{
		return -1;
	}
}

public class GameTests
{
	public void Gutter_game_has_zero_score()
	{
		var game = new Game();
		
		for(var roll = 0; roll < 20; roll++)
		{
			game.Roll(0);
		}
		
		game.Score().ShouldBe(0);
	}
}