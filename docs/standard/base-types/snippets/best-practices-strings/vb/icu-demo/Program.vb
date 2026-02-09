Imports System
Imports System.Globalization

Module Program
    Sub Main()
        System.Threading.Thread.CurrentThread.CurrentCulture = New CultureInfo("de")
        Dim text As String = String.Format("{0:C}", 100)
        Console.WriteLine($"Currency formatted: {text}")

        ' Output on .NET Framework (NLS): "100,00 €"
        ' Output on .NET (ICU): "100,00 ¤"
    End Sub
End Module
