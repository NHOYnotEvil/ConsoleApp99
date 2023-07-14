namespace ConsoleApp99
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string bracketExpression;
            int currentDepthExpression = 0;
            int maxDepthExpression = 0;
            char bracketLeft = '(';
            char bracketRight = ')';

            Console.Write("Введите скобочное выражение: ");
            bracketExpression = Console.ReadLine();

            for (int i = 0; i < bracketExpression.Length; i++)
            {
                if (bracketExpression[i] == bracketLeft)
                {
                    currentDepthExpression++;
                }
                else if (bracketExpression[i] == bracketRight)
                {
                    currentDepthExpression--;
                }

                if (maxDepthExpression < currentDepthExpression)
                {
                    maxDepthExpression = currentDepthExpression;
                }

                if (currentDepthExpression < 0)
                {
                    break;
                }

                Console.WriteLine("Ваша текущая глубина - " + currentDepthExpression);
                Console.WriteLine("Ваша максимальная глубина - " + maxDepthExpression);
            }

            if (currentDepthExpression == 0)
            {
                Console.WriteLine("Выражение верное.");
            }
            else if (currentDepthExpression > 0 || currentDepthExpression < 0)
            {
                Console.WriteLine("Выражение не верное.");
            }
        }
    }
}