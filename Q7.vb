Module Module1

    Sub Main()
        Dim s As String
        Dim FinalStr As String
        Dim str1 As String
        Dim str2 As String
        str1 = ""
        str2 = ""
        s = ""
        FinalStr = ""
        Console.Write("Enter a string to be processed")
        s = Console.ReadLine
        If Len(s) < 2 Then
            Console.WriteLine("Too short string to be processed")
        Else
            str1 = Left(s, 2)
            str2 = Right(s, 2)
            FinalStr = str1 & str2
            Console.WriteLine("The processed string is" & FinalStr)

        End If
        Console.ReadKey()
    End Sub

End Module
