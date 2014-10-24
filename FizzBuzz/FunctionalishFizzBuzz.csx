using Shouldly;

var fixie = Require<FixieRunner>();
fixie.RunAllTests(); 

public class FizzBuzz
{
	public string Answer(int number)
	{
		if(number == 3)
		{
			return "Fizz";
		}
		
		return "Buzz";
	}
}

public class FizzBuzzTests
{
	public void Can_convert_3_to_fizz()
	{
		var fizzer = new FizzBuzz();
		
		fizzer.Answer(3).ShouldBe("Fizz");
	}
	
	public void Can_convert_5_to_buzz()
	{
		var fizzer = new FizzBuzz();
		
		fizzer.Answer(5).ShouldBe("Buzz");
	}
}