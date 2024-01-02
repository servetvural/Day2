using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Day2;
public class Game
{
    public int Id { get; set; }
    public List<Flush> flushes = new List<Flush>();

    public Game(int Id)
    {
        this.Id = Id;   
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="gameline">1 blue, 14 green; 1 red, 4 blue, 15 green; 3 blue, 6 green; 3 blue, 2 green, 1 red; 1 red, 3 green, 1 blue</param>
    public void Populate(string gameline)
    {
        string[] gameflushes = gameline.Split(";", StringSplitOptions.RemoveEmptyEntries);
        foreach (string flush in gameflushes)
        {
            flushes.Add(new Flush(flush));
        }
    }
    public int MaxRed
    {
        get
        {
            return flushes.Max(x => x.Red);
        }
    }
    public int MaxGreen
    {
        get
        {
            return flushes.Max(x => x.Green);
        }
    }
    public int MaxBlue
    {
        get
        {
            return flushes.Max(x => x.Blue);
        }
    }

    public bool isPossible(int Red, int Green, int Blue)
    {
        return Red >= MaxRed && Green >= MaxGreen && Blue >= MaxBlue;
    }

    public int Power
    {
        get { return MaxRed * MaxGreen * MaxBlue; }
    }
}
