
//12 red cubes, 13 green cubes, and 14 blue cubes
using Day2;

//Bag bag = new Bag(12, 13, 14);

StreamReader reader = new StreamReader("input.txt");

List<Game> games = new List<Game>();

//read input and load games
while (true)
{
    string line = reader.ReadLine();
    if (line == null)
        break;
    string[] arr = line.Split(":", StringSplitOptions.RemoveEmptyEntries);

    Game game = new Game(int.Parse(arr[0].Replace("Game","").Trim()));
    game.Populate(arr[1]);
    games.Add(game);
}

int sumOfIdsOfPossibleGames = games.Where(x => x.isPossible(12, 13, 14)).Sum(x => x.Id);
Console.WriteLine(sumOfIdsOfPossibleGames);

//If you want you can print this
//foreach (Game game in games)
//{
//    Console.WriteLine("R=" + game.MaxRed + ", G=" + game.MaxGreen + ", B=" + game.MaxBlue + " " + game.isPossible(12,13,14));
//}

//SECOND SECTION
int thePower = games.Sum(x => x.Power);

Console.WriteLine(thePower);

Console.ReadLine();
