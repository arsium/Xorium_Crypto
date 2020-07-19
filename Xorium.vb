
Public Class Xorium_Algo
    Private Function helper(ByVal y2 As Integer, ByVal l As Integer(), ByVal mp As Byte())
        Dim o = y2


        For h = 0 To l.Length - 1
            o = o Xor l(h)
        Next


        Dim j = o
        For nh = 0 To mp.Length - 1
            j = j Xor mp(nh)
        Next

        Return j
    End Function
    Private Function helperV2(ByVal y2 As Integer, ByVal l As Integer(), ByVal mp As Byte())
        Dim o = y2



        For h = 0 To l.Length - 1
            o = l(h) Xor o
        Next

        Dim j = o

        For nh = 0 To mp.Length - 1
            j = mp(nh) Xor j
        Next

        Return j
        Return o
    End Function


    Public Function Enc(ByVal h As Byte(), ByVal y As Integer, ByVal y2 As Integer, ByVal Key As Integer()) As Byte()
        Dim p = New List(Of Byte)
        For i = 0 To h.Length - 1


            Dim o2 = (h(i) Xor y2)

            Dim o4 = o2 Xor y
            'o4 and o2 are integer to initiate my function and start encryption using XOR.
            'l is an integers array which is one part of the key to encrypt
            ' BitConverter.GetBytes(i) is the position of the single byte in bytes array (h here)

            p.Add(Convert.ToByte(helper(o4, Key, BitConverter.GetBytes(i))))

        Next

        Return p.ToArray
    End Function

    Public Function Dec(ByVal h As Byte(), ByVal y As Integer, ByVal y2 As Integer, ByVal Key As Integer()) As Byte()
        Dim p = New List(Of Byte)
        For i = 0 To h.Length - 1


            Dim o2 = y2 Xor h(i)

            Dim o4 = y Xor o2



            p.Add(Convert.ToByte(helperV2(o4, Key, BitConverter.GetBytes(i))))
        Next


        Return p.ToArray
    End Function
End Class



Public Class Xorium_Algo2
    Private Function helper(ByVal y2 As Integer, ByVal l As Byte(), ByVal mp As Byte())
        Dim o = y2


        For h = 0 To l.Length - 1
            o = o Xor l(h)
        Next


        Dim j = o
        For nh = 0 To mp.Length - 1
            j = j Xor mp(nh)
        Next

        Return j
    End Function
    Private Function helperV2(ByVal y2 As Integer, ByVal l As Byte(), ByVal mp As Byte())
        Dim o = y2



        For h = 0 To l.Length - 1
            o = l(h) Xor o
        Next

        Dim j = o

        For nh = 0 To mp.Length - 1
            j = mp(nh) Xor j
        Next

        Return j
        Return o
    End Function


    Public Function Enc(ByVal h As Byte(), ByVal y As Integer, ByVal y2 As Integer, ByVal Key As String) As Byte()
        Dim p = New List(Of Byte)

        Dim o = Encoding.UTF8.GetBytes(Key)
        For i = 0 To h.Length - 1


            Dim o2 = (h(i) Xor y2)

            Dim o4 = o2 Xor y
            'o4 and o2 are integer to initiate my function and start encryption using XOR.
            'l is an integers array which is one part of the key to encrypt
            ' BitConverter.GetBytes(i) is the position of the single byte in bytes array (h here)

            p.Add(Convert.ToByte(helper(o4, o, BitConverter.GetBytes(i))))

        Next

        Return p.ToArray
    End Function

    Public Function Dec(ByVal h As Byte(), ByVal y As Integer, ByVal y2 As Integer, ByVal Key As String) As Byte()
        Dim p = New List(Of Byte)

        Dim o = Encoding.UTF8.GetBytes(Key)
        For i = 0 To h.Length - 1


            Dim o2 = y2 Xor h(i)

            Dim o4 = y Xor o2



            p.Add(Convert.ToByte(helperV2(o4, o, BitConverter.GetBytes(i))))
        Next
  

        Return p.ToArray
    End Function
End Class
