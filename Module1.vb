Module Module1

    Sub Main()

        Dim Meal, Drink, sum As Integer

        Console.Write("Enter the price of a meal:")

        Meal = Console.ReadLine

        Console.Write("Enter the price of a drink:")

        Drink = Console.ReadLine

        sum = Meal + Drink * 2

        Console.WriteLine(Meal & " + " & Drink & " *2 " & " = " & sum)

        Console.Read()

    End Sub

End Module
