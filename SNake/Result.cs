using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SNake
{
    class Result:IComparable<Result>
    {
        public string Name;
        public int score;
        public Result(string name, int score)
        {
            this.Name = name;
            this.score = score;
        }
        public Result()
        {

        }
        public static bool operator <=(Result a, Result b)
        {
            return a.score <= b.score;
        }
        public static bool operator >=(Result a, Result b)
        {
            return a.score >= b.score;
        }
        public int CompareTo(Result other) { return score.CompareTo(other.score); }
    }
}
