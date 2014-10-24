using Shouldly;

var fixie = Require<FixieRunner>();
fixie.RunAllTests(); 

public class FizzBuzz
{
	public string Answer(int number)
	{
		return "Fizz";
	}
}

public class FizzBuzzTests
{
	public void Can_convert_3_to_fizz()
	{
		var fizzer = new FizzBuzz();
		
		fizzer.Answer(3).ShouldBe("Fizz");
	}
}