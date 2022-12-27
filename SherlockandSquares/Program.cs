namespace SherlockandSquares
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("araligi mueyyen edin:");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            int r, c, sum = 0;
            
            if (a > b) 
            { 
                r = a;
                a = b;
                b = r;
            }
            for (int i = 1; i > 0; i++)
            {
                c = (int)Math.Pow(i, 2);
                if (c >= a && c <= b)
                {
                    sum++;
                }
                else if (c >= b) break; 

            }
            Console.WriteLine(sum);
        }
    }
}