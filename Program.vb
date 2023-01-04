Imports System

Module onehundred_year_calculator
    Sub Main()
        Dim age, birthyear, year As Integer
        Dim name As String
        Console.WriteLine("Please enter the year of your birth")
        birthyear = Console.ReadLine()
        Console.WriteLine("Please enter your age")
        age = Console.ReadLine()
        Console.WriteLine("Please enter your name")
        name = Console.ReadLine()
        year = birthyear + 100
        Console.WriteLine(name & " you are " & age & ". You will be 100 in the year " & year)
    End Sub
End Module
