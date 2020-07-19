# Xorium_Crypto
Xorium Encryption/Decryption

How does it work ?

It uses bitwise operator XOR.

How to use ? : 

        Dim p As New Xorium_Algo
        IO.File.WriteAllBytes("Enc.exe", p.Enc(IO.File.ReadAllBytes(Application.ExecutablePath), 175, 175, New Integer() {4, 5, 8, 10, 200, 78, 25, 201, 60, 78, 246, 0, 7, 142}))

        Dim p2 As New Xorium_Algo2
        IO.File.WriteAllBytes("Enc2.exe", p2.Enc(IO.File.ReadAllBytes(Application.ExecutablePath), 88, 176, "|123Z4E5R6█{{j┘ÂÈ·="))
        
        
        Dim p As New Xorium_Algo
        IO.File.WriteAllBytes("Dec.exe", p.Dec(IO.File.ReadAllBytes("Enc.exe"), 175, 175, New Integer() {4, 5, 8, 10, 200, 78, 25, 201, 60, 78, 246, 0, 7, 142}))


        Dim p2 As New Xorium_Algo2
        IO.File.WriteAllBytes("Dec2.exe", p2.Dec(IO.File.ReadAllBytes("Enc2.exe"), 88, 176, "|123Z4E5R6█{{j┘ÂÈ·="))


