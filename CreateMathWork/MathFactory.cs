using System;
using System.Collections.Generic;
using System.Linq;

namespace CreateMathWork
{
    public class MathFactory
    {
        public List<string> GetMathWork(bool isMulti, string ignore = null)
        {
            //var alldivision = CreateAddition();
            //var alldivision = CreateDivision();
            var ignoreNumbers = ignore is null ? new List<string>() : ignore.Split(',').ToList();
            var alldivision = isMulti ? CreateMulti(ignoreNumbers) : CreateDivision(ignoreNumbers);

            Random random = new Random();
            List<string> test = new List<string>();

            //for (int count = 0; count < numberOfTests; count++)
            {
                for (int i = 0; i < 100; i++)
                {
                    int index = random.Next(alldivision.Count());
                    test.Add(alldivision[index]);
                }

                return test;
            }

            List<string> CreateAddition(List<string> ignore)
            {
                int max = 20;
                List<string> allAddition = new List<string>();
                for (int i = 1; i < max; i++)
                {
                    for (int j = 1; j < max; j++)
                    {
                        string s = $"{i} + {j} = _____";
                        allAddition.Add(s);
                    }
                }
                return allAddition;
            }

            List<string> CreateMulti(List<string> ignore)
            {
                List<string> allMulti = new List<string>();
                for (int j = 1; j <= 10; j++)
                {
                    if (ignore.Any(x => x == j.ToString())) continue;

                    for (int i = 1; i <= 10; i++)
                    {
                        if (ignore.Any(x => x == i.ToString())) continue;

                        string s = $"{i} x {j} = _____";
                        allMulti.Add(s);
                    }
                }

                return allMulti;
            }

            List<string> CreateDivision(List<string> ignore)
            {
                List<string> allMulti = new List<string>();
                for (int j = 1; j <= 10; j++)
                {
                    if (ignore.Any(x => x == j.ToString())) continue;
                    for (int i = 1; i <= 10; i++)
                    {
                        if (ignore.Any(x => x == i.ToString())) continue;

                        int result = i * j;
                        string s = $"{result} / {i} = _____";
                        allMulti.Add(s);
                    }
                }

                return allMulti;
            }
        }
    }
}
