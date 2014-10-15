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
	private Game game = new Game();
	
	public void Gutter_game_has_zero_score()
	{
		RollMany(rolls: 20, pins: 0);
		
		game.Score().ShouldBe(0);
	}
	
	public void All_one_pin_rolls()
	{
		RollMany(rolls: 20, pins: 1);

		game.Score().ShouldBe(20);
	}
	
	public void Roll_one_spare()
	{
		game.Roll(5);
		game.Roll(5); //spare
		game.Roll(3);
		RollMany(rolls: 17, pins: 0);

		game.Score().ShouldBe(16);
	}
	
	private void RollMany(int rolls, int pins)
	{
		for(var roll = 0; roll < rolls; roll++)
		{
			game.Roll(pins);
		}
	}
}