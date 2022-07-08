// See https://aka.ms/new-console-template for more information


using ColorAndBall;

public class Program
{
    public static void Main(string[] args)
    {
        List<Ball> balls = new List<Ball>();

        balls.Add(new Ball(new Color(0,0,0),5));
        balls.Add(new Ball(new Color(24, 0, 0), 5));
        balls.Add(new Ball(new Color(155, 0, 0), 5));
        balls.Add(new Ball(new Color(200, 0, 0), 5));
        balls.Add(new Ball(new Color(255, 0, 0), 5));

        for (int i = 0; i < balls.Count * 5; i++)
        {
            balls[i %5].Throw();
        }
        for (int i = 0; i < balls.Count; i++)
        {
            Console.Write(balls[i % 5].GetThrown() + " ");
        }
        Console.WriteLine();
        for (int i = 0; i < balls.Count; i++)
        {
            if (i % 2==0)
                balls[i].Pop();
        }
        for (int i = 0; i < balls.Count * 5; i++)
        {
            balls[i % 5].Throw();
        }
        for (int i = 0; i < balls.Count; i++)
        {
            Console.Write(balls[i % 5].GetThrown() + " ");
        }
    }
}