''' <summary>
''' The main module of the project.
''' </summary>
Module Program

    ''' <summary>
    ''' The entry point to the program.
    ''' </summary>
    Sub Main()
        Do
            Dim a, b As Byte

            Do
                Console.Write("Enter A value: ")
            Loop Until (Byte.TryParse(Console.ReadLine(), a))

            Do
                Console.Write("Enter B value: ")
            Loop Until (Byte.TryParse(Console.ReadLine(), b))

            Console.WriteLine($"The sum of A and B: {a + b}")

            Console.WriteLine("Press any key to continue or Escape to exit.")
        Loop While (Console.ReadKey(True).Key <> ConsoleKey.Escape)
    End Sub

End Module
