// See https://aka.ms/new-console-template for more informatio

class Program
{
    static void Main(string[]args)
    {
        Console.WriteLine("Hello, what is your name?");
        var userName= Console.ReadLine();
        
        Console.WriteLine($"Hello {userName}, what is your favorite subject?");

        var subject= Console.ReadLine();

        switch (subject)
        {
            case "History":
                Console.WriteLine("Wow History is my favorite subject to!");
                break;

            case "Math":
                Console.WriteLine("Math is very hard, I am surprised its your favorite subject since you are human");
                break ;

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



