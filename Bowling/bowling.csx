using Shouldly;

var fixie = Require<FixieRunner>();
fixie.RunAllTests(); 

public class Game
{
	private int[] rolls = new int[21];
	private int currentRoll = 0;
	
	public void Roll(int pins)
	{
		rolls[currentRoll] = pins;
		currentRoll++;
	}
	
	public int Score()
	{
		var score = 0;
		var roll = 0;
		
		for(var frame = 0; frame < 10; frame++)
		{
			if(IsStrike(roll))
			{
				score += rolls[roll] + StrikeBonus(roll);
				roll += 1;
			}
			if(IsSpare(roll))
			{
				score += ScoreForFrame(roll) + SpareBonus(roll);
				roll += 2;
			}
			else
			{
				score += ScoreForFrame(roll);
				roll += 2;
			}
		}
		
		return score;
	}
	
	private bool IsStrike(int roll)
	{
		return rolls[roll] == 10;
	}
	
	private bool IsSpare(int roll)
	{
		return rolls[roll] + rolls[roll+1] == 10;
	}
	
	private int ScoreForFrame(int roll)
	{
		return rolls[roll] + rolls[roll+1];
	}
	
	private int SpareBonus(int roll)
	{
		return rolls[roll+2]; 
	}

	private int StrikeBonus(int roll)
	{
		return rolls[roll+1] + rolls[roll+2]; 
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
		RollSpare();
		game.Roll(3);
		RollMany(rolls: 17, pins: 0);

		game.Score().ShouldBe(16);
	}
	
	public void Roll_10_over_two_frames()
	{
		game.Roll(0);
		game.Roll(5);
		game.Roll(5); 
		game.Roll(3);
		RollMany(rolls: 16, pins: 0);

		game.Score().ShouldBe(13);
	}
	
	public void Roll_one_strike()
	{
		RollStrike();
		game.Roll(3);
		game.Roll(4); 
		RollMany(rolls: 17, pins: 0);

		game.Score().ShouldBe(24);
	}	
	
	private void RollSpare()
	{
		game.Roll(5);
		game.Roll(5); 
	}
	
	private void RollStrike()
	{
		game.Roll(10);
	}
	
	private void RollMany(int rolls, int pins)
	{
		for(var roll = 0; roll < rolls; roll++)
		{
			game.Roll(pins);
		}
	}
}