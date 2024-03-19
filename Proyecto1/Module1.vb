Module Module1

    Sub Main()

        Console.Clear()
        Console.WriteLine(GetPropina())
        Console.WriteLine("Presione una tecla para confirmar cantidad ")
        Console.ReadKey()
        |
    End Sub
    Function GetPropina() As Double

        Dim Cuenta, Propina, result As Double
        Dim Personas As Integer



        Console.WriteLine("Ingrese el monto de la cuenta:")
        Cuenta = Console.ReadLine()
        Console.WriteLine("Ingrese el % de la propina que desea pagar:")
        Propina = Console.ReadLine()
        Console.WriteLine("Ingrese el Numero de personas a dividir la cuenta:")
        Personas = Console.ReadLine()

        result = (Cuenta + (Cuenta * Propina)) / Personas


    End Function




End Module
