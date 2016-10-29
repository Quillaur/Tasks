''' <summary>
''' The main module of the project.
''' </summary>
Module Program

    ''' <summary>
    ''' The entry point to the program.
    ''' </summary>
    Sub Main()
        Do
            Dim m, n As UShort

            m = 0

            Do
                Console.Write("Enter N value: ")
            Loop Until (UShort.TryParse(Console.ReadLine(), n) AndAlso n <> 0 AndAlso n <= Pow(10, 4))

            For i As UShort = 1 To n
                m += i
            Next

            Console.WriteLine($"The answer: {m}")

            Console.WriteLine("Press any key to continue or Escape to exit.")
        Loop While (Console.ReadKey(True).Key <> ConsoleKey.Escape)
    End Sub

    ''' <summary>
    ''' The function to build a number in a degree.
    ''' </summary>
    ''' <param name="a">A number.</param>
    ''' <param name="n">A degree.</param>
    ''' <returns>A number that has been built in a degree.</returns>
    Private Function Pow(a As Byte, n As Byte) As UShort
        Dim b As UShort = 1

        For i As Byte = 1 To n
            b *= a
        Next

        Return b
    End Function

End Module
