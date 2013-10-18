Module Module1

    Sub Main()
        Dim harga As Double
        Console.Write("Harga barang: ")
        harga = Convert.ToDouble(Console.ReadLine)
        Dim diskonx As Double = diskon(harga)
        Console.WriteLine("Harga diskon: " + diskonx)
        Console.ReadKey()
    End Sub

    Function diskon(h As Double) As Double
        Console.Write("")
        Console.Write("")
        Console.Write("")
        Console.Write("")
        Console.Write("")
        Return 0.2 * h
    End Function



End Module
