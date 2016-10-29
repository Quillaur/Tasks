''' <summary>
''' The main module of the project.
''' </summary>
Module Program

    ''' <summary>
    ''' The entry point to the program.
    ''' </summary>
    Sub Main()
        Do
            Dim n As Byte

            Do
                Console.Write("Enter N value: ")
            Loop Until (Byte.TryParse(Console.ReadLine(), n)) AndAlso n <> 0 AndAlso n <= 100

            Dim dates(n) As Byte

            Console.WriteLine($"Please enter N dates below.")

            For i As Byte = 1 To n
                Do
                    Console.Write($"Enter value #{i}: ")
                Loop Until (Byte.TryParse(Console.ReadLine(), dates(i - 1))) AndAlso n <> 0 AndAlso n <= 31
            Next

            Show(dates)

            Console.WriteLine("Press any key to continue or Escape to exit.")
        Loop While (Console.ReadKey(True).Key <> ConsoleKey.Escape)
    End Sub

    ''' <summary>
    ''' Shows dates and Vasya's studying result.
    ''' </summary>
    ''' <param name="dates">An array of numbers that contains dates.</param>
    Private Sub Show(dates() As Byte)
        Dim count As SByte = 0

        For i As Byte = 0 To dates.Length - 1
            If dates(i) Mod 2 = 1 AndAlso dates(i) <> 0 Then
                Console.Write($"{dates(i)} ")
                count -= 1
            End If
        Next

        Console.WriteLine()

        For i As Byte = 0 To dates.Length - 1
            If dates(i) Mod 2 = 0 AndAlso dates(i) <> 0 Then
                Console.Write($"{dates(i)} ")
                count += 1
            End If
        Next

        Console.WriteLine()

        If (count > 0) Then
            Console.WriteLine("Yes.")
        Else
            Console.WriteLine("No.")
        End If
    End Sub

End Module
