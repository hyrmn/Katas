using Shouldly;

var fixie = Require<FixieRunner>();
fixie.RunAllTests(); 

public class Fizzer
{
	public string Answer(int number)
	{
		return number.ToString();
	}
}

public class FizzerTests
{
	public void Fizzed_1_returns_1()
	{
		var fizzer = new Fizzer();
		fizzer.Answer(1).ShouldBe("1");
	}
	
	public void Fizzed_3_returns_fizz()
	{
		var fizzer = new Fizzer();
		fizzer.Answer(3).ShouldBe("fizz");
	}
}