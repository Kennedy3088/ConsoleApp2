Module Program
    Sub Main(args As String())
        Console.WriteLine(Factorielle(4))
        Console.WriteLine(SommeChiffres(234))
        Console.WriteLine(SommeChiffr(456))
        Console.WriteLine(Fibonn(7))
        Fibonnaci(8)
        Console.WriteLine(nombrepremier(17))




        Dim n As Integer = 17
        Dim compteur As Integer = 0
        Dim i As Integer

        For i = 2 To n - 1
            If n Mod i = 0 Then
                compteur += 1
            End If
        Next

        If compteur = 0 Then
            Console.WriteLine(n & " est premier")
        Else
            Console.WriteLine(n & "  n'est pas premier")

        End If






    End Sub
    Function Factorielle(n As Integer) As Long
        Dim resultat As Long = 1

        For i As Integer = 1 To n
            resultat *= i
        Next

        Return resultat
    End Function



    Function SommeChiffres(n As Integer) As Integer
        Dim somme As Integer = 0
        While n > 0
            somme += n Mod 10   ' Prend le dernier chiffre
            n \= 10             ' Supprime le dernier chiffre
        End While

        Return somme
    End Function


    Function SommeChiffr(nbr As Integer) As Integer
        Dim somme = 0, div As Integer

        While nbr > 0
            div = nbr Mod 10    ' Prend le dernier chiffre
            somme += div
            nbr \= 10            ' Supprime le dernier chiffre
        End While

        Return somme
    End Function



    Function Fibonn(f As Integer) As Integer
        Dim a As Integer = 0
        Dim b As Integer = 1
        Dim c, temp As Integer

        If f = 0 Then Return a
        If f = 1 Then Return b

        For c = 2 To f
            temp = a + b
            a = b
            b = temp
        Next
        Return b

    End Function


    Sub Fibonnaci(n As Integer)
        Dim a As Integer = 0
        Dim b As Integer = 1
        Dim i, temp As Integer
        Console.Write("suite de fibonnacci de " & n & ": ")
        For i = 0 To n - 1
            Console.Write(a & " ")
            temp = a + b
            a = b
            b = temp
        Next
        Console.WriteLine()

    End Sub

    Function nombrepremier(n As Integer) As Boolean

        Dim compteur As Boolean = True
        Dim i As Integer
        For i = 2 To n - 1
            If n Mod i = 0 Then
                compteur = False
            End If
        Next
        Return compteur
    End Function

End Module
