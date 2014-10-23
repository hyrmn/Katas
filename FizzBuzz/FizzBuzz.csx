using Shouldly;

var fixie = Require<FixieRunner>();
fixie.RunAllTests(); 

public class Fizzer
{
	public string Answer(int number)
	{
		if(number == 3)
		{
			return "fizz";
		}
		
		return number.ToString();
	}
}

public class FizzerTests
{
	private readonly Fizzer fizzer = new Fizzer();
	
	public void Fizzed_1_returns_1()
	{
		fizzer.Answer(1).ShouldBe("1");
	}
	
	public void Fizzed_3_returns_fizz()
	{
		fizzer.Answer(3).ShouldBe("fizz");
	}
	
	public void Fizzed_6_returns_fizz()
	{
		fizzer.Answer(6).ShouldBe("fizz");
	}
}