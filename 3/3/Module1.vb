Imports System.IO

Module Module1

    Sub Main()
        Dim fileToRead As New StreamReader("C:\Users\heetv\Desktop\AoC\3\data.txt")
        Dim tempLineData(4) As String
        Dim alphabet As String = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ"
        Dim total As Integer = 0

        Do
            tempLineData(0) = fileToRead.ReadLine
            tempLineData(1) = fileToRead.ReadLine
            tempLineData(2) = fileToRead.ReadLine
            'tempLineData(1) = tempLineData(0).Substring(0, tempLineData(0).Length / 2)
            'tempLineData(2) = tempLineData(0).Substring(tempLineData(0).Length / 2, tempLineData(0).Length / 2)

            Console.WriteLine(tempLineData(0))
            Console.WriteLine(tempLineData(1))
            Console.WriteLine(tempLineData(2))

            For i = 0 To tempLineData(0).Length - 1
                For j = 0 To tempLineData(1).Length - 1
                    For k = 0 To tempLineData(2).Length - 1
                        If tempLineData(0)(i) = tempLineData(1)(j) And tempLineData(1)(j) = tempLineData(2)(k) Then
                            tempLineData(4) = tempLineData(1)(j)
                            Exit For
                        End If
                    Next
                Next
            Next

            'Console.WriteLine(tempLineData(4))

            total += alphabet.IndexOf(tempLineData(4)) + 1
        Loop Until fileToRead.EndOfStream

        Console.WriteLine(total)

        Console.ReadLine()
    End Sub

End Module
