using System;
using System.Collections.Generic;

namespace CreateMathWork
{
    public class MathFactory
    {
        public List<string> GetMathWork(bool isMulti)
        {
            //var alldivision = CreateAddition();
            //var alldivision = CreateDivision();
            var alldivision = isMulti ? CreateMulti() : CreateDivision();

            Random random = new Random();

            List<string> test = new List<string>();

            //int numberOfTests = 10;

            //for (int count = 0; count < numberOfTests; count++)
            {

                for (int i = 0; i < 50; i++)
                {
                    int index = random.Next(alldivision.Count);
                    test.Add(alldivision[index]);
                }

                //string mytest = string.Join(Environment.NewLine, test.ToArray());

                return test;
            }

            List<string> CreateAddition()
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

            List<string> CreateMulti()
            {
                List<string> allMulti = new List<string>();
                for (int j = 1; j <= 10; j++)
                {
                    for (int i = 1; i <= 10; i++)
                    {
                        string s = $"{i} x {j} = _____";
                        allMulti.Add(s);
                    }
                }

                return allMulti;
            }

            List<string> CreateDivision()
            {
                List<string> allMulti = new List<string>();
                for (int j = 1; j <= 10; j++)
                {
                    for (int i = 1; i <= 10; i++)
                    {
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
