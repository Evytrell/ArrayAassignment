namespace ArrayAassignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,,] threeDimArray = new int[3, 2, 2]
            {
                { {3, 2 }, {4, 3 } },
                { {3, 2 }, {4, 3 } },
                { {3, 2 }, {4, 3 } },
            };

            int[,,] threeDimArray2 = new int[3, 2, 2]
              {
                { {3, 2 }, {4, 3 } },
                { {3, 2 }, {4, 3 } },
                { {3, 2 }, {4, 3 } },
            };

            int[,,] result = new int[3, 2, 2];


            for (int a = 0; a < threeDimArray.GetLength(0); a++)
            {
                for (int b = 0; b < threeDimArray.GetLength(1); b++)
                {
                    for (int c = 0; c < threeDimArray.GetLength(2); c++)
                    {
                        result[a, b, c] += threeDimArray[a, b, c] * threeDimArray2[a, b, c];
                        Console.WriteLine(result[a,b,c]);
                   
                    }
                }

            }
       
        }
    }
}