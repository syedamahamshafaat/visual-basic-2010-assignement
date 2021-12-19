Module Module1

    Sub Main()
        Dim Count As Integer
        Dim i As Integer
        i = 0
        Count = 0
        Console.Write("Enter number of donuts:")
        Count = Console.ReadLine
        If Count > 10 Or Count = 10 Then
            Console.Write("Number of donuts is many")
        Else

            Console.Write("Number of donuts is" & Count)
        End If

        Console.ReadKey()
    End Sub

End Module
