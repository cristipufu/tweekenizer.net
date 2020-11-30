# Tweekenizer

Tokenizer for social media posts and comments. It categorizes tokens into words, hashtags, mentions, urls, emails, time, numbers, emojis, emoticons using a set of regular expressions (that can be overwritten or extended).

Supports multiple languages.

[![NuGet](https://img.shields.io/nuget/v/Tweekenizer.svg)](https://www.nuget.org/packages/Tweekenizer/) 

## Installation:

> Install-Package Tweekenizer

## Getting started
```C#
// Tokenize a tweet.
var tweet = @"@MrRobot: you can contact me @ tweekenizer@gmail.com, 2 of us plan party 🎉 @MrsRobot at 3pm:) #vodka";
var tokenizer = new Tokenizer();
tokenizer.Tokenize(tweet);
//tokenizer.ToString():
//Token { Value = tweekenizer@gmail.com, Category = email }
//Token { Value = @MrRobot, Category = mention }
//Token { Value = you, Category = word }
//Token { Value = can, Category = word }
//Token { Value = contact, Category = word }
//Token { Value = me, Category = word }
//Token { Value = :, Category = punctuation }
//Token { Value = @, Category = symbol }
//Token { Value = @MrsRobot, Category = mention }
//Token { Value = 🎉, Category = emoji }
//Token { Value = 2, Category = number }
//Token { Value = ,, Category = punctuation }
//Token { Value = of, Category = word }
//Token { Value = us, Category = word }
//Token { Value = plan, Category = word }
//Token { Value = party, Category = word }
//Token { Value = #vodka, Category = hashtag }
//Token { Value = :), Category = emoticon }
//Token { Value = 3pm, Category = time }
//Token { Value = at, Category = word }

// Tokenize a French sentence.
var french = @"Je suis désolé:(";
tokenizer.Tokenize(french);
//tokenizer.ToString();
//Token { Value = :(, Category = emoticon }
//Token { Value = e, Category = word }
//Token { Value = suis, Category = word }
//Token { Value = désolé, Category = word }
```

C# port of the [wink-tokenizer](https://github.com/winkjs/wink-tokenizer) js library with a few tweaks
