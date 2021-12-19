Module Module1

    Sub Main()
        Dim str1 As String
        Dim str2 As String
        Dim char1 As Char
        Dim char2 As Char
        Dim i As Integer
        Dim char3 As Char
        Dim finalstr As String
        str1 = ""
        str2 = ""
        char1 = ""
        char2 = ""
        char3 = "*"
        finalstr = ""
        i = 0
        Console.Write("enter a string to process:")
        str1 = Console.ReadLine
        str1 = LCase(str1)
        char1 = Left(str1, 1)
        str2 = Right(str1, Len(str1) - 1)
        For i = 1 To Len(str2)
            char2 = Mid(str2, i, 1)
            If char2 = char1 Then
                finalstr = finalstr & char3
            Else
                finalstr = finalstr & char2
            End If
        Next
        Console.WriteLine("the processed string is:" & char1 & finalstr)
        Console.ReadKey()

    End Sub

End Module
