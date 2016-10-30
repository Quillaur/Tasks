Imports System.Numerics

''' <summary>
''' The main module of the project.
''' </summary>
Module Program

    ''' <summary>
    ''' The entry point to the program.
    ''' </summary>
    Sub Main()
        Do
            Dim first, second, third As BigInteger

            first = New BigInteger()

            Do
                Console.Write("Enter first number: ")
            Loop Until (BigInteger.TryParse(Console.ReadLine(), first))

            second = New BigInteger()

            Do
                Console.Write("Enter second number: ")
            Loop Until (BigInteger.TryParse(Console.ReadLine(), second))

            third = New BigInteger()

            Do
                Console.Write("Enter third number: ")
            Loop Until (BigInteger.TryParse(Console.ReadLine(), third))

            If (first >= second) Then
                If (first >= third) Then
                    Console.WriteLine($"The biggest number: {first}")
                Else
                    Console.WriteLine($"The biggest number: {third}")
                End If
            Else
                If (second >= third) Then
                    Console.WriteLine($"The biggest number: {second}")
                Else
                    Console.WriteLine($"The biggest number: {third}")
                End If
            End If

            Console.WriteLine("Press any key to continue or Escape to exit.")
        Loop While (Console.ReadKey(True).Key <> ConsoleKey.Escape)
    End Sub

End Module
