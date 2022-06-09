// See https://aka.ms/new-console-template for more informatio

class Program
{
    static void Main(string[] args)
    {
      //  Console.WriteLine("Hello, what is your name?");
      //  var userName = Console.ReadLine();

      //  Console.WriteLine($"Hello {userName}, what is your favorite subject?");

      //  var subject = Console.ReadLine();

      //  switch (subject)
      //  {
      //      case "History":
      //          Console.WriteLine("Wow History is my favorite subject to!");
      //          break;

      //      case "Math":
      //          Console.WriteLine("Math is very hard, I am surprised its your favorite subject since you are human");
      //          break;

      //      case "Science":
      //          Console.WriteLine("My uncle likes Science as well, lets do experiments!!");
      //          break;

      //      case "English":
      //          Console.WriteLine("I dont like English, but I am happy you do");
      //          break;

      //      case "Chemistry":
      //          Console.WriteLine("Chemistry is fun, lets make a valcano");
      //          break;

      //      default:
      //          Console.WriteLine($"I have never heard of that subject before, {subject} sounds neat!");
      //          break;







      //  }








      //  var favoriteNumber = 200;

      //  var userGuess = int.Parse(Console.ReadLine());

      //  if (userGuess < favoriteNumber)
      //  {
      //      Console.WriteLine("to low");

      //  }
      //  else if (userGuess > favoriteNumber)
      //  {
      //      Console.WriteLine("to high");
      //  }

      //  else
      //  {
      //      Console.WriteLine("you got it");
      //  }


      //  int a = 5;
      //  a++;
      //  int b = a;
      //  b++;
      //  int c = b;

      //  Console.WriteLine($"{c}");
      //  Console.WriteLine($"{c}");

      // int e = 17;
      // int f = 4;
      // int g = e / f;
      //  var remainder = e % f; 

      //  Console.WriteLine($" {e}/ {f} equals {g}, with a remainder of {remainder}");
      //  int i = int.Parse(Console.ReadLine());
      //  var positiveMessage = (i > 0) ? "you are postive!" : "you are not positve";

      //  Console.WriteLine($"{positiveMessage}");

      //  int h = 1;
      //  int j = 3; 

      //  if (h <=1 && j <=2)
      //  {
      //      Console.WriteLine("Hello");
      //  }
      //  else if (j <=3 && h >= 2)
      //  {
      //      Console.WriteLine("Goodbye");
      //  }
      //  else
      //  {
      //      Console.WriteLine("poop");
      //  }
      //  int k = 5;
      //  int l = 6;


      //Console.WriteLine( k += l);


      //  FavoriteSubject();
      //  IsnumberOdd(11);


      //  Console.WriteLine("true or false the state capitol of Califronia is Sacramento?");

      //  var stateCapitol = Console.ReadLine();

      //  switch (stateCapitol)
      //  {
      //      case "true":
      //          Console.WriteLine("Correct");
      //          break;
      //      case "false":
      //          Console.WriteLine("you got it wrong dummy!");
      //          break;

                    
      //  }
      //  var z = int.Parse(Console.ReadLine());

        string teacher;
       int w;
        w = 5;

        Console.WriteLine($"{w}");

        double milesRanToday = 0;
        Console.WriteLine($"How many miles did you run today?");

        var response=Console.ReadLine();

        bool isParsable=double.TryParse(response, out milesRanToday);
        
        if (isParsable==true)
        {
            Console.WriteLine($" you ran {milesRanToday}");

        }
        else
        {
            Console.WriteLine("Please type a number next time.");
        }
      var answer = (isParsable == true) ? $"You ran {milesRanToday} " : "Plese type a number next time";
    
      Console.WriteLine(answer);
    }






  public static void IsnumberOdd(int number)
    {
       Console.WriteLine("Give me a number and i will tell if its even or odd");
        number = int.Parse(Console.ReadLine());
        if (number%2 != 0)
        {
           
          Console.WriteLine("the number is odd");
        }
        else
        {
            Console.WriteLine("the number is even");
        }
        
       
    }

    public static void FavoriteSubject()
    {
        Console.WriteLine("Hello, what is your name?");
        var userName = Console.ReadLine();

        Console.WriteLine($"Hello {userName}, what is your favorite subject?");

        var subject = Console.ReadLine();

        switch (subject)
        {
            case "History":
                Console.WriteLine("Wow History is my favorite subject to!");
                break;

            case "Math":
                Console.WriteLine("Math is very hard, I am surprised its your favorite subject since you are human");
                break;

            case "Science":
                Console.WriteLine("My uncle likes Science as well, lets do experiments!!");
                break;

            case "English":
                Console.WriteLine("I dont like English, but I am happy you do");
                break;

            case "Chemistry":
                Console.WriteLine("Chemistry is fun, lets make a valcano");
                break;

            default:
                Console.WriteLine($"I have never heard of that subject before, {subject} sounds neat!");
                break;

        }
    }


}



