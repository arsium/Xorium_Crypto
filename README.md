# Xorium_Crypto
Xorium Encryption/Decryption

How does it work ?

It uses bitwise operator XOR.

How to use ? : 

        Dim o As New Xorium
        IO.File.WriteAllBytes("enc.exe", o.Enc(IO.File.ReadAllBytes(Application.ExecutablePath), "bxnckw,;:;%*¨%*:m☺☻♥♠♣♦/◘○Ì├↓Õ4┘"))
 
        Dim o As New Xorium
        IO.File.WriteAllBytes("Dec.exe", o.Dec(IO.File.ReadAllBytes("enc.exe"), "bxnckw,;:;%*¨%*:m☺☻♥♠♣♦/◘○Ì├↓Õ4┘"))
