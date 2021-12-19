Module Module1

    Sub Main()

        Dim vowelcount As Integer
        Dim char1 As Char
        Dim str As String
        Dim i As Integer
        vowelcount = 0
        i = 0
        str = ""
        char1 = ""
        Console.Write("enter a string")
        str = Console.ReadLine
        Console.Write("enter character from the string")
        char1 = Console.ReadLine
        For i = 1 To Len(str)
            char1 = Mid(str, i, 1)
            char1 = LCase(char1)
            If char1 = "a" Or char1 = "e" Or char1 = "i" Or char1 = "o" Or char1 = "u" Then
                Console.WriteLine("It's a vowel!")
                vowelcount = vowelcount + 1
            End If
        Next i
        Console.WriteLine("The number of vowels in the string is" & vowelcount)

        Console.ReadKey()
    End Sub

End Module
