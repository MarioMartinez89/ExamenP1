﻿Imports System.IO
Module Module1
	Sub Main()
		Dim opcion As Char = ""
		Dim opcion2 As ConsoleKeyInfo
		Dim nombre, datos As String
		Dim Ent1, Ent2, result As Integer
		Do
			Try
				Console.Clear()
				Console.WriteLine("Menú de opciones:")
				Console.WriteLine("1. Ingreso de nombre de usuario")
				Console.WriteLine("2. Ingreso ejecucion programa")
				Console.WriteLine("3. Historial de datos")
				Console.WriteLine("4. Borrado de datos")
				Console.WriteLine("5. Salir")
				Console.WriteLine("Seleccione una opción")
				opcion2 = Console.ReadKey()
				opcion = opcion2.KeyChar
				Console.Clear()
			Catch ex As Exception
				Console.WriteLine(ex.Message)
			End Try
			Select Case opcion
				Case "1"
					Try
						Console.Clear()
						Console.WriteLine("Ingrese su nombre de usuario")
						nombre = Console.ReadLine()
					Catch ex As Exception
						Console.WriteLine(ex.Message)
					End Try
				Case "2"
					Try
						Console.Clear()
						Console.WriteLine("Ingrese el Primer numero Entero")
						Ent1 = Console.ReadLine()
						Console.WriteLine("Ingrese el Segundo numero Entero")
						Ent2 = Console.ReadLine()
						result = Ent1 + Ent2
						Console.WriteLine("El resultado es: " & result)
						Dim Salida As StreamWriter
						Salida = File.AppendText("Salida.txt")
						Salida.WriteLine(nombre & "," & Ent1 & "," & Ent2 & "," & result)
						Salida.Close()
						Console.WriteLine("Resultados quedaron Guardados")
						Console.ReadKey()
					Catch ex As Exception
						Console.WriteLine(ex.Message)
					End Try
				Case "3"
					Console.Clear()
					Try
						Dim Salida As StreamReader
						Salida = File.OpenText("Salida.txt")
						Console.WriteLine("Nombre, Entero1, Entero2, Resultado")
						Do Until Salida.EndOfStream
							Console.WriteLine(Salida.ReadLine())
						Loop
						Salida.Close()
					Catch ex As FileNotFoundException
						Console.WriteLine("El archivo no existe")
					End Try
					Console.WriteLine("")
					Console.WriteLine("Presione cualquier tecla")
					Console.ReadKey()
				Case "4"
					Dim Salida As String = "Salida.txt"
					File.Delete(Salida)
					Console.WriteLine("Borrar Historial")
					Console.ReadKey()
				Case "5"
					Console.Clear()
					Console.WriteLine("Presione para Salir")
					Exit Do
					Console.ReadKey()
				Case Else
					Console.WriteLine("Opcion no valida")

			End Select
		Loop
	End Sub

End Module
