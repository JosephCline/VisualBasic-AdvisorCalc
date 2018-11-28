Module Module1

    Sub Main()
        Dim iAge As Integer
        Dim sMajor As String
        Dim dGPA As Decimal
        Console.Write("Please enter your age: ")
        iAge = Console.ReadLine

        Console.Write("Please enter your major from the following list: L=Liberal Arts, S=Science, H=Heath Career: ")
        sMajor = Console.ReadLine

        Console.Write("Please enter your GPA: ")
        dGPA = Console.ReadLine
        If (sMajor = "S") And (iAge >= 20) And (dGPA > 3.5) Then
            Console.Write("Set up a meeting with this student!")
            Console.ReadKey()
        End If
    End Sub

End Module
