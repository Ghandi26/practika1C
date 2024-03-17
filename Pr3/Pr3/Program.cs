using System;


// Завдання 1
/*
class Book
{
    private string title;
    private string authorName;
    private string contentText;
    private bool isAuthorEdited = false;

    public Book(string title, string authorName, string contentText)
    {
        this.title = title;
        this.authorName = authorName;
        this.contentText = contentText;
    }

    public string Title => title;

    public string AuthorName
    {
        get { return authorName; }
        set
        {
            if (!isAuthorEdited)
            {
                Console.WriteLine("Do you want to edit the author? (y/n)");
                string response = Console.ReadLine();
                if (response.ToLower() == "y")
                {
                    authorName = value;
                    isAuthorEdited = true;
                    Console.WriteLine("Author edited successfully.");
                }
                else
                {
                    Console.WriteLine("Author was not edited.");
                }
            }
            else
            {
                Console.WriteLine("Author has already been edited.");
            }
        }
    }

    public string ContentText
    {
        get { return contentText; }
        set { contentText = value; }
    }

    public void Show()
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Book title: " + Title);
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("Author: " + AuthorName);
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Content: " + ContentText);
        Console.ResetColor();
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter book details:");

        Console.Write("Title: ");
        string title = Console.ReadLine();

        Console.Write("Author: ");
        string author = Console.ReadLine();

        Console.Write("Content: ");
        string content = Console.ReadLine();

        Book book = new Book(title, author, content);

        Console.WriteLine("\nCurrent book details:");
        book.Show();

        Console.WriteLine("\nDo you want to edit the author? (y/n)");
        string response = Console.ReadLine();

        if (response.ToLower() == "y")
        {
            Console.Write("Enter new author name: ");
            string newAuthor = Console.ReadLine();
            book.AuthorName = newAuthor;
        }

        Console.WriteLine("\nUpdated book details:");
        book.Show();

        Console.ReadLine();
    }
}

*/

// Завдання 2



public class Figure
{
    private Point[] points;

    public Figure(Point[] points)
    {
        if (points.Length < 3 || points.Length > 5)
        {
            throw new ArgumentException("A figure must have 3 to 5 points.");
        }

        this.points = points;
    }

    private double LengthSide(Point A, Point B)
    {
        return Math.Sqrt(Math.Pow(B.X - A.X, 2) + Math.Pow(B.Y - A.Y, 2));
    }

    public void PerimeterCalculator()
    {
        double perimeter = 0;
        for (int i = 0; i < points.Length; i++)
        {
            Point currentPoint = points[i];
            Point nextPoint = points[(i + 1) % points.Length];
            perimeter += LengthSide(currentPoint, nextPoint);
        }

        string figureName;
        switch (points.Length)
        {
            case 3:
                figureName = "Triangle";
                break;
            case 4:
                figureName = "Square";
                break;
            case 5:
                figureName = "Pentagon";
                break;
            default:
                figureName = "Unknown Figure";
                break;
        }

        Console.WriteLine($"Name: {figureName}");
        Console.WriteLine($"Perimeter: {perimeter}");
    }

    public static Figure InputFigure()
    {
        Console.WriteLine("Enter the number of points (3 to 5):");
        int numPoints = int.Parse(Console.ReadLine());

        if (numPoints < 3 || numPoints > 5)
        {
            Console.WriteLine("Invalid number of points. Exiting program.");
            Environment.Exit(1);
        }

        Point[] points = new Point[numPoints];
        for (int i = 0; i < numPoints; i++)
        {
            points[i] = Point.InputPoint(i + 1);
        }

        return new Figure(points);
    }
}


public class Point
{
    private int x;
    private int y;
    private string label;

    public int X
    {
        get { return x; }
    }

    public int Y
    {
        get { return y; }
    }

    public string Label
    {
        get { return label; }
    }

    public Point(int x, int y, string label)
    {
        this.x = x;
        this.y = y;
        this.label = label;
    }

    public static Point InputPoint(int pointNumber)
    {
        Console.WriteLine($"Enter coordinates for point {pointNumber}:");
        Console.Write("X: ");
        int x = int.Parse(Console.ReadLine());
        Console.Write("Y: ");
        int y = int.Parse(Console.ReadLine());
        Console.Write("Label: ");
        string label = Console.ReadLine();

        return new Point(x, y, label);
    }
}

class Program
{
    static void Main(string[] args)
    {
        Figure figure = Figure.InputFigure();
        figure.PerimeterCalculator();
    }
}