using System;

//
// THIS SAMPLE CODE IS INCORRECT.
// DO NOT USE IT IN PRODUCTION.
//
static bool ContainsHtmlSensitiveCharacters(string input)
{
    if (input.IndexOf("<") >= 0) { return true; }
    if (input.IndexOf("&") >= 0) { return true; }
    return false;
}

//
// Corrected version using ordinal comparison
//
static bool ContainsHtmlSensitiveCharactersCorrect(string input)
{
    if (input.IndexOf("<", StringComparison.Ordinal) >= 0) { return true; }
    if (input.IndexOf("&", StringComparison.Ordinal) >= 0) { return true; }
    return false;
}

// Test the functions
string testInput = "Hello <world>";
Console.WriteLine($"Incorrect version: {ContainsHtmlSensitiveCharacters(testInput)}");
Console.WriteLine($"Correct version: {ContainsHtmlSensitiveCharactersCorrect(testInput)}");
