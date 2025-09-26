
using MyMonkeyApp;

class Program
{
	static void Main()
	{
		Console.OutputEncoding = System.Text.Encoding.UTF8;
		var random = new Random();
		string[] asciiArts = new string[]
		{
			@"  (o.o)\n  /|_|\n   / \",
			@"  ('.')\n  /|_|\n   / \",
			@"  (o_o)\n  /|_|\n   / \",
			@"  ( ^.^)\n  /|_|\n   / \",
			@"  (O_O)\n  /|_|\n   / \"
		};

		while (true)
		{
			Console.Clear();
			Console.WriteLine("============================");
			Console.WriteLine("🐒 Monkey 콘솔 애플리케이션 🐒");
			Console.WriteLine("============================");
			Console.WriteLine("1. 모든 원숭이 나열");
			Console.WriteLine("2. 이름으로 원숭이 세부 정보 조회");
			Console.WriteLine("3. 무작위 원숭이 보기");
			Console.WriteLine("4. 종료");
			Console.WriteLine("----------------------------");
			Console.Write("메뉴를 선택하세요 (1-4): ");
			var input = Console.ReadLine();

			Console.Clear();
			// 무작위 ASCII 아트 출력
			Console.WriteLine(asciiArts[random.Next(asciiArts.Length)]);
			Console.WriteLine();

			switch (input)
			{
				case "1":
					ListAllMonkeys();
					break;
				case "2":
					FindMonkeyByName();
					break;
				case "3":
					ShowRandomMonkey();
					break;
				case "4":
					Console.WriteLine("프로그램을 종료합니다. 안녕히 가세요!");
					return;
				default:
					Console.WriteLine("잘못된 입력입니다. 엔터를 눌러 계속하세요.");
					Console.ReadLine();
					break;
			}
		}
	}

	static void ListAllMonkeys()
	{
		var monkeys = MonkeyHelper.GetAllMonkeys();
		Console.WriteLine("\n[모든 원숭이 목록]");
		Console.WriteLine("---------------------------------------------------");
		Console.WriteLine($"{nameof(Monkey.Name),-10} | {nameof(Monkey.Habitat),-15} | {nameof(Monkey.Description)}");
		Console.WriteLine("---------------------------------------------------");
		foreach (var m in monkeys)
		{
			Console.WriteLine($"{m.Name,-10} | {m.Habitat,-15} | {m.Description}");
		}
		Console.WriteLine("---------------------------------------------------");
		Console.WriteLine("\n엔터를 누르면 메뉴로 돌아갑니다.");
		Console.ReadLine();
	}

	static void FindMonkeyByName()
	{
		Console.Write("조회할 원숭이 이름을 입력하세요: ");
		var name = Console.ReadLine();
		var monkey = MonkeyHelper.FindByName(name ?? "");
		if (monkey != null)
		{
			PrintMonkeyDetail(monkey);
		}
		else
		{
			Console.WriteLine("해당 이름의 원숭이를 찾을 수 없습니다.");
		}
		Console.WriteLine("\n엔터를 누르면 메뉴로 돌아갑니다.");
		Console.ReadLine();
	}

	static void ShowRandomMonkey()
	{
		var monkey = MonkeyHelper.GetRandomMonkey();
		PrintMonkeyDetail(monkey);
		Console.WriteLine($"(무작위 선택 횟수: {MonkeyHelper.GetRandomPickCount()})");
		Console.WriteLine("\n엔터를 누르면 메뉴로 돌아갑니다.");
		Console.ReadLine();
	}

	static void PrintMonkeyDetail(Monkey m)
	{
		Console.WriteLine($"이름: {m.Name}");
		Console.WriteLine($"서식지: {m.Habitat}");
		Console.WriteLine($"설명: {m.Description}");
		Console.WriteLine("[ASCII 아트]");
		Console.WriteLine(m.AsciiArt);
	}
}
