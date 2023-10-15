// Math >= 90 or Chemistry >= 90 or  

// math && chimistry || math && biology || chemistry && biology

int math, biology, chemistry;

Console.WriteLine("Enter your math test score: ");
math = Int32.Parse(Console.ReadLine());
Console.WriteLine("Enter your biology test score: ");
biology = Int32.Parse(Console.ReadLine());
Console.WriteLine("Enter your chemistry test score: ");
chemistry = Int32.Parse(Console.ReadLine());

if ((math >= 90 && chemistry >= 90) || (math >= 90 && biology >= 90) || (chemistry >= 90 && biology >= 90))
{
    Console.WriteLine("Congratulations! You are accapted to your school");
}
else
{
    Console.WriteLine("You are not accapted to our school");
}