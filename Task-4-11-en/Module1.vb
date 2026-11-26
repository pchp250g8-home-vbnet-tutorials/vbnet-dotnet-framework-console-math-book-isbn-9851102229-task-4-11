Module Module1

    Sub Main()
        ' Percentage Of participants who successfully completed the distance. 
        ' The 1st part of the interval
        Dim i1 As Single = 91.7F
        ' Percentage of participants who successfully completed the distance. 
        ' The 2nd part of the interval
        Dim i2 As Single = 91.8F
        Dim r1 As Single = i1 / 100 ' The 1-st rational fraction
        Dim r2 As Single = i2 / 100 ' The 2-nd rational fraction
        Dim found As Boolean = False ' Flag wich sgnals that solution Is found
        Dim n As UInteger = 0 ' Number Of participants Of the race
        Console.WriteLine("Between 91.7% and 91.8% of participants successfully completed the race.")
        Console.WriteLine("What is the minimum number of participants?")
        Do While (Not found)
            ' Find the smallest integer k that Is strictly greater than the lower bound
            Dim k = Math.Floor(r1 * n) + 1
            ' Check if this k satisfies the upper bound
            If (k < r2 * n) Then
                Console.WriteLine("Minimum number of participants (N):{0}", n)
                found = True
            Else
                n += 1
            End If
        Loop
    End Sub

End Module
