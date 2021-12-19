Module Module1

    Sub Main()
        Dim str1 As String
        Dim str2 As String
        Dim good As String
        Dim finalstr As String
        Dim i As Integer
        Dim char1 As Char
        Dim char2 As Char
        char1 = ""
        char2 = ""
        i = 0
        str1 = ""
        str2 = ""
        good = ""
        finalstr = ""
        Console.Write("enter a string to process:")
        str1 = Console.ReadLine
        str1 = LCase(str1)
        For i = 1 To Len(str1)
            char1 = Mid(str1, i, 3)
            If char1 = "not" Then
                str2 = "not"
            End If
            char2 = Mid(str1, i, Len(str1) - 3)
            If char2 = "bad" Then
                str2 = str2 & "bad"
            End If
            If str2 >= "not" And str2 >= "bad" Then
                str2 = "good"
                finalstr = str1 - 6 & str2
            End If
        Next
        Console.WriteLine("the processed string is:" & finalstr)
        Console.ReadKey()

    End Sub

End Module
