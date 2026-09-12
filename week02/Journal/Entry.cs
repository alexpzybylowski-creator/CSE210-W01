using System;

public class Entry
{
    private string _date;
    private string _prompt;
    private string _text;

    public Entry(string date, string prompt, string text)
    {
        _date = date;
        _prompt = prompt;
        _text = text;
    }

    public void Display()
    {
        Console.WriteLine($"{_date} - {_prompt}");
        Console.WriteLine(_text);
        Console.WriteLine();
    }

    public string GetFileText()
    {
        return $"{_date}|{_prompt}|{_text}";
    }
}