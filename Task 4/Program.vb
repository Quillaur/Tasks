''' <summary>
''' The main module of the project.
''' </summary>
Module Program

    ''' <summary>
    ''' The entry point to the program.
    ''' </summary>
    Sub Main()
        Do
            Dim k As Byte

            Do
                Console.Write("Enter K value: ")
            Loop Until (Byte.TryParse(Console.ReadLine(), k)) And k <> 0 And k < 10

            Console.WriteLine($"The answer: {Solve(k)}")

            Console.WriteLine("Press any key to continue or Escape to exit.")
        Loop While (Console.ReadKey(True).Key <> ConsoleKey.Escape)
    End Sub

    ''' <summary>
    ''' Finds the source number by using first digit from it and special rules.
    ''' </summary>
    ''' <param name="digit">First digit.</param>
    ''' <returns>A source number.</returns>
    Function Solve(digit As Byte) As UShort
        Return digit * 100 + 9 * 10 + 9 - digit
    End Function

End Module
