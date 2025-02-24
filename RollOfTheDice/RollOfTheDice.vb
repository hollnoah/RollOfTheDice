'Noah Holloway
'RCET 2265
'Spring 2025
'Roll Of The Dice
Option Strict On
Option Explicit On
Option Compare Text
Module RollOfTheDice

    Sub Main()
        Dim result As String

        Console.WriteLine("Roll those dice baby!")

        For i = 1 To 1000


            Console.WriteLine(RandomNumberBetween(2, 12))
        Next

        For i = 1 To 10

            For j = 1 To 10
                result = (i + j).ToString()
                result = result.PadLeft(8)
                Console.Write(result & "|")

                'Console.Write(CStr(i + j).PadLeft(4) & " |")

            Next

            Console.WriteLine()
        Next


    End Sub
    Function RandomNumberBetween(min As Integer, max As Integer) As Integer
        Dim temp As Single 'assigns temp as a single point number (decimal percentage)
        Randomize() 'gives different random numbers each time the program is run
        temp = Rnd() 'makes the single point number random
        temp *= max - min 'displays a random number through max-min (9-3= random number from 0 to 6)
        temp += min 'shifts the minimum up so your random numbers range from min to max
        Return CInt(temp) 'changes the temp from a signle point number to an inte
    End Function

End Module
