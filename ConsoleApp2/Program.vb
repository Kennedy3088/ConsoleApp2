Module Program
    Sub Main(args As String())
        Console.WriteLine(Factorielle(4))
        Console.WriteLine(SommeChiffres(234))
        Console.WriteLine(SommeChiffr(456))






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
            div = nbr Mod 10
            somme += div   ' Prend le dernier chiffre
            nbr \= 10    ' Supprime le dernier chiffre
        End While

        Return somme
    End Function


End Module
