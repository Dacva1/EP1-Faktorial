Imports System

Module Program
  Sub Main(args As String())
        Dim vstup As String
        Dim soucet As Integer = 0
        Dim cislo As Integer

        Console.WriteLine("Zadej èíslo: ")
        vstup = Console.ReadLine


        If Integer.TryParse(vstup, cislo) Then
            For i = 1 To cislo
                soucet = soucet + i
            Next
            Console.WriteLine($"Souèet od 1 do {cislo} je {soucet}")
        Else
            Console.WriteLine("Chyba musíte zadat jen celé èísla")
        End If


    End Sub
End Module
