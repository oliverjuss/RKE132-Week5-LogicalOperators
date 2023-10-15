// Math >= 90; Biology >= 90, chemistry >= 90;

int math, biology, chemistry;

Console.WriteLine("Enter your math test score: ");
math = Int32.Parse(Console.ReadLine());
Console.WriteLine("Enter your biology test score: ");
biology = Int32.Parse(Console.ReadLine());
Console.WriteLine("Enter your chemistry test score: ");
chemistry = Int32.Parse(Console.ReadLine());

if (math >= 90 && biology >= 90 && chemistry >= 90)
{
    Console.WriteLine("Congratulations! You are accapted to your school");
}
else
{
    Console.WriteLine("You are not accapted to our school");
}