namespace SyntaxAndSyntaxSugarExercise
{
    public class Program
    {
       static void Main(string[] args)
        {
            //inferred Typing
            var answer = 4;
            string response;

            Console.WriteLine(answer < 9 ? $"{answer} is less than nine" : $"{answer} is granter than or equal to nine");
            
                
            // if (answer > 9)
            // {
            //    response = answer + "is less than Nine";
            //  }
            //  else
            // {
            //     Console.WriteLine(response = answer + "is greater than or equal to nine");
            //  }

        }
    }
}
