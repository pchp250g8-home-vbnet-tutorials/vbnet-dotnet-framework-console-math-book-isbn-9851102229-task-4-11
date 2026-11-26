Module Module1

    Sub Main()
        Dim i1 As Single = 91.7F ' Процент удачно преодолевших дистанцию участников. 1-я часть интервала
        Dim i2 As Single = 91.8F ' Процент удачно преодолевших дистанцию участников. 2-я часть интервала
        Dim r1 As Single = i1 / 100 ' 1-я обыкновенная дробь
        Dim r2 As Single = i2 / 100 ' 2-я обыкновенная дробь
        Dim found As Boolean = False ' Флаг наличия решения задачи
        Dim n As Integer = 0 ' Число участников забега
        Console.WriteLine("В забеге удачно преодолели дистанцию (91,7%; 91,8%) участников.")
        Console.WriteLine("Каково минимальное число участников?")
        Do While Not found
            ' Находим наименьшее целое k, которое строго больше нижней границы
            Dim k = Math.Floor(r1 * n) + 1
            ' Проверяем, удовлетворяет ли это k верхней границе
            If (k < r2 * n) Then
                Console.WriteLine("Минимальное число участников (N):{0}", n)
                found = True
            Else
                n += 1
            End If
        Loop
        Console.Read()
    End Sub

End Module
