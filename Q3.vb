Module Module1

    Sub Main()
        Dim str1 As String
        Dim char1 As Char
        Dim char2 As Char
        Dim digitcount As Integer
        Dim alphacount As Integer
        Dim count As Integer
        Dim i As Integer
        i = 0
        str1 = ""
        char1 = ""
        char2 = ""
        digitcount = 0
        alphacount = 0
        count = 0
        Console.Write("enter a string:")
        str1 = Console.ReadLine
        Console.Write(" Enter character to be counted from the string:  ")
        char2 = Console.ReadLine
        char2 = LCase(char2)
        For i = 1 To Len(str1)
            char1 = Mid(str1, i, 1)
            char1 = LCase(char1)
            If char1 >= "a" And char1 <= "z" Then
                alphacount = alphacount + 1
            ElseIf char1 >= "0" And char1 <= "9" Then
                digitcount = digitcount + 1
            End If
            If char1 = char2 Then
                count = count + 1
            End If
        Next

        Console.WriteLine("Total Alphabets are:" & alphacount)
        Console.WriteLine("Total Digits are: " & digitcount)
        Console.WriteLine("Counted characters are:" & count)
        Console.ReadKey()

    End Sub

End Module
