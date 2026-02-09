using System;
using System.Globalization;

System.Threading.Thread.CurrentThread.CurrentCulture = new CultureInfo("de");
string text = string.Format("{0:C}", 100);
Console.WriteLine($"Currency formatted: {text}");

// Output on .NET Framework (NLS): "100,00 €"
// Output on .NET (ICU): "100,00 ¤"
