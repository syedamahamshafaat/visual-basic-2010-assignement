Module Module1

    Sub Main()
        Dim Str1 As String
        Dim Char1 As Char
        Dim i As Integer
        Dim Char2 As Char
        Dim Char3 As Char
        Str1 = " "
        Char1 = " "
        Char2 = " "
        Char3 = " "
        i = 0
        Console.Write("Enter a string")
        Str1 = Console.ReadLine
        Console.Write("Enter character to be replaced in the string")
        Char1 = Console.ReadLine
        Console.Write("Enter character to replace with in the string")
        Char2 = Console.ReadLine

        For i = 1 To Len(Str1)
            Char1 = Mid(Str1, i, 1)
            Char2 = mid(str1, i + 1, 2)
            While char2 = char3
                char3 = char2
                char2 = char1
                char1 = char3
            End While
        Next i
        console.writeline("characters have been replaced")
        console.readkey()
    End Sub

End Module





      