'Noah Holloway
'RCET 2265
'Spring 2025
'Roll Of The Dice
Option Strict On
Option Explicit On
Option Compare Text
Module RollOfTheDice
    Sub Main()
        Dim rollCounts(11) As Integer 'index is 0-11. 0=2, 1=3, and so on
        Dim rand As New Random()

        For i As Integer = 1 To 1000
            Dim die1 As Integer = RandomNumberBetween(1, 6)
            Dim die2 As Integer = RandomNumberBetween(1, 6)
            Dim sum As Integer = die1 + die2
            rollCounts(sum - 2) += 1 'shifts the count to the correct index (*see line 10 comment)
        Next


        Console.WriteLine("Roll Results")
        Console.WriteLine("--------------------------------------------------")
        Console.Write("Dice Value:     ")
        For i As Integer = 2 To 12
            Console.Write(i.ToString().PadLeft(4) & " ")
        Next
        Console.WriteLine()
        Console.Write("Times Rolled:   ")
        For i As Integer = 0 To 10
            Console.Write(rollCounts(i).ToString().PadLeft(4) & " ")
        Next
        Console.WriteLine()
        Console.WriteLine("--------------------------------------------------")


        Dim maxIndex As Integer = Array.IndexOf(rollCounts, rollCounts.Max()) + 2
        Select Case maxIndex
            Case 2
                Console.WriteLine("The most frequent roll was 2!")
            Case 3
                Console.WriteLine("The most frequent roll was 3!")
            Case 4
                Console.WriteLine("The most frequent roll was 4!")
            Case 5
                Console.WriteLine("The most frequent roll was 5!")
            Case 6
                Console.WriteLine("The most frequent roll was 6!")
            Case 7
                Console.WriteLine("The most frequent roll was 7!")
            Case 8
                Console.WriteLine("The most frequent roll was 8!")
            Case 9
                Console.WriteLine("The most frequent roll was 9!")
            Case 10
                Console.WriteLine("The most frequent roll was 10!")
            Case 11
                Console.WriteLine("The most frequent roll was 11!")
            Case 12
                Console.WriteLine("The most frequent roll was 12!")
        End Select
    End Sub

    Function RandomNumberBetween(min As Integer, max As Integer) As Integer
        Dim temp As Single 'assigns temp as a single point number (decimal percentage)
        Randomize() 'gives different random numbers each time the program is run
        temp = Rnd() 'makes the single point number random
        temp *= max - min 'displays a random number through max-min (6-1= random number from 0 to 5)
        temp += min 'shifts the minimum up so your random numbers range from min to max
        Return CInt(temp) 'changes the temp from a single point number to an integer
    End Function

End Module

