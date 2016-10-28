''' <summary>
''' The main module of the project.
''' </summary>
Module Program

    ''' <summary>
    ''' The entry point to the program.
    ''' </summary>
    Sub Main()
        Do
            Dim a As UInteger

            Do
                Console.Write("Enter A value: ")
            Loop Until (UInteger.TryParse(Console.ReadLine(), a)) And a <> 0 And a <= 4 * Pow(10, 5) And a Mod 5 = 0 And a Mod 10 <> 0

            Console.WriteLine($"The answer: {Pow(a)}")

            Console.WriteLine("Press any key to continue or Escape to exit.")
        Loop While (Console.ReadKey(True).Key <> ConsoleKey.Escape)
    End Sub

    ''' <summary>
    ''' The function to build a number in a degree.
    ''' </summary>
    ''' <param name="a">A number.</param>
    ''' <param name="n">A degree.</param>
    ''' <returns>A number that has been built in a degree.</returns>
    Private Function Pow(a As Byte, n As Byte) As UInteger
        Dim b As UInteger = 1

        For i As Byte = 1 To n
            b *= a
        Next

        Return b
    End Function

    ''' <summary>
    ''' The function to build a number in the two degree. Uses own method.
    ''' </summary>
    ''' <param name="a">A number.</param>
    ''' <returns>A number that has been built in the two degree.</returns>
    Private Function Pow(a As UInteger) As UInteger
        Return (a \ 10) * (a \ 10 + 1) * 100 + 25
    End Function

End Module
