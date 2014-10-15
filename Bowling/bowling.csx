using Shouldly;

var fixie = Require<FixieRunner>();
fixie.RunAllTests(); 

public class Game
{
	private int score;
	
	public void Roll(int pins)
	{
		score += pins;
	}
	
	public int Score()
	{
		return score;
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
	
	public void All_one_pin_rolls()
	{
		var game = new Game();
		
		for(var roll = 0; roll < 20; roll++)
		{
			game.Roll(1);
		}
		
		game.Score().ShouldBe(20);
	}
}