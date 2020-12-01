using System;

namespace Tweekenizer.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Tweekenizer!");

            var tokenizer = new Tokenizer();

            // Tokenize a tweet.
            var tweet = @"@MrRobot: you can contact me @ tweekenizer@gmail.com, 2 of us plan party 🎉 @MrsRobot at 3pm:) #vodka";
            Console.WriteLine($"\n=>> {tweet}\n");
            var tokens = tokenizer.Tokenize(tweet);
            Console.WriteLine(tokens.ToString());

            // Tokenize a Romanian sentence.
            var romanian = @"S-a suparat pe mine si-a plecat departe, duca-se naiba";
            Console.WriteLine($"\n=>> {romanian}\n");
            tokens = tokenizer.Tokenize(romanian);
            Console.WriteLine(tokens.ToString());

            // Tokenize a French sentence.
            var french = @"Je suis désolé:(";
            Console.WriteLine($"\n=>> {french}\n");
            tokens = tokenizer.Tokenize(french);
            Console.WriteLine(tokens.ToString());

            // Tokenize a sentence containing Hindi and English.
            var hindi = @"द्रविड़ ने टेस्ट में ३६ शतक जमाए, उनमें 21 विदेशी playground पर हैं।";
            Console.WriteLine($"\n=>> {hindi}\n");
            tokens = tokenizer.Tokenize(hindi);
            Console.WriteLine(tokens.ToString());

            var stockwits = @"@chessman1 = 💰💰💰💰cashed out $120k yesterday that doesn’t seem to be hurting my pocket up another 75k today . My April $125/$195 spread is doing well!! $MRNA";
            Console.WriteLine($"\n=>> {stockwits}\n");
            tokens = tokenizer.Tokenize(stockwits);
            Console.WriteLine(tokens.ToString());

            Console.ReadKey();
        }
    }
}
