using System;
using System.Collections.Generic;
using System.Linq;

//Console.Clear();
//Console.Write("Who would you like to say hello to? ");

//string name = Console.ReadLine();

//if (string.IsNullOrWhiteSpace(name))
//{
//    Console.WriteLine("Fine, don't say 'hello'!");
//}
//else
//{
//    Console.WriteLine($"Hello, {name}!");
//}

////JavaScript compard to CSHARP examples

////const theAnswer = 42;
//int theAnswer = 42;

////const olympicScore = 9.1;
//double olympicScore = 9.1;

////const isFunny = True
//bool isFunny = true;

////const insult = "You are unpleasant"
//string insult = "You are unpleasent";

////const aDate = new Date(1989, 6, 2);
////DateTime aDate = newDateTime(1989, 7, 2);

//// const activities = ["bowling", "jumping up on th bed", "sword swallowing"];

//List<string> activities = new List<string>()
//{
//    "bowling", "jumping on the bed", "sword swallowing"
//};

////if statement
///*** 
// * numHats = 50; 
// * if (numHats > 10) {
// * console.log("Why do we have so many hats?");
// * }
// * else if (numHats <= 10 && numHats >=2) {
// * console.log("You have a reasonable number of hats.");
// * }
// * else{
// * console.log("You need more hats?");
// * }
// ***/

//Console.Write($"{name},  How many hats do you have? ");
//int numHats = Int32.Parse(Console.ReadLine());

//if  (numHats > 10)
//{
//    Console.WriteLine($"{name} You have to many hats!");
//}
//else if (numHats <= 10 && numHats >=2)
//{
//    Console.WriteLine($"{name} You have a reasonable amount of hats!");
//}
//else
//{
//    Console.WriteLine($"{name} You need more hats hats!");
//}


//Console.Write($"{name},  What is your favorite number? ");
//int favNum = Int32.Parse(Console.ReadLine());
//for (int i = 0; i <= favNum; i++)
//{
//    Console.WriteLine($"The number is {i}");
//}

List<int> numbers = new List<int>() { 100, 32, 98, 4, 1, 22, 73, 8 };

//foreach (int num in numbers)
//{
//    Console.WriteLine(num);
//}

List<int> small = numbers.Where(n => n<10).ToList();
//foreach (int num in small)
//{
//    Console.WriteLine(num);
//}

Console.WriteLine("Even Numbers");
List<int> even = numbers.Where(n => n % 2 == 0).ToList();
//foreach (int num in even)
//{
//    Console.WriteLine(num);
//}

List<string> words = new List<string>() { "do", "you", "understand", "the", "words", "coming", "out", "of", "my", "mouth?" };
List <string> yelling = words.Select(w => w.ToUpper()).ToList();
string sentence = string.Join(" ", yelling);
foreach (string word in words)
{
    Console.WriteLine(word);
}
Console.WriteLine(sentence);
