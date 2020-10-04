Module Module1
    Public Class Punto
        Private x As Integer
        Private y As Integer
        Public Sub Inicializar()
            Console.SetCursorPosition(10, 8)
            Console.Write("Ingrese cordenadas x: ")
            x = Console.ReadLine()
            Console.SetCursorPosition(10, 10)
            Console.Write("Ingrese cordenadas y: ")
            y = Console.ReadLine()

        End Sub
        Public Sub ImprimirCuadrande()
            If x > 0 And y > 0 Then
                Console.SetCursorPosition(10, 12)
                Console.Write("Se encuwntra en el primer cuadrante")
            Else
                If x < 0 And y > 0 Then
                    Console.SetCursorPosition(10, 12)
                    Console.Write("Se encuwntra en el segundo cuadrante")
                Else
                    If x < 0 And y < 0 Then
                        Console.SetCursorPosition(10, 12)
                        Console.Write("Se encuwntra en el tercer cuadrante")
                    Else
                        If x > 0 And y < 0 Then
                            Console.SetCursorPosition(10, 12)
                            Console.Write("Se encuwntra en el cuarto cuadrante")
                        Else
                            Console.SetCursorPosition(10, 12)
                            Console.Write("El punto no está en un cuadrante")


                        End If
                    End If


                End If
            End If
        End Sub
    End Class
    Public Class Empleado
        Private nombre As String
        Private sueldo As Single

        Public Sub Inicializar()
            Console.SetCursorPosition(10, 5)
            Console.Write("Ingrese el nombre del Empleado: ")
            nombre = Console.ReadLine()
            Console.SetCursorPosition(10, 7)
            Console.Write("Ingrese el sueldo: ")
            sueldo = Console.ReadLine()


        End Sub
        Public Sub PagarImpuestos()
            If sueldo > 3000 Then
                Console.SetCursorPosition(10, 9)
                Console.Write("Debe abonar impuestos")
            Else
                Console.SetCursorPosition(10, 9)
                Console.Write(" No debe abonar impuestos")

            End If
        End Sub
    End Class

    Sub Main()
        ' Plantilla Ejercicio18ManualVisualBasic2019Jorge
        ' En esta plantilla tendrás lo basico para crear un menu
        ' con un marco que podras ver como se crear mas rapido lento
        ' segundo aumentes o bajes el valor del for en el metodo Temprizador
        Ejercicio18ManualVisualBasic2019Jorge()

    End Sub
    Sub Ejercicio18ManualVisualBasic2019Jorge()

        Marco()
        'El menu que haty aqui lo puedes modidicarr a tu gusto 
        'Conserva la numeraracion y sustitulle el resto del texto a tus necesidads
        Console.SetCursorPosition(10, 2)
        Console.Write("Ejercicio18ManualVisualBasic2019Jorge")
        Console.SetCursorPosition(5, 5)
        Console.Write("0.- Salida")
        Console.SetCursorPosition(5, 7)
        Console.Write("1.- Posicion en cuadrantes ")
        Console.SetCursorPosition(5, 9)
        Console.Write("2.- Impuestos o no impuestos")
        'Añadrir mas opciones segun vuestras necesidades

        Dim Opcion As Integer
        Dim verdad As Boolean
        ' el sigyiente codigo controla que se introduzca un valor correcto
        Do
            Try
                Console.SetCursorPosition(10, 15)
                Console.Write("elija opcion: ")
                Opcion = Console.ReadLine()
                Eleccion(Opcion)
                verdad = True

            Catch ex As Exception
                Console.SetCursorPosition(10, 17)
                Console.Write("valor introducido no valido")
                verdad = False

            End Try

        Loop Until verdad = True


    End Sub
    Sub Marco()
        Dim Fila As Integer
        Dim Columna As Integer
        For Columna = 0 To 80
            Console.SetCursorPosition(Columna, 0)
            Console.Write("*")
            Temporizador()

        Next
        For Fila = 0 To 21
            Console.SetCursorPosition(80, Fila)
            Console.Write("*")
            Temporizador()

        Next
        For Columna = 80 To 0 Step -1

            Console.SetCursorPosition(Columna, 21)
            Console.Write("*")
            Temporizador()

        Next
        For Fila = 21 To 0 Step -1
            Console.SetCursorPosition(0, Fila)
            Console.Write("*")
            Temporizador()

        Next

    End Sub
    Sub Temporizador()
        ' Este pequello codigo hace la vez de temporizador 
        Dim tempo As Double
        For tempo = 0 To 100000000

        Next
    End Sub
    Sub Eleccion(opcion)
        ' este codigo distribulle el resto de opcines de codigo
        Dim verdad As Boolean
        Dim punto1 As New Punto()
        Dim empleado1 As New Empleado
        Select Case opcion
            Case 0
                Salida()
                Return
            Case 1
                ' La respuesta a una funcion llamada Cuadrante
                verdad = Cuadrante(opcion, punto1)
            Case 2
                verdad = ImpuestoOnoImpuesto(opcion, empleado1)
            Case Else

                'Una opcion para Controlar  las ociones no aceptadas
                OpcionErronea()
        End Select

    End Sub

    Private Function ImpuestoOnoImpuesto(opcion As Object, empleado1 As Empleado) As Boolean
        Dim verdad As Boolean
        Borrado()
        Marco()

        Do
            Try
                Console.SetCursorPosition(10, 2)
                Console.Write("La opcion elegida es: " & opcion)
                empleado1.Inicializar()
                empleado1.PagarImpuestos()

                verdad = True
            Catch ex As Exception
                Console.SetCursorPosition(10, 14)
                Console.Write(ex.Message)
                verdad = False

            End Try

        Loop Until verdad = True
        'Aqui metes nevo codigo
        Console.ReadKey()
        Borrado()

        Ejercicio18ManualVisualBasic2019Jorge()
        Return verdad
    End Function

    Private Function Cuadrante(opcion As Object, punto1 As Punto) As Boolean
        ' Una funcion donde jaty una variable verdad que controla si hay un prblema
        Dim verdad As Boolean
        Borrado()
        Marco()

        Do
            Try
                Console.SetCursorPosition(10, 2)
                Console.Write(" La Ocion elegida es: " & opcion)
                ' va las subs de la clase
                punto1.Inicializar()
                punto1.ImprimirCuadrande()
                Console.ReadKey()

                verdad = True

            Catch ex As Exception

                Console.SetCursorPosition(10, 13)
                Console.Write(ex.Message)
                verdad = False

            End Try
        Loop Until verdad = True
        Borrado()

        Ejercicio18ManualVisualBasic2019Jorge()

        ' Aqui meter nuevo codigo
        Return verdad
    End Function

    Private Sub OpcionErronea()
        'En  este Metodo controlamos si los numeros introduciodos no son reconocido por el select Case anterior 
        Borrado()
        Marco()


        Console.SetCursorPosition(10, 10)
        Console.Write("OPcion no reconocida")
        Console.ReadKey()
        Borrado()

        Ejercicio18ManualVisualBasic2019Jorge()
    End Sub

    Private Sub Salida()
        Borrado()
        Marco()
        Console.SetCursorPosition(10, 10)
        Console.Write("Gracias por utilizar la aplicación")
        Console.ReadKey()
        Borrado()
        End
    End Sub

    Sub Borrado()
        ' este cdigo hace una subifda de pantalla imitando un borrado hasta el efectvo
        Dim Borra As Integer
        For Borra = 0 To 50
            Console.WriteLine()
            Temporizador()

        Next
        Console.Clear()

    End Sub
End Module
