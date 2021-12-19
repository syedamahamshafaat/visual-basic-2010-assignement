Module Module1

    Sub Main()
        Dim c As Integer
        Dim str1 As String
        Dim char1 As Char
        Dim char2 As Char
        Dim i As Integer
        Dim Char3 As Char
        Dim j As Integer
        Dim max As Integer
        max = 0
        c = 0
        i = 0
        j = 0
        str1 = ""
        char1 = ""
        char2 = ""
        Char3 = ""
        Console.Write("enter a string")
        str1 = Console.ReadLine
        For i = 1 To Len(str1)
            c = 0
            char1 = Mid(str1, i, 1)
            For j = 1 To Len(str1)
                char2 = Mid(str1, j, 1)
                If char2 = char1 Then
                    c = c + 1
                End If
            Next j
            If c > max Then
                max = c
                Char3 = char1
            End If
        Next
        Console.WriteLine("the character that is repeated the most is:" & Char3)
        Console.WriteLine("the number of of times it is repeated is:" & max)
        Console.ReadKey()
    End Sub

End Module
