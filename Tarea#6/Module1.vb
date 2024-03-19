Module Module1

    Sub Main()
        Dim notas(4) As Integer
        Dim Promedio As Integer = 0
        Dim cont As Integer = 0



        For i As Integer = 0 To 4
            Console.WriteLine("Ingrese la nota #" & i + 1 & ":")
            notas(i) = Console.ReadLine()
            Promedio = notas(i) + Promedio
            cont = cont + 1
        Next
        Promedio = Promedio / cont
        Console.WriteLine("El Promedio de las notas es: " & Promedio)
        Console.WriteLine("**** Presione Cualquier Tecla para Salir ****")
        Console.ReadKey()

    End Sub

End Module
