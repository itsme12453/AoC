Imports System.IO

Module Module1

    Sub Main()
        'Part One

        Dim encryptedInput As New StreamReader("C:\Users\heetv\Desktop\AoC\2\encryptedInput.txt")
        Dim encryptedResults As New Dictionary(Of String, String) From {{"A", "rock"}, {"B", "paper"}, {"C", "scissor"}, {"X", "rock"}, {"Y", "paper"}, {"Z", "scissor"}}
        Dim score As Integer = 0
        Dim tempLine As String

        'encryputedInput = encryputedInput.Replace(" ", "")

        Do
            tempLine = encryptedInput.ReadLine.Replace(" ", "")
            'Console.WriteLine(encryptedResults(tempLine(0)))
            'Console.WriteLine(encryptedResults(tempLine(1)))
            'Console.WriteLine(tempLine(1))

            'score += points(encryptedResults(tempLine(0)), encryptedResults(tempLine(1)))
            score += points(encryptedResults(tempLine(0)), tempLine(1))

            'Console.WriteLine(score)
        Loop Until encryptedInput.EndOfStream

        encryptedInput.Close()

        Console.WriteLine(score)

        Console.ReadLine()
    End Sub

    'Function points(opponent, userInput)
    'Part ONE Function
    '    Dim point As New Dictionary(Of String, Integer) From {{"rock", 1}, {"paper", 2}, {"scissor", 3}}

    '    If opponent = userInput Then
    '        Return point(userInput) + 3
    '    ElseIf userInput = "rock" Then
    '        If opponent = "scissor" Then
    '            Return point(userInput) + 6
    '        Else
    '            Return point(userInput)
    '        End If
    '    ElseIf userInput = "scissor" Then
    '        If opponent = "paper" Then
    '            Return point(userInput) + 6
    '        Else
    '            Return point(userInput)
    '        End If
    '    ElseIf userInput = "paper" Then
    '        If opponent = "rock" Then
    '            Return point(userInput) + 6
    '        Else
    '            Return point(userInput)
    '        End If
    '    End If

    'return 0
    'End Function

    Function points(opponent, userInput)
        'Part Two Function
        Dim point As New Dictionary(Of String, Integer) From {{"X", 0}, {"Y", 3}, {"Z", 6}}
        Dim pointWord As New Dictionary(Of String, Integer) From {{"rock", 1}, {"paper", 2}, {"scissor", 3}}

        Console.WriteLine(opponent & userInput)

        If opponent = "rock" Then
            If userInput = "X" Then
                Return point(userInput) + pointWord("scissor")
            ElseIf userInput = "Y" Then
                Return point(userInput) + pointWord("rock")
            Else
                Return point(userInput) + pointWord("paper")
            End If
        ElseIf opponent = "paper" Then
            If userInput = "X" Then
                Return point(userInput) + pointWord("rock")
            ElseIf userInput = "Y" Then
                Return point(userInput) + pointWord("paper")
            Else
                Return point(userInput) + pointWord("scissor")
            End If
        ElseIf opponent = "scissor" Then
            If userInput = "X" Then
                Return point(userInput) + pointWord("paper")
            ElseIf userInput = "Y" Then
                Return point(userInput) + pointWord("scissor")
            Else
                Return point(userInput) + pointWord("rock")
            End If
        End If

        Return 0
    End Function

End Module
