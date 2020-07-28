
    Public Class Xorium_Algo
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


        Public Function Enc(ByVal h As Byte(), ByVal Key As String) As Byte()
            Dim p = New List(Of Byte)

            Dim o = Encoding.UTF8.GetBytes(Key)
            For i = 0 To h.Length - 1


                p.Add(Convert.ToByte(helper(h(i), o, BitConverter.GetBytes(i))))

            Next

            Return p.ToArray
        End Function

        Public Function Dec(ByVal h As Byte(), ByVal Key As String) As Byte()
            Dim p = New List(Of Byte)

            Dim o = Encoding.UTF8.GetBytes(Key)
            For i = 0 To h.Length - 1


                p.Add(Convert.ToByte(helperV2(h(i), o, BitConverter.GetBytes(i))))
            Next


            Return p.ToArray
        End Function
    End Class
