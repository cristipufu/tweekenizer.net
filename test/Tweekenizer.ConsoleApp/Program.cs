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
            tokenizer.Tokenize(tweet);
            Console.WriteLine(tokenizer.ToString());

            // Tokenize a Romanian sentence.
            var romanian = @"S-a suparat pe mine si-a plecat departe, duca-se naiba";
            Console.WriteLine($"\n=>> {romanian}\n");
            tokenizer.Tokenize(romanian);
            Console.WriteLine(tokenizer.ToString());

            // Tokenize a French sentence.
            var french = @"Je suis désolé:(";
            Console.WriteLine($"\n=>> {french}\n");
            tokenizer.Tokenize(french);
            Console.WriteLine(tokenizer.ToString());

            // Tokenize a sentence containing Hindi and English.
            var hindi = @"द्रविड़ ने टेस्ट में ३६ शतक जमाए, उनमें 21 विदेशी playground पर हैं।";
            Console.WriteLine($"\n=>> {hindi}\n");
            tokenizer.Tokenize(hindi);
            Console.WriteLine(tokenizer.ToString());

            Console.ReadKey();
        }
    }
}
