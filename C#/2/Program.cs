namespace _2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //part 1
            float score1 = 90;
            float score2 = 100;
            float score3 = 65;
            float score4 = 75;
            float score5 = 86;
            float scoreAvg = (score1 + score2 + score3 + score4 + score5) / 5;
            Console.WriteLine(scoreAvg);

            //part 2
            int non_dec_score = (int)scoreAvg;
            Console.WriteLine(non_dec_score);

            //part 3
            char letter = 'l';
            int uppercaseMaker = (letter - 32);
            Console.WriteLine((char)uppercaseMaker);

            //part 4
            int x = 10;
            Console.WriteLine(x--);
            Console.WriteLine(--x);
        }
    }
}