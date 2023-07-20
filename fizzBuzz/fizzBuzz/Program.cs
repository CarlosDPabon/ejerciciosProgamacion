for (int i = 1; i <= 100; i++)
{
    string respuesta = string.Empty;
    if (i % 3 == 0 || i % 5 == 0)
    {
        if (i % 3 == 0) respuesta = "Fizz";
        if (i % 5 == 0) respuesta = respuesta + "Buzz";
    }
    else respuesta = i.ToString();
    Console.WriteLine(respuesta);
}

Console.WriteLine("Progama finalizado");