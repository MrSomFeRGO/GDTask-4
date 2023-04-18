Console.WriteLine(shifr("test", 1700));

static string shifr(string toShifr, int i)
{
    string result = "";
    foreach (var element in toShifr)
    {
        int el_char = (int)element + i;
        el_char = recursiya22(el_char);

        result += (char)el_char;
    }

    return result;
}

static int recursiya22(int i)
{
    if (i > 255)
    {
        i -= 255;
    }

    if (i > 255)
    {
        return recursiya22(i);
    }

    return i;
}