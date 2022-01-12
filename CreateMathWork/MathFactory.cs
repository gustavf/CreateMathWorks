using System;
using System.Collections.Generic;
using System.Linq;

namespace CreateMathWork;

public class MathFactory
{
    public List<string> GetMathWork(bool isMulti, int max, string ignore = null)
    {
        var ignoreNumbers = ignore is null ? new List<string>() : ignore.Split(',').ToList();
        var alldivision = isMulti ? CreateMulti(max, ignoreNumbers) : CreateDivision(max, ignoreNumbers);

        Random random = new Random();
        List<string> test = new List<string>();

        for (int i = 0; i < 100; i++)
        {
            int index = random.Next(alldivision.Count());
            test.Add(alldivision[index]);
        }

        return test;
    }


    List<string> CreateMulti(int max, List<string> ignore)
    {
        List<string> allMulti = new List<string>();
        for (int j = 1; j <= max; j++)
        {
            if (ignore.Any(x => x == j.ToString())) continue;

            for (int i = 1; i <= max; i++)
            {
                if (ignore.Any(x => x == i.ToString())) continue;

                string s = $"{i} x {j} = _____";
                allMulti.Add(s);
            }
        }

        return allMulti;
    }

    List<string> CreateDivision(int max, List<string> ignore)
    {
        List<string> allMulti = new List<string>();
        for (int j = 1; j <= max; j++)
        {
            if (ignore.Any(x => x == j.ToString())) continue;
            for (int i = 1; i <= max; i++)
            {
                if (ignore.Any(x => x == i.ToString())) continue;
                int result = i * j;

                if (result > max) continue;

                string s = $"{result} / {i} = _____";
                allMulti.Add(s);
            }
        }

        return allMulti;
    }
}
