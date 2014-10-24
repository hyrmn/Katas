using Shouldly;

var fixie = Require<FixieRunner>();
fixie.RunAllTests(); 

public class FizzBuzz
{
	private static readonly Func<int, bool> IsDivisibleBy3 = number => number % 3 == 0;
	private static readonly Func<int, bool> IsDivisibleBy5 = number => number % 5 == 0;

	private static readonly Dictionary<FizzieKey, Func<int, string>> fizzieMap = new Dictionary<FizzieKey, Func<int, string>>
	{
		{new FizzieKey(true, false), number => "Fizz"},
		{new FizzieKey(false, true), number => "Buzz"},
		{new FizzieKey(false, false), number => number.ToString()},
	};

	public string Answer(int number)
	{
		return fizzieMap[new FizzieKey(IsDivisibleBy3(number), IsDivisibleBy5(number))](number);
	}

	internal struct FizzieKey
	{
		internal FizzieKey(bool showFizz, bool showBuzz) : this()
		{
			ShowFizz = showFizz;
			ShowBuzz = showBuzz;
		}

		internal bool ShowFizz { get; private set; }
		internal bool ShowBuzz { get; private set; }
	}
}

public class FizzBuzzTests
{
	private readonly FizzBuzz fizzer = new FizzBuzz();
	
	public void Can_convert_3_to_fizz()
	{
		fizzer.Answer(3).ShouldBe("Fizz");
	}
	
	public void Can_convert_5_to_buzz()
	{
		fizzer.Answer(5).ShouldBe("Buzz");
	}
	
	public void Unfizzable_number_returns_self()
	{
		fizzer.Answer(2).ShouldBe("2");
	}
}