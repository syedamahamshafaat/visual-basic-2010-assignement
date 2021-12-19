Module Module1

    Sub Main()
        Dim str1 As String
        Dim char1 As Char
        Dim i As Integer
        Dim Alphabets As Boolean
        Alphabets = False
        str1 = ""
        char1 = ""
        i = 0
        console.write("Enter a string")
        st1 = console.Readline
        For i = 1 To len(str1)
            char1 = mid(str1, i, 1)
            char1 = lcase(char1)
            If char1 >= "a" Or char1 <= "z" Then
                Alphabets = True
            Else
                Alphabets = False

            End If
        Next
        If alphabets = True Then

            Console.WriteLine("All characters are alphabets")
        Else
            Console.WriteLine("All characters are not alphabets")
        End If
        Console.ReadKey()
    End Sub

End Module
