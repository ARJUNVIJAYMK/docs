Imports System

Module Program
    '
    ' THIS SAMPLE CODE IS INCORRECT.
    ' DO NOT USE IT IN PRODUCTION.
    '
    Function ContainsHtmlSensitiveCharacters(input As String) As Boolean
        If input.IndexOf("<") >= 0 Then Return True
        If input.IndexOf("&") >= 0 Then Return True
        Return False
    End Function

    '
    ' Corrected version using ordinal comparison
    '
    Function ContainsHtmlSensitiveCharactersCorrect(input As String) As Boolean
        If input.IndexOf("<", StringComparison.Ordinal) >= 0 Then Return True
        If input.IndexOf("&", StringComparison.Ordinal) >= 0 Then Return True
        Return False
    End Function

    Sub Main()
        ' Test the functions
        Dim testInput As String = "Hello <world>"
        Console.WriteLine($"Incorrect version: {ContainsHtmlSensitiveCharacters(testInput)}")
        Console.WriteLine($"Correct version: {ContainsHtmlSensitiveCharactersCorrect(testInput)}")
    End Sub
End Module
