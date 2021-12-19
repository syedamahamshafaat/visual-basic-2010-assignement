Module Module1

    Sub Main()

        Dim Str As String
        Dim str2 As String
        Dim str1 As String
        Dim str3 As String
        Dim finalstr As String
        Str = ""
        Str1 = ""
        Str2 = ""
        Str3 = ""
        finalstr = ""
        Console.Write("Enter string to be processed : ")
        Str = Console.ReadLine
        Str1 = Right(Str, 1)
        If Len(Str) < 3 Then
            Console.WriteLine(Str)
        Else
            If str1 = "g" Then
                finalstr = Str & "ly"
            Else
                finalstr = Str & "ing"
            End If
            Console.WriteLine("Processed String : " & finalstr)
        End If
        Console.ReadKey()
    End Sub

End Module
