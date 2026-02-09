Imports System
Imports System.Globalization

Module Program
    Sub Main()
        ' Demonstrate Unicode normalization with résumé
        Console.WriteLine("=== Unicode Normalization Example ===")
        Console.WriteLine("resume".IndexOf("e", StringComparison.Ordinal)) ' prints '1'
        Console.WriteLine("r" & ChrW(&HE9) & "sum" & ChrW(&HE9)).IndexOf("e", StringComparison.Ordinal) ' prints '-1'
        Console.WriteLine(("r" & ChrW(&HE9) & "sume" & ChrW(&H301)).IndexOf("e", StringComparison.Ordinal)) ' prints '5'
        Console.WriteLine(("re" & ChrW(&H301) & "sum" & ChrW(&HE9)).IndexOf("e", StringComparison.Ordinal)) ' prints '1'
        Console.WriteLine(("re" & ChrW(&H301) & "sume" & ChrW(&H301)).IndexOf("e", StringComparison.Ordinal)) ' prints '1'

        ' Linguistic comparison
        Console.WriteLine(vbCrLf & "=== Linguistic Comparison Example ===")
        Console.WriteLine(("r" & ChrW(&HE9) & "sum" & ChrW(&HE9)).IndexOf("e")) ' prints '-1' (not found)
        Console.WriteLine(("r" & ChrW(&HE9) & "sum" & ChrW(&HE9)).IndexOf(ChrW(&HE9))) ' prints '1'
        Console.WriteLine(ChrW(&HE9).IndexOf("e" & ChrW(&H301))) ' prints '0'

        ' Hungarian culture-aware comparison
        Console.WriteLine(vbCrLf & "=== Hungarian Culture-Aware Example ===")
        CultureInfo.CurrentCulture = CultureInfo.GetCultureInfo("hu-HU")
        Console.WriteLine("endz".EndsWith("z")) ' Prints 'False'

        CultureInfo.CurrentCulture = CultureInfo.InvariantCulture
        Console.WriteLine("endz".EndsWith("z")) ' Prints 'True'
    End Sub
End Module
