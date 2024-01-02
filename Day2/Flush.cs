using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2;
public class Flush
{
    public int Red { get; set; }
    public int Blue { get; set; }
    public int Green { get; set; }

    public Flush(int Red, int Green , int Blue)
    {
        this.Red = Red; 
        this.Green = Green;
        this.Blue = Blue;
    }


    /// <summary>
    /// 
    /// </summary>
    /// <param name="flushline">1 blue, 14 green</param>
    public Flush(string flushline)
    {
        string[] flushsection = flushline.Split(",", StringSplitOptions.RemoveEmptyEntries);
        foreach (string section in flushsection)
        {
            AddFlushBalls(section);
        }
    }

    public void AddFlushBalls(string flush)
    {
        if (flush.Contains("green"))
        {
            Green = int.Parse(flush.Replace("green", "").Trim());
        }
        else if (flush.Contains("red"))
        {
            Red = int.Parse(flush.Replace("red", "").Trim());
        } else if (flush.Contains("blue"))
        {
            Blue = int.Parse(flush.Replace("blue", "").Trim());
        }
    }
}
