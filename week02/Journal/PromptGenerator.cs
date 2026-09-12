using System;
using System.Collections.Generic;

public class PromptGenerator
{
    private List<string> _prompts = new List<string>
    {
        "What was the best part of your day?",
        "What did you learn today?",
        "What are you thankful for?",
        "What was something difficult today?",
        "What is one goal you have?"
    };

    public string GetRandomPrompt()
    {
        Random random = new Random();
        int number = random.Next(_prompts.Count);

        return _prompts[number];
    }
}