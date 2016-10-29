Imports System.Text.RegularExpressions

''' <summary>
''' The main module of the project.
''' </summary>
Module Program

    ''' <summary>
    ''' The entry point to the program.
    ''' </summary>
    Sub Main()
        Do
            Dim input As String

            Do
                Console.Write("Enter a notation record: ")
                input = Console.ReadLine()
            Loop Until IsNotation(input)

            If (Calulate(input)) Then
                Console.WriteLine($"{True}.")
            Else
                Console.WriteLine($"{False}.")
            End If

            Console.WriteLine("Press any key to continue or Escape to exit.")
        Loop While (Console.ReadKey(True).Key <> ConsoleKey.Escape)
    End Sub

    ''' <summary>
    ''' Calculates the result.
    ''' </summary>
    Private Function Calulate(data As String) As Boolean
        data = data.Replace("A", 1)
        data = data.Replace("B", 2)
        data = data.Replace("C", 3)
        data = data.Replace("D", 4)
        data = data.Replace("E", 5)
        data = data.Replace("F", 6)
        data = data.Replace("G", 7)
        data = data.Replace("H", 8)

        data = data.Replace("a", 1)
        data = data.Replace("b", 2)
        data = data.Replace("c", 3)
        data = data.Replace("d", 4)
        data = data.Replace("e", 5)
        data = data.Replace("f", 6)
        data = data.Replace("g", 7)
        data = data.Replace("h", 8)

        data = data.Remove(2, 1)

        Dim number As Byte = Math.Max(Convert.ToByte(data(0)), Convert.ToByte(data(2))) - Math.Min(Convert.ToByte(data(0)), Convert.ToByte(data(2)))
        number += Math.Max(Convert.ToByte(data(1)), Convert.ToByte(data(3))) - Math.Min(Convert.ToByte(data(1)), Convert.ToByte(data(3)))

        Return number = 3
    End Function

    ''' <summary>
    ''' Checks a letter of the field to the basis A-H.
    ''' </summary>
    ''' <param name="letter">A letter.</param>
    ''' <returns>Boolean value.</returns>
    Private Function IsBasisLetter(letter As Char) As Boolean
        Return Regex.IsMatch(letter, "[A-H]") OrElse Regex.IsMatch(letter, "[a-h]")
    End Function

    ''' <summary>
    ''' Checks a digit of the field to the basis 1-8.
    ''' </summary>
    ''' <param name="digit">A digit.</param>
    ''' <returns>Boolean value.</returns>
    Private Function IsBasisDigit(digit As Char) As Boolean
        Return Regex.IsMatch(digit, "[1-8]")
    End Function

    ''' <summary>
    ''' Checks notation criteries for a string.
    ''' </summary>
    ''' <param name="data">A string.</param>
    ''' <returns>Boolean value.</returns>
    Private Function IsNotation(data As String) As Boolean
        Return data.Length = 5 AndAlso IsBasisLetter(data(0)) AndAlso IsBasisDigit(data(1)) AndAlso data(2) = "-" AndAlso IsBasisLetter(data(3)) AndAlso IsBasisDigit(data(4))
    End Function

End Module
